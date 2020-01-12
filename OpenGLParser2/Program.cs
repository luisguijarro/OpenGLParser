using System;

namespace OpenGLParser2
{
    class MainClass
    {
        static bool verbose;
        static bool download;
        static bool ayuda;
        static string output;
        static string s_namespace;
        public static void Main(string[] args)
        {
            Console.WriteLine("OpenGLParser!");
            output = "./output/";
            s_namespace = "OpenGL";
            for (int i=0; i<args.Length; i++)
            {
                string arg = args[i];
                switch (arg)
                {
                    case "-v":
                        verbose = true;
                        break;
                    case "-V":
                        verbose = true;
                        break;
                    case "-d":
                        download = true;
                        break;
                    case "-D":
                        download = true;
                        break;
                    case "-o":
                        output = args[i + 1];
                        i++;
                        break;
                    case "-O":
                        output = args[i + 1];
                        i++;
                        break;
                    case "-n":
                        s_namespace = args[i + 1];
                        i++;
                        break;
                    case "-N":
                        s_namespace = args[i + 1];
                        i++;
                        break;
                    case "-h":
                        ayuda = true;
                        break;
                    case "--help":
                        ayuda = true;
                        break;
                }
            }
            if (ayuda)
            {
                ShowHelp();
            }
            else
            {
                if (download)
                {
                    Download_glxml();
                }
                glParser.Parse("./gl.xml", s_namespace, output, verbose);
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine("Help Output:");
            Console.WriteLine("========================================================");
            Console.WriteLine("oglp2 [OPTION] <option value>");
            Console.WriteLine("Arguments:");
            Console.WriteLine("  -v  -> Verbose Mode.");
            Console.WriteLine("  -d  -> Download new gl.xml file.");
            Console.WriteLine("         If gl.xml file dont exist -d is by default.");
            Console.WriteLine("  -o  -> Output Path of .cs Files. (./output/ by default)");
            Console.WriteLine("  -n  -> NameSpace of .cs Files. (OpenGL by default)");
            Console.WriteLine("  -h  -> Show this Help.");
        }

        private static void Download_glxml()
        {
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                wc.DownloadProgressChanged += delegate (object o_sender, System.Net.DownloadProgressChangedEventArgs f)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("Downloading: (");
                    for (int i=0;i<20;i++)
                    {
                        string progreschar = " ";
                        if (i<= (f.ProgressPercentage/20))
                        {
                            progreschar = "=";
                        }
                        Console.Write(progreschar);
                    }
                    Console.Write(") "+ f.ProgressPercentage.ToString() + "%");
                };
                wc.DownloadFileCompleted += delegate (object d_sender, System.ComponentModel.AsyncCompletedEventArgs f2)
                {
                    if (f2.Cancelled)
                    {
                        Console.WriteLine("Descarga de gl.xml Cancelada");
                    }
                    if (f2.Error != null)
                    {
                        Console.WriteLine(/*f2.Error.Message, */"Error en descarga de gl.xml");
                    }
                    if ((f2.Error == null) && (!f2.Cancelled))
                    {
                        if (System.IO.File.Open("./gl.xml.temp", System.IO.FileMode.Open).Length > 0)
                        {
                            System.IO.File.Replace("./gl.xml.temp", "./gl.xml", "./gl.xml.old");
                            System.IO.File.Delete("./gl.xml.temp");
                            Console.WriteLine("Descarga de gl.xml Realizada con Exito");
                        }
                        else
                        {
                            System.IO.File.Delete("./gl.xml.temp");
                            Console.WriteLine(f2.Error.Message, "Error en descarga de gl.xml");
                        }
                    }
                };

                if (System.IO.File.Exists("./gl.xml"))
                {
                    Console.WriteLine("Ya tiene descargada una versión del archivo gl.xml");
                    Console.Write("¿Desea realmente descargarlo nuevamente?(s/N):");
                    Console.WriteLine();
                    if (Console.ReadKey().KeyChar != 's')
                    {
                        return;
                    }
                }

                Console.WriteLine("Descargando gl.xml desde repositorio oficial.");
                //wc.UseDefaultCredentials = false;
                wc.Proxy = System.Net.WebRequest.GetSystemWebProxy();
                wc.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                //MessageBox.Show(wc.Proxy.ToString());
                Uri uri = new Uri("https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml");
                //wc.DownloadFile(uri, "./gl.xml.temp");
                wc.DownloadFileAsync(uri, "./gl.xml.temp");

                //Console.WriteLine("Archivo gl.xml descargado.");
            }
        }
    }
}
