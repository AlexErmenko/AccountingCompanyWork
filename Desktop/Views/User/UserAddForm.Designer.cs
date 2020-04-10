namespace Desktop.Views.User
{
	partial class UserAddForm
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
			System.Windows.Forms.Label firstNameLabel;
			System.Windows.Forms.Label lastNameLabel;
			System.Windows.Forms.Label middleNameLabel;
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.middleNameTextBox = new System.Windows.Forms.TextBox();
			this.SaveUserBtn = new System.Windows.Forms.Button();
			firstNameLabel = new System.Windows.Forms.Label();
			lastNameLabel = new System.Windows.Forms.Label();
			middleNameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Location = new System.Drawing.Point(16, 24);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(43, 20);
			firstNameLabel.TabIndex = 1;
			firstNameLabel.Text = "Ім\'я:";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Location = new System.Drawing.Point(16, 75);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(98, 20);
			lastNameLabel.TabIndex = 5;
			lastNameLabel.Text = "Побатькові:";
			// 
			// middleNameLabel
			// 
			middleNameLabel.AutoSize = true;
			middleNameLabel.Location = new System.Drawing.Point(16, 123);
			middleNameLabel.Name = "middleNameLabel";
			middleNameLabel.Size = new System.Drawing.Size(93, 20);
			middleNameLabel.TabIndex = 7;
			middleNameLabel.Text = "Призвище:";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(120, 21);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(208, 27);
			this.firstNameTextBox.TabIndex = 2;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(120, 72);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(208, 27);
			this.lastNameTextBox.TabIndex = 6;
			// 
			// middleNameTextBox
			// 
			this.middleNameTextBox.Location = new System.Drawing.Point(120, 120);
			this.middleNameTextBox.Name = "middleNameTextBox";
			this.middleNameTextBox.Size = new System.Drawing.Size(208, 27);
			this.middleNameTextBox.TabIndex = 8;
			// 
			// SaveUserBtn
			// 
			this.SaveUserBtn.Location = new System.Drawing.Point(90, 168);
			this.SaveUserBtn.Name = "SaveUserBtn";
			this.SaveUserBtn.Size = new System.Drawing.Size(176, 32);
			this.SaveUserBtn.TabIndex = 9;
			this.SaveUserBtn.Text = "Зберегти";
			this.SaveUserBtn.UseVisualStyleBackColor = true;
			this.SaveUserBtn.Click += new System.EventHandler(this.SaveUserBtn_Click);
			// 
			// UserAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 233);
			this.Controls.Add(this.SaveUserBtn);
			this.Controls.Add(firstNameLabel);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(lastNameLabel);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(middleNameLabel);
			this.Controls.Add(this.middleNameTextBox);
			this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserAddForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Додавання нового користувача";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox middleNameTextBox;
		private System.Windows.Forms.Button SaveUserBtn;
	}
}