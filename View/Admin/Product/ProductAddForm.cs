using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ProductAddForm : Form
    {
        string imageFileName, imageFilePath;
        public ProductAddForm()
        {
            InitializeComponent();
            populateComboCategory();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                picProduct.ImageLocation = openfile.FileName;
                imageFileName = openfile.SafeFileName;
                imageFilePath = openfile.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = txtName.Text.Trim(),
                Quantity = (int)txtQuantity.Value,
                Price = (int)txtPrice.Value,
                Category_ID = ((Category)comboCategory.SelectedItem).ID,
                Image = imageFileName
            };

            if (inputValidation())
            {
                int affectRow = new ProductDAO().addProduct(product);
                if (affectRow == 1)
                {
                    File.Copy(imageFilePath, getImgDirectoryPath(imageFileName));
                    MessageBox.Show("Add success");
                    clearValue();
                    ((PageProduct)Login.mainwindow.userControl).populateProduct();
                }
            }
        }

        private bool inputValidation()
        {
            int count = 0;
            foreach(Control control in panelAdd.Controls)
            {
                if(control is NumericUpDown)
                {
                    if(((NumericUpDown)control).Value == 0)
                    {
                        errorProvider.SetError(control, $"{control.Name} is 0");
                        count++;
                    }
                    else
                    {
                        errorProvider.SetError(control, string.Empty);
                    }
                }

                if(control is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)control).Text))
                    {
                        errorProvider.SetError(control, $"{control.Name} is empty");
                        count++;
                    }
                    else
                    {
                        errorProvider.SetError(control, string.Empty);
                    }
                }

                if(control is PictureBox)
                {
                    if (((PictureBox)control).Image == null)
                    {
                        errorProvider.SetError(control, $"{control.Name} is empty");
                        count++;
                    }
                    else
                    {
                        errorProvider.SetError(control, string.Empty);
                    }
                }
            }
            return (count == 0) ? true : false;
        }

        private string getImgDirectoryPath(string imgFile)
        {
            string ImageFolderPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\img\";
            if (!Directory.Exists(ImageFolderPath))
            {
                Directory.CreateDirectory(ImageFolderPath);
            }
            return ImageFolderPath + imgFile;
        }

        private void populateComboCategory()
        {
            List<Category> categorylist = new CategoryDAO().getCategories();
            comboCategory.DataSource = categorylist;
            comboCategory.DisplayMember = "Name";
        }

        private void clearValue()
        {
            txtName.Text = "";
            txtQuantity.Value = 0;
            txtPrice.Value = 0;
            picProduct.Image = null;
        }
    }
}
