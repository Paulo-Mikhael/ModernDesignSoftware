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
		private csvCrud csv = new csvCrud();

		public frmAddProduct()
		{
			InitializeComponent();
		}

		private void frmAddProduct_Load(object sender, EventArgs e)
		{
			LoadTheme();
			LoadCategories();
			tbSerial.Focus();
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
					button.FlatAppearance.BorderColor = Color.White;
					button.BackColor = ThemeColor.PrimaryColor;
					button.ForeColor = Color.White;
				}
			}
		}

		private void LoadCategories()
		{
			try
			{
				List<string> categories = csv.LoadCategories();

				foreach (var item in categories)
				{
					cbCategory.Items.Add(item);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			try
			{
				csv.NewProductCSV(tbSerial.Text, tbName.Text, cbCategory.Text, tbBuy.Text, tbSell.Text, tbDescription.Text);
				MessageBox.Show("Product saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tbBuy_Leave(object sender, EventArgs e)
		{
			string formatText = tbBuy.Text.Replace("$", "").Replace("R", "").Replace(" ", "");

			if (decimal.TryParse(formatText, out decimal formatNumber))
			{
				tbBuy.Text = $"$ {formatNumber}";
			}
			else
			{
				tbBuy.BackColor = Color.Salmon;
			}
		}

		private void tbBuy_Enter(object sender, EventArgs e)
		{
			tbBuy.BackColor = Color.White;
		}

		private void tbSell_Leave(object sender, EventArgs e)
		{
			string formatText = tbSell.Text.Replace("$", "").Replace("R", "").Replace(" ", "");

			if (decimal.TryParse(formatText, out decimal formatNumber))
			{
				tbSell.Text = $"$ {formatNumber}";
			}
			else
			{
				tbSell.BackColor = Color.Salmon;
			}
		}

		private void tbSell_Enter(object sender, EventArgs e)
		{
			tbSell.BackColor = Color.White;
		}

		private void ClearForm()
		{
			foreach (var item in this.Controls)
			{
				if (item.GetType() == typeof(TextBox))
				{
					TextBox textBox = (TextBox)item;
					textBox.Clear();
				}
			}

			cbCategory.SelectedIndex = -1;
		}
	}
}
