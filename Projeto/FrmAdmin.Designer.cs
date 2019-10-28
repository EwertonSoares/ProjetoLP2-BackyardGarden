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
            this.rdb_fert = new System.Windows.Forms.RadioButton();
            this.rdb_frut = new System.Windows.Forms.RadioButton();
            this.rdb_hort = new System.Windows.Forms.RadioButton();
            this.rdb_pest = new System.Windows.Forms.RadioButton();
            this.btn_entarAdmin = new System.Windows.Forms.Button();
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
            this.rdb_Adm.AutoSize = true;
            this.rdb_Adm.Checked = true;
            this.rdb_Adm.Location = new System.Drawing.Point(30, 46);
            this.rdb_Adm.Name = "rdb_Adm";
            this.rdb_Adm.Size = new System.Drawing.Size(99, 17);
            this.rdb_Adm.TabIndex = 6;
            this.rdb_Adm.TabStop = true;
            this.rdb_Adm.Text = "Administradores";
            this.rdb_Adm.UseVisualStyleBackColor = true;
            // 
            // rdb_fert
            // 
            this.rdb_fert.AutoSize = true;
            this.rdb_fert.Location = new System.Drawing.Point(30, 80);
            this.rdb_fert.Name = "rdb_fert";
            this.rdb_fert.Size = new System.Drawing.Size(80, 17);
            this.rdb_fert.TabIndex = 7;
            this.rdb_fert.Text = "Fertilizantes";
            this.rdb_fert.UseVisualStyleBackColor = true;
            // 
            // rdb_frut
            // 
            this.rdb_frut.AutoSize = true;
            this.rdb_frut.Location = new System.Drawing.Point(30, 116);
            this.rdb_frut.Name = "rdb_frut";
            this.rdb_frut.Size = new System.Drawing.Size(70, 17);
            this.rdb_frut.TabIndex = 8;
            this.rdb_frut.Text = "Fruticolas";
            this.rdb_frut.UseVisualStyleBackColor = true;
            // 
            // rdb_hort
            // 
            this.rdb_hort.AutoSize = true;
            this.rdb_hort.Location = new System.Drawing.Point(30, 152);
            this.rdb_hort.Name = "rdb_hort";
            this.rdb_hort.Size = new System.Drawing.Size(78, 17);
            this.rdb_hort.TabIndex = 9;
            this.rdb_hort.Text = "Horataliças";
            this.rdb_hort.UseVisualStyleBackColor = true;
            // 
            // rdb_pest
            // 
            this.rdb_pest.AutoSize = true;
            this.rdb_pest.Location = new System.Drawing.Point(30, 190);
            this.rdb_pest.Name = "rdb_pest";
            this.rdb_pest.Size = new System.Drawing.Size(73, 17);
            this.rdb_pest.TabIndex = 10;
            this.rdb_pest.Text = "Pesticidas";
            this.rdb_pest.UseVisualStyleBackColor = true;
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
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 281);
            this.Controls.Add(this.btn_entarAdmin);
            this.Controls.Add(this.rdb_pest);
            this.Controls.Add(this.rdb_hort);
            this.Controls.Add(this.rdb_frut);
            this.Controls.Add(this.rdb_fert);
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
        private System.Windows.Forms.RadioButton rdb_fert;
        private System.Windows.Forms.RadioButton rdb_frut;
        private System.Windows.Forms.RadioButton rdb_hort;
        private System.Windows.Forms.RadioButton rdb_pest;
        private System.Windows.Forms.Button btn_entarAdmin;
    }
}