using System.Net.Http;
using System.Text.Json;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

public class ChyronPlantBotClient
{
    private RawClient _client;

    public ChyronPlantBotClient(RawClient client)
    {
        _client = client;
    }

    public async Task<ChyronPlantPageResponse> ChyronPlantAsync(ChyronPlantPageRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v2/ChyronPlant/",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<ChyronPlantPageResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<AsyncApiResponseModelV3> AsyncChyronPlantAsync(ChyronPlantPageRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v3/ChyronPlant/async/",
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

    public async Task<ChyronPlantPageStatusResponse> StatusChyronPlantAsync(
        StatusChyronPlantRequest request
    )
    {
        var _query = new Dictionary<string, object>() { { "run_id", request.RunId }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "v3/ChyronPlant/status/",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<ChyronPlantPageStatusResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
