using Afiliados.Application.Interfaces;
using Afiliados.Application.Mapper;
using Afiliados.Application.Services;
using Afiliados.Domain.Repositories;
using Afiliados.Infra.Data.Context;
using Afiliados.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
		sqlServerOptions => sqlServerOptions.EnableRetryOnFailure(2, TimeSpan.FromSeconds(5), null).MigrationsHistoryTable("_version_migration"));
});
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IProducerService, ProducerService>();
builder.Services.AddScoped<IAffiliatedService, AffiliatedService>();
builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddAutoMapper(typeof(ProducerEntityToViewModelAndReverseProfile),
							   typeof(AffiliatedEntityToViewModelAndReverseProfile),
							   typeof(SaleEntityToDtoAndRevserProfile));

builder.Services.AddCors(options =>
{
	options.AddPolicy("CorsPolicy", policy =>
	{
		policy.WithOrigins("http://localhost:3000")
			.AllowAnyHeader()
			.AllowAnyMethod();
	});
});

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

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
