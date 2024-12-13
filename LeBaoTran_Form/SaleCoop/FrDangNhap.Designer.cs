namespace SaleCoop
{
    partial class FrDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrDangNhap));
            this.llblQuenMK = new System.Windows.Forms.LinkLabel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pbAnMK = new System.Windows.Forms.PictureBox();
            this.pbHienMK = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.pbLogIn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHienMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // llblQuenMK
            // 
            this.llblQuenMK.AutoSize = true;
            this.llblQuenMK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.llblQuenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblQuenMK.LinkColor = System.Drawing.Color.Black;
            this.llblQuenMK.Location = new System.Drawing.Point(257, 306);
            this.llblQuenMK.Name = "llblQuenMK";
            this.llblQuenMK.Size = new System.Drawing.Size(131, 20);
            this.llblQuenMK.TabIndex = 28;
            this.llblQuenMK.TabStop = true;
            this.llblQuenMK.Text = "Quên mật khẩu?";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.Location = new System.Drawing.Point(117, 260);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(291, 28);
            this.txtPass.TabIndex = 26;
            // 
            // btnLogIn
            // 
            this.btnLogIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogIn.Location = new System.Drawing.Point(159, 352);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(145, 58);
            this.btnLogIn.TabIndex = 25;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(117, 211);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(291, 28);
            this.txtUsername.TabIndex = 24;
            // 
            // pbAnMK
            // 
            this.pbAnMK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbAnMK.BackgroundImage = global::SaleCoop.Properties.Resources.eye1;
            this.pbAnMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAnMK.Location = new System.Drawing.Point(379, 260);
            this.pbAnMK.Name = "pbAnMK";
            this.pbAnMK.Size = new System.Drawing.Size(29, 28);
            this.pbAnMK.TabIndex = 31;
            this.pbAnMK.TabStop = false;
            this.pbAnMK.Click += new System.EventHandler(this.pbAnMK_Click_1);
            // 
            // pbHienMK
            // 
            this.pbHienMK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbHienMK.BackgroundImage = global::SaleCoop.Properties.Resources.view1;
            this.pbHienMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbHienMK.Location = new System.Drawing.Point(379, 260);
            this.pbHienMK.Name = "pbHienMK";
            this.pbHienMK.Size = new System.Drawing.Size(29, 28);
            this.pbHienMK.TabIndex = 32;
            this.pbHienMK.TabStop = false;
            // 
            // pbPass
            // 
            this.pbPass.BackgroundImage = global::SaleCoop.Properties.Resources.lock2;
            this.pbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPass.Location = new System.Drawing.Point(77, 262);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(34, 29);
            this.pbPass.TabIndex = 30;
            this.pbPass.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.BackgroundImage = global::SaleCoop.Properties.Resources.user1;
            this.pbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUsername.Location = new System.Drawing.Point(77, 212);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(34, 30);
            this.pbUsername.TabIndex = 29;
            this.pbUsername.TabStop = false;
            // 
            // pbLogIn
            // 
            this.pbLogIn.BackgroundImage = global::SaleCoop.Properties.Resources.programmer3;
            this.pbLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogIn.Location = new System.Drawing.Point(145, 33);
            this.pbLogIn.Name = "pbLogIn";
            this.pbLogIn.Size = new System.Drawing.Size(204, 166);
            this.pbLogIn.TabIndex = 27;
            this.pbLogIn.TabStop = false;
            // 
            // FrDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.pbAnMK);
            this.Controls.Add(this.pbHienMK);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbUsername);
            this.Controls.Add(this.llblQuenMK);
            this.Controls.Add(this.pbLogIn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrDangNhap";
            this.Text = "FrDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pbAnMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHienMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnMK;
        private System.Windows.Forms.PictureBox pbHienMK;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.LinkLabel llblQuenMK;
        private System.Windows.Forms.PictureBox pbLogIn;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtUsername;
    }
}