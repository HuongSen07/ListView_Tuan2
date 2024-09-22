using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Tuan2
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtFistName.Text);
            lvi.SubItems.Add(txtLastName.Text);
            lvi.SubItems.Add(txtPhone.Text);
            listViewSV.Items.Add(lvi);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewSV.SelectedItems.Count > 0)
            {
                listViewSV.Items.Remove(listViewSV.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chon thanh phan de xoa!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewSV.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listViewSV.SelectedItems[0];
                lvi.SubItems[0].Text = txtFistName.Text;
                lvi.SubItems[1].Text = txtLastName.Text;
                lvi.SubItems[2].Text = txtPhone.Text;
            }
            else
            {
                MessageBox.Show("Chon thanh phan de chinh sua!");
            }
        }
    }
}
