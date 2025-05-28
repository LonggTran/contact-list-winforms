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
            this.HoVaTen = new System.Windows.Forms.Label();
            this.Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(217, 105);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(431, 22);
            this.HoTen.TabIndex = 0;
            this.HoTen.TextChanged += new System.EventHandler(this.HoTen_TextChanged);
            // 
            // HoVaTen
            // 
            this.HoVaTen.AutoSize = true;
            this.HoVaTen.Location = new System.Drawing.Point(98, 105);
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.Size = new System.Drawing.Size(113, 16);
            this.HoVaTen.TabIndex = 2;
            this.HoVaTen.Text = "Thông tin bổ sung";
            this.HoVaTen.Click += new System.EventHandler(this.HoVaTen_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(342, 200);
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
            this.Controls.Add(this.HoVaTen);
            this.Controls.Add(this.HoTen);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.Label HoVaTen;
        private System.Windows.Forms.Button Luu;
    }
}