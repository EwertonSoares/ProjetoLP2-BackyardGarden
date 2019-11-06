namespace Login
{
    partial class Frm_ShowAdmInformation
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
            this.DgvAdm = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ViewAll = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.bnt_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAdm
            // 
            this.DgvAdm.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvAdm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAdm.Location = new System.Drawing.Point(12, 3);
            this.DgvAdm.Name = "DgvAdm";
            this.DgvAdm.Size = new System.Drawing.Size(434, 328);
            this.DgvAdm.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_name.Location = new System.Drawing.Point(42, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_email.Location = new System.Drawing.Point(165, 51);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 7;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_pwd.Location = new System.Drawing.Point(320, 51);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(38, 13);
            this.lbl_pwd.TabIndex = 8;
            this.lbl_pwd.Text = "Senha";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(323, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 20);
            this.textBox3.TabIndex = 9;
            // 
            // ViewAll
            // 
            this.ViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAll.Location = new System.Drawing.Point(45, 139);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(370, 174);
            this.ViewAll.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(244, 110);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(61, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.BackColor = System.Drawing.SystemColors.Control;
            this.btn_upd.Location = new System.Drawing.Point(311, 110);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(47, 23);
            this.btn_upd.TabIndex = 12;
            this.btn_upd.Text = "Editar";
            this.btn_upd.UseVisualStyleBackColor = false;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sair.Location = new System.Drawing.Point(385, 12);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(48, 23);
            this.btn_sair.TabIndex = 13;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.Control;
            this.btn_show.Location = new System.Drawing.Point(45, 110);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(99, 23);
            this.btn_show.TabIndex = 15;
            this.btn_show.Text = "Atualizar exibição";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // bnt_delete
            // 
            this.bnt_delete.BackColor = System.Drawing.SystemColors.Control;
            this.bnt_delete.Location = new System.Drawing.Point(364, 110);
            this.bnt_delete.Name = "bnt_delete";
            this.bnt_delete.Size = new System.Drawing.Size(49, 23);
            this.bnt_delete.TabIndex = 16;
            this.bnt_delete.Text = "Delete";
            this.bnt_delete.UseVisualStyleBackColor = false;
            this.bnt_delete.Click += new System.EventHandler(this.bnt_delete_Click);
            // 
            // Frm_ShowAdmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(458, 336);
            this.Controls.Add(this.bnt_delete);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DgvAdm);
            this.Name = "Frm_ShowAdmInformation";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAdm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView ViewAll;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button bnt_delete;
    }
}