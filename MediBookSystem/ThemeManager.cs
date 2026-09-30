using System.Drawing;
using System.Windows.Forms;

namespace MediBookSystem
{
	public static class ThemeManager
	{
		public static void ApplyDarkTheme(Form form)
		{
			form.BackColor = Color.FromArgb(15, 23, 42);
			ApplyToControls(form.Controls, true);
		}

		public static void ApplyLightTheme(Form form)
		{
			form.BackColor = Color.FromArgb(240, 245, 255);
			ApplyToControls(form.Controls, false);
		}

		private static void ApplyToControls(
			System.Windows.Forms.Control.ControlCollection controls, bool dark)
		{
			foreach (Control c in controls)
			{
				if (c is Button btn)
				{
					if (btn.Parent != null && btn.Parent.Name == "panelSidebar")
					{
						btn.BackColor = Color.FromArgb(30, 41, 59);
						btn.ForeColor = Color.White;
					}
					else
					{
						btn.BackColor = dark
							? Color.FromArgb(30, 41, 59)
							: Color.FromArgb(59, 130, 246);
						btn.ForeColor = Color.White;
					}
					btn.FlatStyle = FlatStyle.Flat;
					btn.FlatAppearance.BorderSize = 0;
				}
				else if (c is Label lbl)
				{
					if (lbl.Name.StartsWith("lblCard"))
						lbl.BackColor = Color.Transparent;
					else
					{
						lbl.ForeColor = dark
							? Color.White
							: Color.FromArgb(15, 23, 42);
						lbl.BackColor = Color.Transparent;
					}
				}
				else if (c is TextBox tb)
				{
					tb.BackColor = dark ? Color.FromArgb(51, 65, 85) : Color.White;
					tb.ForeColor = dark ? Color.White : Color.Black;
					tb.BorderStyle = BorderStyle.FixedSingle;
				}
				else if (c is Panel pnl)
				{
					if (pnl.Name == "panelSidebar")
					{
						pnl.BackColor = Color.FromArgb(15, 23, 42);
					}
					else if (pnl.Name.StartsWith("panelCard"))
					{
						pnl.BackColor = dark
							? Color.FromArgb(30, 41, 59)
							: Color.White;
					}
					else if (pnl.Name == "panelHeader")
					{
						pnl.BackColor = dark
							? Color.FromArgb(30, 41, 59)
							: Color.White;
					}
					else
					{
						pnl.BackColor = dark
							? Color.FromArgb(15, 23, 42)
							: Color.FromArgb(240, 245, 255);
					}
				}
				else if (c is DataGridView dgv)
				{
					dgv.BackgroundColor = dark
						? Color.FromArgb(30, 41, 59) : Color.White;
					dgv.DefaultCellStyle.BackColor = dark
						? Color.FromArgb(51, 65, 85) : Color.White;
					dgv.DefaultCellStyle.ForeColor = dark
						? Color.White : Color.Black;
				}

				if (c.Controls.Count > 0 &&
					!(c.Name == "panelSidebar" && !dark))
				{
					ApplyToControls(c.Controls, dark);
				}
			}
		}
	}
}