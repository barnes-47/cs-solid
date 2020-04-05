using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Solid.Followed.Contract;

namespace Solid.Followed.Concrete
{
    public class JsonDeserializer : IDeserialize
    {
        public T To<T>(string stringifyJson)
            => To<T>(stringifyJson, new StringEnumConverter());

        public T To<T>(string stringifyJson, params JsonConverter[] converters)
            => JsonConvert.DeserializeObject<T>(stringifyJson, converters);
    }
}
