using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Adaptive_educational_application.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace Adaptive_educational_application
{
    public partial class PDD : Form
    {
        public PDD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dictionary<string, string, string, string, string> Answer = new Dictionary<string, string, string, string, string>();
            //Answer.Add("1", "2", "1", "3", "2")
            if (textBox1.Text == "1" && textBox2.Text == "2" && textBox3.Text == "1" && textBox4.Text == "3" && textBox5.Text == "2")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Неверно где-то ответил на вопрос(-ы), проверь еще раз!");
        }
    }
}