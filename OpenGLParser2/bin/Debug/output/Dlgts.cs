// OpenGL Delegates.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;

namespace fgtk.OpenGL
{
	public static class Delegates
	{
		public delegate IntPtr GLDEBUGPROC (GLenum source, GLenum type, UInt32 id, GLenum severity, Int32 length, ref string message, IntPtr userParam);
		public delegate IntPtr GLDEBUGPROCARB (GLenum source, GLenum type, UInt32 id, GLenum severity, Int32 length, ref string message, IntPtr userParam);
		public delegate IntPtr GLDEBUGPROCKHR (GLenum source, GLenum type, UInt32 id, GLenum severity, Int32 length, ref string message, IntPtr userParam);
		public delegate IntPtr GLDEBUGPROCAMD (UInt32 id, GLenum category, GLenum severity, Int32 length, ref string message, IntPtr userParam);
		public delegate IntPtr GLVULKANPROCNV ();
	}
}

