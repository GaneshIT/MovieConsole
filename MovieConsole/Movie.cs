using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    public sealed class MovieData
    {
        public void Data()
        {

        }
    }
    public class MovieResponse
    {

    }
    internal class Movie:Location
    {
        public int Id { get; set; } int id;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }

        public Movie() 
        {
            Console.WriteLine("Welcome to my MyShow");
        }
        public Movie(int id, string name, string description, string type, string language)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Language = language;
        }        
        public Movie(string type)
        {
            Type = type;
        }
        
        public Movie(string[] languages)
        {
           //write code
        }

        public override void GetLocations()
        {
            //logic
        }
        public void GetMovies()
        {
            Console.WriteLine("Loading...Movies");
        }
        public void AddMovie(int id,string title,string type)
        {
            Console.WriteLine("Movie details: ");
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Title:" + title);
            Console.WriteLine("Type:" + type);
        }
    }
}
