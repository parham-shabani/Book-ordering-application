using InfraStucture.Persistance.Dapper;
using Application.Query.BookQueries.GetBook;
using Application.Service.IServices.IReadServices;
using Application.Service.Services.ReadServices;
using System.Reflection;
using Domain.Repositories.CustomerRepositories;
using InfraStucture.Repositories.ReadRepository;
using Domain.Repositories.BookRepositories;
using Domain.Repositories.OrderItemRepositories;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Repositories.WriteRepository;
using Application.Service.IServices.IWriteServices;
using Application.Service.Services.WriteServices;
using Application;
using InfraStucture.Persistance.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(Assembly.GetAssembly(typeof(GetBookQueryHandler)));
            });
            var connectionString = builder.Configuration.GetConnectionString("MyDatabaseConnection");
            builder.Services.AddDbContext<EFContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddScoped<DapperContext>();
            builder.Services.AddScoped<IDapperUnitOfWork, DapperUnitOfWork>();

            builder.Services.AddScoped<IBookReadService, BookReadService>();
            builder.Services.AddScoped<ICustomerReadService, CustomerReadService>();
            builder.Services.AddScoped<IOrderReadService, OrderReadService>();
            builder.Services.AddScoped<IOrderItemReadService, OrderItemReadService>();
            

            builder.Services.AddScoped<IBookWriteService, BookWriteService>();
            builder.Services.AddScoped<ICustomerWriteService, CustomerWriteService>();
            builder.Services.AddScoped<IOrderWriteService, OrderWriteService>();
            builder.Services.AddScoped<IOrderItemWriteService, OrderItemWriteService>();

            builder.Services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            builder.Services.AddScoped<IBookReadRepository, BookReadRepository>();
            builder.Services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            builder.Services.AddScoped<IOrderItemReadRepository, OrderItemReadRepository>();

            builder.Services.AddScoped<IBookWriteRepository, BookWriteRepository>();
            builder.Services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            builder.Services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            builder.Services.AddScoped<IOrderItemWriteRepository, OrderItemWriteRepository>();



            builder.Services.AddScoped<IEFUnitOfWork, EFUnitOfWork>();
            builder.Services.AddScoped<EFContext>();

            

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}