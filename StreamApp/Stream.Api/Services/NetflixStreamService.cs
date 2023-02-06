using Stream.Api.Factory;

namespace Stream.Api.Services
{
    public class NetflixStreamService : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
            "Movie 1",
            "Movie 2",
            "Movie 3"
            };
        }
    }
}