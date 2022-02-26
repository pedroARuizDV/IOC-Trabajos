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
    public partial class Form4 : Form
    {
        Model.PacientsDAO pdao;
        List<Model.Pacients> pacients;
        List<Button> buttons = new List<Button>();
        public Form4()
        {
            InitializeComponent();
            pdao = new Model.PacientsDAO();
            pacients = pdao.ReadText();
            initButtons();
        }

        private void initButtons()
        {
            for (int i = 0; i < pacients.Count; i++)
            {
                buttons.Add(new Button());
                buttons[i].Width = 200;
                buttons[i].Name = (i.ToString());
                buttons[i].Text = pacients[i].Nom + " " + pacients[i].Cognoms;
                buttons[i].Height = 40;
                buttons[i].Top = (i + 1) * 50;
                buttons[i].Left = 50;
                buttons[i].Click += new System.EventHandler(this.Buttons_Click);
                this.Controls.Add(buttons[i]);
            }
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int i = int.Parse(b.Name);
            MessageBox.Show(pacients[i].Historial);
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRP_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
    }
}
