using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMosh1.Models;

namespace MvcMosh1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie{ get; set; }
        public List<Customer> Customers { get; set; }
    }
}