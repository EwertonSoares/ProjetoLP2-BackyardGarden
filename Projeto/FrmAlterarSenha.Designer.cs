namespace Login
{
    partial class FrmUpPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpPass));
            this.txbnovaSenha = new System.Windows.Forms.TextBox();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSavePass = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbnovaSenha
            // 
            this.txbnovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbnovaSenha.Location = new System.Drawing.Point(45, 67);
            this.txbnovaSenha.Name = "txbnovaSenha";
            this.txbnovaSenha.PasswordChar = '•';
            this.txbnovaSenha.Size = new System.Drawing.Size(152, 20);
            this.txbnovaSenha.TabIndex = 14;
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxConfirm.Location = new System.Drawing.Point(45, 128);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.PasswordChar = '•';
            this.tbxConfirm.Size = new System.Drawing.Size(152, 20);
            this.tbxConfirm.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nova senha";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Confirmar nova senha";
            // 
            // buttonSavePass
            // 
            this.buttonSavePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSavePass.Location = new System.Drawing.Point(77, 205);
            this.buttonSavePass.Name = "buttonSavePass";
            this.buttonSavePass.Size = new System.Drawing.Size(95, 23);
            this.buttonSavePass.TabIndex = 32;
            this.buttonSavePass.Text = "Salvar senha";
            this.buttonSavePass.UseVisualStyleBackColor = true;
            this.buttonSavePass.Click += new System.EventHandler(this.buttonSavePass_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Location = new System.Drawing.Point(77, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 23);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FrmUpPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(245, 289);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSavePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxConfirm);
            this.Controls.Add(this.txbnovaSenha);
            this.Name = "FrmUpPass";
            this.ShowIcon = false;
            this.Text = "Alterar senha";
            this.Load += new System.EventHandler(this.FrmUpPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbnovaSenha;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSavePass;
        private System.Windows.Forms.Button buttonCancel;
    }
}