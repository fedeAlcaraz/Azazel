using Azazel_api.Data;
using Azazel_api.Repository.User;
using Azazel_api.Repository.Message;
using Azazel_api.Repository.Conversation;
using Azazel_api.Services.UsuarioService;
using Azazel_api.Services.MessageService;
using Azazel_api.Services.ConversationService;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AzazelDbContext>(options =>{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IUserRepository, UsuarioRepositoryEF>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IMensajeRepository, MensajeRepositoryEF>();
builder.Services.AddScoped<IMessageService, MensajeService>();
builder.Services.AddScoped<IConversacionRepository, ConversacionRepositoryEF>();
builder.Services.AddScoped<IConversationService, ConversacionService>();
builder.Services.AddControllers();
builder.Services.AddOpenApi();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{app.MapOpenApi();}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
