using AutoMapper;
using Dtos;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Models;

namespace MoviesAPI.Services
{
    public class MovieGenreService : ICRUDService<MovieGenreDto, MovieGenreDto, InsertMovieGenreDto, MovieGenreDto>
    {

        protected readonly MovieContext db;
        
        public MovieGenreService(MovieContext _db)
        {
            db = _db;
           

        }
        public List<MovieGenreDto> Get(MovieGenreDto search)
        {
            var list = db.MovieGenre.Include(x => x.Genre).Include(y=>y.Movie).Select(z=> new MovieGenreDto
            {
                  Genre= z.Genre.Name,
                  Title=z.Movie.Title,
                  MovieLength=z.Movie.MovieLength,
                  MovieGenreId=z.MovieGenreId,
                  MovieId=z.MovieId,
                  GenreId=z.GenreId,
                  Plot=z.Movie.Plot,
                  Rating=z.Movie.Rating


            }).ToList();



            return list;
        }

        public MovieGenreDto GetById(int id)
        {
           

            
            var  moviegenre = db.MovieGenre.Include(x => x.Genre).Include(y => y.Movie).Where(x=>x.MovieGenreId==id).Select(z => new MovieGenreDto
            {
                Genre = z.Genre.Name,
                Title = z.Movie.Title,
                MovieLength = z.Movie.MovieLength,
                MovieGenreId = z.MovieGenreId,
                MovieId = z.MovieId,
                GenreId = z.GenreId,
                Plot = z.Movie.Plot,
                Rating = z.Movie.Rating


            }).FirstOrDefault();
            return moviegenre;
        }

        public MovieGenreDto Insert(InsertMovieGenreDto request)
        {
            var entity = new MovieGenre { GenreId = request.GenreId,
                MovieId = request.MovieId,
               
            };
     


            //db.Set<TDatabase>().Add(k);

            db.Add(entity);
            db.SaveChanges();
            var moviegenre = db.MovieGenre.Include(x => x.Genre).Include(y => y.Movie).Where(x => x.MovieId== request.MovieId && x.GenreId==request.GenreId).Select(z => new MovieGenreDto
            {
                Genre = z.Genre.Name,
                Title = z.Movie.Title,
                MovieLength = z.Movie.MovieLength,
                MovieGenreId = z.MovieGenreId,
                MovieId = z.MovieId,
                GenreId = z.GenreId,
                Plot = z.Movie.Plot,
                Rating = z.Movie.Rating


            }).FirstOrDefault();
            return moviegenre;
        }

        public bool Remove(int id)
        {
            var entity = db.MovieGenre.Find(id);
            if (entity != null)
            {
                db.MovieGenre.Remove(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public MovieGenreDto Update(int id, MovieGenreDto request)
        {
            var entity = db.MovieGenre.Find(id);
            
            entity.MovieGenreId = request.MovieGenreId;
            entity.MovieId = request.MovieId;
            entity.GenreId = request.GenreId;


            db.SaveChanges();





            return request;
        }
    }
}
