using Microsoft.AspNetCore.Mvc;
using Stream.Api.Factory;

namespace Stream.Api.Controllers
{
    public class StreamController : Controller
    {
        private readonly StreamFactory streamFactory;

        public StreamController(StreamFactory streamFactory)
        {
            this.streamFactory = streamFactory;
        }
        [HttpGet("movies/{userSelection}")]
        public IEnumerable<string> GetMovies(string userSelection)
        {
            return this.streamFactory.GetStreamService(userSelection).ShowMovies();

        }
    }
}
