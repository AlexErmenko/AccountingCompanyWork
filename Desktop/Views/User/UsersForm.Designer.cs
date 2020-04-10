namespace UI.Views.User
{
	partial class UsersForm
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
			this.UsersGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.RemoveUserBtn = new System.Windows.Forms.Button();
			this.AddUserBtn = new System.Windows.Forms.Button();
			this.GoBack = new System.Windows.Forms.Button();
			( (System.ComponentModel.ISupportInitialize)( this.UsersGridView ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)( this.userBindingSource ) ).BeginInit();
			this.SuspendLayout();

			// 
			// UsersGridView
			// 
			this.UsersGridView.AllowUserToAddRows = false;
			this.UsersGridView.AllowUserToDeleteRows = false;
			this.UsersGridView.AutoGenerateColumns = false;
			this.UsersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.UsersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDataGridViewTextBoxColumn, this.firstNameDataGridViewTextBoxColumn, this.middleNameDataGridViewTextBoxColumn, this.lastNameDataGridViewTextBoxColumn
			});
			this.UsersGridView.DataSource = this.userBindingSource;
			this.UsersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.UsersGridView.Location = new System.Drawing.Point(0, 119);
			this.UsersGridView.Margin = new System.Windows.Forms.Padding(5);
			this.UsersGridView.Name = "UsersGridView";
			this.UsersGridView.ReadOnly = true;
			this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.UsersGridView.Size = new System.Drawing.Size(699, 297);
			this.UsersGridView.TabIndex = 0;

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

			// 
			// RemoveUserBtn
			// 
			this.RemoveUserBtn.Location = new System.Drawing.Point(448, 72);
			this.RemoveUserBtn.Margin = new System.Windows.Forms.Padding(5);
			this.RemoveUserBtn.Name = "RemoveUserBtn";
			this.RemoveUserBtn.Size = new System.Drawing.Size(240, 35);
			this.RemoveUserBtn.TabIndex = 2;
			this.RemoveUserBtn.Text = "Видалити користувача";
			this.RemoveUserBtn.UseVisualStyleBackColor = true;
			this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);

			// 
			// AddUserBtn
			// 
			this.AddUserBtn.Location = new System.Drawing.Point(8, 72);
			this.AddUserBtn.Margin = new System.Windows.Forms.Padding(5);
			this.AddUserBtn.Name = "AddUserBtn";
			this.AddUserBtn.Size = new System.Drawing.Size(240, 35);
			this.AddUserBtn.TabIndex = 3;
			this.AddUserBtn.Text = "Додати користувача";
			this.AddUserBtn.UseVisualStyleBackColor = true;
			this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);

			// 
			// GoBack
			// 
			this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GoBack.Font = new System.Drawing.Font("Century", 18F);
			this.GoBack.Location = new System.Drawing.Point(8, 16);
			this.GoBack.Name = "GoBack";
			this.GoBack.Size = new System.Drawing.Size(80, 32);
			this.GoBack.TabIndex = 4;
			this.GoBack.Text = "←";
			this.GoBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.GoBack.UseVisualStyleBackColor = true;
			this.GoBack.Click += new System.EventHandler(this.GoBackBtn_Click);

			// 
			// UsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 416);
			this.Controls.Add(this.GoBack);
			this.Controls.Add(this.AddUserBtn);
			this.Controls.Add(this.RemoveUserBtn);
			this.Controls.Add(this.UsersGridView);
			this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 204 ) ));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UsersForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Користувачі";
			this.Load += new System.EventHandler(this.UsersForm_Load);
			( (System.ComponentModel.ISupportInitialize)( this.UsersGridView ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize)( this.userBindingSource ) ).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button AddUserBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button GoBack;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button RemoveUserBtn;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.DataGridView UsersGridView;

		#endregion
	}
}