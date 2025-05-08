using StudySprout.Components;
using Google.Cloud.Firestore;


string credentialPath = Path.Combine(Directory.GetCurrentDirectory(), "Credentials", "studysprout-67ec9-firebase-adminsdk-fbsvc-0c981653b7.json");
Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialPath);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<StudySprout.DatabaseData.StudyCalendarEdit>();

/*builder.Services.AddSingleton(_ =>
{
    return new FirestoreDbBuilder{
        ProjectId = "studysprout-67ec9"
    }.Build();
});*/

builder.Services.AddSingleton<FirestoreDb>(provider => 
{
    string projectId = "studysprout-67ec9"; 
    return FirestoreDb.Create(projectId); 
});


builder.Services.AddScoped<user1>();
builder.Services.AddScoped<set1>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
