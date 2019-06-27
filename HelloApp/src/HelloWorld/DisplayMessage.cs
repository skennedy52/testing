using System;


namespace HelloWorld
{
    public class DisplayMessage
    {
        
        public DisplayMessage()
        {}

        public string messageText
        { get; set; }
        

        public void DisplayGreeting(string message)
        {
            if(message != null && message.Length != 0)    
            {
               Console.WriteLine(message);               
            }
            else
            {
                Console.WriteLine("Please enter a greeting.");
            }
            
        }

    }
}