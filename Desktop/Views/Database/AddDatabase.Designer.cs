namespace Desktop.Views.Database
{
    partial class AddDatabase
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idServerNavigationLabel;
            this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idServerNavigationComboBox = new System.Windows.Forms.ComboBox();
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveDatabaseBtn = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            idServerNavigationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBaseBindingSource
            // 
            this.dataBaseBindingSource.DataSource = typeof(UI.Models.DataBase);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(8, 24);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(88, 20);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBaseBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(112, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 27);
            this.nameTextBox.TabIndex = 6;
            // 
            // idServerNavigationLabel
            // 
            idServerNavigationLabel.AutoSize = true;
            idServerNavigationLabel.Location = new System.Drawing.Point(16, 64);
            idServerNavigationLabel.Name = "idServerNavigationLabel";
            idServerNavigationLabel.Size = new System.Drawing.Size(68, 20);
            idServerNavigationLabel.TabIndex = 10;
            idServerNavigationLabel.Text = "Сервер:";
            // 
            // idServerNavigationComboBox
            // 
            this.idServerNavigationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBaseBindingSource, "IdServerNavigation", true));
            this.idServerNavigationComboBox.DataSource = this.serverBindingSource;
            this.idServerNavigationComboBox.DisplayMember = "Id";
            this.idServerNavigationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idServerNavigationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.idServerNavigationComboBox.FormattingEnabled = true;
            this.idServerNavigationComboBox.Location = new System.Drawing.Point(112, 64);
            this.idServerNavigationComboBox.Name = "idServerNavigationComboBox";
            this.idServerNavigationComboBox.Size = new System.Drawing.Size(200, 28);
            this.idServerNavigationComboBox.TabIndex = 11;
            this.idServerNavigationComboBox.ValueMember = "Name";
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataSource = typeof(UI.Models.Server);
            // 
            // SaveDatabaseBtn
            // 
            this.SaveDatabaseBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveDatabaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveDatabaseBtn.Location = new System.Drawing.Point(88, 120);
            this.SaveDatabaseBtn.Name = "SaveDatabaseBtn";
            this.SaveDatabaseBtn.Size = new System.Drawing.Size(142, 40);
            this.SaveDatabaseBtn.TabIndex = 12;
            this.SaveDatabaseBtn.Text = "Зберегти";
            this.SaveDatabaseBtn.UseVisualStyleBackColor = true;
            this.SaveDatabaseBtn.Click += new System.EventHandler(this.SaveDatabaseBtn_Click);
            // 
            // AddDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 190);
            this.Controls.Add(this.SaveDatabaseBtn);
            this.Controls.Add(idServerNavigationLabel);
            this.Controls.Add(this.idServerNavigationComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDatabase";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додавання бази даних";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataBaseBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox idServerNavigationComboBox;
        private System.Windows.Forms.BindingSource serverBindingSource;
        private System.Windows.Forms.Button SaveDatabaseBtn;
    }
}