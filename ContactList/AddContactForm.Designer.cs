namespace ContactList
{
    partial class AddContactForm
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
            this.HoTen = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.HoVaTen = new System.Windows.Forms.Label();
            this.sodth = new System.Windows.Forms.Label();
            this.Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(211, 105);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(431, 22);
            this.HoTen.TabIndex = 0;
            this.HoTen.TextChanged += new System.EventHandler(this.HoTen_TextChanged);
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(211, 157);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(431, 22);
            this.SDT.TabIndex = 1;
            // 
            // HoVaTen
            // 
            this.HoVaTen.AutoSize = true;
            this.HoVaTen.Location = new System.Drawing.Point(98, 105);
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.Size = new System.Drawing.Size(64, 16);
            this.HoVaTen.TabIndex = 2;
            this.HoVaTen.Text = "Họ và tên";
            // 
            // sodth
            // 
            this.sodth.AutoSize = true;
            this.sodth.Location = new System.Drawing.Point(98, 163);
            this.sodth.Name = "sodth";
            this.sodth.Size = new System.Drawing.Size(85, 16);
            this.sodth.TabIndex = 3;
            this.sodth.Text = "Số điện thoại";
            this.sodth.Click += new System.EventHandler(this.label2_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(336, 236);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(75, 23);
            this.Luu.TabIndex = 4;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.sodth);
            this.Controls.Add(this.HoVaTen);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.HoTen);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Label HoVaTen;
        private System.Windows.Forms.Label sodth;
        private System.Windows.Forms.Button Luu;
    }
}