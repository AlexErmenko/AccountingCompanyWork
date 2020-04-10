namespace Desktop.Views.Server
{
	partial class ServerForm
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
      this.ServerGridView = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DatabaseGridView = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idServerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idServerNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.GoBack = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.AddServerBtn = new System.Windows.Forms.Button();
      this.RemoveServerBtn = new System.Windows.Forms.Button();
      this.AddDatabaseForServerBtn = new System.Windows.Forms.Button();
      this.RemoveDatabaseFromServerBtn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.ServerGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DatabaseGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // ServerGridView
      // 
      this.ServerGridView.AllowUserToAddRows = false;
      this.ServerGridView.AllowUserToDeleteRows = false;
      this.ServerGridView.AutoGenerateColumns = false;
      this.ServerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.ServerGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.ServerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ServerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
      this.ServerGridView.DataSource = this.serverBindingSource;
      this.ServerGridView.Location = new System.Drawing.Point(0, 88);
      this.ServerGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.ServerGridView.Name = "ServerGridView";
      this.ServerGridView.ReadOnly = true;
      this.ServerGridView.Size = new System.Drawing.Size(752, 184);
      this.ServerGridView.TabIndex = 0;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Код";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // serverBindingSource
      // 
      this.serverBindingSource.DataSource = typeof(UI.Models.Server);
      // 
      // DatabaseGridView
      // 
      this.DatabaseGridView.AllowUserToAddRows = false;
      this.DatabaseGridView.AllowUserToDeleteRows = false;
      this.DatabaseGridView.AutoGenerateColumns = false;
      this.DatabaseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DatabaseGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.DatabaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DatabaseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.idServerDataGridViewTextBoxColumn,
            this.idServerNavigationDataGridViewTextBoxColumn});
      this.DatabaseGridView.DataSource = this.databasesBindingSource;
      this.DatabaseGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.DatabaseGridView.Location = new System.Drawing.Point(0, 351);
      this.DatabaseGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.DatabaseGridView.Name = "DatabaseGridView";
      this.DatabaseGridView.ReadOnly = true;
      this.DatabaseGridView.Size = new System.Drawing.Size(755, 214);
      this.DatabaseGridView.TabIndex = 1;
      // 
      // idDataGridViewTextBoxColumn1
      // 
      this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn1.HeaderText = "Код";
      this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
      this.idDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // nameDataGridViewTextBoxColumn1
      // 
      this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
      this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
      this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // idServerDataGridViewTextBoxColumn
      // 
      this.idServerDataGridViewTextBoxColumn.DataPropertyName = "IdServer";
      this.idServerDataGridViewTextBoxColumn.HeaderText = "IdServer";
      this.idServerDataGridViewTextBoxColumn.Name = "idServerDataGridViewTextBoxColumn";
      this.idServerDataGridViewTextBoxColumn.ReadOnly = true;
      this.idServerDataGridViewTextBoxColumn.Visible = false;
      // 
      // idServerNavigationDataGridViewTextBoxColumn
      // 
      this.idServerNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdServerNavigation";
      this.idServerNavigationDataGridViewTextBoxColumn.HeaderText = "Сервер";
      this.idServerNavigationDataGridViewTextBoxColumn.Name = "idServerNavigationDataGridViewTextBoxColumn";
      this.idServerNavigationDataGridViewTextBoxColumn.ReadOnly = true;
      this.idServerNavigationDataGridViewTextBoxColumn.Visible = false;
      // 
      // databasesBindingSource
      // 
      this.databasesBindingSource.DataMember = "Databases";
      this.databasesBindingSource.DataSource = this.serverBindingSource;
      // 
      // GoBack
      // 
      this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.GoBack.Font = new System.Drawing.Font("Century", 14F);
      this.GoBack.Location = new System.Drawing.Point(8, 8);
      this.GoBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.GoBack.Name = "GoBack";
      this.GoBack.Size = new System.Drawing.Size(96, 31);
      this.GoBack.TabIndex = 2;
      this.GoBack.Text = "←";
      this.GoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.GoBack.UseVisualStyleBackColor = true;
      this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 56);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Сервер";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 296);
      this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(111, 20);
      this.label2.TabIndex = 4;
      this.label2.Text = "Базы данных";
      // 
      // AddServerBtn
      // 
      this.AddServerBtn.Location = new System.Drawing.Point(368, 24);
      this.AddServerBtn.Name = "AddServerBtn";
      this.AddServerBtn.Size = new System.Drawing.Size(152, 32);
      this.AddServerBtn.TabIndex = 8;
      this.AddServerBtn.Text = "Додати сервер";
      this.AddServerBtn.UseVisualStyleBackColor = true;
      this.AddServerBtn.Click += new System.EventHandler(this.AddServerBtn_Click);
      // 
      // RemoveServerBtn
      // 
      this.RemoveServerBtn.Location = new System.Drawing.Point(584, 24);
      this.RemoveServerBtn.Name = "RemoveServerBtn";
      this.RemoveServerBtn.Size = new System.Drawing.Size(152, 32);
      this.RemoveServerBtn.TabIndex = 9;
      this.RemoveServerBtn.Text = "Видалити сервер";
      this.RemoveServerBtn.UseVisualStyleBackColor = true;
      this.RemoveServerBtn.Click += new System.EventHandler(this.RemoveServerBtn_Click);
      // 
      // AddDatabaseForServerBtn
      // 
      this.AddDatabaseForServerBtn.Location = new System.Drawing.Point(352, 288);
      this.AddDatabaseForServerBtn.Name = "AddDatabaseForServerBtn";
      this.AddDatabaseForServerBtn.Size = new System.Drawing.Size(168, 32);
      this.AddDatabaseForServerBtn.TabIndex = 10;
      this.AddDatabaseForServerBtn.Text = "Додати базу даних";
      this.AddDatabaseForServerBtn.UseVisualStyleBackColor = true;
      // 
      // RemoveDatabaseFromServerBtn
      // 
      this.RemoveDatabaseFromServerBtn.Location = new System.Drawing.Point(552, 288);
      this.RemoveDatabaseFromServerBtn.Name = "RemoveDatabaseFromServerBtn";
      this.RemoveDatabaseFromServerBtn.Size = new System.Drawing.Size(192, 32);
      this.RemoveDatabaseFromServerBtn.TabIndex = 11;
      this.RemoveDatabaseFromServerBtn.Text = "Выдалити базу даних";
      this.RemoveDatabaseFromServerBtn.UseVisualStyleBackColor = true;
      // 
      // ServerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(755, 565);
      this.Controls.Add(this.AddDatabaseForServerBtn);
      this.Controls.Add(this.RemoveDatabaseFromServerBtn);
      this.Controls.Add(this.AddServerBtn);
      this.Controls.Add(this.RemoveServerBtn);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.GoBack);
      this.Controls.Add(this.DatabaseGridView);
      this.Controls.Add(this.ServerGridView);
      this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ServerForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Сервера";
      this.Load += new System.EventHandler(this.ServerForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ServerGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DatabaseGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		private System.Windows.Forms.Button AddServerBtn;
		private System.Windows.Forms.DataGridView DatabaseGridView;
		private System.Windows.Forms.BindingSource databasesBindingSource;
		private System.Windows.Forms.Button GoBack;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServerNavigationDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button RemoveServerBtn;
		private System.Windows.Forms.BindingSource serverBindingSource;
		private System.Windows.Forms.DataGridView ServerGridView;

		#endregion

		private System.Windows.Forms.DataGridViewTextBoxColumn databasesDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button AddDatabaseForServerBtn;
		private System.Windows.Forms.Button RemoveDatabaseFromServerBtn;
	}
}
