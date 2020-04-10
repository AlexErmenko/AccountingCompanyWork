namespace Desktop.Views.OS
{
  partial class AddOS
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
      this.label1 = new System.Windows.Forms.Label();
      this.SaveOsBtn = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();

      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Назва ";

      // 
      // SaveOsBtn
      // 
      this.SaveOsBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.SaveOsBtn.Location = new System.Drawing.Point(80, 128);
      this.SaveOsBtn.Name = "SaveOsBtn";
      this.SaveOsBtn.Size = new System.Drawing.Size(144, 32);
      this.SaveOsBtn.TabIndex = 1;
      this.SaveOsBtn.Text = "Зберегти";
      this.SaveOsBtn.UseVisualStyleBackColor = true;
      this.SaveOsBtn.Click += new System.EventHandler(this.SaveOsBtn_Click);

      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(112, 32);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(208, 27);
      this.textBox1.TabIndex = 2;

      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(112, 80);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(208, 27);
      this.textBox2.TabIndex = 4;

      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Розрядність";

      // 
      // AddOS
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(332, 190);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.SaveOsBtn);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 254 ) ));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AddOS";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Додавання операційної системи";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button SaveOsBtn;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    #endregion
  }
}