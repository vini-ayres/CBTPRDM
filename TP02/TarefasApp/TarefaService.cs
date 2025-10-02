using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasApp
{
    public static class TarefaService
    {
        public static ObservableCollection<Tarefa> Tarefas { get; } = new();
        public static void Adicionar(Tarefa tarefa) => Tarefas.Add(tarefa);
        public static void Remover(Tarefa tarefa) => Tarefas.Remove(tarefa);
    }
}
