using System.Security.Policy;

namespace Moldovan_Andrei_Lab1.Models
{
    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public Models.Publisher? Publisher { get; set; }
        public Book Book { get; set; }
    }
}
