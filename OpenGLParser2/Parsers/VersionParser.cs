using System;
using System.Xml;
using System.Collections.Generic;

namespace OpenGLParser2.Parsers
{
    public static class VersionParser
    {
        public static List<string> versions;
        public static Dictionary<string, objects.glVersion> version;
        public static void Parse(XmlDocument xdoc, bool verbose)
        {
            if (verbose) { Console.WriteLine("Parsing OpenGL Versions."); }
            version = new Dictionary<string, objects.glVersion>();
            XmlNodeList versionlist = xdoc.SelectNodes("registry/feature[@api='gl']");
            versions = new List<string>();
            for (int i=0;i<versionlist.Count;i++)
            {
                string s_version = versionlist[i].Attributes["number"].Value.Replace('.', '_');
                versions.Add(s_version);
                XmlNodeList versionrequires = versionlist[i].SelectNodes("require"); //COMANDS IN VERSION
                List<string> l_commands = new List<string>();
                for (int r=0;r< versionrequires.Count;r++)
                {
                    XmlNodeList versioncommands = versionrequires[r].SelectNodes("command");
                    if (versioncommands != null)
                    {
                        for (int c = 0; c < versioncommands.Count; c++)
                        {
                            if (!l_commands.Contains(versioncommands[c].Attributes["name"].Value))
                            {
                                l_commands.Add(versioncommands[c].Attributes["name"].Value);
                            }
                        }
                    }
                }

                XmlNodeList versionremoveds = versionlist[i].SelectNodes("remove"); //COMANDS REMOVED
                List<string> l_removeds = new List<string>();
                for (int r = 0; r < versionremoveds.Count; r++)
                {
                    XmlNodeList versioncommands = versionremoveds[r].SelectNodes("command");
                    if (versioncommands != null)
                    {
                        for (int c = 0; c < versioncommands.Count; c++)
                        {
                            l_removeds.Add(versioncommands[c].Attributes["name"].Value);
                        }
                    }
                }

                objects.glVersion vrs = new objects.glVersion(s_version, l_commands, l_removeds);

                version.Add(s_version, vrs);
            }

            redefineCmdLists(); //Redefine Commands adding Previews and removed olds

            if (verbose)
            {
                Console.WriteLine("Parsed OpenGL Versions: OK");
                Console.WriteLine("   Parsed " +version.Count + " OpenGL Versions.");
            }
        }

        private static void redefineCmdLists() //Redefine Commands adding Previews and removed olds
        {
            for (int i=0;i<versions.Count;i++)
            {
                if (i>0)
                {
                    List<string> redefined = new List<string>(version[versions[i]].Commands);
                    for (int a=0;a< version[versions[i-1]].Commands.Count;a++)
                    {
                        if (!redefined.Contains(version[versions[i - 1]].Commands[a]))
                        {
                            redefined.Add(version[versions[i - 1]].Commands[a]);
                        }
                    }
                    if (version[versions[i]].Removeds.Count > 0)
                    {
                        for (int r=0;r< version[versions[i]].Removeds.Count;r++)
                        {
                            if (redefined.Contains(version[versions[i]].Removeds[r]))
                            {
                                redefined.Remove(version[versions[i]].Removeds[r]);
                            }
                        }
                    }
                    redefined.Sort();
                    version[versions[i]].Commands = redefined;
                }
            }
        }
    }
}
