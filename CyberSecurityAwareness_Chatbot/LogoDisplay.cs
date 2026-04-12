using System;
using System.Threading;

namespace CyberSecurityAwareness_Chatbot
{
    public class LogoDisplay
    {
        // Method to display the ASCII lOGO

        public void DisplayLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Ascii Logo Goes Here
            string myLogo = (@"

   \`-._:  .:'`:::              |\__/|           /::  .:' `:::: .: /
    \     :       \             |:   |          /         :       /    
     \     ::    . :   `-______/ ::  \_______-'   .      ::   .  /      
      |  :   :: ::'  :   :: ::'  :   :: ::'      :: ::'  :   :: :|       
      |     ;::         ;::         ;::         ;::         ;::  |       
      |  .:'   `:::  .:'   `:::  .:'   `:::  .:'   `:::  .:'   `:|       
      /     :           :           :           :           :    \       
     /______::_____     ::    .     ::    .     ::   _____._::____\      
                   `----._:: ::'  :   :: ::'  _.----'                    
                          `--.       ;::  .--'                           
                              `-. .:'  .-'                               
                                 \    /                            
                                  \  /                                   
                                   \/ 

 -- ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
-- ~                                                                                                    ~
-- ~    .-._   .-._.    .                       .-.                               .    .-.              ~
-- ~  .: (_)`-'       .'                .;;;.`-'                         .-.  ...;... (_) )-.           ~
-- ~  ::     .    .-.;-.   .-.   .;.::.;;  (_).-.  .-.     ,  :    .;.::.`-'   .'.    .-.: __)   .-.    ~
-- ~  ::   _  `:  ; ;   ;.;.-'   .;    `;;;..;.-' ;       ;   ;    .;   ;'   .;   `:  ;.:'   `. ;   ;'  ~
-- ~  `: .; )  `.'.'`::'`-`:::'.;'     _   `:`:::'`;;;;'.'`..:;._.;' _.;:._.;      `.' :'      )`;;'    ~
-- ~    `--'-.;'                      (_.;;;'                                   -.;'(_/  `----'         ~
-- ~     ...;...                                                                                        ~
-- ~      .'                                                                                            ~
-- ~    .;                                                                                              ~
-- ~  .;                                                                                                ~
-- ~                                                                                                    ~
-- ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ");
            Console.WriteLine(myLogo);

            // resetting the normal color 
            Console.ResetColor();

            Thread.Sleep(1500);
        }

        // Method to display the welcome message 
        public void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\n===================================");
            Console.WriteLine("||               Welcome             ");
            Console.WriteLine("||                                   ");
            Console.WriteLine("=====================================");
            Console.ResetColor();
        }

        // Displaying the personalised greeting
        public void DisplayPersonalGreeting(string UserName)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\n===================================");
            Console.WriteLine($"||        Hello {UserName.ToUpper()}||");
            Console.WriteLine($"||                                   ||");
            Console.WriteLine("======================================");

            Console.ResetColor();
        }

        // Method to display the section Header
        public void SectionHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\n===================================");
            Console.WriteLine("||               {title}             ");
            Console.WriteLine("||                                   ");
            Console.WriteLine("=====================================");
            Console.ResetColor();
        }

        // Method to display the topics
        public void DisplayTopics()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            // prints the password safety topics
            Console.WriteLine("\n  + Password Safety");
            // prints the phishing topics
            Console.WriteLine("  + Phishing Attack");
            // prints the safe browsing topics
            Console.WriteLine("  + Safe Browsing ");

            Console.ResetColor();
        }

        // Method to display password tips
        public void DisplayPasswordResponse()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n  *Use at least 12 characters with mixed letters, numbers, and symbols");

            Console.WriteLine("   *Never reuse passwords across different accounts");

            Console.WriteLine("   *Enable two-factor authentication whenever possible");

            Console.WriteLine("   * Avoid using personal information (birthdays, names, etc.)");

            Console.WriteLine("   *Use a password manager to generate and store strong passwords");
            Console.ResetColor();
        }
        // Method to display the messages about phishing
        public void DisplayPhishing()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n Check sender email adress carefully");

            Console.WriteLine("\n Never click on any suspicious links or downlaod unwanted attatchments");

            Console.WriteLine("\n Look for urgent language demanding immediate action");

            Console.WriteLine("\n Verify requests by contacting the company directly");
            Console.ResetColor();
        }

        // Method to display safe browsing
        public void DisplaySafeBrowsing()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n Always look for 'www.' and padlock in the address bar");

            Console.WriteLine("\n Avoid using public WI-FI for banking or any transactions");

            Console.WriteLine("\n Keep your browser and operating system updated");

            Console.WriteLine("\n Use an antivirus and firewall software");

            Console.WriteLine("\n Clear your browser cache regularly");
            Console.ResetColor();
        }

        

        // Method to display the separator line
        public void DisplaySeparator()
        {
            Console.WriteLine("\n" + new string('-', 60));
        }
    }
}
