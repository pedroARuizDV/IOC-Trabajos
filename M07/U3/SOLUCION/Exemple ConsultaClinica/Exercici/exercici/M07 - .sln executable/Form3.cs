using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M07Examen2
{
    public partial class Form3 : Form
    {
        List<Model.Pacients> pacients;
        Model.Pacients pacient;
        Model.PacientsDAO pdao;
        string sex = "Tots";
        public Form3()
        {
            InitializeComponent();
            pdao = new Model.PacientsDAO();
            pacients = pdao.ReadText();
            setPacients();
        }

        private void setPacients()
        {
            ListViewItem lvi;
            listViewPa.Items.Clear();
            string[] arr = new string[5];
            for (int i=0; i < pacients.Count; i++)
            {
                arr[0] = pacients[i].Nom;
                arr[1] = pacients[i].Cognoms;
                arr[2] = pacients[i].Sexe;
                arr[3] = pacients[i].Nacionalidad;
                arr[4] = pacients[i].Historial;
                lvi = new ListViewItem(arr);
                listViewPa.Items.Add(lvi);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxSexe_SelectedIndexChanged(object sender, EventArgs e)
        {
            sex = comboBoxSexe.GetItemText(comboBoxSexe.SelectedItem);
            setPacientsF();

        }

        private void setPacientsF()
        {
            ListViewItem lvi;
            listViewPa.Items.Clear();
            string[] arr = new string[5];
            for (int i = 0; i < pacients.Count; i++)
            {
                if ((pacients[i].Sexe.Equals(sex)) || (sex.Equals("Tots")))
                {
                    arr[0] = pacients[i].Nom;
                    arr[1] = pacients[i].Cognoms;
                    arr[2] = pacients[i].Sexe;
                    arr[3] = pacients[i].Nacionalidad;
                    arr[4] = pacients[i].Historial;
                    lvi = new ListViewItem(arr);
                    listViewPa.Items.Add(lvi);
                }
            }
        }
    }
}
