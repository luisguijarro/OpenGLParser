using System;
namespace OpenGLParser2.objects
{
    public class glargument
    {
        public bool b_pointer;
        public bool b_array;
        public int i_ArraySize; //size of array
        public string s_type;
        public glargument(bool point, bool array, int ArraySize, string type)
        {
            b_pointer = point;
            b_array = array;
            s_type = type;
            i_ArraySize = ArraySize;
        }
    }
}
