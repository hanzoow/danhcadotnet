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
    public partial class EditForm : Form
    {
        private List<NhomDanhBa> nhomdanhba;
        ChiTietDanhBa danhba;
        Form1 form = new Form1();
        public EditForm(ChiTietDanhBa danhba)
        {
            InitializeComponent();
            this.danhba = danhba;
            nhomdanhba = NhomDanhBa.GetListFromDB();
            foreach (NhomDanhBa s in nhomdanhba)
            {
                cbTenNhom.Items.Add(s.TenNhom);
            }
            tbEmail.Text = danhba.Email;
            tvTenGoi.Text = danhba.TenGoi;
            tbPhonenumber.Text = danhba.SDT;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Edited = new ChiTietDanhBa
            {
                TenGoi = tvTenGoi.Text,
                SDT = tbPhonenumber.Text,
                Email = tbEmail.Text,
                TenNhom = cbTenNhom.Text
            };
            ChiTietDanhBa.Edit(Edited);
            DialogResult = DialogResult.OK;
        }
    }
}
