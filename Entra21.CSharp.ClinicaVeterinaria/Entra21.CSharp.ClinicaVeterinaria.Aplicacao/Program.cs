using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Repositorios;
using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Entra21.CSharp.ClinicaVeterinaria.Servico.MapeamentoEntidades;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Aqui vamos registrar todas as injeções de dependências
builder.Services.AddScoped<IRacaRepositorio, RacaRepositorio>();
builder.Services.AddScoped<IRacaServico, RacaServico>();
builder.Services.AddScoped<IVeterinarioServico, VeterinarioServico>();
builder.Services.AddScoped<IVeterinarioMapeamentoEntidade, VeterinarioMapeamentoEntidade>();

builder.Services.AddDbContext<ClinicaVeterinariaContexto>(options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

using(var scopo = app.Services.CreateScope())
{
var contexto = scopo.ServiceProvider.GetService<ClinicaVeterinariaContexto>();
contexto.Database.EnsureCreated();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoint =>
{
    endpoint.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
