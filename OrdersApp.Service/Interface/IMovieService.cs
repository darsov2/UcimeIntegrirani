using OrdersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp.Service.Interface
{
    public interface IMovieService
    {
        ICollection<Movie> GetAll();
        Movie GetById(Guid id);
        Movie Add(Movie movie);
        Movie Update(Movie movie);
        Movie Delete(Guid id);
    }
}
