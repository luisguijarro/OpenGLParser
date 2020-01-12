using System;
using System.Xml;
using System.Collections.Generic;

namespace OpenGLParser2.Parsers
{
    public static class DelegatesParser
    {
        public static Dictionary<string, objects.gldelegate> delegates;
        public static void Parse(XmlDocument xdoc, bool verbose)
        {
            if (verbose) { Console.WriteLine("Parsing Enumerators:"); }
            delegates = new Dictionary<string, objects.gldelegate>();
            XmlNodeList xnl_apientries =  xdoc.SelectNodes("registry/types/type/apientry");

            foreach (XmlNode node in xnl_apientries)
            {
                objects.gldelegate dlgt = new objects.gldelegate();

                XmlNode true_node = node.ParentNode;
                string s_name = true_node.SelectSingleNode("name").InnerText;

                string[] s_params = true_node.InnerText.Split('(')[2].Replace(");", "").Replace("const ", "").Split(',');
                for (int i=0;i< s_params.Length;i++)
                {
                    string s_paramtype = s_params[i].Split(' ')[0];
                    if (s_params[i].Split(' ').Length > 1)
                    {
                        string s_paramname = s_params[i].Split(' ')[1];
                        s_paramtype = Tools.GLTypeConverter(s_paramtype);
                        bool IsPointer = s_paramname.Contains("*");
                        s_paramname = s_paramname.Replace("*", "");

                        if (s_paramtype == "Char" && IsPointer)
                        {
                            s_paramtype = "string";
                        }
                        dlgt.Params.Add(s_paramname, new objects.glparam(s_paramtype, IsPointer)); //ADD PARAMS TO DELEGATE
                    }
                }
                delegates.Add(s_name, dlgt); //ADD DELEGATE TO DICTIONARY
            }
            if (verbose) { Console.WriteLine("Parsed Dalegates: OK"); }
            if (verbose) { Console.WriteLine("   Parsed " + xnl_apientries.Count + "Dalegates"); }
        }
    }
}
