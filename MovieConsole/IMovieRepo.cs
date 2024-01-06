using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    public interface Testing
    {
        void GetID();
        void SetID(int ID);
    }
    public interface IMovieRepo
    {
        void GetAll();
        void Get(int id);
    }
    public interface IMovieRepoOperation
    {
        string AddMovie();
    }
    public class MovieRepo 
    {
        public void Get(int id) { Console.WriteLine("movie"); }
        public void GetAll() { }
    }
    public class VistorRepo : IMovieRepo
    {
        public void Get(int id) { Console.WriteLine("Visitor"); }
        public void GetAll() { }
    }
    public class MovieOperation: IMovieRepoOperation
    {
        public string AddMovie() { return ""; }
    }
}
