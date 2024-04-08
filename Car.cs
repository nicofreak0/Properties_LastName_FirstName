using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Properties_LastName_FirstName
{
    internal class Car
    {
        //makes a private backing field to model
        private string model;

        //makes a public field with the property model, that gets and sets the model
        public string Model { get { return model; } set { model = value; } }

        //makes public field with a property of make
        public string Make { get; set; }

    }
}
