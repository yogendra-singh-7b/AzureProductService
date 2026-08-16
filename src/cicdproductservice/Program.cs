using Microsoft.EntityFrameworkCore;
using cicdproductservice.Operation;
using cicdproductservice.Service;
using cicdproductservice.Data;
using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddAzureKeyVault(
    new Uri("https://yogikeyvault.vault.azure.net/"),
    new DefaultAzureCredential());

builder.Services.AddDbContext<PaymentDBContext>(options =>
    options.UseSqlServer(builder.Configuration["azproductdb-conn"]));
builder.Services.AddControllers();
builder.Services.AddScoped<IPaymentOperation, PaymentOperation>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  
}

app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();