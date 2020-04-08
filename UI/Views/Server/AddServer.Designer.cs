namespace UI.Views.Server
{
    partial class AddServer
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
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveServerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(128, 48);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(200, 27);
            this.serverNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва сервера";
            // 
            // SaveServerBtn
            // 
            this.SaveServerBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveServerBtn.Location = new System.Drawing.Point(58, 128);
            this.SaveServerBtn.Name = "SaveServerBtn";
            this.SaveServerBtn.Size = new System.Drawing.Size(224, 40);
            this.SaveServerBtn.TabIndex = 2;
            this.SaveServerBtn.Text = "Зберегти";
            this.SaveServerBtn.UseVisualStyleBackColor = true;
            this.SaveServerBtn.Click += new System.EventHandler(this.SaveServerBtn_Click);
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 203);
            this.Controls.Add(this.SaveServerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverNameTextBox);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додавання сервера";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveServerBtn;
    }
}