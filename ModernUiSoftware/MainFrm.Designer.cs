namespace ModernUiSoftware
{
	partial class MainFrm
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.btnProducts = new System.Windows.Forms.Button();
			this.btnOrders = new System.Windows.Forms.Button();
			this.btnCustomer = new System.Windows.Forms.Button();
			this.btnReporting = new System.Windows.Forms.Button();
			this.btnNotifications = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.panelMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panelMenu.Controls.Add(this.btnSetting);
			this.panelMenu.Controls.Add(this.btnNotifications);
			this.panelMenu.Controls.Add(this.btnReporting);
			this.panelMenu.Controls.Add(this.btnCustomer);
			this.panelMenu.Controls.Add(this.btnOrders);
			this.panelMenu.Controls.Add(this.btnProducts);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(220, 538);
			this.panelMenu.TabIndex = 0;
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(220, 80);
			this.panelLogo.TabIndex = 1;
			// 
			// btnProducts
			// 
			this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnProducts.FlatAppearance.BorderSize = 0;
			this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
			this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.Location = new System.Drawing.Point(0, 80);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnProducts.Size = new System.Drawing.Size(220, 60);
			this.btnProducts.TabIndex = 2;
			this.btnProducts.Text = "       Products";
			this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnOrders
			// 
			this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnOrders.FlatAppearance.BorderSize = 0;
			this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrders.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
			this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrders.Location = new System.Drawing.Point(0, 140);
			this.btnOrders.Name = "btnOrders";
			this.btnOrders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnOrders.Size = new System.Drawing.Size(220, 60);
			this.btnOrders.TabIndex = 3;
			this.btnOrders.Text = "       Orders";
			this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOrders.UseVisualStyleBackColor = true;
			this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
			// 
			// btnCustomer
			// 
			this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCustomer.FlatAppearance.BorderSize = 0;
			this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
			this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCustomer.Location = new System.Drawing.Point(0, 200);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnCustomer.Size = new System.Drawing.Size(220, 60);
			this.btnCustomer.TabIndex = 4;
			this.btnCustomer.Text = "       Customer";
			this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCustomer.UseVisualStyleBackColor = true;
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			// 
			// btnReporting
			// 
			this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnReporting.FlatAppearance.BorderSize = 0;
			this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReporting.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnReporting.Image = ((System.Drawing.Image)(resources.GetObject("btnReporting.Image")));
			this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReporting.Location = new System.Drawing.Point(0, 260);
			this.btnReporting.Name = "btnReporting";
			this.btnReporting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnReporting.Size = new System.Drawing.Size(220, 60);
			this.btnReporting.TabIndex = 5;
			this.btnReporting.Text = "       Reporting";
			this.btnReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnReporting.UseVisualStyleBackColor = true;
			this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
			// 
			// btnNotifications
			// 
			this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNotifications.FlatAppearance.BorderSize = 0;
			this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNotifications.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnNotifications.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifications.Image")));
			this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNotifications.Location = new System.Drawing.Point(0, 320);
			this.btnNotifications.Name = "btnNotifications";
			this.btnNotifications.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnNotifications.Size = new System.Drawing.Size(220, 60);
			this.btnNotifications.TabIndex = 6;
			this.btnNotifications.Text = "       Notifications";
			this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNotifications.UseVisualStyleBackColor = true;
			this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
			// 
			// btnSetting
			// 
			this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSetting.FlatAppearance.BorderSize = 0;
			this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
			this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSetting.Location = new System.Drawing.Point(0, 380);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.btnSetting.Size = new System.Drawing.Size(220, 60);
			this.btnSetting.TabIndex = 7;
			this.btnSetting.Text = "       Setting";
			this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSetting.UseVisualStyleBackColor = true;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// MainFrm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1144, 538);
			this.Controls.Add(this.panelMenu);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(750, 550);
			this.Name = "MainFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modern Software Design";
			this.panelMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Button btnProducts;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Button btnNotifications;
		private System.Windows.Forms.Button btnReporting;
		private System.Windows.Forms.Button btnCustomer;
		private System.Windows.Forms.Button btnOrders;
	}
}

