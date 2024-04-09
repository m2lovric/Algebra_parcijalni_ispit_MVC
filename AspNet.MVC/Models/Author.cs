using System.Diagnostics.Eventing.Reader;

namespace AspNet.MVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
