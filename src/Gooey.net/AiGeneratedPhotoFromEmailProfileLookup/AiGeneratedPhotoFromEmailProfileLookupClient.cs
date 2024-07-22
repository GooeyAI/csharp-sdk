using System.Net.Http;
using System.Text.Json;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

public class AiGeneratedPhotoFromEmailProfileLookupClient
{
    private RawClient _client;

    public AiGeneratedPhotoFromEmailProfileLookupClient(RawClient client)
    {
        _client = client;
    }

    public async Task<EmailFaceInpaintingPageResponse> EmailFaceInpaintingAsync(
        EmailFaceInpaintingPageRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v2/EmailFaceInpainting/",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EmailFaceInpaintingPageResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<AsyncApiResponseModelV3> AsyncEmailFaceInpaintingAsync(
        EmailFaceInpaintingPageRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "v3/EmailFaceInpainting/async/",
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

    public async Task<EmailFaceInpaintingPageStatusResponse> StatusEmailFaceInpaintingAsync(
        StatusEmailFaceInpaintingRequest request
    )
    {
        var _query = new Dictionary<string, object>() { { "run_id", request.RunId }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "v3/EmailFaceInpainting/status/",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EmailFaceInpaintingPageStatusResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
