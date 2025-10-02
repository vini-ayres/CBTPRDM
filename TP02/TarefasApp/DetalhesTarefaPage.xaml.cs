namespace TarefasApp;

public partial class DetalhesTarefaPage : ContentPage
{
    Tarefa tarefa;

    public DetalhesTarefaPage(Tarefa tarefa)
    {
        InitializeComponent();
        this.tarefa = tarefa;
        BindingContext = tarefa;
    }

    private async void OnEditarClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new EditarTarefaPage(tarefa));
    }

    private async void OnExcluirClicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlert("Confirmar", "Deseja excluir esta tarefa?", "Sim", "Não");
        if (confirmar)
        {
            TarefaService.Remover(tarefa);
            await Navigation.PopAsync();
        }
    }
}