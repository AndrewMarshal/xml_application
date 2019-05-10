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
    public partial class Algebra : Form
    {
        public Algebra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9" && textBox2.Text == "3" && textBox3.Text == "10" && textBox4.Text == "9" && textBox5.Text == "сумма")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Неверно где-то ответил на вопрос(-ы), проверь еще раз!");
        }
    }
}
