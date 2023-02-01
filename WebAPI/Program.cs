using WebAPI.IService;
using WebAPI.Service;
using System.Data;
using Logic.ILogic;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;
using Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IItemLogic, ItemLogic>();
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IUserLogic, UserLogic>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IOrderLogic, OrderLogic>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAdminLogic, AdminLogic>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IBuyerLogic, BuyerLogic>();
builder.Services.AddScoped<IBuyerService, BuyerService>();
builder.Services.AddScoped<IUserRolLogic, UserRolLogic>();
builder.Services.AddScoped<IUserRolService, UserRolService>();

builder.Services.AddDbContext<ServiceContext>(
        options => options.UseSqlServer("name=ConnectionStrings:ServiceContext"));

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
