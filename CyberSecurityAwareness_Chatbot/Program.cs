
using CyberSecurityAwareness_Chatbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityAwareness_Chatbot
{
    public class program
    {
        static void Main(String[] args)
        {
            //sets the console window title so that it will look professional
            Console.Title = "CyberBot - Cybersecurity Awareness ChatBot";

            //
            Console.WindowWidth = 100;
            Console.WindowHeight = 45;

            Console.BackgroundColor = Console.BackgroundColor; // console background to color black
            Console.ForegroundColor = Console.ForegroundColor; // color of the text style
            Console.Clear();

            CyberSecurityBot chatbot = new CyberSecurityBot(); // creates an instancce for the chatbot

            //start the application 
            chatbot.Start();
        }// end of method
    } // ends the program
} // end of namespace
