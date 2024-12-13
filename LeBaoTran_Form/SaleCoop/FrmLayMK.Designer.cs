
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SaleCoop
{
    partial class FrmLayMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLayMK));
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnLayMK = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.pbLogIn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Calistoga", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKQ.Location = new System.Drawing.Point(54, 266);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(0, 29);
            this.lblKQ.TabIndex = 37;
            // 
            // btnLayMK
            // 
            this.btnLayMK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLayMK.Font = new System.Drawing.Font("Calistoga", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLayMK.Location = new System.Drawing.Point(96, 319);
            this.btnLayMK.Name = "btnLayMK";
            this.btnLayMK.Size = new System.Drawing.Size(175, 58);
            this.btnLayMK.TabIndex = 33;
            this.btnLayMK.Text = "LẤY LẠI MẬT KHẨU";
            this.btnLayMK.UseVisualStyleBackColor = true;
            this.btnLayMK.Click += new System.EventHandler(this.btnLayMK_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Calistoga", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(54, 215);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(291, 31);
            this.txtUsername.TabIndex = 32;
            // 
            // pbPass
            // 
            this.pbPass.BackgroundImage = global::SaleCoop.Properties.Resources.lock2;
            this.pbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPass.Location = new System.Drawing.Point(14, 266);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(34, 29);
            this.pbPass.TabIndex = 36;
            this.pbPass.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.BackgroundImage = global::SaleCoop.Properties.Resources.user1;
            this.pbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUsername.Location = new System.Drawing.Point(14, 216);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(34, 30);
            this.pbUsername.TabIndex = 35;
            this.pbUsername.TabStop = false;
            // 
            // pbLogIn
            // 
            this.pbLogIn.BackgroundImage = global::SaleCoop.Properties.Resources.programmer3;
            this.pbLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogIn.Location = new System.Drawing.Point(82, 37);
            this.pbLogIn.Name = "pbLogIn";
            this.pbLogIn.Size = new System.Drawing.Size(204, 166);
            this.pbLogIn.TabIndex = 34;
            this.pbLogIn.TabStop = false;
            // 
            // FrmLayMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 392);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbUsername);
            this.Controls.Add(this.pbLogIn);
            this.Controls.Add(this.btnLayMK);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLayMK";
            this.Text = "FrmLayMK";
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.PictureBox pbLogIn;
        private System.Windows.Forms.Button btnLayMK;
        private System.Windows.Forms.TextBox txtUsername;
    }
}