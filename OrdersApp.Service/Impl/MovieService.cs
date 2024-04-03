using OrdersApp.Domain.Models;
using OrdersApp.Repository.Interface;
using OrdersApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Service.Impl
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;

        public MovieService(IRepository<Movie> movieService)
        {
            _movieRepository = movieService;
        }

        public Movie Add(Movie movie)
        {
            movie.Id = Guid.NewGuid();
            return _movieRepository.Add(movie);
        }

        public Movie Delete(Guid id)
        {
            return _movieRepository.Delete(GetById(id));
        }

        public ICollection<Movie> GetAll()
        {
            return _movieRepository.GetAll().ToList();
        }

        public Movie GetById(Guid id)
        {
            return _movieRepository.GetById(id);
        }

        public Movie Update(Movie movie)
        {
            return _movieRepository.Update(movie);
        }
    }
}
