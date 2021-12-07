
namespace Quản_lý_bài_tập_lớn
{
    partial class FormTTK
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
            this.but_TTKAd = new System.Windows.Forms.Button();
            this.but_TTKGV = new System.Windows.Forms.Button();
            this.but_TTKSV = new System.Windows.Forms.Button();
            this.but_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo tài khoản";
            // 
            // but_TTKAd
            // 
            this.but_TTKAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_TTKAd.Location = new System.Drawing.Point(12, 80);
            this.but_TTKAd.Name = "but_TTKAd";
            this.but_TTKAd.Size = new System.Drawing.Size(212, 34);
            this.but_TTKAd.TabIndex = 20;
            this.but_TTKAd.Text = "Tạo tài khoản Admin";
            this.but_TTKAd.UseVisualStyleBackColor = true;
            this.but_TTKAd.Click += new System.EventHandler(this.but_TTKAd_Click);
            // 
            // but_TTKGV
            // 
            this.but_TTKGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_TTKGV.Location = new System.Drawing.Point(230, 80);
            this.but_TTKGV.Name = "but_TTKGV";
            this.but_TTKGV.Size = new System.Drawing.Size(250, 34);
            this.but_TTKGV.TabIndex = 21;
            this.but_TTKGV.Text = "Tạo tài khoản giảng viên";
            this.but_TTKGV.UseVisualStyleBackColor = true;
            this.but_TTKGV.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_TTKSV
            // 
            this.but_TTKSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_TTKSV.Location = new System.Drawing.Point(486, 80);
            this.but_TTKSV.Name = "but_TTKSV";
            this.but_TTKSV.Size = new System.Drawing.Size(235, 34);
            this.but_TTKSV.TabIndex = 22;
            this.but_TTKSV.Text = "Tạo tài khoản sinh viên";
            this.but_TTKSV.UseVisualStyleBackColor = true;
            this.but_TTKSV.Click += new System.EventHandler(this.but_TTKSV_Click);
            // 
            // but_out
            // 
            this.but_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_out.Location = new System.Drawing.Point(294, 166);
            this.but_out.Name = "but_out";
            this.but_out.Size = new System.Drawing.Size(122, 34);
            this.but_out.TabIndex = 23;
            this.but_out.Text = "Thoát";
            this.but_out.UseVisualStyleBackColor = true;
            this.but_out.Click += new System.EventHandler(this.but_out_Click);
            // 
            // FormTTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 240);
            this.Controls.Add(this.but_out);
            this.Controls.Add(this.but_TTKSV);
            this.Controls.Add(this.but_TTKGV);
            this.Controls.Add(this.but_TTKAd);
            this.Controls.Add(this.label1);
            this.Name = "FormTTK";
            this.Text = "FormTTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_TTKAd;
        private System.Windows.Forms.Button but_TTKGV;
        private System.Windows.Forms.Button but_TTKSV;
        private System.Windows.Forms.Button but_out;
    }
}