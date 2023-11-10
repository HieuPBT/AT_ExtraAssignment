namespace Recursion
{
    partial class Recursion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.btCal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(267, 118);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 26);
            this.txtn.TabIndex = 1;
            // 
            // btCal
            // 
            this.btCal.Location = new System.Drawing.Point(209, 196);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(85, 35);
            this.btCal.TabIndex = 2;
            this.btCal.Text = "Tính X";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X^n = ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập X";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(267, 86);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 26);
            this.txtx.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết Quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(267, 150);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 26);
            this.txtKQ.TabIndex = 1;
            // 
            // Recursion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 256);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Recursion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

