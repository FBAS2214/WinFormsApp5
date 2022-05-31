using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }


        public FormEdit(Product product)
            : this()
        {
            txt_name.Text = product.Name;
            txt_price.Text = product.Price.ToString();
            txt_discount.Text = product.Discount.ToString();
        }



        public void ShowDialog(Product product)
        {
            txt_name.Text = product.Name;
            txt_price.Text = product.Price.ToString();
            txt_discount.Text = product.Discount.ToString();

            ShowDialog();
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool check = byte.TryParse(txt_discount.Text, out byte result);


            if (check && result <= 100)
            {
                DialogResult = DialogResult.Yes;
            }

            else
                lbl_error_discount.Text = "*Error";


        }
    }
}
