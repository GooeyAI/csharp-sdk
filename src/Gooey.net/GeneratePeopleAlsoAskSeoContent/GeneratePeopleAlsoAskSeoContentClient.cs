using System.Net.Http;
using System.Text.Json;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

public class GeneratePeopleAlsoAskSeoContentClient
{
    private RawClient _client;

    public GeneratePeopleAlsoAskSeoContentClient(RawClient client)
    {
        _client = client;
    }

    public async Task<RelatedQnAPageResponse> RelatedQnaMakerAsync(RelatedQnAPageRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v2/related-qna-maker/",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<RelatedQnAPageResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<AsyncApiResponseModelV3> AsyncRelatedQnaMakerAsync(
        RelatedQnAPageRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v3/related-qna-maker/async/",
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

    public async Task<RelatedQnAPageStatusResponse> StatusRelatedQnaMakerAsync(
        StatusRelatedQnaMakerRequest request
    )
    {
        var _query = new Dictionary<string, object>() { { "run_id", request.RunId }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "v3/related-qna-maker/status/",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<RelatedQnAPageStatusResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
