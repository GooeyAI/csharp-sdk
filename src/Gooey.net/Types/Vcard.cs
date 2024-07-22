using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record Vcard
{
    [JsonPropertyName("format_name")]
    public required string FormatName { get; init; }

    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("gender")]
    public string? Gender { get; init; }

    [JsonPropertyName("birthday_year")]
    public int? BirthdayYear { get; init; }

    [JsonPropertyName("birthday_month")]
    public int? BirthdayMonth { get; init; }

    [JsonPropertyName("birthday_day")]
    public int? BirthdayDay { get; init; }

    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    [JsonPropertyName("middle_names")]
    public string? MiddleNames { get; init; }

    [JsonPropertyName("honorific_prefixes")]
    public string? HonorificPrefixes { get; init; }

    [JsonPropertyName("honorific_suffixes")]
    public string? HonorificSuffixes { get; init; }

    [JsonPropertyName("impp")]
    public string? Impp { get; init; }

    [JsonPropertyName("address")]
    public string? Address { get; init; }

    [JsonPropertyName("calendar_url")]
    public string? CalendarUrl { get; init; }

    [JsonPropertyName("comma_separated_categories")]
    public string? CommaSeparatedCategories { get; init; }

    [JsonPropertyName("kind")]
    public string? Kind { get; init; }

    [JsonPropertyName("language")]
    public string? Language { get; init; }

    [JsonPropertyName("organization")]
    public string? Organization { get; init; }

    [JsonPropertyName("photo_url")]
    public string? PhotoUrl { get; init; }

    [JsonPropertyName("logo_url")]
    public string? LogoUrl { get; init; }

    [JsonPropertyName("role")]
    public string? Role { get; init; }

    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    [JsonPropertyName("job_title")]
    public string? JobTitle { get; init; }

    [JsonPropertyName("urls")]
    public IEnumerable<string>? Urls { get; init; }

    [JsonPropertyName("tel")]
    public string? Tel { get; init; }

    [JsonPropertyName("note")]
    public string? Note { get; init; }
}
