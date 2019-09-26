using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class About : Form
    {
        public About()
        {
            //Detta är en CONSTRUCTOR .ctor
            //Denna kod körs ALLTID när man "stansar ut" objektet, dvs NEW
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 MyForm = new Form1();
            MyForm.ShowDialog();
        }
    }
}
