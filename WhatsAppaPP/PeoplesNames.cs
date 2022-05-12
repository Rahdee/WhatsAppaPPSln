using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsAppaPP
{
    internal class PeoplesNames
    {
        public PeoplesNames()
        {

        }

        public PeoplesNames(string name, string text , DateTime lastseen)
        {
            Name = name;
            Text = text;
            Lastseen = lastseen;
        }
        public string Name { set; get; }
        public string Text { set; get; }

        public DateTime Lastseen { set; get; }


    }
}
