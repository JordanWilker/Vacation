using vacaaa.Interfaces;

namespace vacaaa.Models
{
    public class Vacation : IInfo
    {
        public int Duration {get;set;}
        public decimal Price{get;set;}
        public string Catergory{get;set;}
        public string Name{get;set;}
    }
}