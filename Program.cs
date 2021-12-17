using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ______
{
    class Program
    {
        async static Task FromMic(SpeechConfig speechConfig)
        {
            using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            using var recognizer = new SpeechRecognizer(speechConfig, "zh-tw", audioConfig);

            Console.WriteLine("嗨~ 請透過語音下達指令...");
            var result = await recognizer.RecognizeOnceAsync();
            Console.WriteLine($"語音命令 = '{result.Text}' ");
        }

        static void Main(string[] args)
        {
            // Set console encoding to unicode
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            var speechConfig = SpeechConfig.FromSubscription(
                "____your____API_KEY_______", "___location_____");
            FromMic(speechConfig).GetAwaiter().GetResult();
        }
    }
}
