using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSVSpremanjeVjezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string lokacija = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "testNiOP");

            string saved_data = imeTextBox.Text + "," + prezimeTextBox.Text + "," + godRodTextBox.Text + "," + emailTextBox.Text + ",";

            if (!File.Exists(lokacija))
            {
                Directory.CreateDirectory(lokacija);
            }
            StreamWriter sw = new StreamWriter(lokacija + "/PrezimeImeSystemNiOP.csv");
            sw.Write(saved_data);
            sw.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string lokacija = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "testNiOP");

            if (!File.Exists(lokacija))
            {
                Directory.CreateDirectory(lokacija);
            }
            StreamReader sw = new StreamReader(lokacija + "/PrezimeImeSystemNiOP.csv");
            string saved_data = sw.ReadToEnd();
            string[] podaci = saved_data.Split(',');
            imeTextBox.Text = podaci[0];
            prezimeTextBox.Text = podaci[1];
            godRodTextBox.Text = podaci[2];
            emailTextBox.Text = podaci[3];
            sw.Close();
        }
    }
}
