using System;
using System.Xml;
using System.Collections.Generic;

namespace OpenGLParser2.Parsers
{
    public static class MethodParser
    {
        public static Dictionary<string, objects.glmethod> methods;
        public static void Parse(XmlDocument xdoc, bool verbose)
        {
            if (verbose) { Console.WriteLine("Parsing Commands:"); }
            methods = new Dictionary<string, objects.glmethod>();

            XmlNodeList commandlist = xdoc.SelectNodes("registry/commands[@namespace='GL']/command");
            for (int i=0;i<commandlist.Count;i++)
            {
                objects.glmethod glmthd = new objects.glmethod();
                XmlNode commandnode = commandlist[i];
                XmlNode cm_proto_node = commandnode.SelectSingleNode("proto");
                string s_name = cm_proto_node.SelectSingleNode("name").InnerText;
                string s_return = cm_proto_node.InnerText.Split(' ')[0].Replace(s_name, "");

                if (cm_proto_node.InnerText.Contains("void *"))
                {
                    s_return = "IntPtr";
                }

                if (cm_proto_node.SelectSingleNode("ptype") != null)
                {
                    s_return = cm_proto_node.SelectSingleNode("ptype").InnerText;
                }

                if (s_return == "GLenum")
                {
                    if (cm_proto_node.Attributes["group"] != null)
                    {
                        s_return = cm_proto_node.Attributes["group"].Value;
                    }
                }

                XmlNodeList argslist = commandnode.SelectNodes("param");

                for (int p=0;p<argslist.Count;p++) //Add Arguments to Method
                {
                    string s_type = "";
                    if (argslist[p].SelectSingleNode("ptype") == null)
                    {
                        if (argslist[p].InnerText.Contains("void *"))
                        {
                            s_type = "IntPtr";
                        }
                    }
                    else
                    {
                        s_type = argslist[p].SelectSingleNode("ptype").InnerText;
                        if (s_type == "GLenum")
                        {
                            if (argslist[p].Attributes["group"] != null)
                            {
                                string s_enum = argslist[p].Attributes["group"].Value;
                                if (EnumParser.groups.ContainsKey(s_enum))
                                {
                                    s_type = s_enum;
                                }
                                else
                                {
                                    s_type = Tools.GLTypeConverter(s_type);
                                    //throw new Exception("Param Type " + s_enum + " not found.");
                                }
                            }
                        }
                        else
                        {
                            s_type = Tools.GLTypeConverter(s_type);
                        }
                    }
                    string s_pname = argslist[p].SelectSingleNode("name").InnerText;
                    if (s_pname == "params") { s_pname = "@params"; }
                    if (s_pname == "ref") { s_pname = "@ref"; }
                    if (s_pname == "base") { s_pname = "@base"; }
                    if (s_pname == "string") { s_pname = "@string"; }
                    bool isarray = false;
                    int i_len = 0;
                    bool ispointer = false;

                    if (argslist[p].Attributes["len"] != null)
                    {
                        if (int.TryParse(argslist[p].Attributes["len"].Value, out i_len))
                        {
                            if (i_len > 1)
                            {
                                isarray = true;
                            }
                        }
                        else
                        {
                            isarray = true;
                            if (s_type == "IntPtr")
                            {
                                isarray = false;
                            }
                        }
                    }

                    ispointer = (s_type == "IntPtr") ? false : argslist[p].InnerText.Contains("*");

                    glmthd.arguments.Add(s_pname, new objects.glargument(ispointer, isarray, i_len, s_type));
                }

                glmthd.returntype = Tools.GLTypeConverter(s_return);
                methods.Add(s_name, glmthd);
            }
            if (verbose)
            {
                Console.WriteLine("Parsed Commands: OK");
                Console.WriteLine("    Parsed " + methods.Count + " Commands.");
            }
        }
    }
}
