using System;
using System.Xml;
using System.Collections.Generic;

using OpenGLParser2.objects;

namespace OpenGLParser2.Parsers
{
    public static class EnumParser
    {
        //private static Dictionary<string, glenum> enums;
        public static Dictionary<string, glenum> groups;
        public static Dictionary<string, string> values;
        public static void Parse(XmlDocument xdoc, bool verbose)
        {
            if (verbose) { Console.WriteLine("Parsing Enumerators:"); }
            //ENUMS
            //enums = new Dictionary<string, glenum>();
            values = new Dictionary<string, string>();
            XmlNodeList enumlist = xdoc.SelectNodes("registry/enums[@namespace='GL']");
            if (enumlist.Count > 0)
            {
                for (int i = 0; i < enumlist.Count; i++)
                {
                    //glenum tempenum = new glenum();
                    //string s_enumName = enumlist[i].Attributes["group"].Value;
                    XmlNodeList enumvalues = enumlist[i].SelectNodes("enum");
                    if (enumvalues.Count > 0)
                    {
                        for (int a = 0; a < enumvalues.Count; a++)
                        {
                            string s_val = enumvalues[a].Attributes["value"].Value;
                            string s_valname = enumvalues[a].Attributes["name"].Value;
                            //tempenum.values.Add(s_valname, s_val);
                            if (!values.ContainsKey(s_valname))
                            {
                                values.Add(s_valname, s_val);
                            }
                        }
                    }
                    //enums.Add(s_enumName, tempenum);
                }
            }
            //GROUPS
            groups = new Dictionary<string, glenum>();
            XmlNodeList grouplist = xdoc.SelectNodes("registry/groups/group");
            if (grouplist.Count > 0)
            {
                for (int i = 0; i < grouplist.Count; i++)
                {
                    glenum tempgroup = new glenum();
                    string s_groupName = grouplist[i].Attributes["name"].Value;
                    if (verbose) 
                    {
                        //Console.SetCursorPosition(0, Console.CursorTop);
                        //Console.WriteLine("Parsing: "+s_groupName); 
                    }
                    XmlNodeList groupvalues = grouplist[i].SelectNodes("enum");
                    if (groupvalues.Count > 0)
                    {
                        for (int a = 0; a < groupvalues.Count; a++)
                        {
                            string s_valname = groupvalues[a].Attributes["name"].Value;
                            if (values.ContainsKey(s_valname))
                            {
                                if (!tempgroup.values.ContainsKey(s_valname))
                                {
                                    tempgroup.values.Add(s_valname, values[s_valname]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Enum Parse Error: Value to " + s_valname + "not finded.");
                            }
                        }
                    }
                    groups.Add(s_groupName, tempgroup);
                }
            }
            if (verbose)
            {
                Console.WriteLine("Parsed Enumerators: OK");
                Console.WriteLine("    Parsed "+groups.Count+" Enumerators.");
            }
        }
    }
}
