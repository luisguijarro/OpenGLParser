// OpenGL InitDelegates.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;

namespace fgtk.OpenGL
{
	internal static partial class glTools
	{
		internal static void InitGLDelegates(string glversion)
		{
			InitGLDelegates(glversion, true);
		}

		internal static void InitGLDelegates(string glversion, bool backward_compatibility)
		{
			switch(glversion)
			{
				case "1_0":
					id_OpenGL.InitDelGL1_0();
					break;
				case "1_1":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
					}
					id_OpenGL.InitDelGL1_1();
					break;
				case "1_2":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
					}
					id_OpenGL.InitDelGL1_2();
					break;
				case "1_3":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
					}
					id_OpenGL.InitDelGL1_3();
					break;
				case "1_4":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
					}
					id_OpenGL.InitDelGL1_4();
					break;
				case "1_5":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
					}
					id_OpenGL.InitDelGL1_5();
					break;
				case "2_0":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
					}
					id_OpenGL.InitDelGL2_0();
					break;
				case "2_1":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
					}
					id_OpenGL.InitDelGL2_1();
					break;
				case "3_0":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
					}
					id_OpenGL.InitDelGL3_0();
					break;
				case "3_1":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
					}
					id_OpenGL.InitDelGL3_1();
					break;
				case "3_2":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
					}
					id_OpenGL.InitDelGL3_2();
					break;
				case "3_3":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
						id_OpenGL.InitDelGL3_2();
					}
					id_OpenGL.InitDelGL3_3();
					break;
				case "4_0":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
						id_OpenGL.InitDelGL3_2();
						id_OpenGL.InitDelGL3_3();
					}
					id_OpenGL.InitDelGL4_0();
					break;
				case "4_1":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
						id_OpenGL.InitDelGL3_2();
						id_OpenGL.InitDelGL3_3();
						id_OpenGL.InitDelGL4_0();
					}
					id_OpenGL.InitDelGL4_1();
					break;
				case "4_2":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
						id_OpenGL.InitDelGL3_2();
						id_OpenGL.InitDelGL3_3();
						id_OpenGL.InitDelGL4_0();
						id_OpenGL.InitDelGL4_1();
					}
					id_OpenGL.InitDelGL4_2();
					break;
				case "4_3":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
						id_OpenGL.InitDelGL3_2();
						id_OpenGL.InitDelGL3_3();
						id_OpenGL.InitDelGL4_0();
						id_OpenGL.InitDelGL4_1();
						id_OpenGL.InitDelGL4_2();
					}
					id_OpenGL.InitDelGL4_3();
					break;
				case "4_4":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
						id_OpenGL.InitDelGL3_2();
						id_OpenGL.InitDelGL3_3();
						id_OpenGL.InitDelGL4_0();
						id_OpenGL.InitDelGL4_1();
						id_OpenGL.InitDelGL4_2();
						id_OpenGL.InitDelGL4_3();
					}
					id_OpenGL.InitDelGL4_4();
					break;
				case "4_5":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
						id_OpenGL.InitDelGL3_2();
						id_OpenGL.InitDelGL3_3();
						id_OpenGL.InitDelGL4_0();
						id_OpenGL.InitDelGL4_1();
						id_OpenGL.InitDelGL4_2();
						id_OpenGL.InitDelGL4_3();
						id_OpenGL.InitDelGL4_4();
					}
					id_OpenGL.InitDelGL4_5();
					break;
				case "4_6":
					if (backward_compatibility)
					{
						id_OpenGL.InitDelGL1_0();
						id_OpenGL.InitDelGL1_1();
						id_OpenGL.InitDelGL1_2();
						id_OpenGL.InitDelGL1_3();
						id_OpenGL.InitDelGL1_4();
						id_OpenGL.InitDelGL1_5();
						id_OpenGL.InitDelGL2_0();
						id_OpenGL.InitDelGL2_1();
						id_OpenGL.InitDelGL3_0();
						id_OpenGL.InitDelGL3_1();
						id_OpenGL.InitDelGL3_2();
						id_OpenGL.InitDelGL3_3();
						id_OpenGL.InitDelGL4_0();
						id_OpenGL.InitDelGL4_1();
						id_OpenGL.InitDelGL4_2();
						id_OpenGL.InitDelGL4_3();
						id_OpenGL.InitDelGL4_4();
						id_OpenGL.InitDelGL4_5();
					}
					id_OpenGL.InitDelGL4_6();
					break;
			}
		}
	}
}

