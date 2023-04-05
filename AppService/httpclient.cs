using Newtonsoft.Json;
namespace YallaHelp2023.AppService
{
    public static class HttpClientExtensions
    {
        //Root methods post and get from api
        public static async ValueTask<TOutput> STPostAsync<TInput, TOutput>(this HttpClient httpClient, string requestUri, TInput inputModel, string token = "", bool deserializeOutput = true) where TOutput : class
        {
            try
            {
                string serializedUser = JsonConvert.SerializeObject(inputModel);

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
                requestMessage.Content = new StringContent(serializedUser);

                requestMessage.Content.Headers.ContentType
                    = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                if (!string.IsNullOrWhiteSpace(token))
                    requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await httpClient.SendAsync(requestMessage);

                var responseStatusCode = response.StatusCode;
                var responseBody = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(responseBody))
                {
                    if (deserializeOutput)
                    {
                        return await Task.FromResult(JsonConvert.DeserializeObject<TOutput>(responseBody));
                    }
                    else
                        //this may throws exception
                        return responseBody as TOutput;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async ValueTask STPostAsync<TInput>(this HttpClient httpClient, string requestUri, TInput inputModel, string token = "")
        {
            try
            {
                string serializedUser = JsonConvert.SerializeObject(inputModel);

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
                requestMessage.Content = new StringContent(serializedUser);

                requestMessage.Content.Headers.ContentType
                    = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                if (!string.IsNullOrWhiteSpace(token))
                    requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await httpClient.SendAsync(requestMessage);

                var responseStatusCode = response.StatusCode;
                var responseBody = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
                //confirm on success status code or message code 


                //if (!string.IsNullOrWhiteSpace(responseBody))
                //    return await Task.FromResult(JsonConvert.DeserializeObject<TOutput>(responseBody));
                //else
                //    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async ValueTask<HttpResponseMessage> STPostWithResponseAsync<TInput>(this HttpClient httpClient, string requestUri, TInput inputModel, string token = "", bool serializeInput = true)
        {
            try
            {
                string serializedUser = JsonConvert.SerializeObject(inputModel);

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
                requestMessage.Content = new StringContent(serializeInput ? serializedUser : inputModel?.ToString());

                requestMessage.Content.Headers.ContentType
                    = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                if (!string.IsNullOrWhiteSpace(token))
                    requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await httpClient.SendAsync(requestMessage);

                var responseStatusCode = response.StatusCode;
                var responseBody = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static async ValueTask<T> STGetAsync<T>(this HttpClient httpClient, string requestUri, string token = "", bool deserializeOutput = true) where T : class
        {
            try
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);

                if (!string.IsNullOrWhiteSpace(token))
                    requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await httpClient.SendAsync(requestMessage);

                var responseStatusCode = response.StatusCode;

                if (responseStatusCode.ToString() == "OK")// responseStatusCode == System.Net.HttpStatusCode.OK
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(responseBody))
                    {
                        if (deserializeOutput)
                        {
                            return await Task.FromResult(JsonConvert.DeserializeObject<T>(responseBody));
                        }
                        else
                            //this may throws exception
                            return responseBody as T;
                    }
                    else
                        return null;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
