namespace ThaiBaHung_0633_DACN
{
    partial class frm_DanhMuc
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
            this.txt_tendanhmuc = new System.Windows.Forms.TextBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_danhmuc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_madanhmuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tendanhmuc
            // 
            this.txt_tendanhmuc.BackColor = System.Drawing.Color.White;
            this.txt_tendanhmuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tendanhmuc.Location = new System.Drawing.Point(276, 138);
            this.txt_tendanhmuc.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tendanhmuc.Name = "txt_tendanhmuc";
            this.txt_tendanhmuc.Size = new System.Drawing.Size(503, 22);
            this.txt_tendanhmuc.TabIndex = 39;
            // 
            // btn_dong
            // 
            this.btn_dong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dong.Location = new System.Drawing.Point(665, 512);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(93, 41);
            this.btn_dong.TabIndex = 38;
            this.btn_dong.Text = "ĐÓNG";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Location = new System.Drawing.Point(488, 512);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(93, 41);
            this.btn_xoa.TabIndex = 37;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Location = new System.Drawing.Point(302, 512);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(93, 41);
            this.btn_sua.TabIndex = 36;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Location = new System.Drawing.Point(135, 512);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(93, 41);
            this.btn_them.TabIndex = 35;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_danhmuc
            // 
            this.dgv_danhmuc.BackgroundColor = System.Drawing.Color.White;
            this.dgv_danhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhmuc.Location = new System.Drawing.Point(118, 180);
            this.dgv_danhmuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_danhmuc.Name = "dgv_danhmuc";
            this.dgv_danhmuc.Size = new System.Drawing.Size(661, 299);
            this.dgv_danhmuc.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(268, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 43);
            this.label4.TabIndex = 33;
            this.label4.Text = "QUẢN LÝ DANH MỤC";
            // 
            // txt_madanhmuc
            // 
            this.txt_madanhmuc.BackColor = System.Drawing.Color.White;
            this.txt_madanhmuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_madanhmuc.Location = new System.Drawing.Point(276, 100);
            this.txt_madanhmuc.Margin = new System.Windows.Forms.Padding(5);
            this.txt_madanhmuc.Name = "txt_madanhmuc";
            this.txt_madanhmuc.Size = new System.Drawing.Size(503, 22);
            this.txt_madanhmuc.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(118, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên danh mục: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(118, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã danh mục:";
            // 
            // frm_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThaiBaHung_0633_DACN.Properties.Resources.istockphoto_1154731746_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 601);
            this.Controls.Add(this.txt_tendanhmuc);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_danhmuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_madanhmuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frm_DanhMuc";
            this.Text = "Danh Mục Món Ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhmuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tendanhmuc;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_danhmuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_madanhmuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}