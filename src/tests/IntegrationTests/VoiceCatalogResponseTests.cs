namespace Speechify.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void VoiceCatalogResponse_DeserializesPagedEnvelope()
    {
        const string json = """
            {
              "voices": [
                {
                  "id": "agrippina",
                  "type": "shared",
                  "display_name": "Agrippina",
                  "models": [
                    {
                      "name": "simba-3.0",
                      "languages": [
                        {
                          "locale": "ru-RU",
                          "preview_audio": "https://example.com/agrippina.mp3"
                        }
                      ]
                    }
                  ],
                  "gender": "female",
                  "locale": "ru-RU",
                  "preview_audio": "https://example.com/agrippina.mp3",
                  "avatar_image": "",
                  "tags": [
                    "age:young-adult",
                    "use-case:conversational-ai",
                    "timbre:bright"
                  ]
                }
              ],
              "next_cursor": "next-page",
              "has_more": true
            }
            """;

        var response = ListVoicesResponse.FromJson(json);

        response.Should().NotBeNull();
        response!.HasMore.Should().BeTrue();
        response.NextCursor.Should().Be("next-page");
        response.Voices.Should().ContainSingle();
        response.Voices[0].Id.Should().Be("agrippina");
        response.Voices[0].Models[0].Languages[0].Locale.Should().Be("ru-RU");
    }
}
