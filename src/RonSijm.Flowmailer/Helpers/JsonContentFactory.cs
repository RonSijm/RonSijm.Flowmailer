using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace RonSijm.Flowmailer.Helpers;

public static class JsonContentFactory
{
    public static HttpContent Create(object content)
    {
        HttpContent httpContent = null;

        if (content != null)
        {
            var ms = new MemoryStream();
            SerializeJsonIntoStream(content, ms);
            ms.Seek(0, SeekOrigin.Begin);
            httpContent = new StreamContent(ms);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        return httpContent;
    }

    private static void SerializeJsonIntoStream(object value, Stream stream)
    {
        using var streamWriter = new StreamWriter(stream, new UTF8Encoding(false), 1024, true);
        using var jsonTextWriter = new JsonTextWriter(streamWriter);
        jsonTextWriter.Formatting = Formatting.None;
        var jsonSerializer = new JsonSerializer { ContractResolver = new CamelCasePropertyNamesContractResolver(), DefaultValueHandling = DefaultValueHandling.Ignore };
        jsonSerializer.Serialize(jsonTextWriter, value);
        jsonTextWriter.Flush();
    }
}