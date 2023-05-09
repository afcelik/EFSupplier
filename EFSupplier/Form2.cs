using EFSupplier.context;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFSupplier
{
    partial class Form2 : Form
    {
        private SupplierContext db;

        public Form2()
        {
            InitializeComponent();
            //SupplierContext sınıfından yeni bir instance oluşturarak veritabanı işlemleri için bir bağlantı noktası oluşturduk.
            db = new SupplierContext();
        }

        // Arama butonuna basıldığında çalışacak metot.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int supplierId;
            //TextBox'tan alınan metni tedarikçi ID'si olarak okumakla birlikte, int.TryParse kullanarak bunu bir tamsayıya dönüştürmeye çalıştık.
            //Başarılı bir dönüşüm gerçekleşirse, tedarikçi ID'si supplierId değişkenine atanır ve kodun devamı çalıştırılır.
            //Başarısız bir dönüşüm durumunda else bloğu çalışır ve "Geçersiz tedarikçi ID'si" mesajı Label üzerinde görüntülenir.
            if (int.TryParse(textBox1.Text, out supplierId))
            {
                // LINQ sorgusu oluşturduk. Id bulunmadığında patlamaması için First yerine FirstOrDefault kullandık.
                var supplier = db.Suppliers.FirstOrDefault(s => s.Id == supplierId);
                // Tedarikçinin değeri olup olmadığını kontrol ediyoruz.
                if (supplier != null)
                {
                    lblSupplier.Text = $"CompanyName: {supplier.CompanyName}\n" +
                                       $"ContactName: {supplier.ContactName}\n" +
                                       $"ContactTitle: {supplier.ContactTitle}\n" +
                                       $"Address: {supplier.Address}";
                }
                else
                {
                    lblSupplier.Text = "Supplier not found.";
                }
            }
            else
            {
                lblSupplier.Text = "Invalid supplier Id.";
            }
        }
        // Delete butonuna basılınca çalışacak metot
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int supplierId;
            // btnSearch_Click metoduyla aynı mantıkla Id değerini okumaya çalıştık
            if (int.TryParse(textBox1.Text, out supplierId))
            {
                // LINQ sorgusu
                var supplier = db.Suppliers.FirstOrDefault(s => s.Id == supplierId);
                if (supplier != null)
                {
                    // Burada silme işlemini yaptık.
                    db.Suppliers.Remove(supplier);
                    db.SaveChanges();
                    lblSupplier.Text = "Supplier deleted successfully.";
                }
                else
                {
                    // Tedarikçinin bulunamadığı durum.
                    lblSupplier.Text = "Supplier not found.";
                }
            }
            else
            {
                // Geçersiz Id girişi durumu.
                lblSupplier.Text = "Invalid supplier Id.";
            }
        }
    }
}

