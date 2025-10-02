namespace TarefasApp;

public partial class NovaTarefaPage : ContentPage
{
    public NovaTarefaPage()
    {
        InitializeComponent();
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tituloEntry.Text))
        {
            await DisplayAlert("Campo obrigatório", "Por favor, informe o título da tarefa.", "OK");
            return;
        }

        if (prioridadePicker.SelectedItem == null)
        {
            await DisplayAlert("Campo obrigatório", "Por favor, selecione a prioridade da tarefa.", "OK");
            return;
        }

        var novaTarefa = new Tarefa
        {
            Titulo = tituloEntry.Text,
            Descricao = descricaoEditor.Text,
            DataCriacao = dataPicker.Date,
            Prioridade = prioridadePicker.SelectedItem?.ToString()
        };

        TarefaService.Adicionar(novaTarefa);
        await Navigation.PopModalAsync();
    }
}