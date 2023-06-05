using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
     
        private void buttonContinuuar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = boxNome.Text;
            usuario.Email = boxEmail.Text;
            usuario.Idade = int.Parse(boxIdade.Text);
            usuario.Escola = boxEscola.Text;
            usuario.Serie = boxSerie.Text;


            Form2 f2 = new Form2();
            f2.Usuario = usuario;
            f2.ProximoForm = new Form3();
            f2.ShowDialog();

        }
    }
}
