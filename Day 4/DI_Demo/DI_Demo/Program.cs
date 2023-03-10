var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//per call
builder.Services.AddTransient(typeof(DI_Demo.Model.Employee));

//builder.Services.AddTransient(typeof(DI_Demo.Model.Login));

//builder.Services.AddScoped(typeof(DI_Demo.Model.Products));

////per session
//builder.Services.AddScoped(typeof(DI_Demo.Model.Employee));

////singleton
//builder.Services.AddSingleton(typeof(DI_Demo.Model.Employee));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//this section is used for middleware configuration 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
