namespace Login
{
    partial class FrmSegundaPagina
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHort = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Frt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogout.Location = new System.Drawing.Point(12, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 37);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.UseWaitCursor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHort
            // 
            this.btnHort.Location = new System.Drawing.Point(12, 72);
            this.btnHort.Name = "btnHort";
            this.btnHort.Size = new System.Drawing.Size(330, 58);
            this.btnHort.TabIndex = 2;
            this.btnHort.Text = "HORTALÇAS";
            this.btnHort.UseVisualStyleBackColor = true;
            this.btnHort.Click += new System.EventHandler(this.btnHort_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(268, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Perfil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            // 
            // btn_Frt
            // 
            this.btn_Frt.Location = new System.Drawing.Point(12, 172);
            this.btn_Frt.Name = "btn_Frt";
            this.btn_Frt.Size = new System.Drawing.Size(330, 58);
            this.btn_Frt.TabIndex = 4;
            this.btn_Frt.Text = "FRUTICOLAS";
            this.btn_Frt.UseVisualStyleBackColor = true;
            this.btn_Frt.Click += new System.EventHandler(this.btn_Frt_Click);
            // 
            // FrmPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 281);
            this.Controls.Add(this.btn_Frt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHort);
            this.Controls.Add(this.btnLogout);
            this.Name = "FrmPaginaInicial";
            this.Text = "Página principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHort;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Frt;
    }
}