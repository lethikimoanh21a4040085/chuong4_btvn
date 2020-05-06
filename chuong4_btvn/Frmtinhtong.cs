using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong4_btvn
{
    public partial class Frmtinhtong : Form
    {
        public Frmtinhtong()
        {
            InitializeComponent();
        }

        private void bnttinhtong_Click(object sender, EventArgs e)
        {
            
            
            if (txta.Text == "")
            {
                MessageBox.Show("hay nhap so nguyen a");
                txta.Focus();
                return;
            }
            if (txtb.Text == "")
            {
                MessageBox.Show("hay nhap so nguyen b");
                txtb.Focus();
                return;
            }
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int tong = a + b;

            String result = String.Format("a la: {0}; b la: {1}\nTong 2 so nguyen a va b la: {2}", txta.Text, txtb.Text, tong);
            
            label3.Text = result;
            MessageBox.Show(result);
        }
        

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ban muon thoat");
            this.Close();
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ban co muon thuc hien lai");
            this.txta.Clear();
            this.txtb.Clear();
            txtb.Focus();
            txta.Focus();
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9'))  || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
 (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }
    }
}
