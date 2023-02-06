using Stream.Api.Services;

namespace Stream.Api.Factory
{
    public class StreamFactoryOptions
    {
        public IDictionary<string, Type> Types { get; } = new Dictionary<string, Type>();

        public void Register<T>(string name) where T : IStreamService
        {
            Types.Add(name, typeof(T));
        }
    }
}
