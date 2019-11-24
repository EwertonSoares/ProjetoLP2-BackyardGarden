namespace Login
{
    partial class Welcome
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
            this.btn_welcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(87, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO AO BACKYARDGARDEN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_welcome
            // 
            this.btn_welcome.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_welcome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_welcome.Location = new System.Drawing.Point(146, 140);
            this.btn_welcome.Name = "btn_welcome";
            this.btn_welcome.Size = new System.Drawing.Size(75, 23);
            this.btn_welcome.TabIndex = 1;
            this.btn_welcome.Text = "ENTRAR";
            this.btn_welcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_welcome.UseVisualStyleBackColor = true;
            this.btn_welcome.Click += new System.EventHandler(this.btn_welcome_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 281);
            this.Controls.Add(this.btn_welcome);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_welcome;
    }
}