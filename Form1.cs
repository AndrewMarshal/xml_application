using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Adaptive_educational_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Link_Textbooks linkTextbooks = new Link_Textbooks();
            linkTextbooks.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Program form = new About_Program();
            form.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reference form = new Reference();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Suggestion_for_improvements)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var add = new Suggestion_for_improvement() { Suggestion = new Suggestion_for_improvements() };
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(add.Suggestion);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button2.Enabled = listBox1.SelectedItem is Suggestion_for_improvements;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Suggestion_for_improvements)listBox1.Items[index];
                var add = new Suggestion_for_improvement() { Suggestion = item };
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    listBox1.Items.Remove(item);
                    listBox1.Items.Insert(index, item);
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            PDD pdd = new PDD();
            pdd.Show();
            if (progressBar1.Value < 100)
                progressBar1.Value += 1;
            else
            {
                MessageBox.Show("Ваш уровень максимален! Вы - сверхразум!");
                PDD pdd1 = new PDD();
                pdd1.Close();
            }
            if (progressBar5.Value < 100)
                progressBar5.Value += 1;
            else
            {
                MessageBox.Show("Ваш уровень максимален! Вы - сверхразум!");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
            //progressBar1.Value = 0;
            //if (PDD.button2.DialogResult == DialogResult.OK)
            //{
            //    progressBar1.Value += progressBar1.Value + 1;
            //}
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Algebra algebra = new Algebra();
            algebra.Show();
            if (progressBar2.Value < 100)
                progressBar2.Value += 1;
            else
            {
                MessageBox.Show("Ваш уровень максимален! Вы - сверхразум!");
                Algebra algebra1 = new Algebra();
                algebra1.Close();
            }
            if (progressBar5.Value < 100)
                progressBar5.Value += 1;
            else
            {
                MessageBox.Show("Ваш уровень максимален! Вы - сверхразум!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://fomuvi.ru/category/zadachki/geometricheskie-zadachi");
            if (progressBar3.Value < 100)
                progressBar3.Value += 1;
            else
            {
                MessageBox.Show("Ваш уровень максимален! Вы - сверхразум!");
            }
            if (progressBar5.Value < 100)
                progressBar5.Value += 1;
            else
            {
                MessageBox.Show("Ваш уровень максимален! Вы - сверхразум!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/%D0%9C%D1%83%D0%B7%D1%8B%D0%BA%D0%B0%D0%BB%D1%8C%D0%BD%D1%8B%D0%B5_%D0%B8%D0%BD%D1%81%D1%82%D1%80%D1%83%D0%BC%D0%B5%D0%BD%D1%82%D1%8B");
            if (progressBar4.Value < 100)
                progressBar4.Value += 1;
            else
            {
                MessageBox.Show("Ваш уровень максимален! Вы - сверхразум!");
            }
            if (progressBar5.Value < 100)
                progressBar5.Value += 1;
            else
            {
                MessageBox.Show("Ваш уровень максимален! Вы - сверхразум!");
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Learnis|*.learnis" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(Adaptive_educational_application));
            var file = File.OpenRead(ofd.FileName);
            var educational_application = (Adaptive_educational_application)xs.Deserialize(file);
            file.Close();

            textBox1.Text = educational_application.UserName;
            progressBar1.Value = educational_application.Traffic_Laws_Level;
            progressBar2.Value = educational_application.Algebra_Level;
            progressBar3.Value = educational_application.Geometry_Level;
            progressBar4.Value = educational_application.Music_Level;
            progressBar5.Value = educational_application.Curent_Level_User;

            var ms = new MemoryStream(educational_application.User_Picture);
            pictureBox1.Image = Image.FromStream(ms);

            listBox1.Items.Clear();
            foreach (var offers in educational_application.Journal)
            {
                listBox1.Items.Add(offers);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Learnis|*.learnis" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var educational_application = new Adaptive_educational_application()
            {
                Traffic_Laws_Level = progressBar1.Value,
                Algebra_Level = progressBar2.Value,
                Geometry_Level = progressBar3.Value,
                Music_Level = progressBar4.Value,
                Curent_Level_User = progressBar5.Value,
                UserName = textBox1.Text,
                Journal = listBox1.Items.OfType<Suggestion_for_improvements>().ToList()
            };

            var stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            educational_application.User_Picture = stream.ToArray();

            var xs = new XmlSerializer(typeof(Adaptive_educational_application));


            var file = File.Create(sfd.FileName);

            xs.Serialize(file, educational_application);
            file.Close();
        }
    }
}
