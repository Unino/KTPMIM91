
namespace Calculator
{
    partial class TinhToan
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(98, 74);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(247, 26);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(98, 114);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(247, 26);
            this.txtB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(98, 189);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(247, 26);
            this.txtKetQua.TabIndex = 0;
            // 
            // TinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TinhToan";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}
