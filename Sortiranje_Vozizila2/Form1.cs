using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje_Vozizila2
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
       

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            var vozilo = new Vozilo
            {
                Marka = textBox1.Text,
                Model= textBox2.Text,
                GodinaProizvodnje = int.Parse(textBox3.Text),
                Kilometraza = int.Parse(textBox4.Text)


            };
            vozila.Add(vozilo);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kriteriji = comboBox1.SelectedItem.ToString();
            

            switch (kriteriji)
            {
                case "Marka":
                 kriteriji = vozila.OrderBy(x => x.Marka).ToList();
                    break;

                case "Model":
                   kriteriji = vozila.OrderBy(x => x.Model).ToList();
                    break;
                case "GodinaProizvodnje":
                    kriteriji = vozila.OrderBy(x => x.GodinaProizvodnje).ToList();
                    break;
                case "Kilometraza":
                    kriteriji = vozila.OrderBy(x => x.Kilometraza).ToList();
                    break;
                   
            }

            textBoxSort.Clear();
            foreach (var vozilo in kriteriji) ;

            textBoxSort.AppendText($"{vozilo.Marka} - {vozilo.Model} - {vozilo.GodinaProizvodnje} - {vozilo.Kilometraza}{Environment.NewLine}");

        }
    }
}
        
    