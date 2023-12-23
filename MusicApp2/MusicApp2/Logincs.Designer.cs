namespace MusicApp2
{
    partial class Logincs
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
            this.lbl_lgn_mail = new System.Windows.Forms.Label();
            this.lbl_lgn_password = new System.Windows.Forms.Label();
            this.lgn_mail_txb = new System.Windows.Forms.TextBox();
            this.lgn_password_txb = new System.Windows.Forms.TextBox();
            this.lgn_exit_btn = new System.Windows.Forms.Button();
            this.lgn_clear_btn = new System.Windows.Forms.Button();
            this.lgn_login_btn = new System.Windows.Forms.Button();
            this.lbl_lgn_title = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lgn_mail
            // 
            this.lbl_lgn_mail.AccessibleName = "";
            this.lbl_lgn_mail.AutoSize = true;
            this.lbl_lgn_mail.Location = new System.Drawing.Point(101, 97);
            this.lbl_lgn_mail.Name = "lbl_lgn_mail";
            this.lbl_lgn_mail.Size = new System.Drawing.Size(41, 16);
            this.lbl_lgn_mail.TabIndex = 0;
            this.lbl_lgn_mail.Text = "Email";
            // 
            // lbl_lgn_password
            // 
            this.lbl_lgn_password.AutoSize = true;
            this.lbl_lgn_password.Location = new System.Drawing.Point(75, 152);
            this.lbl_lgn_password.Name = "lbl_lgn_password";
            this.lbl_lgn_password.Size = new System.Drawing.Size(67, 16);
            this.lbl_lgn_password.TabIndex = 1;
            this.lbl_lgn_password.Text = "Password";
            // 
            // lgn_mail_txb
            // 
            this.lgn_mail_txb.Location = new System.Drawing.Point(187, 94);
            this.lgn_mail_txb.Name = "lgn_mail_txb";
            this.lgn_mail_txb.Size = new System.Drawing.Size(234, 22);
            this.lgn_mail_txb.TabIndex = 2;
            // 
            // lgn_password_txb
            // 
            this.lgn_password_txb.Location = new System.Drawing.Point(187, 146);
            this.lgn_password_txb.Name = "lgn_password_txb";
            this.lgn_password_txb.Size = new System.Drawing.Size(234, 22);
            this.lgn_password_txb.TabIndex = 3;
            this.lgn_password_txb.UseSystemPasswordChar = true;
            // 
            // lgn_exit_btn
            // 
            this.lgn_exit_btn.Location = new System.Drawing.Point(78, 214);
            this.lgn_exit_btn.Name = "lgn_exit_btn";
            this.lgn_exit_btn.Size = new System.Drawing.Size(75, 33);
            this.lgn_exit_btn.TabIndex = 4;
            this.lgn_exit_btn.Text = "Register";
            this.lgn_exit_btn.UseVisualStyleBackColor = true;
            this.lgn_exit_btn.Click += new System.EventHandler(this.lgn_exit_btn_Click);
            // 
            // lgn_clear_btn
            // 
            this.lgn_clear_btn.BackColor = System.Drawing.Color.White;
            this.lgn_clear_btn.Location = new System.Drawing.Point(221, 214);
            this.lgn_clear_btn.Name = "lgn_clear_btn";
            this.lgn_clear_btn.Size = new System.Drawing.Size(75, 33);
            this.lgn_clear_btn.TabIndex = 5;
            this.lgn_clear_btn.Text = "Clear";
            this.lgn_clear_btn.UseVisualStyleBackColor = false;
            this.lgn_clear_btn.Click += new System.EventHandler(this.lgn_clear_btn_Click);
            // 
            // lgn_login_btn
            // 
            this.lgn_login_btn.Location = new System.Drawing.Point(346, 214);
            this.lgn_login_btn.Name = "lgn_login_btn";
            this.lgn_login_btn.Size = new System.Drawing.Size(75, 33);
            this.lgn_login_btn.TabIndex = 6;
            this.lgn_login_btn.Text = "Login";
            this.lgn_login_btn.UseVisualStyleBackColor = true;
            this.lgn_login_btn.Click += new System.EventHandler(this.lgn_login_btn_Click);
            // 
            // lbl_lgn_title
            // 
            this.lbl_lgn_title.AutoSize = true;
            this.lbl_lgn_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lgn_title.Location = new System.Drawing.Point(178, 9);
            this.lbl_lgn_title.Name = "lbl_lgn_title";
            this.lbl_lgn_title.Size = new System.Drawing.Size(142, 54);
            this.lbl_lgn_title.TabIndex = 7;
            this.lbl_lgn_title.Text = "Login";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Logincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(490, 329);
            this.Controls.Add(this.lbl_lgn_title);
            this.Controls.Add(this.lgn_login_btn);
            this.Controls.Add(this.lgn_clear_btn);
            this.Controls.Add(this.lgn_exit_btn);
            this.Controls.Add(this.lgn_password_txb);
            this.Controls.Add(this.lgn_mail_txb);
            this.Controls.Add(this.lbl_lgn_password);
            this.Controls.Add(this.lbl_lgn_mail);
            this.Name = "Logincs";
            this.Text = "Logincs";
            this.Load += new System.EventHandler(this.Logincs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lgn_mail;
        private System.Windows.Forms.Label lbl_lgn_password;
        private System.Windows.Forms.TextBox lgn_mail_txb;
        private System.Windows.Forms.TextBox lgn_password_txb;
        private System.Windows.Forms.Button lgn_exit_btn;
        private System.Windows.Forms.Button lgn_clear_btn;
        private System.Windows.Forms.Button lgn_login_btn;
        private System.Windows.Forms.Label lbl_lgn_title;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}