using System;
using System.Collections.Generic;

namespace OpenGLParser2.objects
{
    public class glmethod
    {
        public string returntype;
        public Dictionary<string, glargument> arguments; //name | argumento
        public glmethod()
        {
            this.arguments = new Dictionary<string, glargument>();
        }
    }
}
