using AlgorithmApp.Components;
using AlgorithmApp.Services;
using Microsoft.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped(sp => new HttpClient
{
	BaseAddress = new Uri(sp.GetRequiredService<NavigationManager>().BaseUri)
});
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

// تسجيل خدمة الأسئلة
builder.Services.AddScoped<QuizService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	app.UseHsts();
}

app.UseHttpsRedirection();

app.MapStaticAssets();

app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();
