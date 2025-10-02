using System.Collections.ObjectModel;

namespace TarefasApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Tarefa> Tarefas => TarefaService.Tarefas;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void OnAdicionarClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NovaTarefaPage());
        }

        private async void OnTarefaTocada(object sender, EventArgs e)
        {
            if (sender is Frame frame && frame.BindingContext is Tarefa tarefa)
            {
                await Navigation.PushAsync(new DetalhesTarefaPage(tarefa));
            }
        }

        private async void OnCreditosClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Créditos", "Vinicius do Nascimento Ayres (CB3025675)\nMatheus Leandro Terra Luciano (CB3024881)", "Fechar");
        }
    }
}
