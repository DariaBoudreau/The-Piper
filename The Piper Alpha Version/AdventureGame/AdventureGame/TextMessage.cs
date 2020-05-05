using System;
using static System.Console;
namespace AdventureGame
{
    public class TextMessage
    {
        public string Timestamp;
        public string Username;
        public string Message;

        public TextMessage(string timestamp, string username, string message)
        {
            Timestamp = timestamp;
            Username = username;
            Message = message;
        }

        public void DisplayText()
        {
            //timestamp
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Write(Timestamp);
            ResetColor();

            //username
            if (Username == "ellisthewatson")
            {
                BackgroundColor = ConsoleColor.DarkRed;
            }
            else if (Username == "Taylor_Patterson")
            {
                BackgroundColor = ConsoleColor.DarkBlue;
            }
            else if (Username == "AVERYxFOSTER")
            {
                BackgroundColor = ConsoleColor.DarkMagenta;
            }
            Write(Username + ": ");
            ResetColor();

            //message
            Write(Message);
            ReadLine();
        }

    }
}
