
namespace Quản_lý_bài_tập_lớn
{
    partial class Formdoimk
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
            this.txt_mkc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mkm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_xmmkm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.but_Doi = new System.Windows.Forms.Button();
            this.but_QL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // txt_mkc
            // 
            this.txt_mkc.Location = new System.Drawing.Point(197, 84);
            this.txt_mkc.Name = "txt_mkc";
            this.txt_mkc.Size = new System.Drawing.Size(341, 20);
            this.txt_mkc.TabIndex = 6;
            this.txt_mkc.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // txt_mkm
            // 
            this.txt_mkm.Location = new System.Drawing.Point(197, 147);
            this.txt_mkm.Name = "txt_mkm";
            this.txt_mkm.Size = new System.Drawing.Size(341, 20);
            this.txt_mkm.TabIndex = 8;
            this.txt_mkm.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txt_xmmkm
            // 
            this.txt_xmmkm.Location = new System.Drawing.Point(198, 208);
            this.txt_xmmkm.Name = "txt_xmmkm";
            this.txt_xmmkm.Size = new System.Drawing.Size(341, 20);
            this.txt_xmmkm.TabIndex = 10;
            this.txt_xmmkm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Xác nhận mật khẩu mới:";
            // 
            // but_Doi
            // 
            this.but_Doi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Doi.Location = new System.Drawing.Point(167, 308);
            this.but_Doi.Name = "but_Doi";
            this.but_Doi.Size = new System.Drawing.Size(148, 34);
            this.but_Doi.TabIndex = 11;
            this.but_Doi.Text = "Đổi mật khẩu";
            this.but_Doi.UseVisualStyleBackColor = true;
            this.but_Doi.Click += new System.EventHandler(this.but_Doi_Click);
            // 
            // but_QL
            // 
            this.but_QL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_QL.Location = new System.Drawing.Point(331, 308);
            this.but_QL.Name = "but_QL";
            this.but_QL.Size = new System.Drawing.Size(128, 34);
            this.but_QL.TabIndex = 12;
            this.but_QL.Text = "Quay lại";
            this.but_QL.UseVisualStyleBackColor = true;
            this.but_QL.Click += new System.EventHandler(this.but_QL_Click);
            // 
            // Formdoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_QL);
            this.Controls.Add(this.but_Doi);
            this.Controls.Add(this.txt_xmmkm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mkm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mkc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Formdoimk";
            this.Text = "Formdoimk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mkc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mkm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_xmmkm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_Doi;
        private System.Windows.Forms.Button but_QL;
    }
}