using System.Net.Http;
using System.Text.Json;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

public class GenerateProductPhotoBackgroundsClient
{
    private RawClient _client;

    public GenerateProductPhotoBackgroundsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<ObjectInpaintingPageResponse> ObjectInpaintingAsync(
        ObjectInpaintingPageRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v2/ObjectInpainting/",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<ObjectInpaintingPageResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<AsyncApiResponseModelV3> AsyncObjectInpaintingAsync(
        ObjectInpaintingPageRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v3/ObjectInpainting/async/",
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

    public async Task<ObjectInpaintingPageStatusResponse> StatusObjectInpaintingAsync(
        StatusObjectInpaintingRequest request
    )
    {
        var _query = new Dictionary<string, object>() { { "run_id", request.RunId }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "v3/ObjectInpainting/status/",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<ObjectInpaintingPageStatusResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
