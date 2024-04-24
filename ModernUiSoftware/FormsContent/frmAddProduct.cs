using FileLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUiSoftware.FormsContent
{
	public partial class frmAddProduct : Form
	{
		csvCrud csv = new csvCrud();

		public frmAddProduct()
		{
			InitializeComponent();
		}

		private void frmAddProduct_Load(object sender, EventArgs e)
		{
			LoadTheme();

			try
			{
				csv.CreateCSV();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadTheme()
		{
			foreach (Control controls in this.Controls)
			{
				if (controls.GetType() == typeof(Label))
				{
					Label label = (Label)controls;
					label.ForeColor = ThemeColor.SecondaryColor;
				}

				if (controls.GetType() == typeof(Button))
				{
					Button button = (Button)controls;
					button.FlatStyle = FlatStyle.Flat;
					button.FlatAppearance.BorderSize = 2;
					button.FlatAppearance.BorderColor = Color.White;
					button.BackColor = ThemeColor.PrimaryColor;
					button.ForeColor = Color.White;
				}
			}
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{

		}
	}
}
