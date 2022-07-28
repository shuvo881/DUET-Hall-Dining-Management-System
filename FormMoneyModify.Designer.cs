
namespace DUET_Hall_Dining_Management_System
{
    partial class FormMoneyModify
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
            this.buttonShowMoney = new System.Windows.Forms.Button();
            this.buttonUpdateMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowMoney
            // 
            this.buttonShowMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMoney.Location = new System.Drawing.Point(193, 129);
            this.buttonShowMoney.Name = "buttonShowMoney";
            this.buttonShowMoney.Size = new System.Drawing.Size(144, 84);
            this.buttonShowMoney.TabIndex = 0;
            this.buttonShowMoney.Text = "Show Money";
            this.buttonShowMoney.UseVisualStyleBackColor = true;
            this.buttonShowMoney.Click += new System.EventHandler(this.buttonShowMoney_Click);
            // 
            // buttonUpdateMoney
            // 
            this.buttonUpdateMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateMoney.Location = new System.Drawing.Point(403, 129);
            this.buttonUpdateMoney.Name = "buttonUpdateMoney";
            this.buttonUpdateMoney.Size = new System.Drawing.Size(144, 84);
            this.buttonUpdateMoney.TabIndex = 1;
            this.buttonUpdateMoney.Text = "Update Money";
            this.buttonUpdateMoney.UseVisualStyleBackColor = true;
            this.buttonUpdateMoney.Click += new System.EventHandler(this.buttonUpdateMoney_Click);
            // 
            // FormMoneyModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateMoney);
            this.Controls.Add(this.buttonShowMoney);
            this.Name = "FormMoneyModify";
            this.Text = "FormMoneyModify";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowMoney;
        private System.Windows.Forms.Button buttonUpdateMoney;
    }
}