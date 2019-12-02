namespace Login
{
    partial class FrmAdmin
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
            this.rdb_Adm = new System.Windows.Forms.RadioButton();
            this.rdb_frut = new System.Windows.Forms.RadioButton();
            this.rdb_hort = new System.Windows.Forms.RadioButton();
            this.rdb_prag = new System.Windows.Forms.RadioButton();
            this.btn_entarAdmin = new System.Windows.Forms.Button();
            this.rdb_doen = new System.Windows.Forms.RadioButton();
            this.rdb_font = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ESCOLHA UMA DAS OPÇÕES ABAIXO";
            // 
            // rdb_Adm
            // 
            this.rdb_Adm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_Adm.AutoSize = true;
            this.rdb_Adm.Checked = true;
            this.rdb_Adm.Location = new System.Drawing.Point(57, 56);
            this.rdb_Adm.Name = "rdb_Adm";
            this.rdb_Adm.Size = new System.Drawing.Size(99, 17);
            this.rdb_Adm.TabIndex = 6;
            this.rdb_Adm.TabStop = true;
            this.rdb_Adm.Text = "Administradores";
            this.rdb_Adm.UseVisualStyleBackColor = true;
            // 
            // rdb_frut
            // 
            this.rdb_frut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_frut.AutoSize = true;
            this.rdb_frut.Location = new System.Drawing.Point(57, 105);
            this.rdb_frut.Name = "rdb_frut";
            this.rdb_frut.Size = new System.Drawing.Size(68, 17);
            this.rdb_frut.TabIndex = 8;
            this.rdb_frut.Text = "Frutiferas";
            this.rdb_frut.UseVisualStyleBackColor = true;
            // 
            // rdb_hort
            // 
            this.rdb_hort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_hort.AutoSize = true;
            this.rdb_hort.Location = new System.Drawing.Point(57, 152);
            this.rdb_hort.Name = "rdb_hort";
            this.rdb_hort.Size = new System.Drawing.Size(72, 17);
            this.rdb_hort.TabIndex = 9;
            this.rdb_hort.Text = "Hortaliças";
            this.rdb_hort.UseVisualStyleBackColor = true;
            // 
            // rdb_prag
            // 
            this.rdb_prag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_prag.AutoSize = true;
            this.rdb_prag.Location = new System.Drawing.Point(235, 56);
            this.rdb_prag.Name = "rdb_prag";
            this.rdb_prag.Size = new System.Drawing.Size(58, 17);
            this.rdb_prag.TabIndex = 10;
            this.rdb_prag.Text = "Pragas";
            this.rdb_prag.UseVisualStyleBackColor = true;
            // 
            // btn_entarAdmin
            // 
            this.btn_entarAdmin.Location = new System.Drawing.Point(132, 224);
            this.btn_entarAdmin.Name = "btn_entarAdmin";
            this.btn_entarAdmin.Size = new System.Drawing.Size(75, 23);
            this.btn_entarAdmin.TabIndex = 11;
            this.btn_entarAdmin.Text = "Entrar";
            this.btn_entarAdmin.UseVisualStyleBackColor = true;
            this.btn_entarAdmin.Click += new System.EventHandler(this.btn_entarAdmin_Click);
            // 
            // rdb_doen
            // 
            this.rdb_doen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_doen.AutoSize = true;
            this.rdb_doen.Location = new System.Drawing.Point(235, 105);
            this.rdb_doen.Name = "rdb_doen";
            this.rdb_doen.Size = new System.Drawing.Size(68, 17);
            this.rdb_doen.TabIndex = 12;
            this.rdb_doen.Text = "Doenças";
            this.rdb_doen.UseVisualStyleBackColor = true;
            // 
            // rdb_font
            // 
            this.rdb_font.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_font.AutoSize = true;
            this.rdb_font.Location = new System.Drawing.Point(236, 152);
            this.rdb_font.Name = "rdb_font";
            this.rdb_font.Size = new System.Drawing.Size(57, 17);
            this.rdb_font.TabIndex = 13;
            this.rdb_font.Text = "Fontes";
            this.rdb_font.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 281);
            this.Controls.Add(this.rdb_font);
            this.Controls.Add(this.rdb_doen);
            this.Controls.Add(this.btn_entarAdmin);
            this.Controls.Add(this.rdb_prag);
            this.Controls.Add(this.rdb_hort);
            this.Controls.Add(this.rdb_frut);
            this.Controls.Add(this.rdb_Adm);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdmin";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_Adm;
        private System.Windows.Forms.RadioButton rdb_frut;
        private System.Windows.Forms.RadioButton rdb_hort;
        private System.Windows.Forms.RadioButton rdb_prag;
        private System.Windows.Forms.Button btn_entarAdmin;
        private System.Windows.Forms.RadioButton rdb_doen;
        private System.Windows.Forms.RadioButton rdb_font;
    }
}