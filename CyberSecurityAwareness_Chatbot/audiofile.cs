using System;
using System.Media;
using System.Threading;

namespace CyberSecurityAwareness_Chatbot
{
    public class AudioPlayer
    {
        // Automatic property to track if audio is available
        public bool IsAudioAvailable { get; private set; }

        // Constructor
        public AudioPlayer()
        {
            IsAudioAvailable = true;
        }

        // Method to play the greeting voice from the wav file
        public void PlayVoiceGreeting()
        {
            try
            {
                // Check if the file exists first
                if (!System.IO.File.Exists("greeting.wav"))
                {
                    //displays the warning message in blue color
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("\nVoice greeting file not found - continuing with text only");
                    Console.ResetColor();

                    IsAudioAvailable = false;
                    Thread.Sleep(1500); // this pauses the program for 1500 milliseconds
                    return;
                }

                // create a soundplayer with the voice greeting file
                SoundPlayer speaker = new SoundPlayer("greeting.wav");

                // displaying the visual indicator for the voice player
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n[Now PLAYING VOICE GREETING]");
                Console.ResetColor();

                // PLAYING THE SOUND 
                speaker.PlaySync();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Voice Greeting Complete!!!");
                Console.ResetColor();

                // adding a pause 
                Thread.Sleep(550);
                IsAudioAvailable = true; // this sets the availability to true
            }
            // this catches an error if its an unsupported file type
            catch (PlatformNotSupportedException)
            {
                // This handles unsupported audio format
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAudio format not supported on this system - continuing with text only");
                Console.ResetColor();
                IsAudioAvailable = false;
                Thread.Sleep(1500);
            }
            catch (Exception ex)
            {
                // Any other error - just continue without voice
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\nCould not play voice greeting - continuing with text only");

                Console.WriteLine($"Note: {ex.Message}");
                Console.ResetColor();

                IsAudioAvailable = false; // this sets the availability to false
                Thread.Sleep(1500);
            } // end of method
        } // end of play voice greeting method
    } // end of audioplay 
}// end program