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
    public partial class Form3 : Form
    {

        private Usuario usuario = null;
        internal Usuario Usuario { get => usuario; set => usuario = value; }


        private Form4 proximoForm = null;
        internal Form4 ProximoForm { get => proximoForm; set => proximoForm = value; }


        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuario.ListaRedes1 == null)
                usuario.ListaRedes1 = new List<string>();

            if (radioRedes1.Checked == true)
                usuario.ListaRedes1.Add(radioRedes1.Text);

            if (radioRedes2.Checked == true)
            {
                usuario.ListaRedes1.Add(radioRedes2.Text);
                usuario.NomeCanal = respostaYouTube.Text;
            }

            if (radioRedes3.Checked == true)
                usuario.ListaRedes1.Add(radioRedes3.Text);

         
            //usuario.NomeCanal = respostaYouTube.Text;
            Program.usuarioLista.Add(usuario);

            Form4 f4 = new Form4
            {
                Usuario = usuario
            };
            f4.ShowDialog();
        }
    }
}
