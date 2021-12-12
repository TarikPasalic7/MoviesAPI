using AutoMapper;
using Dtos;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Models;

namespace MoviesAPI.Services
{
    public class MovieActorService : ICRUDService<MovieActorDto, MovieActorDto, InsertMovieActorDto, MovieActorDto>
    {
        protected readonly MovieContext db;
     
        public MovieActorService(MovieContext _db)
        {
            db = _db;
           
            
        }
        public List<MovieActorDto> Get(MovieActorDto search)
        {
            var list = db.MovieActor.Include(x =>x.Actor).Include(y => y.Movie).Select(z => new MovieActorDto
            {
               MovieActorId=z.MovieActorId,
               MovieId=z.MovieId,
               MovieLength=z.Movie.MovieLength,
               ActorId=z.ActorId,
               Birth=z.Actor.Birth,
               DirectorID=z.Movie.DirectorID,
               FirstName=z.Actor.FirstName,
               LastName=z.Actor.LastName,
               Nationallity=z.Actor.Nationallity,
               Plot=z.Movie.Plot,
               Rating=z.Movie.Rating,
               Title=z.Movie.Title
               


            }).ToList();



            return list;
        }

        public MovieActorDto GetById(int id)
        {
            var moviegenre = db.MovieActor.Include(x => x.Actor).Include(y => y.Movie).Where(x=>x.MovieActorId==id).Select(z => new MovieActorDto
            {
                MovieActorId = z.MovieActorId,
                MovieId = z.MovieId,
                MovieLength = z.Movie.MovieLength,
                ActorId = z.ActorId,
                Birth = z.Actor.Birth,
                DirectorID = z.Movie.DirectorID,
                FirstName = z.Actor.FirstName,
                LastName = z.Actor.LastName,
                Nationallity = z.Actor.Nationallity,
                Plot = z.Movie.Plot,
                Rating = z.Movie.Rating,
                Title = z.Movie.Title



            }).FirstOrDefault();
            return moviegenre;
        }

        public MovieActorDto Insert(InsertMovieActorDto request)
        {
            var entity = new MovieActor
            {
                
               ActorId= request.ActorId,
                MovieId = request.MovieId

            };



            //db.Set<TDatabase>().Add(k);

            db.Add(entity);
            db.SaveChanges();
            var moviegenre = db.MovieActor.Include(x => x.Actor).Include(y => y.Movie).Where(x => x.MovieId==request.MovieId && x.ActorId==request.ActorId).Select(z => new MovieActorDto
            {
                MovieActorId = z.MovieActorId,
                MovieId = z.MovieId,
                MovieLength = z.Movie.MovieLength,
                ActorId = z.ActorId,
                Birth = z.Actor.Birth,
                DirectorID = z.Movie.DirectorID,
                FirstName = z.Actor.FirstName,
                LastName = z.Actor.LastName,
                Nationallity = z.Actor.Nationallity,
                Plot = z.Movie.Plot,
                Rating = z.Movie.Rating,
                Title = z.Movie.Title



            }).FirstOrDefault();
            return moviegenre;
        }

        public bool Remove(int id)
        {
            var entity = db.MovieActor.Find(id);
            if (entity != null)
            {
                db.MovieActor.Remove(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public MovieActorDto Update(int id, MovieActorDto request)
        {
            var entity = db.MovieActor.Find(id);

           
            entity.MovieId = request.MovieId;
            entity.ActorId = request.ActorId;


            db.SaveChanges();





            return request;
        }
    }
}
