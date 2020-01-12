using System;
using System.Collections.Generic;

namespace OpenGLParser2.objects
{
    public class glVersion
    {
        public string Version;
        public List<string> Commands;
        public List<string> Removeds;
        public glVersion(string version, List<string> commands, List<string> removeds)
        {
            this.Version = version;
            this.Commands = commands;
            this.Removeds = removeds;
        }
    }
}
