using System;
using System.Threading;

namespace CyberSecurityAwareness_Chatbot
{
    public class ResponseManager
    {
        // Logo Display for visual Element

        private LogoDisplay logoDisplay;

        // automatic properties
        public string ResponseType { get; private set; }

        //constructor
        public ResponseManager()
        {
            ResponseType = "none"; // this sets yhe initial
                                   // to noneresponses 
            logoDisplay = new LogoDisplay();

        }

        // Method to process user input and display responses
        public void ProcessInput(string userInput, string userName, ref bool IsRunning)
            // ref means we can change the original IsRunning variable
        {
            // Convert input into lowercase 
            string input = userInput.ToLower();

            // check for exit commands
            if (input == "exit" || input == "quit" || input == "byebye")
            {

                // this sets the response type to goodbye
                ResponseType = "goodbye";

                DisplayGoodByeMessage(userName);
                IsRunning = true;
                return;
        

    }

            //checking for greetings
            if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
            {
                ResponseType = "Greeting";
                DisplayGreeting(userName);
                return;
            }

            // checking for "How Are You"
            if (input.Contains("how are you") || input.Contains("how are u"))
            {
                ResponseType = "status";
                DisplayStatusResponse();
                return;
            }

            //Chcecking for purpose question
            if (input.Contains("purpose") || input.Contains("what do you do") ||
                    input.Contains("what can you do"))
            {
                ResponseType = "purpose";
                DisplayPurposeResponse();
                return;
            }

            // checking for password-related questions
            if (input.Contains("password") || input.Contains("pass"))
            {
                ResponseType = "password";
                DisplayPasswordResponse();
                return;
            }

            //checking for phishing related querstions
            if (input.Contains("phish") || input.Contains("scam") ||
                input.Contains("fake"))
            {
                ResponseType = "phishing";
                DisplayPhishing();
                return;
            }

            // checking for browsing questions
            if (input.Contains("brows") || input.Contains("internet") ||
                    input.Contains("online"))
            {
                ResponseType = "browsing";
                DisplaySafeBrowsingResponses();
                return;
            }

            //checking what to ask
            if (input.Contains("what can I ask") || input.Contains("What Can i Ask") ||
                    input.Contains("help"))
            {
                ResponseType = "Help";
                DisplayHelpResponse();
                return;
            }

            // display response for unknown input
            ResponseType = "unknown";
            DisplayUnknownResponse();
        }

        private void DisplayGreeting(string userName)
        {
            TypewriterEffect($"\nHello, {userName}! How can I help you Stay safe online! ", 40);
        } // end of greeting method

        // the goodbye message for individual responses
        private void DisplayGoodByeMessage(string userName)
        {
            TypewriterEffect($"\nGoodbye, {userName}! Have a lovely day Ahead", 40);
            Thread.Sleep(1500);
        }

        private void DisplaySafeBrowsingResponses()
        {
            logoDisplay.SectionHeader("Safe Browsing Practices");
            TypewriterEffect("\nTips for safe internet browsing:", 40);

            logoDisplay.DisplaySafeBrowsing();

            TypewriterEffect("\nRemember: If a deal seems too good to be true online, it probably is!", 45);

        } // end of sade browsing method

        private void DisplayPhishing()
        {
            logoDisplay.SectionHeader("Phishing Awareness Tips");

            TypewriterEffect("\nHow to spot phishing attempts:", 40);
            logoDisplay.DisplayPhishing();

            TypewriterEffect("\nIn South Africa, phishing attacks" +
                " often pretend to be from banks like Capitec, FNB, or Standard Bank!", 45);

        } // end of phishing method

        private void DisplayPasswordResponse()
        {
            logoDisplay.SectionHeader("PASSWORD SAFETY TIPS");
            TypewriterEffect("\nHere are some important password safety tips:", 40);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n   Use at least 12 characters with mixed letters, numbers, and symbols");

            Console.WriteLine(" Never reuse passwords across different accounts");

            Console.WriteLine("  Enable two-factor authentication whenever possible");
            Console.WriteLine(" Avoid using personal information (birthdays, names, etc.)");

            Console.WriteLine(" Use a password manager to generate and store strong passwords");
            Console.ResetColor();

            TypewriterEffect("\nDid you know that 'password123' is one of the most hacked passwords in South Africa?", 45);
        } //end of password method


        private void DisplayStatusResponse()
        {
            TypewriterEffect("\n Im functioning well, thanks for asking", 40);
        } // end of Status Responses Method

        private void DisplayPurposeResponse()
        {
            TypewriterEffect("\n My purpose is to help you stay safe online", 40);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n * Creating Strong Passwords");

            Console.WriteLine("\n * Identifying phishing emails");

            Console.WriteLine("\n * Safe Browsing practices");

            Console.WriteLine("\n * protecting personal information");
            Console.ResetColor();
        } // end of purpose response method

        private void DisplayHelpResponse()
        {
            TypewriterEffect("\n Type your question normally", 40);
        } // end of help responses method
       
        private void DisplayUnknownResponse()
        { // This opening curly bracket starts the DisplayUnknownResponse method block

            Console.ForegroundColor = ConsoleColor.Red; // This changes color to red for error
            TypewriterEffect("\nI'm baffled and bamboozled by what you are asking me!", 40);
            TypewriterEffect("\nPlease will you rephrase your question about:", 40);

            Console.ResetColor(); // This changes color back to white

            Console.ForegroundColor = ConsoleColor.Blue; // This changes color to blue for suggestions
            Console.WriteLine("\n  • Password safety");

            Console.WriteLine("  • Phishing attacks");

            Console.WriteLine("  • Safe browsing");
            Console.ResetColor();

        } // end of display ynknown response method

        // Helper method to create the typewriter effect
        private void TypewriterEffect(string message, int milliSeconds)
        {
            foreach (char c in message)
            {
                Console.Write(c); //this prints the
                                  //currect character without new linw
                Thread.Sleep(milliSeconds);// this pauses
                                           // for milli seconds
            }
            Console.WriteLine();
        } // end of the typewriter method
    } // end of response Manager
} //end of program