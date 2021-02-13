using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Client:Person
    {
        public string Bank { get; set; }

        public Client(string name,string bank):base(name)
        {
            Bank = bank;
        }
    }
}
