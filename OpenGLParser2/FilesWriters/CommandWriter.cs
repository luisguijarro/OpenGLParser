using System;
using System.IO;

namespace OpenGLParser2
{
    public static partial class FilesWriter
    {
        public static void CommandWriter(string NameSpace, string outpath, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("Writing: .cs Files of OpenGL Commands by Version.");
            }
            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }
            /*if (!Directory.Exists(outpath + "delegates"))
            {
                Directory.CreateDirectory(outpath + "delegates");
            }*/
            if (!Directory.Exists(outpath + "internals"))
            {
                Directory.CreateDirectory(outpath + "internals");
            }
            WritePublic(NameSpace, outpath, verbose);
            Writedelegate(NameSpace, outpath + "internals/", verbose);
            WriteInternal(NameSpace, outpath + "internals/", verbose);
            WriteIntDelegates(NameSpace, outpath + "internals/", verbose);
        }

        private static void WriteInternal(string NameSpace, string outpath, bool verbose)
        {
            foreach (string keyver in Parsers.VersionParser.version.Keys) //Tour Versions
            {
                if (verbose) { Console.WriteLine("Writing Internal OpenGL " + keyver.Replace('_', '.') + "Commands."); }
                if (File.Exists(outpath + "OpenGL" + keyver + "i.cs"))
                {
                    File.Delete(outpath + "OpenGL" + keyver + "i.cs");
                }
                StreamWriter file = File.CreateText(outpath + "OpenGL" + keyver + "i.cs");
                file.WriteLine("// OpenGL " + keyver.Replace('_', '.') + " Internal Commands.");
                file.WriteLine("// File Created with OpenGL Parser 2.");
                file.WriteLine("// OpenGL Parser 2, Developed by");
                file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
                file.WriteLine();
                file.WriteLine("using System;");
                file.WriteLine();
                file.WriteLine("namespace " + NameSpace + ".OpenGL");
                file.WriteLine("{");
                file.WriteLine("\t" + "internal static class i_OpenGL" + keyver);
                file.WriteLine("\t" + "{");

                for(int v=0;v< Parsers.VersionParser.version[keyver].Commands.Count;v++) //Write Commands
                {
                    string s_name_cmd = Parsers.VersionParser.version[keyver].Commands[v];
                    string command = "\t" + "\t" + "internal static d_OpenGL"+keyver+"."+ s_name_cmd + " "+ s_name_cmd + ";";
                    file.WriteLine(command);
                }
                file.WriteLine("\t" + "}");
                file.WriteLine("}");
                file.WriteLine();
                file.Close();
            }
        }

        private static void Writedelegate(string NameSpace, string outpath, bool verbose)
        {
            foreach (string keyver in Parsers.VersionParser.version.Keys) //Tour Versions
            {
                if (verbose) { Console.WriteLine("Writing Delegates OpenGL " + keyver.Replace('_', '.') + "Commands."); }
                if (File.Exists(outpath + "OpenGL" + keyver + "d.cs"))
                {
                    File.Delete(outpath + "OpenGL" + keyver + "d.cs");
                }
                StreamWriter file = File.CreateText(outpath + "OpenGL" + keyver + "d.cs");
                file.WriteLine("// OpenGL " + keyver.Replace('_', '.') + " delegate Commands.");
                file.WriteLine("// File Created with OpenGL Parser 2.");
                file.WriteLine("// OpenGL Parser 2, Developed by");
                file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
                file.WriteLine();
                file.WriteLine("using System;");
                file.WriteLine();
                file.WriteLine("namespace " + NameSpace + ".OpenGL");
                file.WriteLine("{");
                file.WriteLine("\t" + "internal static class d_OpenGL" + keyver);
                file.WriteLine("\t" + "{");

                //Parsers.VersionParser.version[keyver].Sort();

                for (int v = 0; v < Parsers.VersionParser.version[keyver].Commands.Count; v++) //Write Commands
                {
                    string s_name_cmd = Parsers.VersionParser.version[keyver].Commands[v];
                    string command = "\t" + "\t" + "internal delegate ";
                    command += Parsers.MethodParser.methods[s_name_cmd].returntype + " " + s_name_cmd + "(";

                    foreach (string param in Parsers.MethodParser.methods[s_name_cmd].arguments.Keys)
                    {
                        string s_name_param = param;
                        objects.glargument arg = Parsers.MethodParser.methods[s_name_cmd].arguments[param];

                        if (arg.b_pointer/* && !arg.b_array*/) { command += "ref "; } //POINTER USE REF

                        if (arg.b_array && ((arg.s_type == "char") || (arg.s_type == "Char")))
                        {
                            command += "string "; // + s_name_param;
                        }
                        else
                        {
                            if (Parsers.DelegatesParser.delegates.ContainsKey(arg.s_type))
                            {
                                command += "Delegates.";
                            }
                            command += arg.s_type; // + s_name_param + ", ";
                            if (arg.b_array) { command += " []"; }
                        }
                        command += " " + s_name_param + ", ";
                    }
                    if (Parsers.MethodParser.methods[s_name_cmd].arguments.Count > 0) { command = command.Substring(0, command.Length - 2); }

                    command += ");";
                    file.WriteLine(command);
                    file.WriteLine();
                }
                file.WriteLine("\t" + "}");
                file.WriteLine("}");
                file.WriteLine();
                file.Close();
            }
        }

        private static void WritePublic(string NameSpace, string outpath, bool verbose)
        {
            foreach (string keyver in Parsers.VersionParser.version.Keys) //Tour Versions
            {
                if (verbose) { Console.WriteLine("Writing Public OpenGL " + keyver.Replace('_', '.') + "Commands."); }
                if (File.Exists(outpath + "OpenGL" + keyver + ".cs"))
                {
                    File.Delete(outpath + "OpenGL" + keyver + ".cs");
                }
                StreamWriter file = File.CreateText(outpath + "OpenGL" + keyver + ".cs");
                file.WriteLine("// OpenGL " + keyver.Replace('_', '.') + " Commands.");
                file.WriteLine("// File Created with OpenGL Parser 2.");
                file.WriteLine("// OpenGL Parser 2, Developed by");
                file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
                file.WriteLine();
                file.WriteLine("using System;");
                file.WriteLine("using System.Runtime.InteropServices;");
                file.WriteLine();
                file.WriteLine("namespace " + NameSpace + ".OpenGL");
                file.WriteLine("{");
                file.WriteLine("\t"+"public static class OpenGL"+keyver);
                file.WriteLine("\t" + "{");

                for (int v = 0; v < Parsers.VersionParser.version[keyver].Commands.Count; v++) //Write Commands
                {
                    //bool haveData = false; // Comprovar si tiene data para metodo con struct

                    string s_name_cmd = Parsers.VersionParser.version[keyver].Commands[v];
                    string command = "\t" + "\t" + "public static ";
                    command += Parsers.MethodParser.methods[s_name_cmd].returntype + " " + s_name_cmd + "(";

                    foreach (string param in Parsers.MethodParser.methods[s_name_cmd].arguments.Keys)
                    {
                        string s_name_param = param;
                        //if (s_name_param == "data") { haveData = true; }
                        objects.glargument arg = Parsers.MethodParser.methods[s_name_cmd].arguments[param];

                        if (arg.b_pointer/* && !arg.b_array*/) { command += "ref "; } //POINTER USE REF

                        if (arg.b_array && ((arg.s_type == "char") || (arg.s_type == "Char")))
                        {
                            command += "string "+s_name_param+", ";
                        }
                        else
                        {
                            if (Parsers.DelegatesParser.delegates.ContainsKey(arg.s_type))
                            {
                                command += "Delegates.";
                            }
                            command += arg.s_type;
                            if (arg.b_array) { command += "[]"; }
                            command += " " + s_name_param + ", ";
                        }
                    }
                    if (Parsers.MethodParser.methods[s_name_cmd].arguments.Count > 0) { command = command.Substring(0, command.Length - 2); }

                    command += ")";
                    file.WriteLine(command);
                    file.WriteLine("\t" + "\t" + "{");
                    string privcommand = "\t" + "\t" + "\t"; 
                    if (Parsers.MethodParser.methods[s_name_cmd].returntype != "void") { privcommand += "return "; } //Internal Call
                    privcommand += "i_OpenGL"+keyver+"." + s_name_cmd + "(";

                    foreach (string param in Parsers.MethodParser.methods[s_name_cmd].arguments.Keys)
                    {
                        if (Parsers.MethodParser.methods[s_name_cmd].arguments[param].b_pointer) // && !Parsers.MethodParser.methods[s_name_cmd].arguments[param].b_array)
                        {
                            privcommand += "ref ";
                        }
                        privcommand += param + ", ";
                    }
                    if (Parsers.MethodParser.methods[s_name_cmd].arguments.Count > 0) { privcommand = privcommand.Substring(0, privcommand.Length - 2); }
                    privcommand += ");";
                    file.WriteLine(privcommand);

                    file.WriteLine("\t" + "\t" + "}");

                    if ((s_name_cmd == "glBufferData") || (s_name_cmd == "glBufferSubData"))
                    {
                        string help = "\t" + "\t" + "public static " + Parsers.MethodParser.methods[s_name_cmd].returntype + " " + s_name_cmd + "<T>(";
                        foreach (string param in Parsers.MethodParser.methods[s_name_cmd].arguments.Keys)
                        {
                            string s_name_param = param;
                            objects.glargument arg = Parsers.MethodParser.methods[s_name_cmd].arguments[param];

                            if (s_name_param == "data")
                            {
                                help += "T[] data, ";
                            }
                            else
                            {
                                if (arg.b_pointer/* && !arg.b_array*/) { help += "ref "; } //POINTER USE REF

                                if (arg.b_array && (arg.s_type == "char"))
                                {
                                    help += "string " + s_name_param;
                                }
                                else
                                {
                                    if (Parsers.DelegatesParser.delegates.ContainsKey(arg.s_type))
                                    {
                                        help += "Delegates.";
                                    }
                                    help += arg.s_type;
                                    if (arg.b_array) { help += "[]"; }
                                    help += " " + s_name_param + ", ";
                                }
                            }
                        }
                        if (Parsers.MethodParser.methods[s_name_cmd].arguments.Count > 0) { help = help.Substring(0, help.Length - 2); }

                        help += ") where T : struct";
                        file.WriteLine(help);
                        file.WriteLine("\t" + "\t" + "{");
                        file.WriteLine("\t" + "\t" + "\t" + "GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);");
                        string call = s_name_cmd + "(";
                        foreach (string param in Parsers.MethodParser.methods[s_name_cmd].arguments.Keys)
                        {
                            objects.glargument arg = Parsers.MethodParser.methods[s_name_cmd].arguments[param];
                            if (arg.b_pointer/* && !arg.b_array*/) { call += "ref "; } //POINTER USE REF
                            if (param == "data")
                            {
                                call += "(IntPtr)ptr.AddrOfPinnedObject(), ";
                            }
                            else
                            {
                                call += param + ", ";
                            }
                        }
                        if (Parsers.MethodParser.methods[s_name_cmd].arguments.Count > 0) { call = call.Substring(0, call.Length - 2); }
                        file.WriteLine("\t" + "\t" + "\t" + call + ");");
                        file.WriteLine("\t" + "\t" + "\t" + "ptr.Free();");
                        file.WriteLine("\t" + "\t" + "}");
                    }
                }

                file.WriteLine("\t" + "}");
                file.WriteLine("}");
                file.WriteLine();
                file.Close();
                if (verbose) { Console.WriteLine("Writed " + Parsers.VersionParser.version[keyver].Commands.Count + " commands in file " + "OpenGL" + keyver + ".cs"); }
            }
        }

        private static void WriteIntDelegates(string NameSpace, string outpath, bool verbose)
        {
            foreach (string keyver in Parsers.VersionParser.version.Keys) //Tour Versions
            {
                if (verbose) { Console.WriteLine("Writing Intit Delegates for OpenGL " + keyver.Replace('_', '.') + "Commands."); }
                if (File.Exists(outpath + "OpenGL" + keyver + "id.cs"))
                {
                    File.Delete(outpath + "OpenGL" + keyver + "id.cs");
                }
                StreamWriter file = File.CreateText(outpath + "OpenGL" + keyver + "id.cs");
                file.WriteLine("// OpenGL " + keyver.Replace('_', '.') + " Init Delegates Commands.");
                file.WriteLine("// File Created with OpenGL Parser 2.");
                file.WriteLine("// OpenGL Parser 2, Developed by");
                file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
                file.WriteLine();
                file.WriteLine("using System;");
                file.WriteLine();
                file.WriteLine("namespace " + NameSpace + ".OpenGL");
                file.WriteLine("{");
                file.WriteLine("\t" + "internal static partial class id_OpenGL"); // + keyver);
                file.WriteLine("\t" + "{");
                file.WriteLine("\t" + "\t" + "internal static void InitDelGL" + keyver + "()");
                file.WriteLine("\t" + "\t" + "{");

                objects.glVersion glv = Parsers.VersionParser.version[keyver];
                for (int i=0; i<glv.Commands.Count;i++)
                {
                    //glv.Commands[i];
                    file.WriteLine("\t" + "\t" + "\t" + NameSpace + ".OpenGL.i_OpenGL" + keyver + "." + glv.Commands[i] + " = (" + NameSpace + ".OpenGL.d_OpenGL" + keyver + "." + glv.Commands[i] + ")glTools.GetGLMethodAdress(\"" + glv.Commands[i] + "\", typeof(" + NameSpace + ".OpenGL.d_OpenGL" + keyver + "." + glv.Commands[i] + "));");
                }

                file.WriteLine("\t" + "\t" + "}");
                file.WriteLine("\t" + "}");
                file.WriteLine("}");
                file.WriteLine();
                file.Close();
                if (verbose) { Console.WriteLine("Writing Intit Delegates for OpenGL " + keyver.Replace('_', '.') + "Commands."); }
            }
        }
    }
}