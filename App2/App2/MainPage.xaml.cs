using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ListaFuncionarios.ItemsSource = GetFuncionarios();
        }

        private List<Grupo> GetFuncionarios()
        {
            return new List<Grupo> {
                new Grupo("Presidente","CEO")
                {
                     new Pessoa { Nome = "Lucas"},

                },
                new Grupo("Diretores","DIR")
                {
                       new Pessoa { Nome = "João"},
                  new Pessoa { Nome = "Feliepe"},
                  new Pessoa { Nome = "Pedro"},
                },
                      new Grupo("Gerentes","Ger")
                {

                  new Pessoa { Nome = "Fatima"},
                  new Pessoa { Nome = "Katia"},
                  new Pessoa { Nome = "Vanessa"},
                  new Pessoa { Nome = "Juliana"}
                }


            };
        }

        public class Grupo : List<Pessoa>
        {
            public string Titulo { get; set; }

            public string TituloCurto { get; set; }
            public Grupo(string Titulo, string TituloCurto)
            {
                this.Titulo = Titulo;
                this.TituloCurto = TituloCurto;

            }


        }
        public class Pessoa
        {
            public string Nome { get; set; }


        }
    }
}
