using System.Collections.Generic;

public class TarefasService
{
    private static List<Tarefa> tarefas = new();
    private static int proximoId = 1;

    public List<Tarefa> ObterTarefas() => tarefas;

    public void AdicionarTarefa(string titulo, string descricao)
    {
        tarefas.Add(new Tarefa
        {
            Id = proximoId++,
            Titulo = titulo,
            Descricao = descricao
        });
    }

    public void RemoverTarefa(int id)
    {
        var tarefa = tarefas.Find(t => t.Id == id);
        if (tarefa != null)
        {
            tarefas.Remove(tarefa);
        }
    }
}