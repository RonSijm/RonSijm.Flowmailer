using Exception = RonSijm.Flowmailer.Models.Exception;

namespace RonSijm.Flowmailer.Helpers;

public static class HttpResultParser
{
    public static async Task<T> ParseRawResult<T>(HttpResponseMessage response) where T : new()
    {
        var messageContent = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {
            if (response.StatusCode == HttpStatusCode.NoContent || string.IsNullOrWhiteSpace(messageContent))
            {
                return new T();
            }

            try
            {
                var result = JsonConvert.DeserializeObject<T>(messageContent);
                return result;
            }
            catch (System.Exception e)
            {
                var message = $"SuccessCode '{response.StatusCode}' but unexpected return object";
                throw new Exception(message, e) { Type = "Deserialization Error" };
            }
        }

        var viewException = JsonConvert.DeserializeObject<Exception>(messageContent);
        throw viewException;
    }
}