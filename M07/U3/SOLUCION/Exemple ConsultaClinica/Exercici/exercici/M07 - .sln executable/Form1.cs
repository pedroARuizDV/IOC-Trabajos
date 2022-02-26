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
    public partial class Form1 : Form
    {
        List<Model.User> users;
        Model.FileLogDAO fldao;

        public Form1()
        {
            InitializeComponent();
            users = new List<Model.User>();
            fldao = new Model.FileLogDAO();
            users = fldao.ReadText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            if (validuser())
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
                this.Show();

            }
            else
            {
                labelResult.Text = "User i/o Password incorrectes";
            }
        }

        public bool validuser()
        {
            bool result = false;
            for(int i=0; i< users.Count; i++)
            {
                if (textBoxUser.Text.Equals(users[i].Nom))
                {
                    if (textBoxPassword.Text.Equals(users[i].Password))
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
