using System;
using System.Xml;

namespace OpenGLParser2
{
    public static class glParser
    {
        private static XmlDocument xdoc;
        public static void Parse(string rutaxml, string @namespace, string destination, bool verbose)
        {
            xdoc = new XmlDocument();
            xdoc.Load(rutaxml);
            Parsers.EnumParser.Parse(xdoc, verbose);
            Parsers.MethodParser.Parse(xdoc, verbose);
            Parsers.VersionParser.Parse(xdoc, verbose);
            Parsers.DelegatesParser.Parse(xdoc, verbose);

            FilesWriter.EnumWriter(@namespace, destination, verbose);
            FilesWriter.glEnumWriter(@namespace, destination, verbose);
            FilesWriter.CommandWriter(@namespace, destination, verbose);
            FilesWriter.InitGLDelegatesWriter(@namespace, destination, verbose);
            FilesWriter.DelegatesWriter(@namespace, destination, verbose);
            FilesWriter.GetAdressMethodWriter(@namespace, destination, verbose);
        }
    }
}
