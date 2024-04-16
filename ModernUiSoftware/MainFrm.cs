using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

		public MainFrm()
		{
			InitializeComponent();
			random = new Random();
		}

		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];

			return ColorTranslator.FromHtml(color);
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
		}

		private void btnOrders_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
		}

		private void btnReporting_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
		}

		private void btnNotifications_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
		}
	}
}
