namespace vacaaa.Models
{
    public class Cruise: Vacation
    {
        public string Description{get;set;}

        public Cruise()
        {
            Catergory = "Cruise";
        }
    }
}