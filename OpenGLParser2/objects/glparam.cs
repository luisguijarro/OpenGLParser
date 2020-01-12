using System;
namespace OpenGLParser2.objects
{
    public class glparam
    {
        public string ptype;
        public bool IsPointer;
        public glparam(string p_type, bool isPointer)
        {
            this.ptype = p_type;
            this.IsPointer = isPointer;
        }
    }
}
