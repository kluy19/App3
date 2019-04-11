using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3.Modelos;


namespace App3
{
    public partial class MainPage : ContentPage
    {
        // vetor de disciplinas
        /* Disciplina[] disciplinas = new Disciplina[4]
         {
             new Disciplina("Cálculo 1", 1),
             new Disciplina("Introdução a Engenharia", 2),
             new Disciplina("Cálculo 2", 3),
             new Disciplina("Projetos de Engenharia", 4)
         };

         Professor[] professor = new Professor[4]
         {
             new Professor("Maria", 1),
             new Professor("José", 2),
             new Professor("João", 3),
             new Professor("Ana", 4)
         };*/


        public MainPage()
        {
            InitializeComponent();

        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            // desabilitar mensagens
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            Label01.IsVisible = false;
            Label02.IsVisible = false;

            if (Entry1.Text != null &&
                Entry2.Text != null &&
                Entry1.Text.Length > 0 &&
                Entry2.Text.Length > 0 &&
                Picker.SelectedIndex >= 0 &&
                Picker1.SelectedIndex >= 0)
            {
                // criar variáveis 
                int matrícula = int.Parse(Entry1.Text);
                int nota = int.Parse(Entry2.Text);
                int professor = Picker.SelectedIndex + 1;
                int disciplina = Picker1.SelectedIndex + 1;
                // verificar se os valores são iguais
                if (professor == disciplina)
                {
                    Label1.IsVisible = true;

                    if (nota >= 6)
                    {
                        Label01.IsVisible = true;
                    }
                    else
                    {
                        Label02.IsVisible = true;
                    }
                }
                else
                {
                    // habilitar mensagem de erro
                    Label2.IsVisible = true;
                }
            }


        }

    }

    
}
