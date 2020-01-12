using System;
using System.IO;

namespace OpenGLParser2
{
    public static partial class FilesWriter
    {
        public static void EnumWriter(string NameSpace, string outpath, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("Writing: Enums.cs File.");
            }
            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }
            if (File.Exists(outpath + "Enums.cs"))
            {
                File.Delete(outpath + "Enums.cs");
            }
            StreamWriter file = File.CreateText(outpath + "Enums.cs");
            file.WriteLine("// OpenGL Enumerators.");
            file.WriteLine("// File Created with OpenGL Parser 2.");
            file.WriteLine("// OpenGL Parser 2, Developed by");
            file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
            file.WriteLine();

            file.WriteLine("using System;");
            file.WriteLine();
            file.WriteLine("namespace " + NameSpace + ".OpenGL");
            file.WriteLine("{");

            foreach (string name in Parsers.EnumParser.groups.Keys)
            {
                string s_val = "uint";
                foreach (string val in Parsers.EnumParser.groups[name].values.Keys)
                {
                    ulong u_val = 0;
                    try
                    {
                        u_val = Convert.ToUInt64(Parsers.EnumParser.groups[name].values[val], 16);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("VAL: " + val + ": " + Parsers.EnumParser.groups[name].values[val]);
                        Console.WriteLine(e);
                    }
                    if (u_val > uint.MaxValue)
                    {
                        s_val = "ulong";
                    }
                }


                file.WriteLine("\t" + "public enum " + name + " : " + s_val);
                file.WriteLine("\t{");
                foreach (string val in Parsers.EnumParser.groups[name].values.Keys)
                {
                    string s_value = "\t\t";
                    s_value += val + " = " + Parsers.EnumParser.groups[name].values[val] + ",";
                    file.WriteLine(s_value);
                }
                file.WriteLine("\t}");
                file.WriteLine();
            }
            file.WriteLine("}");
            file.WriteLine();
            file.Close();

            if (verbose)
            {
                Console.WriteLine("Writed: Enums.cs File.");
            }
        }

        public static void glEnumWriter(string NameSpace, string outpath, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("Writing: GLenum.cs File.");
            }
            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }
            if (File.Exists(outpath + "GLenum.cs"))
            {
                File.Delete(outpath + "GLenum.cs");
            }
            StreamWriter file = File.CreateText(outpath + "GLenum.cs");
            file.WriteLine("// OpenGL Enumerators.");
            file.WriteLine("// File Created with OpenGL Parser 2.");
            file.WriteLine("// OpenGL Parser 2, Developed by");
            file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
            file.WriteLine();

            file.WriteLine("using System;");
            file.WriteLine();
            file.WriteLine("namespace " + NameSpace + ".OpenGL");
            file.WriteLine("{");

            file.WriteLine("\t" + "public enum GLenum : ulong");
            file.WriteLine("\t{");
            foreach (string val in Parsers.EnumParser.values.Keys)
            {
                bool isnegative = false;
                try
                {
                    Convert.ToInt64(Parsers.EnumParser.values[val], 16);
                }
                catch(Exception e)
                {
                    isnegative = true;
                }
                if (!isnegative)
                {
                    string s_value = "\t\t";
                    s_value += val + " = " + Parsers.EnumParser.values[val] + ",";
                    file.WriteLine(s_value);
                }
            }
            file.WriteLine("\t}");
            file.WriteLine();
            file.WriteLine("}");
            file.WriteLine();
            file.Close();

            if (verbose)
            {
                Console.WriteLine("Writed: GLenum.cs File.");
            }
        }
    }
}
