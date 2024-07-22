using System.Net.Http;
using System.Text.Json;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

public class AiAnimationGeneratorClient
{
    private RawClient _client;

    public AiAnimationGeneratorClient(RawClient client)
    {
        _client = client;
    }

    public async Task<DeforumSdPageResponse> DeforumSdAsync(DeforumSdPageRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v2/DeforumSD/",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<DeforumSdPageResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<AsyncApiResponseModelV3> AsyncDeforumSdAsync(DeforumSdPageRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v3/DeforumSD/async/",
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

    public async Task<DeforumSdPageStatusResponse> StatusDeforumSdAsync(
        StatusDeforumSdRequest request
    )
    {
        var _query = new Dictionary<string, object>() { { "run_id", request.RunId }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "v3/DeforumSD/status/",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<DeforumSdPageStatusResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
