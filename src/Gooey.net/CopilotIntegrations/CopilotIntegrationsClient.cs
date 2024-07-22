using System.Net.Http;
using System.Text.Json;
using Gooey.net;
using Gooey.net.Core;
using OneOf;

#nullable enable

namespace Gooey.net;

public class CopilotIntegrationsClient
{
    private RawClient _client;

    public CopilotIntegrationsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<CreateStreamResponse> VideoBotsStreamCreateAsync(CreateStreamRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v3/integrations/stream/",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<CreateStreamResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<
        OneOf<ConversationStart, RunStart, MessagePart, FinalResponse, StreamError>
    > VideoBotsStreamAsync(string requestId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"v3/integrations/stream/{requestId}/"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<
                OneOf<ConversationStart, RunStart, MessagePart, FinalResponse, StreamError>
            >(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
