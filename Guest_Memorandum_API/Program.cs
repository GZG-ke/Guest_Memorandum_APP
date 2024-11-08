using Guest_Memorandum_API.Context;
using Guest_Memorandum_API.Context.Extensions;
using Guest_Memorandum_API.Context.Repositorys;
using Guest_Memorandum_API.Extensions;
using Guest_Memorandum_API.Interface;
using Guest_Memorandum_API.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MemorandumDbContext>(option =>
{
    var connectionString = builder.Configuration.GetConnectionString("Default");
    option.UseSqlServer(connectionString);
}).AddUnitOfWork<MemorandumDbContext>();
builder.Services.AddTransient<IDbContextProvider, DbContextProvider>();
builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
builder.Services.AddTransient<IToDoService, ToDoService>();
builder.Services.AddTransient<IMemoService, MemoService>();
builder.Services.AddTransient<ILoginService, LoginService>();

builder.Services.AddAutoMapper((configuration) =>
{
    AutoMapperProFile.CreateMappings(configuration);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();