namespace Desktop.Views.Software
{
    partial class ChoiseSoftwareForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.operatingSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.AcceptSelect = new System.Windows.Forms.Button();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.softwaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.operatingSystemBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(0, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(165, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Операційна система";
      // 
      // comboBox1
      // 
      this.comboBox1.DataSource = this.operatingSystemBindingSource;
      this.comboBox1.DisplayMember = "Name";
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(176, 48);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(200, 28);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.ValueMember = "Id";
      // 
      // operatingSystemBindingSource
      // 
      this.operatingSystemBindingSource.DataSource = typeof(UI.Models.OperatingSystem);
      // 
      // AcceptSelect
      // 
      this.AcceptSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.AcceptSelect.Location = new System.Drawing.Point(104, 168);
      this.AcceptSelect.Name = "AcceptSelect";
      this.AcceptSelect.Size = new System.Drawing.Size(168, 32);
      this.AcceptSelect.TabIndex = 2;
      this.AcceptSelect.Text = "Обрати";
      this.AcceptSelect.UseVisualStyleBackColor = true;
      this.AcceptSelect.Click += new System.EventHandler(this.AcceptSelect_Click);
      // 
      // comboBox2
      // 
      this.comboBox2.DataSource = this.softwaresBindingSource;
      this.comboBox2.DisplayMember = "Name";
      this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(176, 104);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(200, 28);
      this.comboBox2.TabIndex = 4;
      this.comboBox2.ValueMember = "Id";
      // 
      // softwaresBindingSource
      // 
      this.softwaresBindingSource.DataMember = "Softwares";
      this.softwaresBindingSource.DataSource = this.operatingSystemBindingSource;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(0, 104);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Програма";
      // 
      // ChoiseSoftwareForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(391, 230);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.AcceptSelect);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChoiseSoftwareForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Вибір існуючого програмного додатку";
      this.Load += new System.EventHandler(this.ChoiseSoftwareForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.operatingSystemBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AcceptSelect;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource operatingSystemBindingSource;
        private System.Windows.Forms.BindingSource softwaresBindingSource;
    }
}