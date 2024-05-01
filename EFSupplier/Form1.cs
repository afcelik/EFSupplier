using System.Xml.Linq;
using EFSupplier.context;
using EFSupplier.model;
using Microsoft.EntityFrameworkCore;

namespace EFSupplier
{
    public partial class Form1 : Form
    {
        SupplierContext db = new();

        public Form1()
        {

            InitializeComponent();
            List<Supplier> data = db.Suppliers.ToList();
            dataGridView1.DataSource = data;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
  
                // Formdaki textboxlardan ald���m�z verileri de�i�kenlere atad�k.
                string companyName = txtCompanyName.Text;
                string contactName = txtContactName.Text;
                string contactTitle = txtContactTitle.Text;
                string address = txtAddress.Text;

                // Supplier nesnesinden instance al�p, verileri veritaban�na g�nderdik.
                Supplier supplier = new();
                supplier.CompanyName = companyName;
                supplier.ContactName = contactName;
                supplier.ContactTitle = contactTitle;
                supplier.Address = address;

                db.Suppliers.Add(supplier);
                db.SaveChanges();

                MessageBox.Show("Supplier added successfully");

                // dataGridView' da tedarik�ileri g�rebilmek i�in liste olu�turduk. ��nk� dataGridView liste alarak g�sterebiliyor.
                List<Supplier> suppliers = db.Suppliers.ToList();

                dataGridView1.DataSource = suppliers;
            
        }

    }
}