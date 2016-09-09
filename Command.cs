using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotGenerator
{
    class Command
    {
        public String title { get; set; }
        public int numArguments { get; set; }
       
        public bool usesPrefix { get; set; }

        public String replyMessage { get; set; }

        public Command(String title, int args)
        {
            this.title = title;
            this.numArguments = args;
            usesPrefix = true;
            replyMessage = "Hello World!";
        }
        
    }
}
