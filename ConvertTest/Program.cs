var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddCors(options =>
  {
    options.AddPolicy("AllowClientOrigin",
      builder =>
      {
        builder.WithOrigins("http://localhost:5174")
          .AllowAnyHeader()
          .AllowAnyMethod();
      });
  });

  builder.Services.AddControllers();
  builder.Services.AddScoped<IConvertService, ConvertService>();
}

var app = builder.Build();
{
  app.UseExceptionHandler("/error");
  app.UseCors("AllowClientOrigin");

  app.UseDefaultFiles();
  app.UseStaticFiles();

  app.UseHttpsRedirection();
  app.MapControllers();

  app.Run();
}