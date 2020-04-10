namespace Desktop.Views
{
	partial class Main
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
      this.components = new System.ComponentModel.Container();
      this.MenuNavigation = new System.Windows.Forms.MenuStrip();
      this.usersNavigation = new System.Windows.Forms.ToolStripMenuItem();
      this.databasesNavigation = new System.Windows.Forms.ToolStripMenuItem();
      this.serversNavigation = new System.Windows.Forms.ToolStripMenuItem();
      this.softwareNavigation = new System.Windows.Forms.ToolStripMenuItem();
      this.operatingSystemNavigation = new System.Windows.Forms.ToolStripMenuItem();
      this.SoftwareGridView = new System.Windows.Forms.DataGridView();
      this.UsersGridView = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.AddSoftwareForUserBtn = new System.Windows.Forms.Button();
      this.RemoveSoftwareFromUserBtn = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.SelectSoftwareForUserBtn = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.softwaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idOperatingSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idOperatingSystemNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idUserNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MenuNavigation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SoftwareGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // MenuNavigation
      // 
      this.MenuNavigation.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MenuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersNavigation,
            this.databasesNavigation,
            this.serversNavigation,
            this.softwareNavigation,
            this.operatingSystemNavigation});
      this.MenuNavigation.Location = new System.Drawing.Point(0, 0);
      this.MenuNavigation.Name = "MenuNavigation";
      this.MenuNavigation.Size = new System.Drawing.Size(925, 28);
      this.MenuNavigation.TabIndex = 0;
      // 
      // usersNavigation
      // 
      this.usersNavigation.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.usersNavigation.Name = "usersNavigation";
      this.usersNavigation.Size = new System.Drawing.Size(116, 24);
      this.usersNavigation.Text = "Користувачі";
      this.usersNavigation.Click += new System.EventHandler(this.usersNavigation_Click);
      // 
      // databasesNavigation
      // 
      this.databasesNavigation.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.databasesNavigation.Name = "databasesNavigation";
      this.databasesNavigation.Size = new System.Drawing.Size(109, 24);
      this.databasesNavigation.Text = "Бази даних";
      this.databasesNavigation.Click += new System.EventHandler(this.databasesNavigation_Click);
      // 
      // serversNavigation
      // 
      this.serversNavigation.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.serversNavigation.Name = "serversNavigation";
      this.serversNavigation.Size = new System.Drawing.Size(85, 24);
      this.serversNavigation.Text = "Сервера";
      this.serversNavigation.Click += new System.EventHandler(this.serversNavigation_Click);
      // 
      // softwareNavigation
      // 
      this.softwareNavigation.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.softwareNavigation.Name = "softwareNavigation";
      this.softwareNavigation.Size = new System.Drawing.Size(178, 24);
      this.softwareNavigation.Text = "Програмні продукти";
      this.softwareNavigation.Click += new System.EventHandler(this.softwareNavigation_Click);
      // 
      // operatingSystemNavigation
      // 
      this.operatingSystemNavigation.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.operatingSystemNavigation.Name = "operatingSystemNavigation";
      this.operatingSystemNavigation.Size = new System.Drawing.Size(174, 24);
      this.operatingSystemNavigation.Text = "Операційні системи";
      this.operatingSystemNavigation.Click += new System.EventHandler(this.operatingSystemNavigation_Click);
      // 
      // SoftwareGridView
      // 
      this.SoftwareGridView.AllowUserToAddRows = false;
      this.SoftwareGridView.AllowUserToDeleteRows = false;
      this.SoftwareGridView.AutoGenerateColumns = false;
      this.SoftwareGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.SoftwareGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.SoftwareGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SoftwareGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.idUserDataGridViewTextBoxColumn,
            this.idOperatingSystemDataGridViewTextBoxColumn,
            this.idOperatingSystemNavigationDataGridViewTextBoxColumn,
            this.idUserNavigationDataGridViewTextBoxColumn});
      this.SoftwareGridView.DataSource = this.softwaresBindingSource;
      this.SoftwareGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.SoftwareGridView.Location = new System.Drawing.Point(0, 384);
      this.SoftwareGridView.Name = "SoftwareGridView";
      this.SoftwareGridView.ReadOnly = true;
      this.SoftwareGridView.Size = new System.Drawing.Size(925, 274);
      this.SoftwareGridView.TabIndex = 1;
      // 
      // UsersGridView
      // 
      this.UsersGridView.AllowUserToAddRows = false;
      this.UsersGridView.AllowUserToDeleteRows = false;
      this.UsersGridView.AutoGenerateColumns = false;
      this.UsersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.UsersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.UsersGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
      this.UsersGridView.DataSource = this.userBindingSource;
      this.UsersGridView.Location = new System.Drawing.Point(0, 88);
      this.UsersGridView.Name = "UsersGridView";
      this.UsersGridView.ReadOnly = true;
      this.UsersGridView.Size = new System.Drawing.Size(928, 232);
      this.UsersGridView.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 20);
      this.label1.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 336);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 20);
      this.label2.TabIndex = 4;
      // 
      // AddSoftwareForUserBtn
      // 
      this.AddSoftwareForUserBtn.Location = new System.Drawing.Point(520, 336);
      this.AddSoftwareForUserBtn.Name = "AddSoftwareForUserBtn";
      this.AddSoftwareForUserBtn.Size = new System.Drawing.Size(176, 32);
      this.AddSoftwareForUserBtn.TabIndex = 10;
      this.AddSoftwareForUserBtn.Text = "Додати";
      this.AddSoftwareForUserBtn.UseVisualStyleBackColor = true;
      this.AddSoftwareForUserBtn.Click += new System.EventHandler(this.AddSoftwareForUserBtn_Click);
      // 
      // RemoveSoftwareFromUserBtn
      // 
      this.RemoveSoftwareFromUserBtn.Location = new System.Drawing.Point(744, 336);
      this.RemoveSoftwareFromUserBtn.Name = "RemoveSoftwareFromUserBtn";
      this.RemoveSoftwareFromUserBtn.Size = new System.Drawing.Size(176, 32);
      this.RemoveSoftwareFromUserBtn.TabIndex = 11;
      this.RemoveSoftwareFromUserBtn.Text = "Видалити";
      this.RemoveSoftwareFromUserBtn.UseVisualStyleBackColor = true;
      this.RemoveSoftwareFromUserBtn.Click += new System.EventHandler(this.RemoveSoftwareFromUserBtn_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 336);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(171, 20);
      this.label3.TabIndex = 12;
      this.label3.Text = "Програмний продукт";
      // 
      // SelectSoftwareForUserBtn
      // 
      this.SelectSoftwareForUserBtn.Location = new System.Drawing.Point(296, 336);
      this.SelectSoftwareForUserBtn.Name = "SelectSoftwareForUserBtn";
      this.SelectSoftwareForUserBtn.Size = new System.Drawing.Size(176, 32);
      this.SelectSoftwareForUserBtn.TabIndex = 13;
      this.SelectSoftwareForUserBtn.Text = "Обрати";
      this.SelectSoftwareForUserBtn.UseVisualStyleBackColor = true;
      this.SelectSoftwareForUserBtn.Click += new System.EventHandler(this.SelectSoftwareForUserBtn_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(8, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(104, 20);
      this.label4.TabIndex = 14;
      this.label4.Text = "Користувачі";
      // 
      // softwaresBindingSource
      // 
      this.softwaresBindingSource.DataMember = "Softwares";
      this.softwaresBindingSource.DataSource = this.userBindingSource;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Код";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // firstNameDataGridViewTextBoxColumn
      // 
      this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
      this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
      this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // middleNameDataGridViewTextBoxColumn
      // 
      this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
      this.middleNameDataGridViewTextBoxColumn.HeaderText = "Призвище";
      this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
      this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // lastNameDataGridViewTextBoxColumn
      // 
      this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn.HeaderText = "Побатькові";
      this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
      this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // userBindingSource
      // 
      this.userBindingSource.DataSource = typeof(UI.Models.User);
      this.userBindingSource.PositionChanged += new System.EventHandler(this.userBindingSource_PositionChanged);
      // 
      // idDataGridViewTextBoxColumn1
      // 
      this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn1.HeaderText = "Код";
      this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
      this.idDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // idUserDataGridViewTextBoxColumn
      // 
      this.idUserDataGridViewTextBoxColumn.DataPropertyName = "IdUser";
      this.idUserDataGridViewTextBoxColumn.HeaderText = "IdUser";
      this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
      this.idUserDataGridViewTextBoxColumn.ReadOnly = true;
      this.idUserDataGridViewTextBoxColumn.Visible = false;
      // 
      // idOperatingSystemDataGridViewTextBoxColumn
      // 
      this.idOperatingSystemDataGridViewTextBoxColumn.DataPropertyName = "IdOperatingSystem";
      this.idOperatingSystemDataGridViewTextBoxColumn.HeaderText = "IdOperatingSystem";
      this.idOperatingSystemDataGridViewTextBoxColumn.Name = "idOperatingSystemDataGridViewTextBoxColumn";
      this.idOperatingSystemDataGridViewTextBoxColumn.ReadOnly = true;
      this.idOperatingSystemDataGridViewTextBoxColumn.Visible = false;
      // 
      // idOperatingSystemNavigationDataGridViewTextBoxColumn
      // 
      this.idOperatingSystemNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdOperatingSystemNavigation";
      this.idOperatingSystemNavigationDataGridViewTextBoxColumn.HeaderText = "Операційна система";
      this.idOperatingSystemNavigationDataGridViewTextBoxColumn.Name = "idOperatingSystemNavigationDataGridViewTextBoxColumn";
      this.idOperatingSystemNavigationDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // idUserNavigationDataGridViewTextBoxColumn
      // 
      this.idUserNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdUserNavigation";
      this.idUserNavigationDataGridViewTextBoxColumn.HeaderText = "IdUserNavigation";
      this.idUserNavigationDataGridViewTextBoxColumn.Name = "idUserNavigationDataGridViewTextBoxColumn";
      this.idUserNavigationDataGridViewTextBoxColumn.ReadOnly = true;
      this.idUserNavigationDataGridViewTextBoxColumn.Visible = false;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(925, 658);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.SelectSoftwareForUserBtn);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.AddSoftwareForUserBtn);
      this.Controls.Add(this.RemoveSoftwareFromUserBtn);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.UsersGridView);
      this.Controls.Add(this.SoftwareGridView);
      this.Controls.Add(this.MenuNavigation);
      this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MainMenuStrip = this.MenuNavigation;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Main";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
      this.Load += new System.EventHandler(this.Main_Load);
      this.MenuNavigation.ResumeLayout(false);
      this.MenuNavigation.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SoftwareGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		private System.Windows.Forms.Button AddSoftwareForUserBtn;
		private System.Windows.Forms.ToolStripMenuItem databasesNavigation;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOperatingSystemDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOperatingSystemNavigationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idUserNavigationDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.MenuStrip MenuNavigation;
		private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripMenuItem operatingSystemNavigation;
		private System.Windows.Forms.Button RemoveSoftwareFromUserBtn;
		private System.Windows.Forms.ToolStripMenuItem serversNavigation;
		private System.Windows.Forms.DataGridView SoftwareGridView;
		private System.Windows.Forms.ToolStripMenuItem softwareNavigation;
		private System.Windows.Forms.BindingSource softwaresBindingSource;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.DataGridView UsersGridView;
		private System.Windows.Forms.ToolStripMenuItem usersNavigation;

		private System.Windows.Forms.DataGridViewTextBoxColumn softwareDatabasesDataGridViewTextBoxColumn;

		#endregion

		private System.Windows.Forms.DataGridViewTextBoxColumn softwaresDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button SelectSoftwareForUserBtn;
        private System.Windows.Forms.Label label4;
    }
}
