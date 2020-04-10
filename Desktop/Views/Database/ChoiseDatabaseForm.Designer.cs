namespace Desktop.Views.Database
{
  partial class ChoiseDatabaseForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Сервер";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(88, 152);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(168, 32);
      this.button1.TabIndex = 1;
      this.button1.Text = "Обрати";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.DataSource = this.serverBindingSource;
      this.comboBox1.DisplayMember = "Name";
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(128, 40);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(200, 28);
      this.comboBox1.TabIndex = 3;
      this.comboBox1.ValueMember = "Id";
      // 
      // serverBindingSource
      // 
      this.serverBindingSource.DataSource = typeof(UI.Models.Server);
      // 
      // comboBox2
      // 
      this.comboBox2.DataSource = this.databasesBindingSource;
      this.comboBox2.DisplayMember = "Name";
      this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(128, 96);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(200, 28);
      this.comboBox2.TabIndex = 4;
      this.comboBox2.ValueMember = "Id";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 96);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "База даних";
      // 
      // databasesBindingSource
      // 
      this.databasesBindingSource.DataMember = "Databases";
      this.databasesBindingSource.DataSource = this.serverBindingSource;
      // 
      // ChoiseDatabaseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(345, 217);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChoiseDatabaseForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ChoiseDatabaseForm";
      ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource serverBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource databasesBindingSource;
    }
}