using Newtonsoft.Json;

namespace Solid.Followed.Contract
{
    public interface IDeserialize
    {
        T To<T>(string stringifyJson);

        T To<T>(string stringifyJson, params JsonConverter[] converters);
    }
}
