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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form3 proximoForm = null;
        internal Form3 ProximoForm { get => proximoForm; set => proximoForm = value; }


        private Usuario usuario = null;
        //List<Usuario> usuarioLista = new List<Usuario>();

        internal Usuario Usuario { get => usuario; set => usuario = value; }


        private void button1_Click(object sender, EventArgs e)
        {

            if (radioJogo1.Checked == true)
                usuario.ListaJogos1.Add(radioJogo1.Text);

            if (radioJogo2.Checked == true)
                usuario.ListaJogos1.Add(radioJogo2.Text);

            if (radioJogo3.Checked == true)
                usuario.ListaJogos1.Add(radioJogo3.Text);

            if (radioJogo4.Checked == true)
                usuario.ListaJogos1.Add(radioJogo4.Text);

            if (radioJogo5.Checked == true)
                usuario.ListaJogos1.Add(radioJogo5.Text);

            if (radioJogo6.Checked == true)
                usuario.ListaJogos1.Add(radioJogo6.Text);

            Form3 f3 = new Form3();
            f3.Usuario = Usuario;
            f3.ProximoForm = new Form4();
            f3.ShowDialog();
        }
    }
}
