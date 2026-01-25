using AlgorithmApp.Components;
using AlgorithmApp.Services;

var builder = WebApplication.CreateBuilder(args);

// إضافة خدمات Blazor مع التمكين التفاعلي للسيرفر
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

// ميزة .NET 9 للتعامل الذكي مع ملفات CSS و JS
app.MapStaticAssets();

app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();