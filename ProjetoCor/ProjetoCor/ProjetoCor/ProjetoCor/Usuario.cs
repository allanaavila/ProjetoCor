using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCor
{
    internal class Usuario
    {
        private string nome;
        private string email;
        private int idade;
        private string escola;
        private string serie;
        private string nomeCanal;
        private List<string> ListaJogos;
        private List<string> ListaRedes;

        public string Nome { get => nome; set => nome = value; }
        public string NomeCanal { get => nomeCanal; set => nomeCanal = value; }
        public string Email { get => email; set => email = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Escola { get => escola; set => escola = value; }
        public string Serie { get => serie; set => serie = value; }
        public List<string> ListaJogos1 { get => ListaJogos; set => ListaJogos = value; }
        public List<string> ListaRedes1 { get => ListaRedes; set => ListaRedes = value; }

        public string MostraListaUsuario()
        {
            string dados = "Nome: " + Nome + " - " + "E-mail: " + Email + " - " +
                             "Idade: " + Idade + " - " + "Escola: " + Escola + " - " + 
                             "Série: " + Serie;        
            return dados;
        }


        public string MostraListaJogos()
        {
            string aux = "";

            foreach (string item in ListaJogos)
            {
                aux += " - " + item;
            }
            return aux;
        }

        public string MostraListaRedes()
        {
            string aux = "";
            foreach (string item in ListaRedes)
            {
                aux += " - " + item + "\n";
            }

            if (ListaRedes.Contains("YouTube"))
            {
                aux += " Nome Canal: " + NomeCanal + "\n";
            }
            return aux;
        }

        public Usuario()
        {
            ListaJogos = new List<string>();
            ListaRedes = new List<string>();   
        }
    }
}
