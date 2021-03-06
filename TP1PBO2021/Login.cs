using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.Equals(Convert.ToString(Pass.Text), "pbo123") && Convert.ToString(Username.Text) != "")
            {
                MenuUtama Menut = new MenuUtama();
                Menut.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username Yang anda masukkan tidak tepat atau username salah!");
            }

        }
    }
}
