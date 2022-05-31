namespace WinFormsApp5
{
    public partial class FormMain : Form
    {
        public Product? Product { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            Product = new Product
            {
                Id = 1,
                Name = "Fanta",
                Price = 1.5M,
                Discount = 10
            };


            FillProductProperties();
        }



        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (Product == null) return;


            // this.Close();
            this.Hide();




            // Way 1 (with Constructor)
            FormEdit formEdit = new FormEdit(Product);
            formEdit.ShowDialog();




            //// Way 2  (with public field or property)
            // FormEdit formEdit = new FormEdit();
            // 
            // formEdit.txt_name.Text = txt_name.Text;
            // formEdit.txt_price.Text = txt_price.Text;
            // formEdit.txt_discount.Text = txt_discount.Text;
            // formEdit.ShowDialog();






            //// Way 3  (with "ShowDialog" method overloading)
            // FormEdit formEdit = new FormEdit();
            // formEdit.ShowDialog(Product);







            /////////////////////////////////////////////////////
            //// Common
            

            this.Show();

            if (formEdit.DialogResult == DialogResult.Yes)
            {
                Product.Name = formEdit.txt_name.Text;
                Product.Price = Convert.ToDecimal(formEdit.txt_price.Text);
                Product.Discount = Convert.ToByte(formEdit.txt_discount.Text);


                FillProductProperties();
            }


            // formEdit.Show();
        }



        private void FillProductProperties()
        {
            txt_id.Text = Product?.Id.ToString();
            txt_name.Text = Product?.Name;
            txt_price.Text = Product?.Price.ToString();
            txt_discount.Text = Product?.Discount.ToString();
        }
    }
}