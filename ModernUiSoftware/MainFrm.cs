using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ModernUiSoftware
{
	public partial class MainFrm : Form
	{
		private Button currentButton;
		private Random random;
		private int tempIndex;
		private Form activeForm;

		public MainFrm()
		{
			InitializeComponent();
			random = new Random();
			btnCloseChildForm.Visible = false;
			this.Text = string.Empty;
			this.ControlBox = false;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];

			return ColorTranslator.FromHtml(color);
		}

		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesktopPane.Controls.Add(childForm);
			this.panelDesktopPane.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitle.Text = childForm.Text;
		}

		private void ActivateButton(object btnSender)
		{
			if (btnSender != null)
			{
				if (currentButton != (Button)btnSender)
				{
					DisableButton();

					Color color = SelectThemeColor();

					currentButton = (Button)btnSender;
					currentButton.BackColor = color;
					currentButton.ForeColor = Color.White;
					currentButton.Font = new System.Drawing.Font("Segoe UI", 11.80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					panelTitleBar.BackColor = color;
					panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					ThemeColor.PrimaryColor = color;
					ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					btnCloseChildForm.Visible = true;
				}
			}
		}

		private void DisableButton()
		{
			foreach (Control previousBtn in panelMenu.Controls)
			{
				if (previousBtn.GetType() == typeof(Button))
				{
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.Gainsboro;
					previousBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				}
			}
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new Forms.frmProduct(), sender);
		}

		private void btnOrders_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new Forms.frmOrder(), sender);
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new Forms.frmCustomer(), sender);
		}

		private void btnReporting_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new Forms.Reporting(), sender);
		}

		private void btnNotifications_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new Forms.frmNotification(), sender);
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
			OpenChildForm(new Forms.frmSetting(), sender);
		}

		private void btnCloseChildForm_Click(object sender, EventArgs e)
		{
			if (activeForm != null)
			{
				activeForm.Close();
				Reset();
			}
		}

		private void Reset()
		{
			DisableButton();
			panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
			panelLogo.BackColor = Color.FromArgb(39, 39, 58);
			lblTitle.Text = "HOME";
			currentButton = null;
			btnCloseChildForm.Visible = false;
		}

		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
