
namespace DUET_Hall_Dining_Management_System
{
    partial class FormResetPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxVarifyPassword = new System.Windows.Forms.TextBox();
            this.buttonSucces = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSucces);
            this.panel1.Controls.Add(this.textBoxVarifyPassword);
            this.panel1.Controls.Add(this.textBoxNewPassword);
            this.panel1.Location = new System.Drawing.Point(236, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 237);
            this.panel1.TabIndex = 0;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(54, 47);
            this.textBoxNewPassword.Multiline = true;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(172, 29);
            this.textBoxNewPassword.TabIndex = 0;
            this.textBoxNewPassword.Text = "New Password";
            this.textBoxNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVarifyPassword
            // 
            this.textBoxVarifyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVarifyPassword.Location = new System.Drawing.Point(54, 105);
            this.textBoxVarifyPassword.Multiline = true;
            this.textBoxVarifyPassword.Name = "textBoxVarifyPassword";
            this.textBoxVarifyPassword.Size = new System.Drawing.Size(172, 29);
            this.textBoxVarifyPassword.TabIndex = 1;
            this.textBoxVarifyPassword.Text = "Confrim Password";
            this.textBoxVarifyPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSucces
            // 
            this.buttonSucces.Location = new System.Drawing.Point(151, 173);
            this.buttonSucces.Name = "buttonSucces";
            this.buttonSucces.Size = new System.Drawing.Size(75, 23);
            this.buttonSucces.TabIndex = 2;
            this.buttonSucces.Text = "OK";
            this.buttonSucces.UseVisualStyleBackColor = true;
            this.buttonSucces.Click += new System.EventHandler(this.buttonSucces_Click);
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormResetPassword";
            this.Text = "FormResetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSucces;
        private System.Windows.Forms.TextBox textBoxVarifyPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
    }
}