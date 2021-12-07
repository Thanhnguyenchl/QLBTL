
namespace Quản_lý_bài_tập_lớn
{
    partial class FormDN
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
            this.lb_tk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.but_DN = new System.Windows.Forms.Button();
            this.but_TTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÀI TẬP LỚN";
            // 
            // lb_tk
            // 
            this.lb_tk.AutoSize = true;
            this.lb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tk.Location = new System.Drawing.Point(146, 109);
            this.lb_tk.Name = "lb_tk";
            this.lb_tk.Size = new System.Drawing.Size(82, 20);
            this.lb_tk.TabIndex = 1;
            this.lb_tk.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(259, 109);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(341, 20);
            this.txt_tk.TabIndex = 3;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(259, 184);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(341, 20);
            this.txt_mk.TabIndex = 4;
            this.txt_mk.UseSystemPasswordChar = true;
            this.txt_mk.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // but_DN
            // 
            this.but_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_DN.Location = new System.Drawing.Point(273, 303);
            this.but_DN.Name = "but_DN";
            this.but_DN.Size = new System.Drawing.Size(128, 34);
            this.but_DN.TabIndex = 5;
            this.but_DN.Text = "Đăng nhập";
            this.but_DN.UseVisualStyleBackColor = true;
            this.but_DN.Click += new System.EventHandler(this.but_DN_Click);
            // 
            // but_TTK
            // 
            this.but_TTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_TTK.Location = new System.Drawing.Point(414, 303);
            this.but_TTK.Name = "but_TTK";
            this.but_TTK.Size = new System.Drawing.Size(164, 34);
            this.but_TTK.TabIndex = 6;
            this.but_TTK.Text = "Tạo tài khoản";
            this.but_TTK.UseVisualStyleBackColor = true;
            this.but_TTK.Click += new System.EventHandler(this.but_TTK_Click);
            // 
            // FormDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_TTK);
            this.Controls.Add(this.but_DN);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_tk);
            this.Controls.Add(this.label1);
            this.Name = "FormDN";
            this.Text = "Quản lý bài tập lớn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Button but_DN;
        private System.Windows.Forms.Button but_TTK;
    }
}

