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
    public partial class Form2 : Form
    {
        List<Model.Pacients> pacients;
        Model.Pacients pacient;
        Model.PacientsDAO pdao;
        public Form2()
        {
            InitializeComponent();
            pdao = new Model.PacientsDAO();
            pacients = pdao.ReadText();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (validPacient())
            {
                addpaccient();
                resetValues();
                pdao.WriteFile(pacients);
                MessageBox.Show("Les dades s'han guardad amb exit");
            }
            else
            {
                MessageBox.Show("Dades no valides");
            }
        }

        private void resetValues()
        {
            textBoxNom.Text = "";
            textBoxCognom.Text = "";
            textBoxNacion.Text = "";
            richTextBoxHist.Text = "";
        }

        private void addpaccient()
        {
            String sex;
            if (radioButtonM.Checked) sex = "M";
            else sex = "H";
            pacient = new Model.Pacients(textBoxNom.Text, textBoxCognom.Text, sex, textBoxNacion.Text, richTextBoxHist.Text);
            pacients.Add(pacient);
        }

        private bool validPacient()
        {
            bool result = false;
            if(!textBoxNom.Text.Equals("") && !textBoxCognom.Text.Equals("") && !textBoxNacion.Text.Equals(""))
            {
                if(radioButtonM.Checked || radioButtonH.Checked)
                {
                    result = true;
                }
            }
            return result;
        }

        private void ToolStripButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonVD_Click(object sender, EventArgs e)
        {
            if (canPas())
            {
                Form4 f4 = new Form4();
                this.Hide();
                f4.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede pasar al siguinete si hay empezado un paciente\n(borra los datos o termina al paciente)");
            }
        }

        private bool canPas()
        {
            bool result = false;
            if (textBoxNom.Text.Equals("") && textBoxCognom.Text.Equals("") && textBoxNacion.Text.Equals("") && richTextBoxHist.Text.Equals(""))
            {
                result = true;
            }
                return result;
        }
    }
}
