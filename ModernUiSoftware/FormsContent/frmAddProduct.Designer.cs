namespace ModernUiSoftware.FormsContent
{
	partial class frmAddProduct
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.tbSerial = new System.Windows.Forms.TextBox();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.tbSell = new System.Windows.Forms.TextBox();
			this.tbBuy = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbCategory
			// 
			this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(242, 65);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(169, 25);
			this.cbCategory.TabIndex = 5;
			// 
			// tbSerial
			// 
			this.tbSerial.Location = new System.Drawing.Point(70, 65);
			this.tbSerial.Name = "tbSerial";
			this.tbSerial.Size = new System.Drawing.Size(77, 25);
			this.tbSerial.TabIndex = 1;
			// 
			// tbDescription
			// 
			this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDescription.Location = new System.Drawing.Point(335, 100);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(212, 61);
			this.tbDescription.TabIndex = 6;
			// 
			// tbSell
			// 
			this.tbSell.Location = new System.Drawing.Point(172, 136);
			this.tbSell.Name = "tbSell";
			this.tbSell.Size = new System.Drawing.Size(65, 25);
			this.tbSell.TabIndex = 4;
			this.tbSell.Enter += new System.EventHandler(this.tbSell_Enter);
			this.tbSell.Leave += new System.EventHandler(this.tbSell_Leave);
			// 
			// tbBuy
			// 
			this.tbBuy.Location = new System.Drawing.Point(55, 136);
			this.tbBuy.Name = "tbBuy";
			this.tbBuy.Size = new System.Drawing.Size(65, 25);
			this.tbBuy.TabIndex = 3;
			this.tbBuy.Enter += new System.EventHandler(this.tbBuy_Enter);
			this.tbBuy.Leave += new System.EventHandler(this.tbBuy_Leave);
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(70, 100);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(166, 25);
			this.tbName.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(12, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Serial:";
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label15.Location = new System.Drawing.Point(130, 137);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(36, 20);
			this.label15.TabIndex = 37;
			this.label15.Text = "Sell:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(241, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 20);
			this.label6.TabIndex = 38;
			this.label6.Text = "Description:";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label8.Location = new System.Drawing.Point(13, 137);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 20);
			this.label8.TabIndex = 0;
			this.label8.Text = "Buy:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(159, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 40;
			this.label1.Text = "Category:";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(12, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Name:";
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
			this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAddProduct.FlatAppearance.BorderSize = 2;
			this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddProduct.Location = new System.Drawing.Point(504, 12);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(42, 38);
			this.btnAddProduct.TabIndex = 7;
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Add Product";
			// 
			// frmAddProduct
			// 
			this.AcceptButton = this.btnAddProduct;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(563, 173);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.cbCategory);
			this.Controls.Add(this.tbSerial);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.tbSell);
			this.Controls.Add(this.tbBuy);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmAddProduct";
			this.Text = "frmAddProduct";
			this.Load += new System.EventHandler(this.frmAddProduct_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.TextBox tbSerial;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.TextBox tbSell;
		private System.Windows.Forms.TextBox tbBuy;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.Label label3;
	}
}