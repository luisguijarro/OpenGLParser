using System;
using System.IO;

namespace OpenGLParser2
{
    public static partial class FilesWriter
    {
        public static void InitGLDelegatesWriter(string NameSpace, string outpath, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("Writing: InitDelGL.cs File.");
            }
            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }
            if (File.Exists(outpath + "InitDelGL.cs"))
            {
                File.Delete(outpath + "InitDelGL.cs");
            }
            StreamWriter file = File.CreateText(outpath + "InitDelGL.cs");
            file.WriteLine("// OpenGL InitDelegates.");
            file.WriteLine("// File Created with OpenGL Parser 2.");
            file.WriteLine("// OpenGL Parser 2, Developed by");
            file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
            file.WriteLine();

            file.WriteLine("using System;");
            file.WriteLine();
            file.WriteLine("namespace " + NameSpace + ".OpenGL");
            file.WriteLine("{");

            file.WriteLine("\t" + "internal static partial class glTools");
            file.WriteLine("\t" + "{");
            file.WriteLine("\t" + "\t" + "internal static void InitGLDelegates(string glversion)");
            file.WriteLine("\t" + "\t" + "{");
            file.WriteLine("\t" + "\t" + "\t" + "InitGLDelegates(glversion, true);");
            file.WriteLine("\t" + "\t" + "}");
            file.WriteLine();
            file.WriteLine("\t" + "\t" + "internal static void InitGLDelegates(string glversion, bool backward_compatibility)");
            file.WriteLine("\t" + "\t" + "{");
            file.WriteLine("\t" + "\t" + "\t" + "switch(glversion)");
            file.WriteLine("\t" + "\t" + "\t" + "{");
            bool isnotOne = false;
            foreach (string keyver in Parsers.VersionParser.version.Keys) //Tour Versions
            {
                int[] i_version = new int[] { int.Parse(keyver.Split('_')[0]), int.Parse(keyver.Split('_')[1]) };
                file.WriteLine("\t" + "\t" + "\t" + "\t" + "case \"" + keyver + "\":");
                if (isnotOne)
                {
                    file.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "if (backward_compatibility)");
                    file.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "{");
                }
                for (int v=0;v<Parsers.VersionParser.versions.Count;v++)
                {
                    int[] i_miniver = new int[] { int.Parse(Parsers.VersionParser.versions[v].Split('_')[0]), int.Parse(Parsers.VersionParser.versions[v].Split('_')[1]) };

                    if (i_miniver[0] < i_version[0])
                    {
                        file.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "id_OpenGL.InitDelGL" + Parsers.VersionParser.versions[v]+"();");
                    }
                    else if ((i_miniver[0] == i_version[0]))
                    {
                        if (i_miniver[1] == i_version[1])
                        {
                            if (isnotOne)
                            {
                                file.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "}");
                            }
                        }
                        if (i_miniver[1] == i_version[1])
                        {
                            file.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "id_OpenGL.InitDelGL" + Parsers.VersionParser.versions[v] + "();");
                        }
                        else if (i_miniver[1] < i_version[1])
                        {
                            file.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "id_OpenGL.InitDelGL" + Parsers.VersionParser.versions[v] + "();");
                        }
                    }
                }
                file.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "break;");
                if (!isnotOne) { isnotOne = true; }
            }
            file.WriteLine("\t" + "\t" + "\t" + "}");


            file.WriteLine("\t" + "\t" + "}");
            file.WriteLine("\t" + "}");
            file.WriteLine("}");
            file.WriteLine();
            file.Close();
        }
    }
}
