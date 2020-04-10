namespace Desktop.Views.Database
{
    partial class DatabaseForm
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
      this.dataBaseDataGridView = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.RemoveDatabaseBtn = new System.Windows.Forms.Button();
      this.AddDatabaseBtn = new System.Windows.Forms.Button();
      this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idServerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idServerNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataBaseDataGridView
      // 
      this.dataBaseDataGridView.AllowUserToAddRows = false;
      this.dataBaseDataGridView.AllowUserToDeleteRows = false;
      this.dataBaseDataGridView.AutoGenerateColumns = false;
      this.dataBaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataBaseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.dataBaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataBaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.idServerDataGridViewTextBoxColumn,
            this.idServerNavigationDataGridViewTextBoxColumn});
      this.dataBaseDataGridView.DataSource = this.dataBaseBindingSource;
      this.dataBaseDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dataBaseDataGridView.Location = new System.Drawing.Point(0, 131);
      this.dataBaseDataGridView.Name = "dataBaseDataGridView";
      this.dataBaseDataGridView.ReadOnly = true;
      this.dataBaseDataGridView.Size = new System.Drawing.Size(833, 220);
      this.dataBaseDataGridView.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 80);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "Бази даних";
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.button1.Font = new System.Drawing.Font("Century", 18F);
      this.button1.Location = new System.Drawing.Point(8, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(80, 40);
      this.button1.TabIndex = 6;
      this.button1.Text = "←";
      this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.GoBack_Click);
      // 
      // RemoveDatabaseBtn
      // 
      this.RemoveDatabaseBtn.Location = new System.Drawing.Point(672, 72);
      this.RemoveDatabaseBtn.Name = "RemoveDatabaseBtn";
      this.RemoveDatabaseBtn.Size = new System.Drawing.Size(152, 32);
      this.RemoveDatabaseBtn.TabIndex = 7;
      this.RemoveDatabaseBtn.Text = "Видалити базу";
      this.RemoveDatabaseBtn.UseVisualStyleBackColor = true;
      this.RemoveDatabaseBtn.Click += new System.EventHandler(this.RemoveDatabaseBtn_Click);
      // 
      // AddDatabaseBtn
      // 
      this.AddDatabaseBtn.Location = new System.Drawing.Point(456, 72);
      this.AddDatabaseBtn.Name = "AddDatabaseBtn";
      this.AddDatabaseBtn.Size = new System.Drawing.Size(152, 32);
      this.AddDatabaseBtn.TabIndex = 7;
      this.AddDatabaseBtn.Text = "Додати базу";
      this.AddDatabaseBtn.UseVisualStyleBackColor = true;
      this.AddDatabaseBtn.Click += new System.EventHandler(this.AddDatabaseBtn_Click);
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
      // 
      // dataBaseBindingSource
      // 
      this.dataBaseBindingSource.DataSource = typeof(UI.Models.DataBase);
      this.dataBaseBindingSource.PositionChanged += new System.EventHandler(this.dataBaseBindingSource_PositionChanged);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(256, 72);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(152, 32);
      this.button2.TabIndex = 8;
      this.button2.Text = "Додати базу";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // DatabaseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(833, 351);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.AddDatabaseBtn);
      this.Controls.Add(this.RemoveDatabaseBtn);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataBaseDataGridView);
      this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DatabaseForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Бази даних";
      this.Load += new System.EventHandler(this.DatabaseForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        private System.Windows.Forms.Button AddDatabaseBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataBaseDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveDatabaseBtn;

        #endregion
        private System.Windows.Forms.BindingSource dataBaseBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idServerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idServerNavigationDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button button2;
  }
}