using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Windows.Forms;

namespace MediBookSystem
{
	public partial class BillingForm : Form
	{
		public BillingForm()
		{
			InitializeComponent();
			LoadBilling();
			LoadPatientNames();
			LoadDoctorNames();
		}

		private void LoadPatientNames()
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT patient_name FROM patients", conn);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				cmbPatient.Items.Clear();
				foreach (DataRow row in dt.Rows)
					cmbPatient.Items.Add(row["patient_name"].ToString());
				conn.Close();
			}
			catch { }
		}

		private void LoadDoctorNames()
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT doctor_name FROM doctors", conn);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				cmbDoctor.Items.Clear();
				foreach (DataRow row in dt.Rows)
					cmbDoctor.Items.Add(row["doctor_name"].ToString());
				conn.Close();
			}
			catch { }
		}

		private void LoadBilling()
		{
			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query = "SELECT * FROM billing ORDER BY bill_date DESC";
				MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgvBilling.DataSource = dt;
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading billing: " + ex.Message);
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			if (cmbPatient.SelectedItem == null ||
				string.IsNullOrWhiteSpace(txtService.Text) ||
				string.IsNullOrWhiteSpace(txtAmount.Text))
			{
				MessageBox.Show(
					"Please fill in Patient, Service, and Amount.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			if (!decimal.TryParse(txtAmount.Text, out decimal amount))
			{
				MessageBox.Show(
					"Please enter a valid amount.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query =
					"INSERT INTO billing (patient_name, doctor_name, service, amount, payment_status) " +
					"VALUES (@patient, @doctor, @service, @amount, @status)";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@patient", cmbPatient.SelectedItem.ToString());
				cmd.Parameters.AddWithValue("@doctor", cmbDoctor.SelectedItem?.ToString() ?? "");
				cmd.Parameters.AddWithValue("@service", txtService.Text.Trim());
				cmd.Parameters.AddWithValue("@amount", amount);
				cmd.Parameters.AddWithValue("@status", cmbStatus.Text == "" ? "Unpaid" : cmbStatus.Text);
				cmd.ExecuteNonQuery();
				MessageBox.Show(
					"Bill generated successfully!\n\n" +
					"Patient: " + cmbPatient.SelectedItem + "\n" +
					"Service: " + txtService.Text + "\n" +
					"Amount:  Rs. " + amount.ToString("F2") + "\n" +
					"Status:  " + (cmbStatus.Text == "" ? "Unpaid" : cmbStatus.Text),
					"Bill Generated",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				LoadBilling();
				ClearFields();
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnUpdateStatus_Click(object sender, EventArgs e)
		{
			if (dgvBilling.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Please select a bill to update.",
					"Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			int id = Convert.ToInt32(dgvBilling.SelectedRows[0].Cells["id"].Value);
			string newStatus = cmbStatus.Text == "" ? "Paid" : cmbStatus.Text;

			MySqlConnection conn = DBConnection.GetConnection();
			try
			{
				conn.Open();
				string query = "UPDATE billing SET payment_status=@status WHERE id=@id";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@status", newStatus);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show(
					"Payment status updated to: " + newStatus,
					"Updated",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				LoadBilling();
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvBilling.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select a bill to delete.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Delete this bill?", "Confirm",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				int id = Convert.ToInt32(dgvBilling.SelectedRows[0].Cells["id"].Value);
				MySqlConnection conn = DBConnection.GetConnection();
				try
				{
					conn.Open();
					new MySqlCommand("DELETE FROM billing WHERE id=" + id, conn).ExecuteNonQuery();
					MessageBox.Show("Bill deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadBilling();
					conn.Close();
				}
				catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}

		private void btnClear_Click(object sender, EventArgs e) => ClearFields();

		private void ClearFields()
		{
			cmbPatient.SelectedIndex = -1;
			cmbDoctor.SelectedIndex = -1;
			txtService.Clear();
			txtAmount.Clear();
			cmbStatus.SelectedIndex = -1;
		}

		private void dgvBilling_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvBilling.Rows[e.RowIndex];
				if (row.Cells["patient_name"].Value != null)
					cmbPatient.Text = row.Cells["patient_name"].Value.ToString();
				if (row.Cells["doctor_name"].Value != null)
					cmbDoctor.Text = row.Cells["doctor_name"].Value.ToString();
				if (row.Cells["service"].Value != null)
					txtService.Text = row.Cells["service"].Value.ToString();
				if (row.Cells["amount"].Value != null)
					txtAmount.Text = row.Cells["amount"].Value.ToString();
				if (row.Cells["payment_status"].Value != null)
					cmbStatus.Text = row.Cells["payment_status"].Value.ToString();
			}
		}

		private void BillingForm_Load(object sender, EventArgs e) { }
	}
}