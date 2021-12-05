using AutoMapper;
using Dtos;
using MoviesAPI.Models;


namespace MoviesAPI.Mappers
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            CreateMap<Actor, ActorDto>().ReverseMap();
            CreateMap<Director, DirectorDto>().ReverseMap();
            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<MovieActor, MovieActor>().ReverseMap();
            CreateMap<MovieDto, MovieDto>().ReverseMap();
            CreateMap<MovieGenre, MovieGenre>().ReverseMap();

        }
    }
}
