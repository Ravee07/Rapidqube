using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = LstCity.GetItemText(LstCity.SelectedItem);
            MessageBox.Show(city);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string add = txtAdd.Text;

            MessageBox.Show(name + " " + add);

        }
    }
}
