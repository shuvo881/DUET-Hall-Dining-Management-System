
namespace DUET_Hall_Dining_Management_System
{
    partial class FormModifyMillDitals
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
            this.buttonShowMillDitals = new System.Windows.Forms.Button();
            this.buttonUpdateMill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowMillDitals
            // 
            this.buttonShowMillDitals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowMillDitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMillDitals.Location = new System.Drawing.Point(492, 349);
            this.buttonShowMillDitals.Name = "buttonShowMillDitals";
            this.buttonShowMillDitals.Size = new System.Drawing.Size(230, 63);
            this.buttonShowMillDitals.TabIndex = 0;
            this.buttonShowMillDitals.Text = "Show Mill Ditals";
            this.buttonShowMillDitals.UseVisualStyleBackColor = false;
            this.buttonShowMillDitals.Click += new System.EventHandler(this.buttonShowMillDitals_Click);
            // 
            // buttonUpdateMill
            // 
            this.buttonUpdateMill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateMill.Location = new System.Drawing.Point(492, 281);
            this.buttonUpdateMill.Name = "buttonUpdateMill";
            this.buttonUpdateMill.Size = new System.Drawing.Size(230, 62);
            this.buttonUpdateMill.TabIndex = 1;
            this.buttonUpdateMill.Text = "Update Mill";
            this.buttonUpdateMill.UseVisualStyleBackColor = false;
            this.buttonUpdateMill.Click += new System.EventHandler(this.buttonUpdateMill_Click);
            // 
            // FormModifyMillDitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DUET_Hall_Dining_Management_System.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateMill);
            this.Controls.Add(this.buttonShowMillDitals);
            this.Name = "FormModifyMillDitals";
            this.Text = "Modify Mill Ditals";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowMillDitals;
        private System.Windows.Forms.Button buttonUpdateMill;
    }
}