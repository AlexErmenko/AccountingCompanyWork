namespace UI.Views.Software
{
	partial class SoftwareForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GoBack = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idOperatingSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idOperatingSystemNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idUserNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idServerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idServerNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1.SuspendLayout();
			( (System.ComponentModel.ISupportInitialize)( this.dataGridView2 ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)( this.softwareBindingSource ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)( this.dataGridView1 ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)( this.dataBaseBindingSource ) ).BeginInit();
			this.SuspendLayout();

			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.GoBack);
			this.groupBox1.Controls.Add(this.dataGridView2);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(927, 482);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;

			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Програмний продукт";

			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "База даних";

			// 
			// GoBack
			// 
			this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GoBack.Font = new System.Drawing.Font("Century", 18F);
			this.GoBack.Location = new System.Drawing.Point(8, 8);
			this.GoBack.Name = "GoBack";
			this.GoBack.Size = new System.Drawing.Size(80, 32);
			this.GoBack.TabIndex = 2;
			this.GoBack.Text = "←";
			this.GoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.GoBack.UseVisualStyleBackColor = true;
			this.GoBack.Click += new System.EventHandler(this.GoBack_Click);

			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDataGridViewTextBoxColumn, this.nameDataGridViewTextBoxColumn, this.idUserDataGridViewTextBoxColumn, this.idOperatingSystemDataGridViewTextBoxColumn, this.idOperatingSystemNavigationDataGridViewTextBoxColumn, this.idUserNavigationDataGridViewTextBoxColumn
			});
			this.dataGridView2.DataSource = this.softwareBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(0, 88);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(928, 150);
			this.dataGridView2.TabIndex = 2;

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
			this.softwareBindingSource.PositionChanged += new System.EventHandler(this.softwareBindingSource_PositionChanged);

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
				this.idDataGridViewTextBoxColumn1, this.nameDataGridViewTextBoxColumn1, this.idServerDataGridViewTextBoxColumn, this.idServerNavigationDataGridViewTextBoxColumn
			});
			this.dataGridView1.DataSource = this.dataBaseBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(3, 295);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(921, 184);
			this.dataGridView1.TabIndex = 1;

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

			// 
			// SoftwareForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 482);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 204 ) ));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SoftwareForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Програмні продукти";
			this.Load += new System.EventHandler(this.SoftwareForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			( (System.ComponentModel.ISupportInitialize)( this.dataGridView2 ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize)( this.softwareBindingSource ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize)( this.dataGridView1 ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize)( this.dataBaseBindingSource ) ).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.BindingSource dataBaseBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button GoBack;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOperatingSystemDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOperatingSystemNavigationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServerNavigationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idUserNavigationDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource softwareBindingSource;

		#endregion
	}
}