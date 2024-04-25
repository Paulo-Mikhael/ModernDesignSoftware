namespace ModernUiSoftware.FormsContent
{
	partial class frmSearchProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchProduct));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.tbSerial = new System.Windows.Forms.TextBox();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.tbSell = new System.Windows.Forms.TextBox();
			this.tbBuy = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.lblActualLine = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblLastLine = new System.Windows.Forms.Label();
			this.dtgProducts = new System.Windows.Forms.DataGridView();
			this.dtgSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtgDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblProducts = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
			this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAddProduct.FlatAppearance.BorderSize = 2;
			this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddProduct.Location = new System.Drawing.Point(506, 12);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(42, 38);
			this.btnAddProduct.TabIndex = 34;
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// tbSerial
			// 
			this.tbSerial.Enabled = false;
			this.tbSerial.Location = new System.Drawing.Point(71, 68);
			this.tbSerial.Name = "tbSerial";
			this.tbSerial.Size = new System.Drawing.Size(77, 25);
			this.tbSerial.TabIndex = 29;
			// 
			// tbDescription
			// 
			this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDescription.Location = new System.Drawing.Point(336, 103);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(212, 61);
			this.tbDescription.TabIndex = 30;
			// 
			// tbSell
			// 
			this.tbSell.Location = new System.Drawing.Point(173, 139);
			this.tbSell.Name = "tbSell";
			this.tbSell.Size = new System.Drawing.Size(65, 25);
			this.tbSell.TabIndex = 31;
			// 
			// tbBuy
			// 
			this.tbBuy.Location = new System.Drawing.Point(56, 139);
			this.tbBuy.Name = "tbBuy";
			this.tbBuy.Size = new System.Drawing.Size(65, 25);
			this.tbBuy.TabIndex = 32;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(71, 103);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(166, 25);
			this.tbName.TabIndex = 33;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 23;
			this.label3.Text = "Product";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(13, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 20);
			this.label5.TabIndex = 24;
			this.label5.Text = "Serial:";
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label15.Location = new System.Drawing.Point(131, 140);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(36, 20);
			this.label15.TabIndex = 25;
			this.label15.Text = "Sell:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(242, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 20);
			this.label6.TabIndex = 26;
			this.label6.Text = "Description:";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label8.Location = new System.Drawing.Point(14, 140);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 20);
			this.label8.TabIndex = 27;
			this.label8.Text = "Buy:";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(13, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "Name:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(160, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 28;
			this.label1.Text = "Category:";
			// 
			// cbCategory
			// 
			this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(243, 68);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(169, 25);
			this.cbCategory.TabIndex = 35;
			// 
			// btnLast
			// 
			this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
			this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLast.Location = new System.Drawing.Point(458, 16);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(30, 30);
			this.btnLast.TabIndex = 34;
			this.btnLast.UseVisualStyleBackColor = true;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
			this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Location = new System.Drawing.Point(428, 16);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(30, 30);
			this.btnNext.TabIndex = 34;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
			this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrevious.Location = new System.Drawing.Point(398, 16);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(30, 30);
			this.btnPrevious.TabIndex = 34;
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
			this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFirst.Location = new System.Drawing.Point(368, 16);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(30, 30);
			this.btnFirst.TabIndex = 34;
			this.btnFirst.UseVisualStyleBackColor = true;
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// lblActualLine
			// 
			this.lblActualLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblActualLine.AutoSize = true;
			this.lblActualLine.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblActualLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblActualLine.Location = new System.Drawing.Point(82, 12);
			this.lblActualLine.Name = "lblActualLine";
			this.lblActualLine.Size = new System.Drawing.Size(25, 20);
			this.lblActualLine.TabIndex = 24;
			this.lblActualLine.Text = "10";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(113, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 20);
			this.label7.TabIndex = 24;
			this.label7.Text = "of";
			// 
			// lblLastLine
			// 
			this.lblLastLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblLastLine.AutoSize = true;
			this.lblLastLine.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblLastLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblLastLine.Location = new System.Drawing.Point(142, 12);
			this.lblLastLine.Name = "lblLastLine";
			this.lblLastLine.Size = new System.Drawing.Size(25, 20);
			this.lblLastLine.TabIndex = 24;
			this.lblLastLine.Text = "20";
			// 
			// dtgProducts
			// 
			this.dtgProducts.AllowUserToAddRows = false;
			this.dtgProducts.AllowUserToDeleteRows = false;
			this.dtgProducts.AllowUserToResizeRows = false;
			this.dtgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgSerial,
            this.dtgName,
            this.dtgCategory,
            this.dtgBuy,
            this.dtgSell,
            this.dtgDescription});
			this.dtgProducts.Location = new System.Drawing.Point(17, 227);
			this.dtgProducts.Name = "dtgProducts";
			this.dtgProducts.ReadOnly = true;
			this.dtgProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dtgProducts.RowHeadersVisible = false;
			this.dtgProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgProducts.Size = new System.Drawing.Size(534, 110);
			this.dtgProducts.TabIndex = 0;
			this.dtgProducts.TabStop = false;
			this.dtgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducts_CellClick);
			this.dtgProducts.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgProducts_ColumnHeaderMouseClick);
			// 
			// dtgSerial
			// 
			this.dtgSerial.HeaderText = "SERIAL";
			this.dtgSerial.Name = "dtgSerial";
			this.dtgSerial.ReadOnly = true;
			this.dtgSerial.Width = 90;
			// 
			// dtgName
			// 
			this.dtgName.HeaderText = "NAME";
			this.dtgName.Name = "dtgName";
			this.dtgName.ReadOnly = true;
			this.dtgName.Width = 150;
			// 
			// dtgCategory
			// 
			this.dtgCategory.HeaderText = "CATEGORY";
			this.dtgCategory.Name = "dtgCategory";
			this.dtgCategory.ReadOnly = true;
			this.dtgCategory.Width = 150;
			// 
			// dtgBuy
			// 
			this.dtgBuy.HeaderText = "BUY";
			this.dtgBuy.Name = "dtgBuy";
			this.dtgBuy.ReadOnly = true;
			this.dtgBuy.Width = 80;
			// 
			// dtgSell
			// 
			this.dtgSell.HeaderText = "SELL";
			this.dtgSell.Name = "dtgSell";
			this.dtgSell.ReadOnly = true;
			this.dtgSell.Width = 80;
			// 
			// dtgDescription
			// 
			this.dtgDescription.HeaderText = "DESCRIPTION";
			this.dtgDescription.Name = "dtgDescription";
			this.dtgDescription.ReadOnly = true;
			this.dtgDescription.Width = 400;
			// 
			// lblProducts
			// 
			this.lblProducts.AutoSize = true;
			this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducts.Location = new System.Drawing.Point(15, 204);
			this.lblProducts.Name = "lblProducts";
			this.lblProducts.Size = new System.Drawing.Size(72, 20);
			this.lblProducts.TabIndex = 36;
			this.lblProducts.Text = "Products";
			// 
			// frmSearchProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 349);
			this.ControlBox = false;
			this.Controls.Add(this.dtgProducts);
			this.Controls.Add(this.lblProducts);
			this.Controls.Add(this.cbCategory);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.tbSerial);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.tbSell);
			this.Controls.Add(this.tbBuy);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblLastLine);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblActualLine);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmSearchProduct";
			this.Text = "frmSearchProduct";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddProduct_FormClosed);
			this.Load += new System.EventHandler(this.frmAddProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.TextBox tbSerial;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.TextBox tbSell;
		private System.Windows.Forms.TextBox tbBuy;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Label lblActualLine;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblLastLine;
		private System.Windows.Forms.DataGridView dtgProducts;
		private System.Windows.Forms.Label lblProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgSerial;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgBuy;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgSell;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgDescription;
	}
}