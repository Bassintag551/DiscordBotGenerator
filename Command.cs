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

        public int[] argumentsType;
       
        public bool usesPrefix { get; set; }

        public List<CommandAction> actions { get; private set; }

        public int numArguments
        {
            get
            {
                return argumentsType.Length;
            }

            set
            {
                Array.Resize<int>(ref argumentsType, value);
            }
        }

        public Command()
        {
            actions = new List<CommandAction>();
        }

    }
}
