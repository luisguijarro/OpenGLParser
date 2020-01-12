using System;
using System.IO;

namespace OpenGLParser2
{
    public static partial class FilesWriter
    {
        public static void GetAdressMethodWriter(string NameSpace, string outpath, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("Writing: GetGLMethodAdress.cs File.");
            }
            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }
            if (File.Exists(outpath + "GetGLMethodAdress.cs"))
            {
                File.Delete(outpath + "GetGLMethodAdress.cs");
            }
            StreamWriter file = File.CreateText(outpath + "GetGLMethodAdress.cs");
            file.WriteLine("// OpenGL Enumerators.");
            file.WriteLine("// File Created with OpenGL Parser 2.");
            file.WriteLine("// OpenGL Parser 2, Developed by");
            file.WriteLine("// BROTHERHOOD OF THE BLACK SWORD.");
            //file.WriteLine();
            string s_file = @"
using System;
using System.Runtime.InteropServices;

namespace " + NameSpace + @".OpenGL
{
    internal static partial class glTools
    {
        internal static IntPtr lib;
        internal static Delegate GetGLMethodAdress(String MethodName, Type type_origen)
        {
            
            IntPtr p_ret = IntPtr.Zero;
            switch(fgtk.Platforms.Tools.GetPlatform())
            {
                case Platforms.Platform.Windows:
                    if (lib == IntPtr.Zero)
                    {
                        lib = Platforms.Win32.Imports.LoadLibrary(""opengl32.dll"");
                    }
                    p_ret = Platforms.Win32.wgl.wglGetProcAddress(MethodName);
                    if (p_ret == IntPtr.Zero)
                    {
                        p_ret = Platforms.Win32.Imports.GetProcAddress(lib, MethodName);
                    }
                    break;
                case Platforms.Platform.Linux_X11:
                    p_ret = Platforms.X11.glx.glXGetProcAddress(MethodName);
                    break;
                default:                    
                    p_ret = IntPtr.Zero;
                    break;
            }           
            
            if (p_ret != IntPtr.Zero)
            {
                return Marshal.GetDelegateForFunctionPointer(p_ret, type_origen);
            }
            else
            {
                throw new Exception(""The delegate of method ""+MethodName+"" was not can getted."");
                //return null;
            }
        }
    }
}";
            file.WriteLine(s_file);
            file.Close();
        }
    }
}
