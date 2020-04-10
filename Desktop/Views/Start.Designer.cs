namespace Desktop.Views
{
  partial class Start
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
		  this.label1 = new System.Windows.Forms.Label();
		  this.GetStartBtn = new System.Windows.Forms.Button();
		  this.label2 = new System.Windows.Forms.Label();
		  this.SuspendLayout();

		  // 
		  // label1
		  // 
		  this.label1.AutoSize = true;
		  this.label1.Location = new System.Drawing.Point(77, 48);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(387, 20);
		  this.label1.TabIndex = 0;
		  this.label1.Text = "Тема: облік роботи з різними додатками на фірмі ";

		  // 
		  // GetStartBtn
		  // 
		  this.GetStartBtn.Location = new System.Drawing.Point(160, 208);
		  this.GetStartBtn.Name = "GetStartBtn";
		  this.GetStartBtn.Size = new System.Drawing.Size(221, 48);
		  this.GetStartBtn.TabIndex = 1;
		  this.GetStartBtn.Text = "Перейти до демонстрації";
		  this.GetStartBtn.UseVisualStyleBackColor = true;
		  this.GetStartBtn.Click += new System.EventHandler(this.GetStartBtn_Click);

		  // 
		  // label2
		  // 
		  this.label2.AutoSize = true;
		  this.label2.Location = new System.Drawing.Point(77, 128);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(97, 20);
		  this.label2.TabIndex = 2;
		  this.label2.Text = "Розробник: ";

		  // 
		  // Start
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(541, 286);
		  this.Controls.Add(this.label2);
		  this.Controls.Add(this.GetStartBtn);
		  this.Controls.Add(this.label1);
		  this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 204 ) ));
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		  this.Margin = new System.Windows.Forms.Padding(5);
		  this.MaximizeBox = false;
		  this.MinimizeBox = false;
		  this.Name = "Start";
		  this.ShowIcon = false;
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Початкове вікно";
		  this.ResumeLayout(false);
		  this.PerformLayout();
	  }

	  private System.Windows.Forms.Button GetStartBtn;
	  private System.Windows.Forms.Label label1;
	  private System.Windows.Forms.Label label2;

	  #endregion
  }
}
