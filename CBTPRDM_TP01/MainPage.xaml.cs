namespace CBTPRDM_TP01;

// Vinicius do Nascimento Ayres(CB3025675)
// Matheus Leandro Terra Luciano(CB3024881)

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnOkClicked(object sender, EventArgs e)
    {
        string mensagem;

        if (ID.Text == "admin" && Pass.Text == "senha@dmin")
            mensagem = $"Você logou com sucesso!";
        else
            mensagem = $"Login não autorizado. Tente novamente.";

        await DisplayAlert("Resultado do Login", mensagem, "OK");
    }

    private void OnCleanClicked(object sender, EventArgs e)
    {
        ID.Text = "";
        Pass.Text = "";
    }

    private void OnCreditsClicked(object sender, EventArgs e)
    {
        CreditsLabel.Text = $"Vinicius do Nascimento Ayres (CB3025675)\nMatheus Leandro Terra Luciano (CB3024881)";
    }
}