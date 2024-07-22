using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

public partial class Gooey
{
    private RawClient _client;

    public Gooey(string? authorization = null, ClientOptions? clientOptions = null)
    {
        _client = new RawClient(
            new Dictionary<string, string>()
            {
                { "Authorization", authorization },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Gooey.net" },
                { "X-Fern-SDK-Version", "0.0.0" },
            },
            clientOptions ?? new ClientOptions()
        );
        CopilotIntegrations = new CopilotIntegrationsClient(_client);
        CopilotForYourEnterprise = new CopilotForYourEnterpriseClient(_client);
        AiAnimationGenerator = new AiAnimationGeneratorClient(_client);
        AiArtQrCode = new AiArtQrCodeClient(_client);
        GeneratePeopleAlsoAskSeoContent = new GeneratePeopleAlsoAskSeoContentClient(_client);
        CreateAPerfectSeoOptimizedTitleParagraph =
            new CreateAPerfectSeoOptimizedTitleParagraphClient(_client);
        WebSearchGpt3 = new WebSearchGpt3Client(_client);
        ProfileLookupGpt3ForAiPersonalizedEmails =
            new ProfileLookupGpt3ForAiPersonalizedEmailsClient(_client);
        BulkRunner = new BulkRunnerClient(_client);
        Evaluator = new EvaluatorClient(_client);
        SyntheticDataMakerForVideosPdFs = new SyntheticDataMakerForVideosPdFsClient(_client);
        LargeLanguageModelsGpt3 = new LargeLanguageModelsGpt3Client(_client);
        SearchYourDocsWithGpt = new SearchYourDocsWithGptClient(_client);
        SmartGpt = new SmartGptClient(_client);
        SummarizeYourDocsWithGpt = new SummarizeYourDocsWithGptClient(_client);
        Functions = new FunctionsClient(_client);
        LipSyncing = new LipSyncingClient(_client);
        LipsyncVideoWithAnyText = new LipsyncVideoWithAnyTextClient(_client);
        CompareAiVoiceGenerators = new CompareAiVoiceGeneratorsClient(_client);
        SpeechRecognitionTranslation = new SpeechRecognitionTranslationClient(_client);
        TextGuidedAudioGenerator = new TextGuidedAudioGeneratorClient(_client);
        CompareAiTranslations = new CompareAiTranslationsClient(_client);
        EditAnImageWithAiPrompt = new EditAnImageWithAiPromptClient(_client);
        CompareAiImageGenerators = new CompareAiImageGeneratorsClient(_client);
        GenerateProductPhotoBackgrounds = new GenerateProductPhotoBackgroundsClient(_client);
        AiImageWithAFace = new AiImageWithAFaceClient(_client);
        AiGeneratedPhotoFromEmailProfileLookup = new AiGeneratedPhotoFromEmailProfileLookupClient(
            _client
        );
        RenderImageSearchResultsWithAi = new RenderImageSearchResultsWithAiClient(_client);
        AiBackgroundChanger = new AiBackgroundChangerClient(_client);
        CompareAiImageUpscalers = new CompareAiImageUpscalersClient(_client);
        ChyronPlantBot = new ChyronPlantBotClient(_client);
        LetterWriter = new LetterWriterClient(_client);
        Embeddings = new EmbeddingsClient(_client);
        PeopleAlsoAskAnswersFromADoc = new PeopleAlsoAskAnswersFromADocClient(_client);
        Misc = new MiscClient(_client);
    }

    public CopilotIntegrationsClient CopilotIntegrations { get; init; }

    public CopilotForYourEnterpriseClient CopilotForYourEnterprise { get; init; }

    public AiAnimationGeneratorClient AiAnimationGenerator { get; init; }

    public AiArtQrCodeClient AiArtQrCode { get; init; }

    public GeneratePeopleAlsoAskSeoContentClient GeneratePeopleAlsoAskSeoContent { get; init; }

    public CreateAPerfectSeoOptimizedTitleParagraphClient CreateAPerfectSeoOptimizedTitleParagraph { get; init; }

    public WebSearchGpt3Client WebSearchGpt3 { get; init; }

    public ProfileLookupGpt3ForAiPersonalizedEmailsClient ProfileLookupGpt3ForAiPersonalizedEmails { get; init; }

    public BulkRunnerClient BulkRunner { get; init; }

    public EvaluatorClient Evaluator { get; init; }

    public SyntheticDataMakerForVideosPdFsClient SyntheticDataMakerForVideosPdFs { get; init; }

    public LargeLanguageModelsGpt3Client LargeLanguageModelsGpt3 { get; init; }

    public SearchYourDocsWithGptClient SearchYourDocsWithGpt { get; init; }

    public SmartGptClient SmartGpt { get; init; }

    public SummarizeYourDocsWithGptClient SummarizeYourDocsWithGpt { get; init; }

    public FunctionsClient Functions { get; init; }

    public LipSyncingClient LipSyncing { get; init; }

    public LipsyncVideoWithAnyTextClient LipsyncVideoWithAnyText { get; init; }

    public CompareAiVoiceGeneratorsClient CompareAiVoiceGenerators { get; init; }

    public SpeechRecognitionTranslationClient SpeechRecognitionTranslation { get; init; }

    public TextGuidedAudioGeneratorClient TextGuidedAudioGenerator { get; init; }

    public CompareAiTranslationsClient CompareAiTranslations { get; init; }

    public EditAnImageWithAiPromptClient EditAnImageWithAiPrompt { get; init; }

    public CompareAiImageGeneratorsClient CompareAiImageGenerators { get; init; }

    public GenerateProductPhotoBackgroundsClient GenerateProductPhotoBackgrounds { get; init; }

    public AiImageWithAFaceClient AiImageWithAFace { get; init; }

    public AiGeneratedPhotoFromEmailProfileLookupClient AiGeneratedPhotoFromEmailProfileLookup { get; init; }

    public RenderImageSearchResultsWithAiClient RenderImageSearchResultsWithAi { get; init; }

    public AiBackgroundChangerClient AiBackgroundChanger { get; init; }

    public CompareAiImageUpscalersClient CompareAiImageUpscalers { get; init; }

    public ChyronPlantBotClient ChyronPlantBot { get; init; }

    public LetterWriterClient LetterWriter { get; init; }

    public EmbeddingsClient Embeddings { get; init; }

    public PeopleAlsoAskAnswersFromADocClient PeopleAlsoAskAnswersFromADoc { get; init; }

    public MiscClient Misc { get; init; }
}
