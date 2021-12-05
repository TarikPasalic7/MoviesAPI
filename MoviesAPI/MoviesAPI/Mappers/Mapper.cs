using AutoMapper;
using Dtos;
using MoviesAPI.Models;


namespace MoviesAPI.Mappers
{
    public class MapperConf : Profile
    {

        public MapperConf()
        {
            CreateMap<Actor, ActorDto>().ReverseMap();
            CreateMap<Director, DirectorDto>().ReverseMap();
            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<MovieActor, MovieActorDto>().ReverseMap();
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<MovieGenre, MovieGenreDto>().ReverseMap();

        }
    }
}
