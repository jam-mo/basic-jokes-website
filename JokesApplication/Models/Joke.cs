namespace JokesApplication.Models
{
    public class Joke
    {
        public string Id { get; set; }
        public string JokeQuestion  { get; set; }

        public string JokeAnswer { get; set; }

        public Joke()
        { // ctor + tabx2 will auto create constructor
            
        }
    }
}
