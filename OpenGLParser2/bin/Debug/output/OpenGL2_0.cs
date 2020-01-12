// OpenGL 2.0 Commands.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;
using System.Runtime.InteropServices;

namespace fgtk.OpenGL
{
	public static class OpenGL2_0
	{
		public static void glAccum(AccumOp op, Single value)
		{
			i_OpenGL2_0.glAccum(op, value);
		}
		public static void glActiveTexture(TextureUnit texture)
		{
			i_OpenGL2_0.glActiveTexture(texture);
		}
		public static void glAlphaFunc(AlphaFunction func, Single @ref)
		{
			i_OpenGL2_0.glAlphaFunc(func, @ref);
		}
		public static Boolean glAreTexturesResident(Int32 n, ref UInt32[] textures, ref Boolean[] residences)
		{
			return i_OpenGL2_0.glAreTexturesResident(n, ref textures, ref residences);
		}
		public static void glArrayElement(Int32 i)
		{
			i_OpenGL2_0.glArrayElement(i);
		}
		public static void glAttachShader(UInt32 program, UInt32 shader)
		{
			i_OpenGL2_0.glAttachShader(program, shader);
		}
		public static void glBegin(PrimitiveType mode)
		{
			i_OpenGL2_0.glBegin(mode);
		}
		public static void glBeginQuery(QueryTarget target, UInt32 id)
		{
			i_OpenGL2_0.glBeginQuery(target, id);
		}
		public static void glBindAttribLocation(UInt32 program, UInt32 index, ref Char name)
		{
			i_OpenGL2_0.glBindAttribLocation(program, index, ref name);
		}
		public static void glBindBuffer(BufferTargetARB target, UInt32 buffer)
		{
			i_OpenGL2_0.glBindBuffer(target, buffer);
		}
		public static void glBindTexture(TextureTarget target, UInt32 texture)
		{
			i_OpenGL2_0.glBindTexture(target, texture);
		}
		public static void glBitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, ref Byte[] bitmap)
		{
			i_OpenGL2_0.glBitmap(width, height, xorig, yorig, xmove, ymove, ref bitmap);
		}
		public static void glBlendColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL2_0.glBlendColor(red, green, blue, alpha);
		}
		public static void glBlendEquation(BlendEquationModeEXT mode)
		{
			i_OpenGL2_0.glBlendEquation(mode);
		}
		public static void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			i_OpenGL2_0.glBlendEquationSeparate(modeRGB, modeAlpha);
		}
		public static void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			i_OpenGL2_0.glBlendFunc(sfactor, dfactor);
		}
		public static void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
		{
			i_OpenGL2_0.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		public static void glBufferData(BufferTargetARB target, IntPtr size, IntPtr data, BufferUsageARB usage)
		{
			i_OpenGL2_0.glBufferData(target, size, data, usage);
		}
		public static void glBufferData<T>(BufferTargetARB target, IntPtr size, T[] data, BufferUsageARB usage) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			glBufferData(target, size, (IntPtr)ptr.AddrOfPinnedObject(), usage);
			ptr.Free();
		}
		public static void glBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL2_0.glBufferSubData(target, offset, size, data);
		}
		public static void glBufferSubData<T>(BufferTargetARB target, IntPtr offset, IntPtr size, T[] data) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			glBufferSubData(target, offset, size, (IntPtr)ptr.AddrOfPinnedObject());
			ptr.Free();
		}
		public static void glCallList(UInt32 list)
		{
			i_OpenGL2_0.glCallList(list);
		}
		public static void glCallLists(Int32 n, ListNameType type, IntPtr lists)
		{
			i_OpenGL2_0.glCallLists(n, type, lists);
		}
		public static void glClear(UInt32 mask)
		{
			i_OpenGL2_0.glClear(mask);
		}
		public static void glClearAccum(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL2_0.glClearAccum(red, green, blue, alpha);
		}
		public static void glClearColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL2_0.glClearColor(red, green, blue, alpha);
		}
		public static void glClearDepth(Double depth)
		{
			i_OpenGL2_0.glClearDepth(depth);
		}
		public static void glClearIndex(Single c)
		{
			i_OpenGL2_0.glClearIndex(c);
		}
		public static void glClearStencil(Int32 s)
		{
			i_OpenGL2_0.glClearStencil(s);
		}
		public static void glClientActiveTexture(TextureUnit texture)
		{
			i_OpenGL2_0.glClientActiveTexture(texture);
		}
		public static void glClipPlane(ClipPlaneName plane, ref Double[] equation)
		{
			i_OpenGL2_0.glClipPlane(plane, ref equation);
		}
		public static void glColor3b(SByte red, SByte green, SByte blue)
		{
			i_OpenGL2_0.glColor3b(red, green, blue);
		}
		public static void glColor3bv(ref SByte[] v)
		{
			i_OpenGL2_0.glColor3bv(ref v);
		}
		public static void glColor3d(Double red, Double green, Double blue)
		{
			i_OpenGL2_0.glColor3d(red, green, blue);
		}
		public static void glColor3dv(ref Double[] v)
		{
			i_OpenGL2_0.glColor3dv(ref v);
		}
		public static void glColor3f(Single red, Single green, Single blue)
		{
			i_OpenGL2_0.glColor3f(red, green, blue);
		}
		public static void glColor3fv(ref Single[] v)
		{
			i_OpenGL2_0.glColor3fv(ref v);
		}
		public static void glColor3i(Int32 red, Int32 green, Int32 blue)
		{
			i_OpenGL2_0.glColor3i(red, green, blue);
		}
		public static void glColor3iv(ref Int32[] v)
		{
			i_OpenGL2_0.glColor3iv(ref v);
		}
		public static void glColor3s(Int16 red, Int16 green, Int16 blue)
		{
			i_OpenGL2_0.glColor3s(red, green, blue);
		}
		public static void glColor3sv(ref Int16[] v)
		{
			i_OpenGL2_0.glColor3sv(ref v);
		}
		public static void glColor3ub(Byte red, Byte green, Byte blue)
		{
			i_OpenGL2_0.glColor3ub(red, green, blue);
		}
		public static void glColor3ubv(ref Byte[] v)
		{
			i_OpenGL2_0.glColor3ubv(ref v);
		}
		public static void glColor3ui(UInt32 red, UInt32 green, UInt32 blue)
		{
			i_OpenGL2_0.glColor3ui(red, green, blue);
		}
		public static void glColor3uiv(ref UInt32[] v)
		{
			i_OpenGL2_0.glColor3uiv(ref v);
		}
		public static void glColor3us(UInt16 red, UInt16 green, UInt16 blue)
		{
			i_OpenGL2_0.glColor3us(red, green, blue);
		}
		public static void glColor3usv(ref UInt16[] v)
		{
			i_OpenGL2_0.glColor3usv(ref v);
		}
		public static void glColor4b(SByte red, SByte green, SByte blue, SByte alpha)
		{
			i_OpenGL2_0.glColor4b(red, green, blue, alpha);
		}
		public static void glColor4bv(ref SByte[] v)
		{
			i_OpenGL2_0.glColor4bv(ref v);
		}
		public static void glColor4d(Double red, Double green, Double blue, Double alpha)
		{
			i_OpenGL2_0.glColor4d(red, green, blue, alpha);
		}
		public static void glColor4dv(ref Double[] v)
		{
			i_OpenGL2_0.glColor4dv(ref v);
		}
		public static void glColor4f(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL2_0.glColor4f(red, green, blue, alpha);
		}
		public static void glColor4fv(ref Single[] v)
		{
			i_OpenGL2_0.glColor4fv(ref v);
		}
		public static void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			i_OpenGL2_0.glColor4i(red, green, blue, alpha);
		}
		public static void glColor4iv(ref Int32[] v)
		{
			i_OpenGL2_0.glColor4iv(ref v);
		}
		public static void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha)
		{
			i_OpenGL2_0.glColor4s(red, green, blue, alpha);
		}
		public static void glColor4sv(ref Int16[] v)
		{
			i_OpenGL2_0.glColor4sv(ref v);
		}
		public static void glColor4ub(Byte red, Byte green, Byte blue, Byte alpha)
		{
			i_OpenGL2_0.glColor4ub(red, green, blue, alpha);
		}
		public static void glColor4ubv(ref Byte[] v)
		{
			i_OpenGL2_0.glColor4ubv(ref v);
		}
		public static void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha)
		{
			i_OpenGL2_0.glColor4ui(red, green, blue, alpha);
		}
		public static void glColor4uiv(ref UInt32[] v)
		{
			i_OpenGL2_0.glColor4uiv(ref v);
		}
		public static void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha)
		{
			i_OpenGL2_0.glColor4us(red, green, blue, alpha);
		}
		public static void glColor4usv(ref UInt16[] v)
		{
			i_OpenGL2_0.glColor4usv(ref v);
		}
		public static void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
		{
			i_OpenGL2_0.glColorMask(red, green, blue, alpha);
		}
		public static void glColorMaterial(MaterialFace face, ColorMaterialParameter mode)
		{
			i_OpenGL2_0.glColorMaterial(face, mode);
		}
		public static void glColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glColorPointer(size, type, stride, pointer);
		}
		public static void glCompileShader(UInt32 shader)
		{
			i_OpenGL2_0.glCompileShader(shader);
		}
		public static void glCompressedTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL2_0.glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		}
		public static void glCompressedTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL2_0.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}
		public static void glCompressedTexImage3D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL2_0.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public static void glCompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL2_0.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		}
		public static void glCompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL2_0.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public static void glCompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL2_0.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public static void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelCopyType type)
		{
			i_OpenGL2_0.glCopyPixels(x, y, width, height, type);
		}
		public static void glCopyTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			i_OpenGL2_0.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}
		public static void glCopyTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			i_OpenGL2_0.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}
		public static void glCopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			i_OpenGL2_0.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}
		public static void glCopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL2_0.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}
		public static void glCopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL2_0.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		public static UInt32 glCreateProgram()
		{
			return i_OpenGL2_0.glCreateProgram();
		}
		public static UInt32 glCreateShader(ShaderType type)
		{
			return i_OpenGL2_0.glCreateShader(type);
		}
		public static void glCullFace(CullFaceMode mode)
		{
			i_OpenGL2_0.glCullFace(mode);
		}
		public static void glDeleteBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL2_0.glDeleteBuffers(n, ref buffers);
		}
		public static void glDeleteLists(UInt32 list, Int32 range)
		{
			i_OpenGL2_0.glDeleteLists(list, range);
		}
		public static void glDeleteProgram(UInt32 program)
		{
			i_OpenGL2_0.glDeleteProgram(program);
		}
		public static void glDeleteQueries(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL2_0.glDeleteQueries(n, ref ids);
		}
		public static void glDeleteShader(UInt32 shader)
		{
			i_OpenGL2_0.glDeleteShader(shader);
		}
		public static void glDeleteTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL2_0.glDeleteTextures(n, ref textures);
		}
		public static void glDepthFunc(DepthFunction func)
		{
			i_OpenGL2_0.glDepthFunc(func);
		}
		public static void glDepthMask(Boolean flag)
		{
			i_OpenGL2_0.glDepthMask(flag);
		}
		public static void glDepthRange(Double n, Double f)
		{
			i_OpenGL2_0.glDepthRange(n, f);
		}
		public static void glDetachShader(UInt32 program, UInt32 shader)
		{
			i_OpenGL2_0.glDetachShader(program, shader);
		}
		public static void glDisable(EnableCap cap)
		{
			i_OpenGL2_0.glDisable(cap);
		}
		public static void glDisableClientState(EnableCap array)
		{
			i_OpenGL2_0.glDisableClientState(array);
		}
		public static void glDisableVertexAttribArray(UInt32 index)
		{
			i_OpenGL2_0.glDisableVertexAttribArray(index);
		}
		public static void glDrawArrays(PrimitiveType mode, Int32 first, Int32 count)
		{
			i_OpenGL2_0.glDrawArrays(mode, first, count);
		}
		public static void glDrawBuffer(DrawBufferMode buf)
		{
			i_OpenGL2_0.glDrawBuffer(buf);
		}
		public static void glDrawBuffers(Int32 n, ref GLenum[] bufs)
		{
			i_OpenGL2_0.glDrawBuffers(n, ref bufs);
		}
		public static void glDrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL2_0.glDrawElements(mode, count, type, indices);
		}
		public static void glDrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glDrawPixels(width, height, format, type, pixels);
		}
		public static void glDrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL2_0.glDrawRangeElements(mode, start, end, count, type, indices);
		}
		public static void glEdgeFlag(Boolean flag)
		{
			i_OpenGL2_0.glEdgeFlag(flag);
		}
		public static void glEdgeFlagPointer(Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glEdgeFlagPointer(stride, pointer);
		}
		public static void glEdgeFlagv(ref Boolean flag)
		{
			i_OpenGL2_0.glEdgeFlagv(ref flag);
		}
		public static void glEnable(EnableCap cap)
		{
			i_OpenGL2_0.glEnable(cap);
		}
		public static void glEnableClientState(EnableCap array)
		{
			i_OpenGL2_0.glEnableClientState(array);
		}
		public static void glEnableVertexAttribArray(UInt32 index)
		{
			i_OpenGL2_0.glEnableVertexAttribArray(index);
		}
		public static void glEnd()
		{
			i_OpenGL2_0.glEnd();
		}
		public static void glEndList()
		{
			i_OpenGL2_0.glEndList();
		}
		public static void glEndQuery(QueryTarget target)
		{
			i_OpenGL2_0.glEndQuery(target);
		}
		public static void glEvalCoord1d(Double u)
		{
			i_OpenGL2_0.glEvalCoord1d(u);
		}
		public static void glEvalCoord1dv(ref Double u)
		{
			i_OpenGL2_0.glEvalCoord1dv(ref u);
		}
		public static void glEvalCoord1f(Single u)
		{
			i_OpenGL2_0.glEvalCoord1f(u);
		}
		public static void glEvalCoord1fv(ref Single u)
		{
			i_OpenGL2_0.glEvalCoord1fv(ref u);
		}
		public static void glEvalCoord2d(Double u, Double v)
		{
			i_OpenGL2_0.glEvalCoord2d(u, v);
		}
		public static void glEvalCoord2dv(ref Double[] u)
		{
			i_OpenGL2_0.glEvalCoord2dv(ref u);
		}
		public static void glEvalCoord2f(Single u, Single v)
		{
			i_OpenGL2_0.glEvalCoord2f(u, v);
		}
		public static void glEvalCoord2fv(ref Single[] u)
		{
			i_OpenGL2_0.glEvalCoord2fv(ref u);
		}
		public static void glEvalMesh1(MeshMode1 mode, Int32 i1, Int32 i2)
		{
			i_OpenGL2_0.glEvalMesh1(mode, i1, i2);
		}
		public static void glEvalMesh2(MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2)
		{
			i_OpenGL2_0.glEvalMesh2(mode, i1, i2, j1, j2);
		}
		public static void glEvalPoint1(Int32 i)
		{
			i_OpenGL2_0.glEvalPoint1(i);
		}
		public static void glEvalPoint2(Int32 i, Int32 j)
		{
			i_OpenGL2_0.glEvalPoint2(i, j);
		}
		public static void glFeedbackBuffer(Int32 size, FeedbackType type, ref Single[] buffer)
		{
			i_OpenGL2_0.glFeedbackBuffer(size, type, ref buffer);
		}
		public static void glFinish()
		{
			i_OpenGL2_0.glFinish();
		}
		public static void glFlush()
		{
			i_OpenGL2_0.glFlush();
		}
		public static void glFogCoordd(Double coord)
		{
			i_OpenGL2_0.glFogCoordd(coord);
		}
		public static void glFogCoorddv(ref Double coord)
		{
			i_OpenGL2_0.glFogCoorddv(ref coord);
		}
		public static void glFogCoordf(Single coord)
		{
			i_OpenGL2_0.glFogCoordf(coord);
		}
		public static void glFogCoordfv(ref Single coord)
		{
			i_OpenGL2_0.glFogCoordfv(ref coord);
		}
		public static void glFogCoordPointer(FogPointerTypeEXT type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glFogCoordPointer(type, stride, pointer);
		}
		public static void glFogf(FogParameter pname, Single param)
		{
			i_OpenGL2_0.glFogf(pname, param);
		}
		public static void glFogfv(FogParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glFogfv(pname, ref @params);
		}
		public static void glFogi(FogParameter pname, Int32 param)
		{
			i_OpenGL2_0.glFogi(pname, param);
		}
		public static void glFogiv(FogParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glFogiv(pname, ref @params);
		}
		public static void glFrontFace(FrontFaceDirection mode)
		{
			i_OpenGL2_0.glFrontFace(mode);
		}
		public static void glFrustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar)
		{
			i_OpenGL2_0.glFrustum(left, right, bottom, top, zNear, zFar);
		}
		public static void glGenBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL2_0.glGenBuffers(n, ref buffers);
		}
		public static UInt32 glGenLists(Int32 range)
		{
			return i_OpenGL2_0.glGenLists(range);
		}
		public static void glGenQueries(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL2_0.glGenQueries(n, ref ids);
		}
		public static void glGenTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL2_0.glGenTextures(n, ref textures);
		}
		public static void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string name)
		{
			i_OpenGL2_0.glGetActiveAttrib(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string name)
		{
			i_OpenGL2_0.glGetActiveUniform(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static void glGetAttachedShaders(UInt32 program, Int32 maxCount, ref Int32 count, ref UInt32[] shaders)
		{
			i_OpenGL2_0.glGetAttachedShaders(program, maxCount, ref count, ref shaders);
		}
		public static Int32 glGetAttribLocation(UInt32 program, ref Char name)
		{
			return i_OpenGL2_0.glGetAttribLocation(program, ref name);
		}
		public static void glGetBooleanv(GetPName pname, ref Boolean[] data)
		{
			i_OpenGL2_0.glGetBooleanv(pname, ref data);
		}
		public static void glGetBufferParameteriv(BufferTargetARB target, GLenum pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetBufferParameteriv(target, pname, ref @params);
		}
		public static void glGetBufferPointerv(BufferTargetARB target, GLenum pname, IntPtr @params)
		{
			i_OpenGL2_0.glGetBufferPointerv(target, pname, @params);
		}
		public static void glGetBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL2_0.glGetBufferSubData(target, offset, size, data);
		}
		public static void glGetClipPlane(ClipPlaneName plane, ref Double[] equation)
		{
			i_OpenGL2_0.glGetClipPlane(plane, ref equation);
		}
		public static void glGetCompressedTexImage(TextureTarget target, Int32 level, IntPtr img)
		{
			i_OpenGL2_0.glGetCompressedTexImage(target, level, img);
		}
		public static void glGetDoublev(GetPName pname, ref Double[] data)
		{
			i_OpenGL2_0.glGetDoublev(pname, ref data);
		}
		public static ErrorCode glGetError()
		{
			return i_OpenGL2_0.glGetError();
		}
		public static void glGetFloatv(GetPName pname, ref Single[] data)
		{
			i_OpenGL2_0.glGetFloatv(pname, ref data);
		}
		public static void glGetIntegerv(GetPName pname, ref Int32[] data)
		{
			i_OpenGL2_0.glGetIntegerv(pname, ref data);
		}
		public static void glGetLightfv(LightName light, LightParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glGetLightfv(light, pname, ref @params);
		}
		public static void glGetLightiv(LightName light, LightParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetLightiv(light, pname, ref @params);
		}
		public static void glGetMapdv(MapTarget target, GetMapQuery query, ref Double[] v)
		{
			i_OpenGL2_0.glGetMapdv(target, query, ref v);
		}
		public static void glGetMapfv(MapTarget target, GetMapQuery query, ref Single[] v)
		{
			i_OpenGL2_0.glGetMapfv(target, query, ref v);
		}
		public static void glGetMapiv(MapTarget target, GetMapQuery query, ref Int32[] v)
		{
			i_OpenGL2_0.glGetMapiv(target, query, ref v);
		}
		public static void glGetMaterialfv(MaterialFace face, MaterialParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glGetMaterialfv(face, pname, ref @params);
		}
		public static void glGetMaterialiv(MaterialFace face, MaterialParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetMaterialiv(face, pname, ref @params);
		}
		public static void glGetPixelMapfv(PixelMap map, ref Single[] values)
		{
			i_OpenGL2_0.glGetPixelMapfv(map, ref values);
		}
		public static void glGetPixelMapuiv(PixelMap map, ref UInt32[] values)
		{
			i_OpenGL2_0.glGetPixelMapuiv(map, ref values);
		}
		public static void glGetPixelMapusv(PixelMap map, ref UInt16[] values)
		{
			i_OpenGL2_0.glGetPixelMapusv(map, ref values);
		}
		public static void glGetPointerv(GetPointervPName pname, IntPtr @params)
		{
			i_OpenGL2_0.glGetPointerv(pname, @params);
		}
		public static void glGetPolygonStipple(ref Byte[] mask)
		{
			i_OpenGL2_0.glGetPolygonStipple(ref mask);
		}
		public static void glGetProgramInfoLog(UInt32 program, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL2_0.glGetProgramInfoLog(program, bufSize, ref length, ref infoLog);
		}
		public static void glGetProgramiv(UInt32 program, ProgramPropertyARB pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetProgramiv(program, pname, ref @params);
		}
		public static void glGetQueryiv(QueryTarget target, QueryParameterName pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetQueryiv(target, pname, ref @params);
		}
		public static void glGetQueryObjectiv(UInt32 id, QueryObjectParameterName pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetQueryObjectiv(id, pname, ref @params);
		}
		public static void glGetQueryObjectuiv(UInt32 id, QueryObjectParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL2_0.glGetQueryObjectuiv(id, pname, ref @params);
		}
		public static void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL2_0.glGetShaderInfoLog(shader, bufSize, ref length, ref infoLog);
		}
		public static void glGetShaderiv(UInt32 shader, ShaderParameterName pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetShaderiv(shader, pname, ref @params);
		}
		public static void glGetShaderSource(UInt32 shader, Int32 bufSize, ref Int32 length, ref string source)
		{
			i_OpenGL2_0.glGetShaderSource(shader, bufSize, ref length, ref source);
		}
		public static Byte glGetString(StringName name)
		{
			return i_OpenGL2_0.glGetString(name);
		}
		public static void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glGetTexEnvfv(target, pname, ref @params);
		}
		public static void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetTexEnviv(target, pname, ref @params);
		}
		public static void glGetTexGendv(TextureCoordName coord, TextureGenParameter pname, ref Double[] @params)
		{
			i_OpenGL2_0.glGetTexGendv(coord, pname, ref @params);
		}
		public static void glGetTexGenfv(TextureCoordName coord, TextureGenParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glGetTexGenfv(coord, pname, ref @params);
		}
		public static void glGetTexGeniv(TextureCoordName coord, TextureGenParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetTexGeniv(coord, pname, ref @params);
		}
		public static void glGetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glGetTexImage(target, level, format, type, pixels);
		}
		public static void glGetTexLevelParameterfv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glGetTexLevelParameterfv(target, level, pname, ref @params);
		}
		public static void glGetTexLevelParameteriv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetTexLevelParameteriv(target, level, pname, ref @params);
		}
		public static void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glGetTexParameterfv(target, pname, ref @params);
		}
		public static void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetTexParameteriv(target, pname, ref @params);
		}
		public static void glGetUniformfv(UInt32 program, Int32 location, ref Single[] @params)
		{
			i_OpenGL2_0.glGetUniformfv(program, location, ref @params);
		}
		public static void glGetUniformiv(UInt32 program, Int32 location, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetUniformiv(program, location, ref @params);
		}
		public static Int32 glGetUniformLocation(UInt32 program, ref Char name)
		{
			return i_OpenGL2_0.glGetUniformLocation(program, ref name);
		}
		public static void glGetVertexAttribdv(UInt32 index, GLenum pname, ref Double[] @params)
		{
			i_OpenGL2_0.glGetVertexAttribdv(index, pname, ref @params);
		}
		public static void glGetVertexAttribfv(UInt32 index, GLenum pname, ref Single[] @params)
		{
			i_OpenGL2_0.glGetVertexAttribfv(index, pname, ref @params);
		}
		public static void glGetVertexAttribiv(UInt32 index, GLenum pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glGetVertexAttribiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribPointerv(UInt32 index, GLenum pname, IntPtr pointer)
		{
			i_OpenGL2_0.glGetVertexAttribPointerv(index, pname, pointer);
		}
		public static void glHint(HintTarget target, HintMode mode)
		{
			i_OpenGL2_0.glHint(target, mode);
		}
		public static void glIndexd(Double c)
		{
			i_OpenGL2_0.glIndexd(c);
		}
		public static void glIndexdv(ref Double c)
		{
			i_OpenGL2_0.glIndexdv(ref c);
		}
		public static void glIndexf(Single c)
		{
			i_OpenGL2_0.glIndexf(c);
		}
		public static void glIndexfv(ref Single c)
		{
			i_OpenGL2_0.glIndexfv(ref c);
		}
		public static void glIndexi(Int32 c)
		{
			i_OpenGL2_0.glIndexi(c);
		}
		public static void glIndexiv(ref Int32 c)
		{
			i_OpenGL2_0.glIndexiv(ref c);
		}
		public static void glIndexMask(UInt32 mask)
		{
			i_OpenGL2_0.glIndexMask(mask);
		}
		public static void glIndexPointer(IndexPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glIndexPointer(type, stride, pointer);
		}
		public static void glIndexs(Int16 c)
		{
			i_OpenGL2_0.glIndexs(c);
		}
		public static void glIndexsv(ref Int16 c)
		{
			i_OpenGL2_0.glIndexsv(ref c);
		}
		public static void glIndexub(Byte c)
		{
			i_OpenGL2_0.glIndexub(c);
		}
		public static void glIndexubv(ref Byte c)
		{
			i_OpenGL2_0.glIndexubv(ref c);
		}
		public static void glInitNames()
		{
			i_OpenGL2_0.glInitNames();
		}
		public static void glInterleavedArrays(InterleavedArrayFormat format, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glInterleavedArrays(format, stride, pointer);
		}
		public static Boolean glIsBuffer(UInt32 buffer)
		{
			return i_OpenGL2_0.glIsBuffer(buffer);
		}
		public static Boolean glIsEnabled(EnableCap cap)
		{
			return i_OpenGL2_0.glIsEnabled(cap);
		}
		public static Boolean glIsList(UInt32 list)
		{
			return i_OpenGL2_0.glIsList(list);
		}
		public static Boolean glIsProgram(UInt32 program)
		{
			return i_OpenGL2_0.glIsProgram(program);
		}
		public static Boolean glIsQuery(UInt32 id)
		{
			return i_OpenGL2_0.glIsQuery(id);
		}
		public static Boolean glIsShader(UInt32 shader)
		{
			return i_OpenGL2_0.glIsShader(shader);
		}
		public static Boolean glIsTexture(UInt32 texture)
		{
			return i_OpenGL2_0.glIsTexture(texture);
		}
		public static void glLightf(LightName light, LightParameter pname, Single param)
		{
			i_OpenGL2_0.glLightf(light, pname, param);
		}
		public static void glLightfv(LightName light, LightParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glLightfv(light, pname, ref @params);
		}
		public static void glLighti(LightName light, LightParameter pname, Int32 param)
		{
			i_OpenGL2_0.glLighti(light, pname, param);
		}
		public static void glLightiv(LightName light, LightParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glLightiv(light, pname, ref @params);
		}
		public static void glLightModelf(LightModelParameter pname, Single param)
		{
			i_OpenGL2_0.glLightModelf(pname, param);
		}
		public static void glLightModelfv(LightModelParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glLightModelfv(pname, ref @params);
		}
		public static void glLightModeli(LightModelParameter pname, Int32 param)
		{
			i_OpenGL2_0.glLightModeli(pname, param);
		}
		public static void glLightModeliv(LightModelParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glLightModeliv(pname, ref @params);
		}
		public static void glLineStipple(Int32 factor, UInt16 pattern)
		{
			i_OpenGL2_0.glLineStipple(factor, pattern);
		}
		public static void glLineWidth(Single width)
		{
			i_OpenGL2_0.glLineWidth(width);
		}
		public static void glLinkProgram(UInt32 program)
		{
			i_OpenGL2_0.glLinkProgram(program);
		}
		public static void glListBase(UInt32 @base)
		{
			i_OpenGL2_0.glListBase(@base);
		}
		public static void glLoadIdentity()
		{
			i_OpenGL2_0.glLoadIdentity();
		}
		public static void glLoadMatrixd(ref Double[] m)
		{
			i_OpenGL2_0.glLoadMatrixd(ref m);
		}
		public static void glLoadMatrixf(ref Single[] m)
		{
			i_OpenGL2_0.glLoadMatrixf(ref m);
		}
		public static void glLoadName(UInt32 name)
		{
			i_OpenGL2_0.glLoadName(name);
		}
		public static void glLoadTransposeMatrixd(ref Double[] m)
		{
			i_OpenGL2_0.glLoadTransposeMatrixd(ref m);
		}
		public static void glLoadTransposeMatrixf(ref Single[] m)
		{
			i_OpenGL2_0.glLoadTransposeMatrixf(ref m);
		}
		public static void glLogicOp(LogicOp opcode)
		{
			i_OpenGL2_0.glLogicOp(opcode);
		}
		public static void glMap1d(MapTarget target, Double u1, Double u2, Int32 stride, Int32 order, ref Double[] points)
		{
			i_OpenGL2_0.glMap1d(target, u1, u2, stride, order, ref points);
		}
		public static void glMap1f(MapTarget target, Single u1, Single u2, Int32 stride, Int32 order, ref Single[] points)
		{
			i_OpenGL2_0.glMap1f(target, u1, u2, stride, order, ref points);
		}
		public static void glMap2d(MapTarget target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, ref Double[] points)
		{
			i_OpenGL2_0.glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref points);
		}
		public static void glMap2f(MapTarget target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, ref Single[] points)
		{
			i_OpenGL2_0.glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref points);
		}
		public static IntPtr glMapBuffer(BufferTargetARB target, BufferAccessARB access)
		{
			return i_OpenGL2_0.glMapBuffer(target, access);
		}
		public static void glMapGrid1d(Int32 un, Double u1, Double u2)
		{
			i_OpenGL2_0.glMapGrid1d(un, u1, u2);
		}
		public static void glMapGrid1f(Int32 un, Single u1, Single u2)
		{
			i_OpenGL2_0.glMapGrid1f(un, u1, u2);
		}
		public static void glMapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2)
		{
			i_OpenGL2_0.glMapGrid2d(un, u1, u2, vn, v1, v2);
		}
		public static void glMapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2)
		{
			i_OpenGL2_0.glMapGrid2f(un, u1, u2, vn, v1, v2);
		}
		public static void glMaterialf(MaterialFace face, MaterialParameter pname, Single param)
		{
			i_OpenGL2_0.glMaterialf(face, pname, param);
		}
		public static void glMaterialfv(MaterialFace face, MaterialParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glMaterialfv(face, pname, ref @params);
		}
		public static void glMateriali(MaterialFace face, MaterialParameter pname, Int32 param)
		{
			i_OpenGL2_0.glMateriali(face, pname, param);
		}
		public static void glMaterialiv(MaterialFace face, MaterialParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glMaterialiv(face, pname, ref @params);
		}
		public static void glMatrixMode(MatrixMode mode)
		{
			i_OpenGL2_0.glMatrixMode(mode);
		}
		public static void glMultiDrawArrays(PrimitiveType mode, ref Int32[] first, ref Int32[] count, Int32 drawcount)
		{
			i_OpenGL2_0.glMultiDrawArrays(mode, ref first, ref count, drawcount);
		}
		public static void glMultiDrawElements(PrimitiveType mode, ref Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount)
		{
			i_OpenGL2_0.glMultiDrawElements(mode, ref count, type, indices, drawcount);
		}
		public static void glMultiTexCoord1d(TextureUnit target, Double s)
		{
			i_OpenGL2_0.glMultiTexCoord1d(target, s);
		}
		public static void glMultiTexCoord1dv(TextureUnit target, ref Double v)
		{
			i_OpenGL2_0.glMultiTexCoord1dv(target, ref v);
		}
		public static void glMultiTexCoord1f(TextureUnit target, Single s)
		{
			i_OpenGL2_0.glMultiTexCoord1f(target, s);
		}
		public static void glMultiTexCoord1fv(TextureUnit target, ref Single v)
		{
			i_OpenGL2_0.glMultiTexCoord1fv(target, ref v);
		}
		public static void glMultiTexCoord1i(TextureUnit target, Int32 s)
		{
			i_OpenGL2_0.glMultiTexCoord1i(target, s);
		}
		public static void glMultiTexCoord1iv(TextureUnit target, ref Int32 v)
		{
			i_OpenGL2_0.glMultiTexCoord1iv(target, ref v);
		}
		public static void glMultiTexCoord1s(TextureUnit target, Int16 s)
		{
			i_OpenGL2_0.glMultiTexCoord1s(target, s);
		}
		public static void glMultiTexCoord1sv(TextureUnit target, ref Int16 v)
		{
			i_OpenGL2_0.glMultiTexCoord1sv(target, ref v);
		}
		public static void glMultiTexCoord2d(TextureUnit target, Double s, Double t)
		{
			i_OpenGL2_0.glMultiTexCoord2d(target, s, t);
		}
		public static void glMultiTexCoord2dv(TextureUnit target, ref Double[] v)
		{
			i_OpenGL2_0.glMultiTexCoord2dv(target, ref v);
		}
		public static void glMultiTexCoord2f(TextureUnit target, Single s, Single t)
		{
			i_OpenGL2_0.glMultiTexCoord2f(target, s, t);
		}
		public static void glMultiTexCoord2fv(TextureUnit target, ref Single[] v)
		{
			i_OpenGL2_0.glMultiTexCoord2fv(target, ref v);
		}
		public static void glMultiTexCoord2i(TextureUnit target, Int32 s, Int32 t)
		{
			i_OpenGL2_0.glMultiTexCoord2i(target, s, t);
		}
		public static void glMultiTexCoord2iv(TextureUnit target, ref Int32[] v)
		{
			i_OpenGL2_0.glMultiTexCoord2iv(target, ref v);
		}
		public static void glMultiTexCoord2s(TextureUnit target, Int16 s, Int16 t)
		{
			i_OpenGL2_0.glMultiTexCoord2s(target, s, t);
		}
		public static void glMultiTexCoord2sv(TextureUnit target, ref Int16[] v)
		{
			i_OpenGL2_0.glMultiTexCoord2sv(target, ref v);
		}
		public static void glMultiTexCoord3d(TextureUnit target, Double s, Double t, Double r)
		{
			i_OpenGL2_0.glMultiTexCoord3d(target, s, t, r);
		}
		public static void glMultiTexCoord3dv(TextureUnit target, ref Double[] v)
		{
			i_OpenGL2_0.glMultiTexCoord3dv(target, ref v);
		}
		public static void glMultiTexCoord3f(TextureUnit target, Single s, Single t, Single r)
		{
			i_OpenGL2_0.glMultiTexCoord3f(target, s, t, r);
		}
		public static void glMultiTexCoord3fv(TextureUnit target, ref Single[] v)
		{
			i_OpenGL2_0.glMultiTexCoord3fv(target, ref v);
		}
		public static void glMultiTexCoord3i(TextureUnit target, Int32 s, Int32 t, Int32 r)
		{
			i_OpenGL2_0.glMultiTexCoord3i(target, s, t, r);
		}
		public static void glMultiTexCoord3iv(TextureUnit target, ref Int32[] v)
		{
			i_OpenGL2_0.glMultiTexCoord3iv(target, ref v);
		}
		public static void glMultiTexCoord3s(TextureUnit target, Int16 s, Int16 t, Int16 r)
		{
			i_OpenGL2_0.glMultiTexCoord3s(target, s, t, r);
		}
		public static void glMultiTexCoord3sv(TextureUnit target, ref Int16[] v)
		{
			i_OpenGL2_0.glMultiTexCoord3sv(target, ref v);
		}
		public static void glMultiTexCoord4d(TextureUnit target, Double s, Double t, Double r, Double q)
		{
			i_OpenGL2_0.glMultiTexCoord4d(target, s, t, r, q);
		}
		public static void glMultiTexCoord4dv(TextureUnit target, ref Double[] v)
		{
			i_OpenGL2_0.glMultiTexCoord4dv(target, ref v);
		}
		public static void glMultiTexCoord4f(TextureUnit target, Single s, Single t, Single r, Single q)
		{
			i_OpenGL2_0.glMultiTexCoord4f(target, s, t, r, q);
		}
		public static void glMultiTexCoord4fv(TextureUnit target, ref Single[] v)
		{
			i_OpenGL2_0.glMultiTexCoord4fv(target, ref v);
		}
		public static void glMultiTexCoord4i(TextureUnit target, Int32 s, Int32 t, Int32 r, Int32 q)
		{
			i_OpenGL2_0.glMultiTexCoord4i(target, s, t, r, q);
		}
		public static void glMultiTexCoord4iv(TextureUnit target, ref Int32[] v)
		{
			i_OpenGL2_0.glMultiTexCoord4iv(target, ref v);
		}
		public static void glMultiTexCoord4s(TextureUnit target, Int16 s, Int16 t, Int16 r, Int16 q)
		{
			i_OpenGL2_0.glMultiTexCoord4s(target, s, t, r, q);
		}
		public static void glMultiTexCoord4sv(TextureUnit target, ref Int16[] v)
		{
			i_OpenGL2_0.glMultiTexCoord4sv(target, ref v);
		}
		public static void glMultMatrixd(ref Double[] m)
		{
			i_OpenGL2_0.glMultMatrixd(ref m);
		}
		public static void glMultMatrixf(ref Single[] m)
		{
			i_OpenGL2_0.glMultMatrixf(ref m);
		}
		public static void glMultTransposeMatrixd(ref Double[] m)
		{
			i_OpenGL2_0.glMultTransposeMatrixd(ref m);
		}
		public static void glMultTransposeMatrixf(ref Single[] m)
		{
			i_OpenGL2_0.glMultTransposeMatrixf(ref m);
		}
		public static void glNewList(UInt32 list, ListMode mode)
		{
			i_OpenGL2_0.glNewList(list, mode);
		}
		public static void glNormal3b(SByte nx, SByte ny, SByte nz)
		{
			i_OpenGL2_0.glNormal3b(nx, ny, nz);
		}
		public static void glNormal3bv(ref SByte[] v)
		{
			i_OpenGL2_0.glNormal3bv(ref v);
		}
		public static void glNormal3d(Double nx, Double ny, Double nz)
		{
			i_OpenGL2_0.glNormal3d(nx, ny, nz);
		}
		public static void glNormal3dv(ref Double[] v)
		{
			i_OpenGL2_0.glNormal3dv(ref v);
		}
		public static void glNormal3f(Single nx, Single ny, Single nz)
		{
			i_OpenGL2_0.glNormal3f(nx, ny, nz);
		}
		public static void glNormal3fv(ref Single[] v)
		{
			i_OpenGL2_0.glNormal3fv(ref v);
		}
		public static void glNormal3i(Int32 nx, Int32 ny, Int32 nz)
		{
			i_OpenGL2_0.glNormal3i(nx, ny, nz);
		}
		public static void glNormal3iv(ref Int32[] v)
		{
			i_OpenGL2_0.glNormal3iv(ref v);
		}
		public static void glNormal3s(Int16 nx, Int16 ny, Int16 nz)
		{
			i_OpenGL2_0.glNormal3s(nx, ny, nz);
		}
		public static void glNormal3sv(ref Int16[] v)
		{
			i_OpenGL2_0.glNormal3sv(ref v);
		}
		public static void glNormalPointer(NormalPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glNormalPointer(type, stride, pointer);
		}
		public static void glOrtho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar)
		{
			i_OpenGL2_0.glOrtho(left, right, bottom, top, zNear, zFar);
		}
		public static void glPassThrough(Single token)
		{
			i_OpenGL2_0.glPassThrough(token);
		}
		public static void glPixelMapfv(PixelMap map, Int32 mapsize, ref Single[] values)
		{
			i_OpenGL2_0.glPixelMapfv(map, mapsize, ref values);
		}
		public static void glPixelMapuiv(PixelMap map, Int32 mapsize, ref UInt32[] values)
		{
			i_OpenGL2_0.glPixelMapuiv(map, mapsize, ref values);
		}
		public static void glPixelMapusv(PixelMap map, Int32 mapsize, ref UInt16[] values)
		{
			i_OpenGL2_0.glPixelMapusv(map, mapsize, ref values);
		}
		public static void glPixelStoref(PixelStoreParameter pname, Single param)
		{
			i_OpenGL2_0.glPixelStoref(pname, param);
		}
		public static void glPixelStorei(PixelStoreParameter pname, Int32 param)
		{
			i_OpenGL2_0.glPixelStorei(pname, param);
		}
		public static void glPixelTransferf(PixelTransferParameter pname, Single param)
		{
			i_OpenGL2_0.glPixelTransferf(pname, param);
		}
		public static void glPixelTransferi(PixelTransferParameter pname, Int32 param)
		{
			i_OpenGL2_0.glPixelTransferi(pname, param);
		}
		public static void glPixelZoom(Single xfactor, Single yfactor)
		{
			i_OpenGL2_0.glPixelZoom(xfactor, yfactor);
		}
		public static void glPointParameterf(GLenum pname, Single param)
		{
			i_OpenGL2_0.glPointParameterf(pname, param);
		}
		public static void glPointParameterfv(GLenum pname, ref Single[] @params)
		{
			i_OpenGL2_0.glPointParameterfv(pname, ref @params);
		}
		public static void glPointParameteri(GLenum pname, Int32 param)
		{
			i_OpenGL2_0.glPointParameteri(pname, param);
		}
		public static void glPointParameteriv(GLenum pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glPointParameteriv(pname, ref @params);
		}
		public static void glPointSize(Single size)
		{
			i_OpenGL2_0.glPointSize(size);
		}
		public static void glPolygonMode(MaterialFace face, PolygonMode mode)
		{
			i_OpenGL2_0.glPolygonMode(face, mode);
		}
		public static void glPolygonOffset(Single factor, Single units)
		{
			i_OpenGL2_0.glPolygonOffset(factor, units);
		}
		public static void glPolygonStipple(ref Byte[] mask)
		{
			i_OpenGL2_0.glPolygonStipple(ref mask);
		}
		public static void glPopAttrib()
		{
			i_OpenGL2_0.glPopAttrib();
		}
		public static void glPopClientAttrib()
		{
			i_OpenGL2_0.glPopClientAttrib();
		}
		public static void glPopMatrix()
		{
			i_OpenGL2_0.glPopMatrix();
		}
		public static void glPopName()
		{
			i_OpenGL2_0.glPopName();
		}
		public static void glPrioritizeTextures(Int32 n, ref UInt32[] textures, ref Single[] priorities)
		{
			i_OpenGL2_0.glPrioritizeTextures(n, ref textures, ref priorities);
		}
		public static void glPushAttrib(UInt32 mask)
		{
			i_OpenGL2_0.glPushAttrib(mask);
		}
		public static void glPushClientAttrib(UInt32 mask)
		{
			i_OpenGL2_0.glPushClientAttrib(mask);
		}
		public static void glPushMatrix()
		{
			i_OpenGL2_0.glPushMatrix();
		}
		public static void glPushName(UInt32 name)
		{
			i_OpenGL2_0.glPushName(name);
		}
		public static void glRasterPos2d(Double x, Double y)
		{
			i_OpenGL2_0.glRasterPos2d(x, y);
		}
		public static void glRasterPos2dv(ref Double[] v)
		{
			i_OpenGL2_0.glRasterPos2dv(ref v);
		}
		public static void glRasterPos2f(Single x, Single y)
		{
			i_OpenGL2_0.glRasterPos2f(x, y);
		}
		public static void glRasterPos2fv(ref Single[] v)
		{
			i_OpenGL2_0.glRasterPos2fv(ref v);
		}
		public static void glRasterPos2i(Int32 x, Int32 y)
		{
			i_OpenGL2_0.glRasterPos2i(x, y);
		}
		public static void glRasterPos2iv(ref Int32[] v)
		{
			i_OpenGL2_0.glRasterPos2iv(ref v);
		}
		public static void glRasterPos2s(Int16 x, Int16 y)
		{
			i_OpenGL2_0.glRasterPos2s(x, y);
		}
		public static void glRasterPos2sv(ref Int16[] v)
		{
			i_OpenGL2_0.glRasterPos2sv(ref v);
		}
		public static void glRasterPos3d(Double x, Double y, Double z)
		{
			i_OpenGL2_0.glRasterPos3d(x, y, z);
		}
		public static void glRasterPos3dv(ref Double[] v)
		{
			i_OpenGL2_0.glRasterPos3dv(ref v);
		}
		public static void glRasterPos3f(Single x, Single y, Single z)
		{
			i_OpenGL2_0.glRasterPos3f(x, y, z);
		}
		public static void glRasterPos3fv(ref Single[] v)
		{
			i_OpenGL2_0.glRasterPos3fv(ref v);
		}
		public static void glRasterPos3i(Int32 x, Int32 y, Int32 z)
		{
			i_OpenGL2_0.glRasterPos3i(x, y, z);
		}
		public static void glRasterPos3iv(ref Int32[] v)
		{
			i_OpenGL2_0.glRasterPos3iv(ref v);
		}
		public static void glRasterPos3s(Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL2_0.glRasterPos3s(x, y, z);
		}
		public static void glRasterPos3sv(ref Int16[] v)
		{
			i_OpenGL2_0.glRasterPos3sv(ref v);
		}
		public static void glRasterPos4d(Double x, Double y, Double z, Double w)
		{
			i_OpenGL2_0.glRasterPos4d(x, y, z, w);
		}
		public static void glRasterPos4dv(ref Double[] v)
		{
			i_OpenGL2_0.glRasterPos4dv(ref v);
		}
		public static void glRasterPos4f(Single x, Single y, Single z, Single w)
		{
			i_OpenGL2_0.glRasterPos4f(x, y, z, w);
		}
		public static void glRasterPos4fv(ref Single[] v)
		{
			i_OpenGL2_0.glRasterPos4fv(ref v);
		}
		public static void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			i_OpenGL2_0.glRasterPos4i(x, y, z, w);
		}
		public static void glRasterPos4iv(ref Int32[] v)
		{
			i_OpenGL2_0.glRasterPos4iv(ref v);
		}
		public static void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			i_OpenGL2_0.glRasterPos4s(x, y, z, w);
		}
		public static void glRasterPos4sv(ref Int16[] v)
		{
			i_OpenGL2_0.glRasterPos4sv(ref v);
		}
		public static void glReadBuffer(ReadBufferMode src)
		{
			i_OpenGL2_0.glReadBuffer(src);
		}
		public static void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glReadPixels(x, y, width, height, format, type, pixels);
		}
		public static void glRectd(Double x1, Double y1, Double x2, Double y2)
		{
			i_OpenGL2_0.glRectd(x1, y1, x2, y2);
		}
		public static void glRectdv(ref Double[] v1, ref Double[] v2)
		{
			i_OpenGL2_0.glRectdv(ref v1, ref v2);
		}
		public static void glRectf(Single x1, Single y1, Single x2, Single y2)
		{
			i_OpenGL2_0.glRectf(x1, y1, x2, y2);
		}
		public static void glRectfv(ref Single[] v1, ref Single[] v2)
		{
			i_OpenGL2_0.glRectfv(ref v1, ref v2);
		}
		public static void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2)
		{
			i_OpenGL2_0.glRecti(x1, y1, x2, y2);
		}
		public static void glRectiv(ref Int32[] v1, ref Int32[] v2)
		{
			i_OpenGL2_0.glRectiv(ref v1, ref v2);
		}
		public static void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2)
		{
			i_OpenGL2_0.glRects(x1, y1, x2, y2);
		}
		public static void glRectsv(ref Int16[] v1, ref Int16[] v2)
		{
			i_OpenGL2_0.glRectsv(ref v1, ref v2);
		}
		public static Int32 glRenderMode(RenderingMode mode)
		{
			return i_OpenGL2_0.glRenderMode(mode);
		}
		public static void glRotated(Double angle, Double x, Double y, Double z)
		{
			i_OpenGL2_0.glRotated(angle, x, y, z);
		}
		public static void glRotatef(Single angle, Single x, Single y, Single z)
		{
			i_OpenGL2_0.glRotatef(angle, x, y, z);
		}
		public static void glSampleCoverage(Single value, Boolean invert)
		{
			i_OpenGL2_0.glSampleCoverage(value, invert);
		}
		public static void glScaled(Double x, Double y, Double z)
		{
			i_OpenGL2_0.glScaled(x, y, z);
		}
		public static void glScalef(Single x, Single y, Single z)
		{
			i_OpenGL2_0.glScalef(x, y, z);
		}
		public static void glScissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL2_0.glScissor(x, y, width, height);
		}
		public static void glSecondaryColor3b(SByte red, SByte green, SByte blue)
		{
			i_OpenGL2_0.glSecondaryColor3b(red, green, blue);
		}
		public static void glSecondaryColor3bv(ref SByte[] v)
		{
			i_OpenGL2_0.glSecondaryColor3bv(ref v);
		}
		public static void glSecondaryColor3d(Double red, Double green, Double blue)
		{
			i_OpenGL2_0.glSecondaryColor3d(red, green, blue);
		}
		public static void glSecondaryColor3dv(ref Double[] v)
		{
			i_OpenGL2_0.glSecondaryColor3dv(ref v);
		}
		public static void glSecondaryColor3f(Single red, Single green, Single blue)
		{
			i_OpenGL2_0.glSecondaryColor3f(red, green, blue);
		}
		public static void glSecondaryColor3fv(ref Single[] v)
		{
			i_OpenGL2_0.glSecondaryColor3fv(ref v);
		}
		public static void glSecondaryColor3i(Int32 red, Int32 green, Int32 blue)
		{
			i_OpenGL2_0.glSecondaryColor3i(red, green, blue);
		}
		public static void glSecondaryColor3iv(ref Int32[] v)
		{
			i_OpenGL2_0.glSecondaryColor3iv(ref v);
		}
		public static void glSecondaryColor3s(Int16 red, Int16 green, Int16 blue)
		{
			i_OpenGL2_0.glSecondaryColor3s(red, green, blue);
		}
		public static void glSecondaryColor3sv(ref Int16[] v)
		{
			i_OpenGL2_0.glSecondaryColor3sv(ref v);
		}
		public static void glSecondaryColor3ub(Byte red, Byte green, Byte blue)
		{
			i_OpenGL2_0.glSecondaryColor3ub(red, green, blue);
		}
		public static void glSecondaryColor3ubv(ref Byte[] v)
		{
			i_OpenGL2_0.glSecondaryColor3ubv(ref v);
		}
		public static void glSecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue)
		{
			i_OpenGL2_0.glSecondaryColor3ui(red, green, blue);
		}
		public static void glSecondaryColor3uiv(ref UInt32[] v)
		{
			i_OpenGL2_0.glSecondaryColor3uiv(ref v);
		}
		public static void glSecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue)
		{
			i_OpenGL2_0.glSecondaryColor3us(red, green, blue);
		}
		public static void glSecondaryColor3usv(ref UInt16[] v)
		{
			i_OpenGL2_0.glSecondaryColor3usv(ref v);
		}
		public static void glSecondaryColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glSecondaryColorPointer(size, type, stride, pointer);
		}
		public static void glSelectBuffer(Int32 size, ref UInt32[] buffer)
		{
			i_OpenGL2_0.glSelectBuffer(size, ref buffer);
		}
		public static void glShadeModel(ShadingModel mode)
		{
			i_OpenGL2_0.glShadeModel(mode);
		}
		public static void glShaderSource(UInt32 shader, Int32 count, ref string @string, ref Int32[] length)
		{
			i_OpenGL2_0.glShaderSource(shader, count, ref @string, ref length);
		}
		public static void glStencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL2_0.glStencilFunc(func, @ref, mask);
		}
		public static void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL2_0.glStencilFuncSeparate(face, func, @ref, mask);
		}
		public static void glStencilMask(UInt32 mask)
		{
			i_OpenGL2_0.glStencilMask(mask);
		}
		public static void glStencilMaskSeparate(StencilFaceDirection face, UInt32 mask)
		{
			i_OpenGL2_0.glStencilMaskSeparate(face, mask);
		}
		public static void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			i_OpenGL2_0.glStencilOp(fail, zfail, zpass);
		}
		public static void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			i_OpenGL2_0.glStencilOpSeparate(face, sfail, dpfail, dppass);
		}
		public static void glTexCoord1d(Double s)
		{
			i_OpenGL2_0.glTexCoord1d(s);
		}
		public static void glTexCoord1dv(ref Double v)
		{
			i_OpenGL2_0.glTexCoord1dv(ref v);
		}
		public static void glTexCoord1f(Single s)
		{
			i_OpenGL2_0.glTexCoord1f(s);
		}
		public static void glTexCoord1fv(ref Single v)
		{
			i_OpenGL2_0.glTexCoord1fv(ref v);
		}
		public static void glTexCoord1i(Int32 s)
		{
			i_OpenGL2_0.glTexCoord1i(s);
		}
		public static void glTexCoord1iv(ref Int32 v)
		{
			i_OpenGL2_0.glTexCoord1iv(ref v);
		}
		public static void glTexCoord1s(Int16 s)
		{
			i_OpenGL2_0.glTexCoord1s(s);
		}
		public static void glTexCoord1sv(ref Int16 v)
		{
			i_OpenGL2_0.glTexCoord1sv(ref v);
		}
		public static void glTexCoord2d(Double s, Double t)
		{
			i_OpenGL2_0.glTexCoord2d(s, t);
		}
		public static void glTexCoord2dv(ref Double[] v)
		{
			i_OpenGL2_0.glTexCoord2dv(ref v);
		}
		public static void glTexCoord2f(Single s, Single t)
		{
			i_OpenGL2_0.glTexCoord2f(s, t);
		}
		public static void glTexCoord2fv(ref Single[] v)
		{
			i_OpenGL2_0.glTexCoord2fv(ref v);
		}
		public static void glTexCoord2i(Int32 s, Int32 t)
		{
			i_OpenGL2_0.glTexCoord2i(s, t);
		}
		public static void glTexCoord2iv(ref Int32[] v)
		{
			i_OpenGL2_0.glTexCoord2iv(ref v);
		}
		public static void glTexCoord2s(Int16 s, Int16 t)
		{
			i_OpenGL2_0.glTexCoord2s(s, t);
		}
		public static void glTexCoord2sv(ref Int16[] v)
		{
			i_OpenGL2_0.glTexCoord2sv(ref v);
		}
		public static void glTexCoord3d(Double s, Double t, Double r)
		{
			i_OpenGL2_0.glTexCoord3d(s, t, r);
		}
		public static void glTexCoord3dv(ref Double[] v)
		{
			i_OpenGL2_0.glTexCoord3dv(ref v);
		}
		public static void glTexCoord3f(Single s, Single t, Single r)
		{
			i_OpenGL2_0.glTexCoord3f(s, t, r);
		}
		public static void glTexCoord3fv(ref Single[] v)
		{
			i_OpenGL2_0.glTexCoord3fv(ref v);
		}
		public static void glTexCoord3i(Int32 s, Int32 t, Int32 r)
		{
			i_OpenGL2_0.glTexCoord3i(s, t, r);
		}
		public static void glTexCoord3iv(ref Int32[] v)
		{
			i_OpenGL2_0.glTexCoord3iv(ref v);
		}
		public static void glTexCoord3s(Int16 s, Int16 t, Int16 r)
		{
			i_OpenGL2_0.glTexCoord3s(s, t, r);
		}
		public static void glTexCoord3sv(ref Int16[] v)
		{
			i_OpenGL2_0.glTexCoord3sv(ref v);
		}
		public static void glTexCoord4d(Double s, Double t, Double r, Double q)
		{
			i_OpenGL2_0.glTexCoord4d(s, t, r, q);
		}
		public static void glTexCoord4dv(ref Double[] v)
		{
			i_OpenGL2_0.glTexCoord4dv(ref v);
		}
		public static void glTexCoord4f(Single s, Single t, Single r, Single q)
		{
			i_OpenGL2_0.glTexCoord4f(s, t, r, q);
		}
		public static void glTexCoord4fv(ref Single[] v)
		{
			i_OpenGL2_0.glTexCoord4fv(ref v);
		}
		public static void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q)
		{
			i_OpenGL2_0.glTexCoord4i(s, t, r, q);
		}
		public static void glTexCoord4iv(ref Int32[] v)
		{
			i_OpenGL2_0.glTexCoord4iv(ref v);
		}
		public static void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q)
		{
			i_OpenGL2_0.glTexCoord4s(s, t, r, q);
		}
		public static void glTexCoord4sv(ref Int16[] v)
		{
			i_OpenGL2_0.glTexCoord4sv(ref v);
		}
		public static void glTexCoordPointer(Int32 size, TexCoordPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glTexCoordPointer(size, type, stride, pointer);
		}
		public static void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, Single param)
		{
			i_OpenGL2_0.glTexEnvf(target, pname, param);
		}
		public static void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glTexEnvfv(target, pname, ref @params);
		}
		public static void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, Int32 param)
		{
			i_OpenGL2_0.glTexEnvi(target, pname, param);
		}
		public static void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glTexEnviv(target, pname, ref @params);
		}
		public static void glTexGend(TextureCoordName coord, TextureGenParameter pname, Double param)
		{
			i_OpenGL2_0.glTexGend(coord, pname, param);
		}
		public static void glTexGendv(TextureCoordName coord, TextureGenParameter pname, ref Double[] @params)
		{
			i_OpenGL2_0.glTexGendv(coord, pname, ref @params);
		}
		public static void glTexGenf(TextureCoordName coord, TextureGenParameter pname, Single param)
		{
			i_OpenGL2_0.glTexGenf(coord, pname, param);
		}
		public static void glTexGenfv(TextureCoordName coord, TextureGenParameter pname, ref Single[] @params)
		{
			i_OpenGL2_0.glTexGenfv(coord, pname, ref @params);
		}
		public static void glTexGeni(TextureCoordName coord, TextureGenParameter pname, Int32 param)
		{
			i_OpenGL2_0.glTexGeni(coord, pname, param);
		}
		public static void glTexGeniv(TextureCoordName coord, TextureGenParameter pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glTexGeniv(coord, pname, ref @params);
		}
		public static void glTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}
		public static void glTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}
		public static void glTexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		public static void glTexParameterf(TextureTarget target, TextureParameterName pname, Single param)
		{
			i_OpenGL2_0.glTexParameterf(target, pname, param);
		}
		public static void glTexParameterfv(TextureTarget target, TextureParameterName pname, ref Single[] @params)
		{
			i_OpenGL2_0.glTexParameterfv(target, pname, ref @params);
		}
		public static void glTexParameteri(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			i_OpenGL2_0.glTexParameteri(target, pname, param);
		}
		public static void glTexParameteriv(TextureTarget target, TextureParameterName pname, ref Int32[] @params)
		{
			i_OpenGL2_0.glTexParameteriv(target, pname, ref @params);
		}
		public static void glTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}
		public static void glTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		public static void glTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL2_0.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public static void glTranslated(Double x, Double y, Double z)
		{
			i_OpenGL2_0.glTranslated(x, y, z);
		}
		public static void glTranslatef(Single x, Single y, Single z)
		{
			i_OpenGL2_0.glTranslatef(x, y, z);
		}
		public static void glUniform1f(Int32 location, Single v0)
		{
			i_OpenGL2_0.glUniform1f(location, v0);
		}
		public static void glUniform1fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL2_0.glUniform1fv(location, count, ref value);
		}
		public static void glUniform1i(Int32 location, Int32 v0)
		{
			i_OpenGL2_0.glUniform1i(location, v0);
		}
		public static void glUniform1iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL2_0.glUniform1iv(location, count, ref value);
		}
		public static void glUniform2f(Int32 location, Single v0, Single v1)
		{
			i_OpenGL2_0.glUniform2f(location, v0, v1);
		}
		public static void glUniform2fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL2_0.glUniform2fv(location, count, ref value);
		}
		public static void glUniform2i(Int32 location, Int32 v0, Int32 v1)
		{
			i_OpenGL2_0.glUniform2i(location, v0, v1);
		}
		public static void glUniform2iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL2_0.glUniform2iv(location, count, ref value);
		}
		public static void glUniform3f(Int32 location, Single v0, Single v1, Single v2)
		{
			i_OpenGL2_0.glUniform3f(location, v0, v1, v2);
		}
		public static void glUniform3fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL2_0.glUniform3fv(location, count, ref value);
		}
		public static void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			i_OpenGL2_0.glUniform3i(location, v0, v1, v2);
		}
		public static void glUniform3iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL2_0.glUniform3iv(location, count, ref value);
		}
		public static void glUniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3)
		{
			i_OpenGL2_0.glUniform4f(location, v0, v1, v2, v3);
		}
		public static void glUniform4fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL2_0.glUniform4fv(location, count, ref value);
		}
		public static void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			i_OpenGL2_0.glUniform4i(location, v0, v1, v2, v3);
		}
		public static void glUniform4iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL2_0.glUniform4iv(location, count, ref value);
		}
		public static void glUniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL2_0.glUniformMatrix2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL2_0.glUniformMatrix3fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL2_0.glUniformMatrix4fv(location, count, transpose, ref value);
		}
		public static Boolean glUnmapBuffer(BufferTargetARB target)
		{
			return i_OpenGL2_0.glUnmapBuffer(target);
		}
		public static void glUseProgram(UInt32 program)
		{
			i_OpenGL2_0.glUseProgram(program);
		}
		public static void glValidateProgram(UInt32 program)
		{
			i_OpenGL2_0.glValidateProgram(program);
		}
		public static void glVertex2d(Double x, Double y)
		{
			i_OpenGL2_0.glVertex2d(x, y);
		}
		public static void glVertex2dv(ref Double[] v)
		{
			i_OpenGL2_0.glVertex2dv(ref v);
		}
		public static void glVertex2f(Single x, Single y)
		{
			i_OpenGL2_0.glVertex2f(x, y);
		}
		public static void glVertex2fv(ref Single[] v)
		{
			i_OpenGL2_0.glVertex2fv(ref v);
		}
		public static void glVertex2i(Int32 x, Int32 y)
		{
			i_OpenGL2_0.glVertex2i(x, y);
		}
		public static void glVertex2iv(ref Int32[] v)
		{
			i_OpenGL2_0.glVertex2iv(ref v);
		}
		public static void glVertex2s(Int16 x, Int16 y)
		{
			i_OpenGL2_0.glVertex2s(x, y);
		}
		public static void glVertex2sv(ref Int16[] v)
		{
			i_OpenGL2_0.glVertex2sv(ref v);
		}
		public static void glVertex3d(Double x, Double y, Double z)
		{
			i_OpenGL2_0.glVertex3d(x, y, z);
		}
		public static void glVertex3dv(ref Double[] v)
		{
			i_OpenGL2_0.glVertex3dv(ref v);
		}
		public static void glVertex3f(Single x, Single y, Single z)
		{
			i_OpenGL2_0.glVertex3f(x, y, z);
		}
		public static void glVertex3fv(ref Single[] v)
		{
			i_OpenGL2_0.glVertex3fv(ref v);
		}
		public static void glVertex3i(Int32 x, Int32 y, Int32 z)
		{
			i_OpenGL2_0.glVertex3i(x, y, z);
		}
		public static void glVertex3iv(ref Int32[] v)
		{
			i_OpenGL2_0.glVertex3iv(ref v);
		}
		public static void glVertex3s(Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL2_0.glVertex3s(x, y, z);
		}
		public static void glVertex3sv(ref Int16[] v)
		{
			i_OpenGL2_0.glVertex3sv(ref v);
		}
		public static void glVertex4d(Double x, Double y, Double z, Double w)
		{
			i_OpenGL2_0.glVertex4d(x, y, z, w);
		}
		public static void glVertex4dv(ref Double[] v)
		{
			i_OpenGL2_0.glVertex4dv(ref v);
		}
		public static void glVertex4f(Single x, Single y, Single z, Single w)
		{
			i_OpenGL2_0.glVertex4f(x, y, z, w);
		}
		public static void glVertex4fv(ref Single[] v)
		{
			i_OpenGL2_0.glVertex4fv(ref v);
		}
		public static void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			i_OpenGL2_0.glVertex4i(x, y, z, w);
		}
		public static void glVertex4iv(ref Int32[] v)
		{
			i_OpenGL2_0.glVertex4iv(ref v);
		}
		public static void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			i_OpenGL2_0.glVertex4s(x, y, z, w);
		}
		public static void glVertex4sv(ref Int16[] v)
		{
			i_OpenGL2_0.glVertex4sv(ref v);
		}
		public static void glVertexAttrib1d(UInt32 index, Double x)
		{
			i_OpenGL2_0.glVertexAttrib1d(index, x);
		}
		public static void glVertexAttrib1dv(UInt32 index, ref Double v)
		{
			i_OpenGL2_0.glVertexAttrib1dv(index, ref v);
		}
		public static void glVertexAttrib1f(UInt32 index, Single x)
		{
			i_OpenGL2_0.glVertexAttrib1f(index, x);
		}
		public static void glVertexAttrib1fv(UInt32 index, ref Single v)
		{
			i_OpenGL2_0.glVertexAttrib1fv(index, ref v);
		}
		public static void glVertexAttrib1s(UInt32 index, Int16 x)
		{
			i_OpenGL2_0.glVertexAttrib1s(index, x);
		}
		public static void glVertexAttrib1sv(UInt32 index, ref Int16 v)
		{
			i_OpenGL2_0.glVertexAttrib1sv(index, ref v);
		}
		public static void glVertexAttrib2d(UInt32 index, Double x, Double y)
		{
			i_OpenGL2_0.glVertexAttrib2d(index, x, y);
		}
		public static void glVertexAttrib2dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL2_0.glVertexAttrib2dv(index, ref v);
		}
		public static void glVertexAttrib2f(UInt32 index, Single x, Single y)
		{
			i_OpenGL2_0.glVertexAttrib2f(index, x, y);
		}
		public static void glVertexAttrib2fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL2_0.glVertexAttrib2fv(index, ref v);
		}
		public static void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y)
		{
			i_OpenGL2_0.glVertexAttrib2s(index, x, y);
		}
		public static void glVertexAttrib2sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL2_0.glVertexAttrib2sv(index, ref v);
		}
		public static void glVertexAttrib3d(UInt32 index, Double x, Double y, Double z)
		{
			i_OpenGL2_0.glVertexAttrib3d(index, x, y, z);
		}
		public static void glVertexAttrib3dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL2_0.glVertexAttrib3dv(index, ref v);
		}
		public static void glVertexAttrib3f(UInt32 index, Single x, Single y, Single z)
		{
			i_OpenGL2_0.glVertexAttrib3f(index, x, y, z);
		}
		public static void glVertexAttrib3fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL2_0.glVertexAttrib3fv(index, ref v);
		}
		public static void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL2_0.glVertexAttrib3s(index, x, y, z);
		}
		public static void glVertexAttrib3sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL2_0.glVertexAttrib3sv(index, ref v);
		}
		public static void glVertexAttrib4bv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL2_0.glVertexAttrib4bv(index, ref v);
		}
		public static void glVertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w)
		{
			i_OpenGL2_0.glVertexAttrib4d(index, x, y, z, w);
		}
		public static void glVertexAttrib4dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL2_0.glVertexAttrib4dv(index, ref v);
		}
		public static void glVertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w)
		{
			i_OpenGL2_0.glVertexAttrib4f(index, x, y, z, w);
		}
		public static void glVertexAttrib4fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL2_0.glVertexAttrib4fv(index, ref v);
		}
		public static void glVertexAttrib4iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL2_0.glVertexAttrib4iv(index, ref v);
		}
		public static void glVertexAttrib4Nbv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL2_0.glVertexAttrib4Nbv(index, ref v);
		}
		public static void glVertexAttrib4Niv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL2_0.glVertexAttrib4Niv(index, ref v);
		}
		public static void glVertexAttrib4Nsv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL2_0.glVertexAttrib4Nsv(index, ref v);
		}
		public static void glVertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w)
		{
			i_OpenGL2_0.glVertexAttrib4Nub(index, x, y, z, w);
		}
		public static void glVertexAttrib4Nubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL2_0.glVertexAttrib4Nubv(index, ref v);
		}
		public static void glVertexAttrib4Nuiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL2_0.glVertexAttrib4Nuiv(index, ref v);
		}
		public static void glVertexAttrib4Nusv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL2_0.glVertexAttrib4Nusv(index, ref v);
		}
		public static void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			i_OpenGL2_0.glVertexAttrib4s(index, x, y, z, w);
		}
		public static void glVertexAttrib4sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL2_0.glVertexAttrib4sv(index, ref v);
		}
		public static void glVertexAttrib4ubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL2_0.glVertexAttrib4ubv(index, ref v);
		}
		public static void glVertexAttrib4uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL2_0.glVertexAttrib4uiv(index, ref v);
		}
		public static void glVertexAttrib4usv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL2_0.glVertexAttrib4usv(index, ref v);
		}
		public static void glVertexAttribPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}
		public static void glVertexPointer(Int32 size, VertexPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL2_0.glVertexPointer(size, type, stride, pointer);
		}
		public static void glViewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL2_0.glViewport(x, y, width, height);
		}
		public static void glWindowPos2d(Double x, Double y)
		{
			i_OpenGL2_0.glWindowPos2d(x, y);
		}
		public static void glWindowPos2dv(ref Double[] v)
		{
			i_OpenGL2_0.glWindowPos2dv(ref v);
		}
		public static void glWindowPos2f(Single x, Single y)
		{
			i_OpenGL2_0.glWindowPos2f(x, y);
		}
		public static void glWindowPos2fv(ref Single[] v)
		{
			i_OpenGL2_0.glWindowPos2fv(ref v);
		}
		public static void glWindowPos2i(Int32 x, Int32 y)
		{
			i_OpenGL2_0.glWindowPos2i(x, y);
		}
		public static void glWindowPos2iv(ref Int32[] v)
		{
			i_OpenGL2_0.glWindowPos2iv(ref v);
		}
		public static void glWindowPos2s(Int16 x, Int16 y)
		{
			i_OpenGL2_0.glWindowPos2s(x, y);
		}
		public static void glWindowPos2sv(ref Int16[] v)
		{
			i_OpenGL2_0.glWindowPos2sv(ref v);
		}
		public static void glWindowPos3d(Double x, Double y, Double z)
		{
			i_OpenGL2_0.glWindowPos3d(x, y, z);
		}
		public static void glWindowPos3dv(ref Double[] v)
		{
			i_OpenGL2_0.glWindowPos3dv(ref v);
		}
		public static void glWindowPos3f(Single x, Single y, Single z)
		{
			i_OpenGL2_0.glWindowPos3f(x, y, z);
		}
		public static void glWindowPos3fv(ref Single[] v)
		{
			i_OpenGL2_0.glWindowPos3fv(ref v);
		}
		public static void glWindowPos3i(Int32 x, Int32 y, Int32 z)
		{
			i_OpenGL2_0.glWindowPos3i(x, y, z);
		}
		public static void glWindowPos3iv(ref Int32[] v)
		{
			i_OpenGL2_0.glWindowPos3iv(ref v);
		}
		public static void glWindowPos3s(Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL2_0.glWindowPos3s(x, y, z);
		}
		public static void glWindowPos3sv(ref Int16[] v)
		{
			i_OpenGL2_0.glWindowPos3sv(ref v);
		}
	}
}

