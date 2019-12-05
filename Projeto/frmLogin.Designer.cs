namespace Login
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.rdb_user = new System.Windows.Forms.RadioButton();
            this.rdb_Adm = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(52, 29);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(126, 20);
            this.txbUser.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(52, 63);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(126, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Login.Location = new System.Drawing.Point(31, 95);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(70, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Entrar";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadastrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cadastrar.Location = new System.Drawing.Point(31, 124);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(70, 23);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // rdb_user
            // 
            this.rdb_user.AutoSize = true;
            this.rdb_user.BackColor = System.Drawing.Color.Transparent;
            this.rdb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_user.Location = new System.Drawing.Point(117, 124);
            this.rdb_user.Name = "rdb_user";
            this.rdb_user.Size = new System.Drawing.Size(68, 17);
            this.rdb_user.TabIndex = 7;
            this.rdb_user.Text = "Usuario";
            this.rdb_user.UseVisualStyleBackColor = false;
            // 
            // rdb_Adm
            // 
            this.rdb_Adm.AutoSize = true;
            this.rdb_Adm.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Adm.Checked = true;
            this.rdb_Adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Adm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_Adm.Location = new System.Drawing.Point(117, 95);
            this.rdb_Adm.Name = "rdb_Adm";
            this.rdb_Adm.Size = new System.Drawing.Size(101, 17);
            this.rdb_Adm.TabIndex = 8;
            this.rdb_Adm.TabStop = true;
            this.rdb_Adm.Text = "Administrador";
            this.rdb_Adm.UseVisualStyleBackColor = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.txbUser);
            this.pnlLogin.Controls.Add(this.rdb_Adm);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.rdb_user);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btn_cadastrar);
            this.pnlLogin.Controls.Add(this.btn_Login);
            this.pnlLogin.Location = new System.Drawing.Point(146, 155);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(229, 170);
            this.pnlLogin.TabIndex = 10;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(232, 35);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(59, 66);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 11;
            this.pictureLogo.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Yu Gothic Light", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(115, 104);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(281, 48);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Horta no Quintal";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 344);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.pnlLogin);
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.Text = "Login de usuário";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.RadioButton rdb_user;
        private System.Windows.Forms.RadioButton rdb_Adm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelName;
    }
}

