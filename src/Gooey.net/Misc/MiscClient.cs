using System.Net.Http;
using System.Text.Json;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

public class MiscClient
{
    private RawClient _client;

    public MiscClient(RawClient client)
    {
        _client = client;
    }

    public async Task<BalanceResponse> GetBalanceAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = "v1/balance/" }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<BalanceResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<object> VideoBotsBroadcastAsync(BotBroadcastRequestModel request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.ExampleId != null)
        {
            _query["example_id"] = request.ExampleId;
        }
        if (request.RunId != null)
        {
            _query["run_id"] = request.RunId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v2/video-bots/broadcast/send/",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<object> HealthAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = "" }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
