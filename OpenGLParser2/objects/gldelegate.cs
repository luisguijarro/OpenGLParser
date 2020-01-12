using System;
using System.Collections.Generic;

namespace OpenGLParser2.objects
{
    public class gldelegate
    {
        public Dictionary<string, glparam> Params;
        public gldelegate()
        {
            this.Params = new Dictionary<string, glparam>();
        }
    }
}
