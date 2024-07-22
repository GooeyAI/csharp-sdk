using System.Net.Http;
using System.Text.Json;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

public class RenderImageSearchResultsWithAiClient
{
    private RawClient _client;

    public RenderImageSearchResultsWithAiClient(RawClient client)
    {
        _client = client;
    }

    public async Task<GoogleImageGenPageResponse> GoogleImageGenAsync(
        GoogleImageGenPageRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v2/GoogleImageGen/",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<GoogleImageGenPageResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<AsyncApiResponseModelV3> AsyncGoogleImageGenAsync(
        GoogleImageGenPageRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v3/GoogleImageGen/async/",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<AsyncApiResponseModelV3>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<GoogleImageGenPageStatusResponse> StatusGoogleImageGenAsync(
        StatusGoogleImageGenRequest request
    )
    {
        var _query = new Dictionary<string, object>() { { "run_id", request.RunId }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "v3/GoogleImageGen/status/",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<GoogleImageGenPageStatusResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
