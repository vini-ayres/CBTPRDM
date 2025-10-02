using System.ComponentModel;

public class Tarefa : INotifyPropertyChanged
{
    private string titulo;
    private string descricao;
    private DateTime dataCriacao;
    private string prioridade;

    public string Titulo
    {
        get => titulo;
        set
        {
            if (titulo != value)
            {
                titulo = value;
                OnPropertyChanged(nameof(Titulo));
            }
        }
    }

    public string Descricao
    {
        get => descricao;
        set
        {
            if (descricao != value)
            {
                descricao = value;
                OnPropertyChanged(nameof(Descricao));
            }
        }
    }

    public DateTime DataCriacao
    {
        get => dataCriacao;
        set
        {
            if (dataCriacao != value)
            {
                dataCriacao = value;
                OnPropertyChanged(nameof(DataCriacao));
            }
        }
    }

    public string Prioridade
    {
        get => prioridade;
        set
        {
            if (prioridade != value)
            {
                prioridade = value;
                OnPropertyChanged(nameof(Prioridade));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string nome) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nome));
}