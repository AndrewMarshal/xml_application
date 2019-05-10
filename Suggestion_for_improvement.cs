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
    public partial class Suggestion_for_improvement : Form
    {
        public Suggestion_for_improvement()
        {
            InitializeComponent();
        }

        public Suggestion_for_improvements Suggestion { get; set; }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Suggestion.Subject_Area;
            textBox2.Text = Suggestion.Wishes;
            textBox3.Text = Suggestion.Proposed_link;
            textBox4.Text = Suggestion.Add_to_application;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suggestion.Subject_Area = textBox1.Text;
            Suggestion.Wishes = textBox2.Text;
            Suggestion.Proposed_link = textBox3.Text;
            Suggestion.Add_to_application = textBox4.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
