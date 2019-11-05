using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Baikiemtranhom1.bean;

namespace Baikiemtranhom1
{
    public partial class Form1 : Form
    {
        string datanhom,datathanhvien;
        private List<nhom> dsnhom;
        private List<thanhvien> dsthanhvien;


        private void dgvnhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = (nhom)bdsnhom.Current;
            dsthanhvien = thanhvien.getfromfile(datathanhvien, temp.tennhom);
            dgvthongtinthanhvien.AutoGenerateColumns = false;
            bdsthanhvien.DataSource = dsthanhvien;
            dgvthongtinthanhvien.DataSource = bdsthanhvien;
        }

        private void dgvthongtinthanhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = (thanhvien)bdsthanhvien.Current;
            edttengoi.Text = temp.tengoi;
            edtemail.Text = temp.email;
            edtsodienthoai.Text = temp.phone;
            edtdiachi.Text = temp.diachi;
        }

        private void btnxoanhom_Click(object sender, EventArgs e)
        {
            var nhom = (nhom)bdsnhom.Current;
            bdsnhom.Remove(nhom);
            bdsthanhvien.Clear();
        }

        private void btnxoalienlac_Click(object sender, EventArgs e)
        {
            var ll = (thanhvien)bdsthanhvien.Current;
            bdsthanhvien.Remove(ll);
            
        }

        private void btnthemnhom_Click(object sender, EventArgs e)
        {
            
        }

        private void btnthemlienlac_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();            
            datanhom = Application.StartupPath + @"\DATA\dsnhom.data";
            datathanhvien = Application.StartupPath + @"\DATA\dsthanhvien.txt";
            ///////////////////////////////////////
            dgvnhom.AutoGenerateColumns = false;            
            dsnhom = nhom.getdatafromfile(datanhom);
            bdsnhom.DataSource = dsnhom;
            dgvnhom.DataSource = bdsnhom;
            ////////////////////////////////////////
            //dgvthongtinthanhvien.AutoGenerateColumns = false;
            //dsthanhvien = thanhvien.getfromfile(datathanhvien, "Học tập");
            //dgvthongtinthanhvien.DataSource = dsthanhvien;

        }
    }
}
