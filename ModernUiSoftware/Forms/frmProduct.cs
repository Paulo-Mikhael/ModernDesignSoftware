using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUiSoftware.Forms
{
	public partial class frmProduct : Form
	{
		Form activeForm;

		public frmProduct()
		{
			InitializeComponent();
			LoadTheme();
		}

		private void LoadTheme()
		{
			foreach (Control btns in this.Controls)
			{
				if (btns.GetType() == typeof(Button))
				{
					Button btn = (Button)btns;
					btn.BackColor = ThemeColor.PrimaryColor;
					btn.ForeColor = Color.White;
					btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
				}

				if (btns.GetType() == typeof(Label))
				{
					Label label = (Label)btns;
					label.ForeColor = ThemeColor.SecondaryColor;
				}
			}
		}

		private void frmProduct_Load(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormsContent.frmAddProduct());
			btnAdd.Enabled = false;
		}

		private void OpenChildForm(Form childForm)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelAddProduct.Controls.Add(childForm);
			panelAddProduct.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
	}
}
