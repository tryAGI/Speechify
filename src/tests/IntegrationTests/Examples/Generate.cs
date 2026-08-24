/*
order: 10
title: Latest Text to Speech
slug: latest-text-to-speech

List a compatible voice and synthesize audio with Simba 3.2.
*/

namespace Speechify.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(60_000)]
    public async Task Example_LatestTextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        var voices = await client.Voices.ListAsync(
            limit: 50,
            model: GetSpeechRequestModel.Simba32.ToValueString());
        var voice = voices.Voices.FirstOrDefault(candidate =>
            candidate.Models.Any(model => model.Name == GetVoicesModelName.Simba32));
        if (voice is null)
        {
            throw new AssertInconclusiveException("No Simba 3.2 voice is available to this Speechify workspace.");
        }

        var response = await client.Audio.SpeechAsync(
            input: "Hello from the latest Speechify speech model.",
            voiceId: voice.Id,
            language: "en-US",
            model: GetSpeechRequestModel.Simba32,
            audioFormat: GetSpeechRequestAudioFormat.Mp3);

        response.AudioData.Should().NotBeNullOrEmpty();
    }
}
