namespace Baikiemtranhom1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthemnhom = new System.Windows.Forms.ToolStripButton();
            this.btnxoanhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnthemlienlac = new System.Windows.Forms.ToolStripButton();
            this.btnxoalienlac = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvnhom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvthongtinthanhvien = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.edttengoi = new System.Windows.Forms.Label();
            this.edtsodienthoai = new System.Windows.Forms.Label();
            this.edtemail = new System.Windows.Forms.Label();
            this.edtdiachi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsthanhvien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsnhom = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtinthanhvien)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsthanhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsnhom)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthemnhom,
            this.btnxoanhom,
            this.toolStripSeparator1,
            this.btnthemlienlac,
            this.btnxoalienlac,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthemnhom
            // 
            this.btnthemnhom.Image = global::Baikiemtranhom1.Properties.Resources.plus;
            this.btnthemnhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemnhom.Name = "btnthemnhom";
            this.btnthemnhom.Size = new System.Drawing.Size(92, 22);
            this.btnthemnhom.Text = "Thêm nhóm";
            this.btnthemnhom.Click += new System.EventHandler(this.btnthemnhom_Click);
            // 
            // btnxoanhom
            // 
            this.btnxoanhom.Image = global::Baikiemtranhom1.Properties.Resources.delete;
            this.btnxoanhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoanhom.Name = "btnxoanhom";
            this.btnxoanhom.Size = new System.Drawing.Size(82, 22);
            this.btnxoanhom.Text = "Xóa nhóm";
            this.btnxoanhom.Click += new System.EventHandler(this.btnxoanhom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnthemlienlac
            // 
            this.btnthemlienlac.Image = global::Baikiemtranhom1.Properties.Resources.plus;
            this.btnthemlienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemlienlac.Name = "btnthemlienlac";
            this.btnthemlienlac.Size = new System.Drawing.Size(97, 22);
            this.btnthemlienlac.Text = "Thêm liên lạc";
            this.btnthemlienlac.Click += new System.EventHandler(this.btnthemlienlac_Click);
            // 
            // btnxoalienlac
            // 
            this.btnxoalienlac.Image = global::Baikiemtranhom1.Properties.Resources.delete;
            this.btnxoalienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoalienlac.Name = "btnxoalienlac";
            this.btnxoalienlac.Size = new System.Drawing.Size(87, 22);
            this.btnxoalienlac.Text = "Xóa liên lạc";
            this.btnxoalienlac.Click += new System.EventHandler(this.btnxoalienlac_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Nhập từ cần tìm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvnhom);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 409);
            this.panel1.TabIndex = 1;
            // 
            // dgvnhom
            // 
            this.dgvnhom.AllowUserToAddRows = false;
            this.dgvnhom.AllowUserToDeleteRows = false;
            this.dgvnhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvnhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnhom.Location = new System.Drawing.Point(0, 0);
            this.dgvnhom.Name = "dgvnhom";
            this.dgvnhom.Size = new System.Drawing.Size(236, 409);
            this.dgvnhom.TabIndex = 0;
            this.dgvnhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhom_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "tennhom";
            this.Column1.HeaderText = "Tên nhóm";
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvthongtinthanhvien);
            this.panel2.Location = new System.Drawing.Point(242, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 235);
            this.panel2.TabIndex = 2;
            // 
            // dgvthongtinthanhvien
            // 
            this.dgvthongtinthanhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtinthanhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvthongtinthanhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvthongtinthanhvien.Location = new System.Drawing.Point(0, 0);
            this.dgvthongtinthanhvien.Name = "dgvthongtinthanhvien";
            this.dgvthongtinthanhvien.Size = new System.Drawing.Size(558, 235);
            this.dgvthongtinthanhvien.TabIndex = 0;
            this.dgvthongtinthanhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthongtinthanhvien_CellClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tengoi";
            this.Column2.HeaderText = "Tên gọi";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "phone";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.edttengoi);
            this.panel3.Controls.Add(this.edtsodienthoai);
            this.panel3.Controls.Add(this.edtemail);
            this.panel3.Controls.Add(this.edtdiachi);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(243, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 177);
            this.panel3.TabIndex = 3;
            // 
            // edttengoi
            // 
            this.edttengoi.AutoSize = true;
            this.edttengoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edttengoi.Location = new System.Drawing.Point(151, 0);
            this.edttengoi.Name = "edttengoi";
            this.edttengoi.Size = new System.Drawing.Size(0, 37);
            this.edttengoi.TabIndex = 7;
            // 
            // edtsodienthoai
            // 
            this.edtsodienthoai.AutoSize = true;
            this.edtsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtsodienthoai.Location = new System.Drawing.Point(143, 116);
            this.edtsodienthoai.Name = "edtsodienthoai";
            this.edtsodienthoai.Size = new System.Drawing.Size(0, 24);
            this.edtsodienthoai.TabIndex = 6;
            // 
            // edtemail
            // 
            this.edtemail.AutoSize = true;
            this.edtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtemail.Location = new System.Drawing.Point(79, 82);
            this.edtemail.Name = "edtemail";
            this.edtemail.Size = new System.Drawing.Size(0, 24);
            this.edtemail.TabIndex = 5;
            // 
            // edtdiachi
            // 
            this.edtdiachi.AutoSize = true;
            this.edtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtdiachi.Location = new System.Drawing.Point(89, 46);
            this.edtdiachi.Name = "edtdiachi";
            this.edtdiachi.Size = new System.Drawing.Size(0, 24);
            this.edtdiachi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "[Tên gọi]: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - Dương Viết Thuận";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhom)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtinthanhvien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsthanhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsnhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthemnhom;
        private System.Windows.Forms.ToolStripButton btnxoanhom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnthemlienlac;
        private System.Windows.Forms.ToolStripButton btnxoalienlac;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvnhom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvthongtinthanhvien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label edtsodienthoai;
        private System.Windows.Forms.Label edtemail;
        private System.Windows.Forms.Label edtdiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource bdsthanhvien;
        private System.Windows.Forms.BindingSource bdsnhom;
        private System.Windows.Forms.Label edttengoi;
    }
}

