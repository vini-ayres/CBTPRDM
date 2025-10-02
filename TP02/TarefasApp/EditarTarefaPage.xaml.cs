namespace TarefasApp;

public partial class EditarTarefaPage : ContentPage
{
    private Tarefa tarefa;

    public EditarTarefaPage(Tarefa tarefa)
    {
        InitializeComponent();
        this.tarefa = tarefa;

        // Preenche os campos com os dados atuais
        tituloEntry.Text = tarefa.Titulo;
        descricaoEditor.Text = tarefa.Descricao;
        dataPicker.Date = tarefa.DataCriacao;
        prioridadePicker.SelectedItem = tarefa.Prioridade;
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
        // Validação básica
        if (string.IsNullOrWhiteSpace(tituloEntry.Text))
        {
            await DisplayAlert("Campo obrigatório", "O título não pode estar vazio.", "OK");
            return;
        }

        if (prioridadePicker.SelectedItem == null)
        {
            await DisplayAlert("Campo obrigatório", "Selecione uma prioridade.", "OK");
            return;
        }

        // Atualiza os dados da tarefa
        tarefa.Titulo = tituloEntry.Text.Trim();
        tarefa.Descricao = descricaoEditor.Text?.Trim();
        tarefa.DataCriacao = dataPicker.Date;
        tarefa.Prioridade = prioridadePicker.SelectedItem.ToString();

        await Navigation.PopModalAsync();
    }
}