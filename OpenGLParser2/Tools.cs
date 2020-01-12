using System;
namespace OpenGLParser2
{
    public static class Tools
    {
        public static string GLTypeConverter(string s_type)
        {
            switch(s_type)
            {
                case "GLboolean":
                    return "Boolean";
                case "GLbitfield":
                    return "UInt32";
                case "GLbyte":
                    return "SByte";
                case "GLshort":
                    return "Int16";
                case "GLint":
                    return "Int32";
                case "GLclampx":
                    return "Int32";
                case "GLubyte":
                    return "Byte";
                case "GLushort":
                    return "UInt16";
                case "GLuint":
                    return "UInt32";
                case "GLsizei":
                    return "Int32";
                case "GLfloat":
                    return "Single";
                case "GLclampf":
                    return "Single";
                case "GLdouble":
                    return "Double";
                case "GLclampd":
                    return "Double";
                case "GLeglClientBufferEXT":
                    return "IntPtr";
                case "GLeglImageOES":
                    return "IntPtr";
                case "GLchar":
                    return "Char";
                case "GLcharARB":
                    return "Char";
                case "GLhandleARB":
                    return "IntPtr";
                case "GLhalfARB":
                    return "UInt16";
                case "GLhalf":
                    return "UInt16";
                case "GLfixed":
                    return "Int32";
                case "GLintptr":
                    return "IntPtr";
                case "GLsizeiptr":
                    return "IntPtr";
                case "GLintptrARB":
                    return "IntPtr";
                case "GLsizeiptrARB":
                    return "IntPtr";
                case "GLint64":
                    return "Int64";
                case "GLuint64":
                    return "UInt64";
                case "GLint64EXT":
                    return "Int64";
                case "GLuint64EXT":
                    return "UInt64";
                case "GLsync": //Struct
                    return "IntPtr";
                case "GLvdpauSurfaceNV":
                    return "IntPtr";
                case "GLhalfNV":
                    return "UInt16";
                default:
                    return s_type;
            }
        }
    }
}
