using DelegatesAndEvents.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddTransient<ProductService>();
builder.Services.AddTransient<EmailService>(); 


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var productService = app.Services.GetRequiredService<ProductService>();
var emailService = app.Services.GetService<EmailService>();

//Subscrever o Evento. 
productService.ProductAdded += emailService.OnProductAdded; 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
