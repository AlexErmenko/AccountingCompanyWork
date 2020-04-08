namespace UI.Views.Database
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
            this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperatingSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperatingSystemNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RemoveDatabaseBtn = new System.Windows.Forms.Button();
            this.AddDatabaseBtn = new System.Windows.Forms.Button();
            ( (System.ComponentModel.ISupportInitialize)( this.dataBaseBindingSource ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.dataBaseDataGridView ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.dataGridView1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.softwareBindingSource ) ).BeginInit();
            this.SuspendLayout();

            // 
            // dataBaseBindingSource
            // 
            this.dataBaseBindingSource.DataSource = typeof(UI.Models.DataBase);
            this.dataBaseBindingSource.PositionChanged += new System.EventHandler(this.dataBaseBindingSource_PositionChanged);

            // 
            // dataBaseDataGridView
            // 
            this.dataBaseDataGridView.AllowUserToAddRows = false;
            this.dataBaseDataGridView.AllowUserToDeleteRows = false;
            this.dataBaseDataGridView.AutoGenerateColumns = false;
            this.dataBaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBaseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataBaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4
            });
            this.dataBaseDataGridView.DataSource = this.dataBaseBindingSource;
            this.dataBaseDataGridView.Location = new System.Drawing.Point(0, 88);
            this.dataBaseDataGridView.Name = "dataBaseDataGridView";
            this.dataBaseDataGridView.ReadOnly = true;
            this.dataBaseDataGridView.Size = new System.Drawing.Size(840, 220);
            this.dataBaseDataGridView.TabIndex = 1;

            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;

            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;

            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdServer";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdServer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;

            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdServerNavigation";
            this.dataGridViewTextBoxColumn4.HeaderText = "Сервер";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;

            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.idDataGridViewTextBoxColumn, this.nameDataGridViewTextBoxColumn, this.idUserDataGridViewTextBoxColumn, this.idOperatingSystemDataGridViewTextBoxColumn, this.idOperatingSystemNavigationDataGridViewTextBoxColumn, this.idUserNavigationDataGridViewTextBoxColumn
            });
            this.dataGridView1.DataSource = this.softwareBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(833, 230);
            this.dataGridView1.TabIndex = 2;

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
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataSource = typeof(UI.Models.Software);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Бази даних";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Програмні продукти";

            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Century", 18F);
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "←";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBack_Click);

            // 
            // RemoveDatabaseBtn
            // 
            this.RemoveDatabaseBtn.Location = new System.Drawing.Point(672, 40);
            this.RemoveDatabaseBtn.Name = "RemoveDatabaseBtn";
            this.RemoveDatabaseBtn.Size = new System.Drawing.Size(152, 32);
            this.RemoveDatabaseBtn.TabIndex = 7;
            this.RemoveDatabaseBtn.Text = "Видалити базу";
            this.RemoveDatabaseBtn.UseVisualStyleBackColor = true;
            this.RemoveDatabaseBtn.Click += new System.EventHandler(this.RemoveDatabaseBtn_Click);

            // 
            // AddDatabaseBtn
            // 
            this.AddDatabaseBtn.Location = new System.Drawing.Point(456, 40);
            this.AddDatabaseBtn.Name = "AddDatabaseBtn";
            this.AddDatabaseBtn.Size = new System.Drawing.Size(152, 32);
            this.AddDatabaseBtn.TabIndex = 7;
            this.AddDatabaseBtn.Text = "Додати базу";
            this.AddDatabaseBtn.UseVisualStyleBackColor = true;
            this.AddDatabaseBtn.Click += new System.EventHandler(this.AddDatabaseBtn_Click);

            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 594);
            this.Controls.Add(this.AddDatabaseBtn);
            this.Controls.Add(this.RemoveDatabaseBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataBaseDataGridView);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бази даних";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ( (System.ComponentModel.ISupportInitialize)( this.dataBaseBindingSource ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.dataBaseDataGridView ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.dataGridView1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.softwareBindingSource ) ).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button AddDatabaseBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataBaseBindingSource;
        private System.Windows.Forms.DataGridView dataBaseDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatingSystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatingSystemNavigationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserNavigationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RemoveDatabaseBtn;
        private System.Windows.Forms.BindingSource softwareBindingSource;

        #endregion
    }
}