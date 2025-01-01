using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly TarefasService _tarefasService;

    public IndexModel(TarefasService tarefasService)
    {
        _tarefasService = tarefasService;
    }

    [BindProperty]
    public string Titulo { get; set; }

    [BindProperty]
    public string Descricao { get; set; }

    [BindProperty]
    public int? ExcluirId { get; set; }

    public void OnPost()
    {
        if (ExcluirId.HasValue)
        {
            _tarefasService.RemoverTarefa(ExcluirId.Value);
        }
        else if (!string.IsNullOrEmpty(Titulo) && !string.IsNullOrEmpty(Descricao))
        {
            _tarefasService.AdicionarTarefa(Titulo, Descricao);
        }
    }
}
