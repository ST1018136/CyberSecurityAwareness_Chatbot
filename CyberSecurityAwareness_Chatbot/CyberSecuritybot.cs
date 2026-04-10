using System;
using System.Threading;

namespace CyberSecurityAwareness_Chatbot
{
    public class CyberSecurityBot
    {
        public string UserName { get; set; }
        public bool IsRunning { get; set; }

        private AudioPlayer audioPlayer;
        private LogoDisplay logoDisplay;
        private ResponseManager responseManager;

        // constructor that will run when the chatbot is created
        public CyberSecurityBot()
        {
            IsRunning = true;
            UserName = "Sethu Crescendo";

            // initialise the helper classes
            audioPlayer = new AudioPlayer();
            logoDisplay = new LogoDisplay();
            responseManager = new ResponseManager();
        }

        //Main method to start the chatbot awereness
        public void Start()
        {
            // play the voice greeting 
            audioPlayer.PlayVoiceGreeting();

            // display the ascii logo
            logoDisplay.DisplayLogo();

            // display the welcome message
            logoDisplay.DisplayWelcomeMessage();

            //typing effect for the welcome message
            TypewriterEffect("I am your CyberSecurity Awareness assistant", 30);
            Console.WriteLine();

            TypewriterEffect("How may I assist you staying safe online", 30);
            Console.WriteLine("\n");

            // Get the username
            GetUserName();

            // show the personalised greetings
            DisplayGreeting();

            // Starting the main conversation loop
            RunConversation(GetIsRunning());
        }

        private void GetUserName()
        {
            bool validName = false;

            while (!validName)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("What Is Your Name??");

                Console.ForegroundColor = ConsoleColor.White;

                string input = Console.ReadLine();

                // check if the name is empty or white space
                if (string.IsNullOrEmpty(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("i am baffled and bamboozled because i do" +
                        "not know what you are asking.");
                    Console.WriteLine("please tell me your name again");
                    Console.ResetColor();
                }
                else
                {
                    UserName = char.ToUpper(input[0]) + input.Substring(1).ToLower();
                    validName = true;
                }
            }
        }

        // Method to show personalised greeting
        private void DisplayGreeting()
        {
            Console.Clear();
            logoDisplay.DisplayLogo();
            logoDisplay.SectionHeader(UserName);

            Console.WriteLine($" it is wonderful to meet you, {UserName}", 40);

            TypewriterEffect("\n I am here to help learn about online safety", 40);

            TypewriterEffect("\n You can ask me about: ", 40);

            logoDisplay.DisplayTopics();

            TypewriterEffect("\n You can also ask me how i am doing or ask me my purpose is", 40);
            Console.WriteLine("\n");
        }

        private bool GetIsRunning()
        {
            return IsRunning;
        }

        // Method to run the main conversation 
        private void RunConversation(bool IsRunning)
        {
            while (this.IsRunning)
            {
                // display input with styling
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine($"{UserName} > ");
                Console.ForegroundColor = ConsoleColor.White;

                string userInput = Console.ReadLine();

                // Validate input
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\ni am baffled and bamboozled because i do" +
                        "not know what you are asking.");

                    Console.WriteLine("Kindly rephrase your question!");
                    Console.ResetColor();
                    continue;
                }

                // displaying the bots prefix
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("\nBot >");
                Console.ForegroundColor = ConsoleColor.White;

                // Processing the user input using response manager
                responseManager.ProcessInput(userInput, UserName, ref IsRunning);

                // add a separator line for better readability
                if (this.IsRunning)
                {
                    logoDisplay.DisplaySeparator();

                }
            }
        } //end of run conversation method

        // Helper Method to create typing effect
        private void TypewriterEffect(string message, int MilliSeconds)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(MilliSeconds); 
            }
            Console.WriteLine();

        } // end of the typewriter method
    } // end of response Manager
} //end of program

