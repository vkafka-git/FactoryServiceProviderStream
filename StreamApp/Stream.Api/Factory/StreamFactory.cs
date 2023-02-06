using Stream.Api.Services;
using System.Xml.Linq;
using System;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Threading.Tasks;

namespace Stream.Api.Factory
{
    public class StreamFactory
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IDictionary<string, Type> _types;

        public StreamFactory(IServiceProvider serviceProvider, IOptions<StreamFactoryOptions> options)
        {
            this.serviceProvider = serviceProvider;
            _types = options.Value.Types;
        }

        public IStreamService GetStreamService(string userSelection)
        {
            if (_types.TryGetValue(userSelection, out var type))
            {
                return (IStreamService)this.serviceProvider.GetRequiredService(type);
            }

            throw new ArgumentOutOfRangeException(nameof(userSelection));
        }

    }
}