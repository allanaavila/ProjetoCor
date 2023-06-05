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
    public partial class Form4 : Form
    {


        private Usuario usuario = null;
       // List<Usuario> usuarioLista = new List<Usuario>();


        public Form4()
        {
            InitializeComponent();
        }

        internal Usuario Usuario { get => usuario; set => usuario = value; }


        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            foreach (Usuario item in Program.usuarioLista)
            {
                listaUsuario.Items.Add(item.MostraListaUsuario());
            }
            
            foreach (Usuario item in Program.usuarioLista)
            {
                listaJogos.Items.Add(item.MostraListaJogos());
            }

            foreach (Usuario item in Program.usuarioLista)
            {
                listaRedes.Items.Add(item.MostraListaRedes());
            }

        }
    }
}
