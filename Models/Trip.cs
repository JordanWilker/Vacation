namespace vacaaa.Models
{
    public class Trip: Vacation
    {
        public string Description{get;set;}

        public Trip()
        {
            Catergory = "Trip";
        }
    }
}