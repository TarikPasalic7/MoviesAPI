using AutoMapper;
using Dtos;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Mappers;
using MoviesAPI.Models;
using MoviesAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperConf());
});
IMapper autoMapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(autoMapper);

builder.Services.AddDbContext<MovieContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Movie"));
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICRUDService<ActorDto, ActorDto, ActorDto, ActorDto>, BaseCRUDService<ActorDto, ActorDto, Actor, ActorDto, ActorDto>>();
builder.Services.AddScoped<ICRUDService<GenreDto,GenreDto,GenreDto,GenreDto>,BaseCRUDService<GenreDto,GenreDto,Genre,GenreDto,GenreDto>>();
builder.Services.AddScoped<ICRUDService<DirectorDto, DirectorDto, DirectorDto, DirectorDto>, BaseCRUDService<DirectorDto, DirectorDto, Director, DirectorDto, DirectorDto>>();
builder.Services.AddScoped<ICRUDService<MovieDto, MovieDto, MovieDto, MovieDto>, BaseCRUDService<MovieDto, MovieDto, Movie, MovieDto, MovieDto>>();
builder.Services.AddScoped<ICRUDService<MovieActorDto, MovieActorDto, MovieActorDto, MovieActorDto>, BaseCRUDService<MovieActorDto, MovieActorDto, MovieActor, MovieActorDto, MovieActorDto>>();
builder.Services.AddScoped<ICRUDService<MovieGenreDto, MovieGenreDto, MovieGenreDto, MovieGenreDto>, BaseCRUDService<MovieGenreDto, MovieGenreDto, MovieGenre, MovieGenreDto, MovieGenreDto>>();

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
