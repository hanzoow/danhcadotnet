using Contact.Models;
using Contact.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class Form1 : Form
    {
        string pathDataNhom;
        string pathDataChitiet;
        public string tenNhom;
        private ChiTietDanhBa danhBa;
        private List<ChiTietDanhBa> chiTietDanhBa;
        private List<NhomDanhBa> nhomDanhBa;
        public Form1()
        {
            InitializeComponent();
        
            dvg1.AutoGenerateColumns = false;

            nhomDanhBa = NhomDanhBa.GetListFromDB();
            bds1.DataSource = nhomDanhBa;
            dvg1.DataSource = bds1;


        }
        public void Load()
        {
            dvg1.AutoGenerateColumns = false;

            nhomDanhBa = NhomDanhBa.GetListFromDB();
            bds1.DataSource = nhomDanhBa;
            dvg1.DataSource = bds1;
            var nhomdanhba1 = (NhomDanhBa)bds1.Current;
            chiTietDanhBa = ChiTietDanhBa.GetListFromDB(nhomdanhba1.TenNhom);
            dvg2.AutoGenerateColumns = false;
            bds2.DataSource = chiTietDanhBa;
            dvg2.DataSource = bds2;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            var f = new ThemNhom();
            f.ShowDialog();
            Load();

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhóm này?", "Thông báo!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                var nhom = (NhomDanhBa)bds1.Current;
                NhomDanhBa.Remove(nhom);
                MessageBox.Show("Đã xóa dữ liệu có tên là: " + nhom.TenNhom, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Load();
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
           
            var f = new ThemLienLac();
            f.ShowDialog();
            Load();
        }



        private void Dvg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nhomdanhba = (NhomDanhBa)bds1.Current;
            chiTietDanhBa = ChiTietDanhBa.GetListFromDB(nhomdanhba.TenNhom);
            dvg2.AutoGenerateColumns = false;
            bds2.DataSource = chiTietDanhBa;
            dvg2.DataSource = bds2;
        }

        private void Dvg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nhomdanhba = (NhomDanhBa)bds1.Current;
            chiTietDanhBa = ChiTietDanhBa.GetListFromDB(nhomdanhba.TenNhom);
            dvg2.AutoGenerateColumns = false;
            bds2.DataSource = chiTietDanhBa;
            dvg2.DataSource = bds2;
            var chitiet = (ChiTietDanhBa)bds2.Current;
            label6.Text = chitiet.TenGoi;
            label7.Text = chitiet.Diachi;
            label8.Text = chitiet.Email;
            label9.Text = chitiet.SDT;
        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string t = toolStripTextBox1.Text;
            List<ChiTietDanhBa> ct = new List<ChiTietDanhBa>();
            for (int i = 0; i < chiTietDanhBa.Count; i++)
            {
                if ((chiTietDanhBa[i].TenGoi.ToLower().Contains(t.ToLower()) == true) || (chiTietDanhBa[i].Email.ToLower().Contains(t.ToLower()) == true) ||
                        (chiTietDanhBa[i].SDT.Contains(t.ToLower()) == true))
                {
                    ct.Add(new ChiTietDanhBa
                    {
                        TenGoi = chiTietDanhBa[i].TenGoi,
                        TenNhom = chiTietDanhBa[i].TenNhom,
                        Diachi = chiTietDanhBa[i].Diachi,
                        Email = chiTietDanhBa[i].Email,
                        SDT = chiTietDanhBa[i].SDT
                    });
                }
            }
            dvg2.DataSource = ct;
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa liên lạc này ?", "Thông báo!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                var nhomll = (ChiTietDanhBa)bds2.Current;


                ChiTietDanhBa.Remove(nhomll);
                Load();



                MessageBox.Show("Đã xóa dữ liệu có tên là: " + nhomll.TenGoi, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        { 
           
            var nhomEdit = (ChiTietDanhBa)bds2.Current;
            var detail = bds2.Current as ChiTietDanhBa;
            if(detail != null)
            {
                var f = new EditForm(detail);
                var rs = f.ShowDialog();
                if(rs == DialogResult.OK)
                {
                   // var nhomdanhba2 = (NhomDanhBa)bds1.Current;
                    bds2.DataSource = ChiTietDanhBa.GetListFromDB(detail.TenNhom);
                    dvg2.DataSource = bds2;
                }
            }
        
            Load();
            
        }

        private void btnAddNhom_Click(object sender, EventArgs e)
        {
            var f = new ThemNhom();
            f.ShowDialog();
            Load();
        }

        private void btnDeleteNhom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhóm này?", "Thông báo!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                var nhom = (NhomDanhBa)bds1.Current;
                NhomDanhBa.Remove(nhom);
                MessageBox.Show("Đã xóa dữ liệu có tên là: " + nhom.TenNhom, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Load();
            }
        }

        private void btnAddLienLac_Click(object sender, EventArgs e)
        {
            var f = new ThemLienLac();
            f.ShowDialog();
            Load();
        }

        private void btnDeleteLienLac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa liên lạc này ?", "Thông báo!", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                var nhomll = (ChiTietDanhBa)bds2.Current;


                ChiTietDanhBa.Remove(nhomll);
                Load();



                MessageBox.Show("Đã xóa dữ liệu có tên là: " + nhomll.TenGoi, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nhomEdit = (ChiTietDanhBa)bds2.Current;
            var detail = bds2.Current as ChiTietDanhBa;
            if (detail != null)
            {
                var f = new EditForm(detail);
                var rs = f.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    // var nhomdanhba2 = (NhomDanhBa)bds1.Current;
                    bds2.DataSource = ChiTietDanhBa.GetListFromDB(detail.TenNhom);
                    dvg2.DataSource = bds2;
                }
            }

            Load();
        }
    }
}
