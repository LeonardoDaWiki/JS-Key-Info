using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProdKeyFind
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            form.Focus();
            this.Visible = false;
        }
    }
}
