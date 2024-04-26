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
	public partial class frmSearchProduct : Form
	{
		private csvCrud csv = new csvCrud();
		private static int actualLine = 1;

		public frmSearchProduct()
		{
			InitializeComponent();
		}

		private void frmAddProduct_Load(object sender, EventArgs e)
		{
			try
			{
				LoadTheme();
				LoadCategories();
				LoadDtgProducts();
				LoadProduct();
				csv.ChangeSeparator();
				lblLastLine.Text = Convert.ToString(csv.LastProductArray());
				tbName.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void LoadProduct()
		{
			try
			{
				List<string> product = csv.ReturnProduct(actualLine);

				string serial = product[0];
				string name = product[1];
				string category = product[2];
				string buy = $"$ {product[3].Replace(".", ",")}";
				string sell = $"$ {product[4].Replace(".", ",")}";
				string description = product[5];

				int categoryIndex = cbCategory.Items.IndexOf(category);

				tbSerial.Text = serial;
				tbName.Text = name;
				cbCategory.SelectedIndex = categoryIndex;
				tbBuy.Text = buy;
				tbSell.Text = sell;
				tbDescription.Text = description;

				lblActualLine.Text = Convert.ToString(actualLine);

				int rowIndexToFocus = actualLine - 1;
				dtgProducts.CurrentCell = dtgProducts.Rows[rowIndexToFocus].Cells[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					button.FlatAppearance.BorderColor = Color.White;
					button.BackColor = ThemeColor.PrimaryColor;
					button.ForeColor = Color.White;
				}
			}
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			actualLine = csv.LastProductArray();
			LoadProduct();
			tbName.Focus();
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			actualLine = 1;
			LoadProduct();
			tbName.Focus();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			actualLine++;

			if (actualLine <= csv.LastProductArray())
			{
				LoadProduct();
				tbName.Focus();
			}
			else
			{
				actualLine--;
			}
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			actualLine--;
			
			if (actualLine > 0)
			{
				LoadProduct();
				tbName.Focus();
			}
			else
			{
				actualLine++;
			}
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
			tbSerial.Focus();
		}

		private void frmAddProduct_FormClosed(object sender, FormClosedEventArgs e)
		{
			ClearForm();
			actualLine = 1;
		}

		private void LoadDtgProducts()
		{
			try
			{
				for (int i = 0; i < csv.LastProductArray(); i++)
				{
					List<string> product = csv.ReturnProduct(i + 1);

					string serial = product[0];
					string name = product[1];
					string category = product[2];
					string buy = $"$ {product[3].Replace(".", ",")}";
					string sell = $"$ {product[4].Replace(".", ",")}";
					string description = product[5];

					dtgProducts.Rows.Add(serial, name, category, buy, sell, description);
				}

				StyleDtg();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void StyleDtg()
		{
			for (int i = 0; i < dtgProducts.RowCount; i += 2)
			{
				dtgProducts.Rows[i].Cells["dtgSerial"].Style.BackColor = Color.LightSteelBlue;
				dtgProducts.Rows[i].Cells["dtgName"].Style.BackColor = Color.LightSteelBlue;
				dtgProducts.Rows[i].Cells["dtgCategory"].Style.BackColor = Color.LightSteelBlue;
				dtgProducts.Rows[i].Cells["dtgBuy"].Style.BackColor = Color.LightSteelBlue;
				dtgProducts.Rows[i].Cells["dtgSell"].Style.BackColor = Color.LightSteelBlue;
				dtgProducts.Rows[i].Cells["dtgDescription"].Style.BackColor = Color.LightSteelBlue;
			}
		}

		private void dtgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			actualLine = dtgProducts.CurrentRow.Index + 1;
			LoadProduct();
		}

		private void dtgProducts_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			dtgProducts.Rows.Clear();
			LoadDtgProducts();
			actualLine = 1;
			LoadProduct();
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			try
			{
				csv.UpdateProductCSV(actualLine, tbSerial.Text, tbName.Text, cbCategory.Text, tbBuy.Text, tbSell.Text, tbDescription.Text);
				MessageBox.Show("Product actualized sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDtgProducts();
				ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
