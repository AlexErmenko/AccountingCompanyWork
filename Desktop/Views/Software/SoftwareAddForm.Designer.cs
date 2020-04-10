using System.ComponentModel;

namespace Desktop.Views.Software
{
  partial class SoftwareAddForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if(disposing && ( components != null ))
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
      this.label5 = new System.Windows.Forms.Label();
      this.SoftwareNameTextBox = new System.Windows.Forms.TextBox();
      this.SoftwareOcCbb = new System.Windows.Forms.ComboBox();
      this.operatingSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label6 = new System.Windows.Forms.Label();
      this.AddSoftwareForUserBtn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.operatingSystemBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(23, 72);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(56, 20);
      this.label5.TabIndex = 0;
      this.label5.Text = "Назва";
      // 
      // SoftwareNameTextBox
      // 
      this.SoftwareNameTextBox.Location = new System.Drawing.Point(95, 64);
      this.SoftwareNameTextBox.Name = "SoftwareNameTextBox";
      this.SoftwareNameTextBox.Size = new System.Drawing.Size(216, 27);
      this.SoftwareNameTextBox.TabIndex = 1;
      // 
      // SoftwareOcCbb
      // 
      this.SoftwareOcCbb.DataSource = this.operatingSystemBindingSource;
      this.SoftwareOcCbb.DisplayMember = "Name";
      this.SoftwareOcCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SoftwareOcCbb.FormattingEnabled = true;
      this.SoftwareOcCbb.Location = new System.Drawing.Point(95, 16);
      this.SoftwareOcCbb.Name = "SoftwareOcCbb";
      this.SoftwareOcCbb.Size = new System.Drawing.Size(216, 28);
      this.SoftwareOcCbb.TabIndex = 2;
      this.SoftwareOcCbb.ValueMember = "Id";
      // 
      // operatingSystemBindingSource
      // 
      this.operatingSystemBindingSource.DataSource = typeof(UI.Models.OperatingSystem);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(23, 24);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(33, 20);
      this.label6.TabIndex = 3;
      this.label6.Text = "ОС";
      // 
      // AddSoftwareForUserBtn
      // 
      this.AddSoftwareForUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.AddSoftwareForUserBtn.Location = new System.Drawing.Point(83, 152);
      this.AddSoftwareForUserBtn.Name = "AddSoftwareForUserBtn";
      this.AddSoftwareForUserBtn.Size = new System.Drawing.Size(168, 40);
      this.AddSoftwareForUserBtn.TabIndex = 4;
      this.AddSoftwareForUserBtn.Text = "Створити";
      this.AddSoftwareForUserBtn.UseVisualStyleBackColor = true;
      this.AddSoftwareForUserBtn.Click += new System.EventHandler(this.AddSoftwareForUserBtn_Click);
      // 
      // SoftwareAddForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(334, 227);
      this.Controls.Add(this.AddSoftwareForUserBtn);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.SoftwareOcCbb);
      this.Controls.Add(this.SoftwareNameTextBox);
      this.Controls.Add(this.label5);
      this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Location = new System.Drawing.Point(15, 15);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SoftwareAddForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Вікно додавання програмного додатку";
      this.Load += new System.EventHandler(this.SoftwareAddForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.operatingSystemBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button CreateSoftwareForUserBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoftwareNameTextBox;
        private System.Windows.Forms.ComboBox SoftwareOcCbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddSoftwareForUserBtn;
        private System.Windows.Forms.BindingSource operatingSystemBindingSource;
    }
}

