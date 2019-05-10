using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adaptive_educational_application
{
    public partial class Link_Textbooks : Form
    {
        public Link_Textbooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Ссылка на ПДД
        {
            System.Diagnostics.Process.Start("http://www.pdd24.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Ссылка на аглгебру
        {
            System.Diagnostics.Process.Start("https://www.yaklass.ru/p/algebra");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Ссылка на геометрию
        {
            System.Diagnostics.Process.Start("https://www.yaklass.ru/p/geometria");
        }
    }
}
