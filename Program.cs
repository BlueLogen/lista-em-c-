var builder = WebApplication.CreateBuilder(args);

// Registrar o serviço TarefasService
builder.Services.AddSingleton<TarefasService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Permite acessar arquivos estáticos como CSS e JS
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();