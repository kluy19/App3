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
        

         Professor[] professor = new Professor[4]
         {
             new Professor("Maria", 1),
             new Professor("José", 2),
             new Professor("João", 3),
             new Professor("Ana", 4)
         };
        Disciplina[] disciplinas = new Disciplina[4]
         {
             new Disciplina("Cálculo 1", 1),
             new Disciplina("Introdução a Engenharia", 2),
             new Disciplina("Cálculo 2", 3),
             new Disciplina("Projetos de Engenharia", 4)
         };


        public MainPage()
        {
            InitializeComponent();
            // para todos as disciplinas do vetor
            

            foreach (Professor professor in professor)
                {
                // adicionar um elemento na caixa de seleção
                
                Picker1.Items.Add(professor.código + " - " + professor.nome);
                }
            foreach (Disciplina disciplina in disciplinas)
            {
                // adicionar um elemento na caixa de seleção
                Picker.Items.Add(disciplina.semestre + " - " + disciplina.nome);

            }
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
                Picker1.SelectedIndex >= 0 &&
                (disciplinas[Picker1.SelectedIndex].Lecionar(professor[Picker.SelectedIndex]))
            {

                Label1.IsVisible = true;
                Aluno aluno = new Aluno()
                {
                    matrícula = Entry1.Text
                };
                Nota nota = new Nota
                (aluno.matrícula,disciplinas[Picker1.SelectedIndex].nome,int.Parse(Entry1.Text));


                if (nota.Aprovar())
                {
                    Label01.IsVisible = true;
                }
                else
                {
                    Label02.IsVisible = true;
                }

            }else
                {
                    // habilitar mensagem de erro
                    Label2.IsVisible = true;
                }
            


        }

    }

    
}
