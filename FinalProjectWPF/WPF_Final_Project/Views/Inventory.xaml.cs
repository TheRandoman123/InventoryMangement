using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using static WPF_Final_Project.Server;
using System.Drawing;
// ReSharper disable All

namespace WPF_Final_Project.Views
{
    /// <summary>
    /// Interaction logic for Inventory.xaml
    /// </summary>
    public partial class Inventory : System.Windows.Controls.UserControl
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            char[] items = UPCSKUTextBox.Text.ToCharArray();
            int count = items.Count();

            if (e.Key == Key.Enter)
            {

                if (count == 7)
                {
                    Product product = (Product)SKULookup(items);
                    numberOnHandTextBlock.Text = product.QuantityOnHand.ToString();
                    numberInHastingsTextBlock.Text = product.QuantityInHastings.ToString();
                    numberInKalamazoo.Text = product.QuantityInKalamazoo.ToString();
                    price.Text = product.Price.ToString();
                    Location.Text = product.Location.ToString();

                    byte[] binaryData = Convert.FromBase64String(product.Photo);
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.StreamSource = new MemoryStream(binaryData);
                    bi.EndInit();
                    Picture.Source = bi;

                }

                else if (count == 11 || count == 12)
                {
                    Product product = (Product)UPCLookup(items);
                    numberOnHandTextBlock.Text = product.QuantityOnHand.ToString();
                    numberInHastingsTextBlock.Text = product.QuantityInHastings.ToString();
                    numberInKalamazoo.Text = product.QuantityInKalamazoo.ToString();
                    price.Text = product.Price.ToString();
                    Location.Text = product.Location.ToString();

                    byte[] binaryData = Convert.FromBase64String(product.Photo);
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.StreamSource = new MemoryStream(binaryData);
                    bi.EndInit();
                    Picture.Source = bi;

                }

                else
                {
                    MessageBox.Show($"A upc needs 11 or 12 chars and a sku needs 7 you have {count.ToString()}");
                }
            }

            count = 0;
            Array.Clear(items, 0, items.Length);
        }

        public static object SKULookup(char[] SKU)
        {
            int full_SKU = 0;
            string skuToBeConverted = "";

            foreach (char character in SKU)
            {
                skuToBeConverted += character;
            }

            full_SKU = Convert.ToInt32(skuToBeConverted);

            Product product = (Product)GetSKUInfo(full_SKU);
            return product;

        }

        public static object UPCLookup(char[] UPC)
        {
            long full_UPC = 0;
            string upcToBeConverted = "";

            foreach (char character in UPC)
            {
                upcToBeConverted += character;
            }

            full_UPC = Convert.ToInt64(upcToBeConverted);

            Product product = (Product)GetUPCInfo(full_UPC);
            return product;
        }
 
    }
}
