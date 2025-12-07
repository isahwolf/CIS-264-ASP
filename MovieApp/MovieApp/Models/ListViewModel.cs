using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieApp.Models
{
    public class ListViewModel
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
