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
            this.ViewAll = new System.Windows.Forms.DataGridView();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
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
            this.DgvAdm.Location = new System.Drawing.Point(12, 12);
            this.DgvAdm.Name = "DgvAdm";
            this.DgvAdm.Size = new System.Drawing.Size(434, 319);
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
            // ViewAll
            // 
            this.ViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAll.Location = new System.Drawing.Point(45, 81);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(370, 205);
            this.ViewAll.TabIndex = 10;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.Control;
            this.btn_del.Location = new System.Drawing.Point(45, 50);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(88, 25);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "Deletar";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(359, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(136, 292);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(179, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Test.Location = new System.Drawing.Point(300, 50);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(88, 25);
            this.btn_Test.TabIndex = 15;
            this.btn_Test.Text = "Teste";
            this.btn_Test.UseVisualStyleBackColor = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // Frm_ShowAdmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(458, 336);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DgvAdm);
            this.Name = "Frm_ShowAdmInformation";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Frm_ShowAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAdm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView ViewAll;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Test;
    }
}