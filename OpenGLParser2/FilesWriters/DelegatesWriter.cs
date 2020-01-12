using System;
using System.IO;

namespace OpenGLParser2
{
    public static partial class FilesWriter
    {
        public static void DelegatesWriter(string NameSpace, string outpath, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("Writing: Dlgts.cs File.");
            }
            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }
            if (File.Exists(outpath + "Dlgts.cs"))
            {
                File.Delete(outpath + "Dlgts.cs");
            }
            StreamWriter file = File.CreateText(outpath + "Dlgts.cs");
            file.WriteLine("// OpenGL Delegates.");
            file.WriteLine("// File Created with OpenGL Parser 2.");
            file.WriteLine("// OpenGL Parser 2, Developed by");
            file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
            file.WriteLine();

            file.WriteLine("using System;");
            file.WriteLine();
            file.WriteLine("namespace " + NameSpace + ".OpenGL");
            file.WriteLine("{");
            file.WriteLine("\t" + "public static class Delegates");
            file.WriteLine("\t" + "{");

            foreach(string dlgt in Parsers.DelegatesParser.delegates.Keys)
            {
                string s_delegate = "public delegate IntPtr " + dlgt + " (";

                foreach (string prm in Parsers.DelegatesParser.delegates[dlgt].Params.Keys)
                {
                    objects.glparam glprm = Parsers.DelegatesParser.delegates[dlgt].Params[prm];
                    if (glprm.IsPointer)
                    {
                        if (glprm.ptype != "void")
                        {
                            s_delegate += "ref ";
                        }
                        else
                        {
                            glprm.ptype = "IntPtr";
                        }
                    }
                    s_delegate += glprm.ptype + " " + prm + ", ";
                }
                if (Parsers.DelegatesParser.delegates[dlgt].Params.Count > 0)
                {
                    s_delegate = s_delegate.Substring(0, s_delegate.Length - 2);
                }
                s_delegate += ");";

                file.WriteLine("\t" + "\t" + s_delegate);
            }

            file.WriteLine("\t" + "}");
            file.WriteLine("}");
            file.WriteLine();
            file.Close();
            if (verbose)
            {
                Console.WriteLine("Writed: Dlgts.cs File.");
            }
        }
    }
}
