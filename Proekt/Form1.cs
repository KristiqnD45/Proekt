using Proekt.Controllers;
using Proekt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt
{
    

    public partial class Form1 : Form
    {
      SouvenirContext context = new SouvenirContext();
        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Въведете име на продукта!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Невалидна цена!");
                return;
            }

            var souvenir = new Souvenir
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = price,
                SouvenirTypeId = (int)cmbType.SelectedValue
            };

            context.Souvenirs.Add(souvenir);
            context.SaveChanges();

            MessageBox.Show("Добавен успешно!");
        }

    }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text); 

            var souvenir = new Souvenir
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = decimal.Parse(txtPrice.Text),
                SouvenirTypeId = (int)cmbType.SelectedValue
            };

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

    }
}
 
  
