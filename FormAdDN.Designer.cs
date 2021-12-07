
namespace Quản_lý_bài_tập_lớn
{
    partial class FormAdDN
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
            this.but_QL = new System.Windows.Forms.Button();
            this.but_DN = new System.Windows.Forms.Button();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_tk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_QL
            // 
            this.but_QL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_QL.Location = new System.Drawing.Point(441, 350);
            this.but_QL.Name = "but_QL";
            this.but_QL.Size = new System.Drawing.Size(164, 34);
            this.but_QL.TabIndex = 13;
            this.but_QL.Text = "Quay lại";
            this.but_QL.UseVisualStyleBackColor = true;
            this.but_QL.Click += new System.EventHandler(this.but_QL_Click);
            // 
            // but_DN
            // 
            this.but_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_DN.Location = new System.Drawing.Point(300, 350);
            this.but_DN.Name = "but_DN";
            this.but_DN.Size = new System.Drawing.Size(128, 34);
            this.but_DN.TabIndex = 12;
            this.but_DN.Text = "Đăng nhập";
            this.but_DN.UseVisualStyleBackColor = true;
            this.but_DN.Click += new System.EventHandler(this.but_DN_Click);
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(286, 231);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(341, 20);
            this.txt_mk.TabIndex = 11;
            this.txt_mk.UseSystemPasswordChar = true;
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(286, 156);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(341, 20);
            this.txt_tk.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu";
            // 
            // lb_tk
            // 
            this.lb_tk.AutoSize = true;
            this.lb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tk.Location = new System.Drawing.Point(173, 156);
            this.lb_tk.Name = "lb_tk";
            this.lb_tk.Size = new System.Drawing.Size(82, 20);
            this.lb_tk.TabIndex = 8;
            this.lb_tk.Text = "Tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng nhập quyền Admin";
            // 
            // FormAdDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_QL);
            this.Controls.Add(this.but_DN);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_tk);
            this.Controls.Add(this.label1);
            this.Name = "FormAdDN";
            this.Text = "FormAdDN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_QL;
        private System.Windows.Forms.Button but_DN;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_tk;
        private System.Windows.Forms.Label label1;
    }
}