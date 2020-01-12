// OpenGL 3.3 Commands.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;
using System.Runtime.InteropServices;

namespace fgtk.OpenGL
{
	public static class OpenGL3_3
	{
		public static void glActiveTexture(TextureUnit texture)
		{
			i_OpenGL3_3.glActiveTexture(texture);
		}
		public static void glAttachShader(UInt32 program, UInt32 shader)
		{
			i_OpenGL3_3.glAttachShader(program, shader);
		}
		public static void glBeginConditionalRender(UInt32 id, TypeEnum mode)
		{
			i_OpenGL3_3.glBeginConditionalRender(id, mode);
		}
		public static void glBeginQuery(QueryTarget target, UInt32 id)
		{
			i_OpenGL3_3.glBeginQuery(target, id);
		}
		public static void glBeginTransformFeedback(PrimitiveType primitiveMode)
		{
			i_OpenGL3_3.glBeginTransformFeedback(primitiveMode);
		}
		public static void glBindAttribLocation(UInt32 program, UInt32 index, ref Char name)
		{
			i_OpenGL3_3.glBindAttribLocation(program, index, ref name);
		}
		public static void glBindBuffer(BufferTargetARB target, UInt32 buffer)
		{
			i_OpenGL3_3.glBindBuffer(target, buffer);
		}
		public static void glBindBufferBase(BufferTargetARB target, UInt32 index, UInt32 buffer)
		{
			i_OpenGL3_3.glBindBufferBase(target, index, buffer);
		}
		public static void glBindBufferRange(BufferTargetARB target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size)
		{
			i_OpenGL3_3.glBindBufferRange(target, index, buffer, offset, size);
		}
		public static void glBindFragDataLocation(UInt32 program, UInt32 color, ref string name)
		{
			i_OpenGL3_3.glBindFragDataLocation(program, color, ref name);
		}
		public static void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, ref Char name)
		{
			i_OpenGL3_3.glBindFragDataLocationIndexed(program, colorNumber, index, ref name);
		}
		public static void glBindFramebuffer(FramebufferTarget target, UInt32 framebuffer)
		{
			i_OpenGL3_3.glBindFramebuffer(target, framebuffer);
		}
		public static void glBindRenderbuffer(RenderbufferTarget target, UInt32 renderbuffer)
		{
			i_OpenGL3_3.glBindRenderbuffer(target, renderbuffer);
		}
		public static void glBindSampler(UInt32 unit, UInt32 sampler)
		{
			i_OpenGL3_3.glBindSampler(unit, sampler);
		}
		public static void glBindTexture(TextureTarget target, UInt32 texture)
		{
			i_OpenGL3_3.glBindTexture(target, texture);
		}
		public static void glBindVertexArray(UInt32 array)
		{
			i_OpenGL3_3.glBindVertexArray(array);
		}
		public static void glBlendColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL3_3.glBlendColor(red, green, blue, alpha);
		}
		public static void glBlendEquation(BlendEquationModeEXT mode)
		{
			i_OpenGL3_3.glBlendEquation(mode);
		}
		public static void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			i_OpenGL3_3.glBlendEquationSeparate(modeRGB, modeAlpha);
		}
		public static void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			i_OpenGL3_3.glBlendFunc(sfactor, dfactor);
		}
		public static void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
		{
			i_OpenGL3_3.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		public static void glBlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, BlitFramebufferFilter filter)
		{
			i_OpenGL3_3.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		public static void glBufferData(BufferTargetARB target, IntPtr size, IntPtr data, BufferUsageARB usage)
		{
			i_OpenGL3_3.glBufferData(target, size, data, usage);
		}
		public static void glBufferData<T>(BufferTargetARB target, IntPtr size, T[] data, BufferUsageARB usage) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			glBufferData(target, size, (IntPtr)ptr.AddrOfPinnedObject(), usage);
			ptr.Free();
		}
		public static void glBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL3_3.glBufferSubData(target, offset, size, data);
		}
		public static void glBufferSubData<T>(BufferTargetARB target, IntPtr offset, IntPtr size, T[] data) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			glBufferSubData(target, offset, size, (IntPtr)ptr.AddrOfPinnedObject());
			ptr.Free();
		}
		public static FramebufferStatus glCheckFramebufferStatus(FramebufferTarget target)
		{
			return i_OpenGL3_3.glCheckFramebufferStatus(target);
		}
		public static void glClampColor(GLenum target, GLenum clamp)
		{
			i_OpenGL3_3.glClampColor(target, clamp);
		}
		public static void glClear(UInt32 mask)
		{
			i_OpenGL3_3.glClear(mask);
		}
		public static void glClearBufferfi(Buffer buffer, Int32 drawbuffer, Single depth, Int32 stencil)
		{
			i_OpenGL3_3.glClearBufferfi(buffer, drawbuffer, depth, stencil);
		}
		public static void glClearBufferfv(Buffer buffer, Int32 drawbuffer, ref Single[] value)
		{
			i_OpenGL3_3.glClearBufferfv(buffer, drawbuffer, ref value);
		}
		public static void glClearBufferiv(Buffer buffer, Int32 drawbuffer, ref Int32[] value)
		{
			i_OpenGL3_3.glClearBufferiv(buffer, drawbuffer, ref value);
		}
		public static void glClearBufferuiv(Buffer buffer, Int32 drawbuffer, ref UInt32[] value)
		{
			i_OpenGL3_3.glClearBufferuiv(buffer, drawbuffer, ref value);
		}
		public static void glClearColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL3_3.glClearColor(red, green, blue, alpha);
		}
		public static void glClearDepth(Double depth)
		{
			i_OpenGL3_3.glClearDepth(depth);
		}
		public static void glClearStencil(Int32 s)
		{
			i_OpenGL3_3.glClearStencil(s);
		}
		public static SyncStatus glClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
		{
			return i_OpenGL3_3.glClientWaitSync(sync, flags, timeout);
		}
		public static void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
		{
			i_OpenGL3_3.glColorMask(red, green, blue, alpha);
		}
		public static void glColorMaski(UInt32 index, Boolean r, Boolean g, Boolean b, Boolean a)
		{
			i_OpenGL3_3.glColorMaski(index, r, g, b, a);
		}
		public static void glColorP3ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL3_3.glColorP3ui(type, color);
		}
		public static void glColorP3uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL3_3.glColorP3uiv(type, ref color);
		}
		public static void glColorP4ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL3_3.glColorP4ui(type, color);
		}
		public static void glColorP4uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL3_3.glColorP4uiv(type, ref color);
		}
		public static void glCompileShader(UInt32 shader)
		{
			i_OpenGL3_3.glCompileShader(shader);
		}
		public static void glCompressedTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL3_3.glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		}
		public static void glCompressedTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL3_3.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}
		public static void glCompressedTexImage3D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL3_3.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public static void glCompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL3_3.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		}
		public static void glCompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL3_3.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public static void glCompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL3_3.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public static void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
		{
			i_OpenGL3_3.glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		}
		public static void glCopyTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			i_OpenGL3_3.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}
		public static void glCopyTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			i_OpenGL3_3.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}
		public static void glCopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			i_OpenGL3_3.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}
		public static void glCopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL3_3.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}
		public static void glCopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL3_3.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		public static UInt32 glCreateProgram()
		{
			return i_OpenGL3_3.glCreateProgram();
		}
		public static UInt32 glCreateShader(ShaderType type)
		{
			return i_OpenGL3_3.glCreateShader(type);
		}
		public static void glCullFace(CullFaceMode mode)
		{
			i_OpenGL3_3.glCullFace(mode);
		}
		public static void glDeleteBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL3_3.glDeleteBuffers(n, ref buffers);
		}
		public static void glDeleteFramebuffers(Int32 n, ref UInt32[] framebuffers)
		{
			i_OpenGL3_3.glDeleteFramebuffers(n, ref framebuffers);
		}
		public static void glDeleteProgram(UInt32 program)
		{
			i_OpenGL3_3.glDeleteProgram(program);
		}
		public static void glDeleteQueries(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL3_3.glDeleteQueries(n, ref ids);
		}
		public static void glDeleteRenderbuffers(Int32 n, ref UInt32[] renderbuffers)
		{
			i_OpenGL3_3.glDeleteRenderbuffers(n, ref renderbuffers);
		}
		public static void glDeleteSamplers(Int32 count, ref UInt32[] samplers)
		{
			i_OpenGL3_3.glDeleteSamplers(count, ref samplers);
		}
		public static void glDeleteShader(UInt32 shader)
		{
			i_OpenGL3_3.glDeleteShader(shader);
		}
		public static void glDeleteSync(IntPtr sync)
		{
			i_OpenGL3_3.glDeleteSync(sync);
		}
		public static void glDeleteTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL3_3.glDeleteTextures(n, ref textures);
		}
		public static void glDeleteVertexArrays(Int32 n, ref UInt32[] arrays)
		{
			i_OpenGL3_3.glDeleteVertexArrays(n, ref arrays);
		}
		public static void glDepthFunc(DepthFunction func)
		{
			i_OpenGL3_3.glDepthFunc(func);
		}
		public static void glDepthMask(Boolean flag)
		{
			i_OpenGL3_3.glDepthMask(flag);
		}
		public static void glDepthRange(Double n, Double f)
		{
			i_OpenGL3_3.glDepthRange(n, f);
		}
		public static void glDetachShader(UInt32 program, UInt32 shader)
		{
			i_OpenGL3_3.glDetachShader(program, shader);
		}
		public static void glDisable(EnableCap cap)
		{
			i_OpenGL3_3.glDisable(cap);
		}
		public static void glDisablei(EnableCap target, UInt32 index)
		{
			i_OpenGL3_3.glDisablei(target, index);
		}
		public static void glDisableVertexAttribArray(UInt32 index)
		{
			i_OpenGL3_3.glDisableVertexAttribArray(index);
		}
		public static void glDrawArrays(PrimitiveType mode, Int32 first, Int32 count)
		{
			i_OpenGL3_3.glDrawArrays(mode, first, count);
		}
		public static void glDrawArraysInstanced(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount)
		{
			i_OpenGL3_3.glDrawArraysInstanced(mode, first, count, instancecount);
		}
		public static void glDrawBuffer(DrawBufferMode buf)
		{
			i_OpenGL3_3.glDrawBuffer(buf);
		}
		public static void glDrawBuffers(Int32 n, ref GLenum[] bufs)
		{
			i_OpenGL3_3.glDrawBuffers(n, ref bufs);
		}
		public static void glDrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL3_3.glDrawElements(mode, count, type, indices);
		}
		public static void glDrawElementsBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			i_OpenGL3_3.glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}
		public static void glDrawElementsInstanced(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount)
		{
			i_OpenGL3_3.glDrawElementsInstanced(mode, count, type, indices, instancecount);
		}
		public static void glDrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			i_OpenGL3_3.glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}
		public static void glDrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL3_3.glDrawRangeElements(mode, start, end, count, type, indices);
		}
		public static void glDrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			i_OpenGL3_3.glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}
		public static void glEnable(EnableCap cap)
		{
			i_OpenGL3_3.glEnable(cap);
		}
		public static void glEnablei(EnableCap target, UInt32 index)
		{
			i_OpenGL3_3.glEnablei(target, index);
		}
		public static void glEnableVertexAttribArray(UInt32 index)
		{
			i_OpenGL3_3.glEnableVertexAttribArray(index);
		}
		public static void glEndConditionalRender()
		{
			i_OpenGL3_3.glEndConditionalRender();
		}
		public static void glEndQuery(QueryTarget target)
		{
			i_OpenGL3_3.glEndQuery(target);
		}
		public static void glEndTransformFeedback()
		{
			i_OpenGL3_3.glEndTransformFeedback();
		}
		public static IntPtr glFenceSync(SyncCondition condition, UInt32 flags)
		{
			return i_OpenGL3_3.glFenceSync(condition, flags);
		}
		public static void glFinish()
		{
			i_OpenGL3_3.glFinish();
		}
		public static void glFlush()
		{
			i_OpenGL3_3.glFlush();
		}
		public static void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length)
		{
			i_OpenGL3_3.glFlushMappedBufferRange(target, offset, length);
		}
		public static void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
		{
			i_OpenGL3_3.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}
		public static void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level)
		{
			i_OpenGL3_3.glFramebufferTexture(target, attachment, texture, level);
		}
		public static void glFramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			i_OpenGL3_3.glFramebufferTexture1D(target, attachment, textarget, texture, level);
		}
		public static void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			i_OpenGL3_3.glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}
		public static void glFramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset)
		{
			i_OpenGL3_3.glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
		}
		public static void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			i_OpenGL3_3.glFramebufferTextureLayer(target, attachment, texture, level, layer);
		}
		public static void glFrontFace(FrontFaceDirection mode)
		{
			i_OpenGL3_3.glFrontFace(mode);
		}
		public static void glGenBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL3_3.glGenBuffers(n, ref buffers);
		}
		public static void glGenerateMipmap(TextureTarget target)
		{
			i_OpenGL3_3.glGenerateMipmap(target);
		}
		public static void glGenFramebuffers(Int32 n, ref UInt32[] framebuffers)
		{
			i_OpenGL3_3.glGenFramebuffers(n, ref framebuffers);
		}
		public static void glGenQueries(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL3_3.glGenQueries(n, ref ids);
		}
		public static void glGenRenderbuffers(Int32 n, ref UInt32[] renderbuffers)
		{
			i_OpenGL3_3.glGenRenderbuffers(n, ref renderbuffers);
		}
		public static void glGenSamplers(Int32 count, ref UInt32[] samplers)
		{
			i_OpenGL3_3.glGenSamplers(count, ref samplers);
		}
		public static void glGenTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL3_3.glGenTextures(n, ref textures);
		}
		public static void glGenVertexArrays(Int32 n, ref UInt32[] arrays)
		{
			i_OpenGL3_3.glGenVertexArrays(n, ref arrays);
		}
		public static void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string name)
		{
			i_OpenGL3_3.glGetActiveAttrib(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string name)
		{
			i_OpenGL3_3.glGetActiveUniform(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static void glGetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, UniformBlockPName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, ref @params);
		}
		public static void glGetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, ref Int32 length, ref string uniformBlockName)
		{
			i_OpenGL3_3.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, ref length, ref uniformBlockName);
		}
		public static void glGetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, ref Int32 length, ref string uniformName)
		{
			i_OpenGL3_3.glGetActiveUniformName(program, uniformIndex, bufSize, ref length, ref uniformName);
		}
		public static void glGetActiveUniformsiv(UInt32 program, Int32 uniformCount, ref UInt32[] uniformIndices, UniformPName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetActiveUniformsiv(program, uniformCount, ref uniformIndices, pname, ref @params);
		}
		public static void glGetAttachedShaders(UInt32 program, Int32 maxCount, ref Int32 count, ref UInt32[] shaders)
		{
			i_OpenGL3_3.glGetAttachedShaders(program, maxCount, ref count, ref shaders);
		}
		public static Int32 glGetAttribLocation(UInt32 program, ref Char name)
		{
			return i_OpenGL3_3.glGetAttribLocation(program, ref name);
		}
		public static void glGetBooleani_v(BufferTargetARB target, UInt32 index, ref Boolean[] data)
		{
			i_OpenGL3_3.glGetBooleani_v(target, index, ref data);
		}
		public static void glGetBooleanv(GetPName pname, ref Boolean[] data)
		{
			i_OpenGL3_3.glGetBooleanv(pname, ref data);
		}
		public static void glGetBufferParameteri64v(BufferTargetARB target, GLenum pname, ref Int64[] @params)
		{
			i_OpenGL3_3.glGetBufferParameteri64v(target, pname, ref @params);
		}
		public static void glGetBufferParameteriv(BufferTargetARB target, GLenum pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetBufferParameteriv(target, pname, ref @params);
		}
		public static void glGetBufferPointerv(BufferTargetARB target, GLenum pname, IntPtr @params)
		{
			i_OpenGL3_3.glGetBufferPointerv(target, pname, @params);
		}
		public static void glGetBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL3_3.glGetBufferSubData(target, offset, size, data);
		}
		public static void glGetCompressedTexImage(TextureTarget target, Int32 level, IntPtr img)
		{
			i_OpenGL3_3.glGetCompressedTexImage(target, level, img);
		}
		public static void glGetDoublev(GetPName pname, ref Double[] data)
		{
			i_OpenGL3_3.glGetDoublev(pname, ref data);
		}
		public static ErrorCode glGetError()
		{
			return i_OpenGL3_3.glGetError();
		}
		public static void glGetFloatv(GetPName pname, ref Single[] data)
		{
			i_OpenGL3_3.glGetFloatv(pname, ref data);
		}
		public static Int32 glGetFragDataIndex(UInt32 program, ref Char name)
		{
			return i_OpenGL3_3.glGetFragDataIndex(program, ref name);
		}
		public static Int32 glGetFragDataLocation(UInt32 program, ref string name)
		{
			return i_OpenGL3_3.glGetFragDataLocation(program, ref name);
		}
		public static void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetFramebufferAttachmentParameteriv(target, attachment, pname, ref @params);
		}
		public static void glGetInteger64i_v(TypeEnum target, UInt32 index, ref Int64[] data)
		{
			i_OpenGL3_3.glGetInteger64i_v(target, index, ref data);
		}
		public static void glGetInteger64v(GetPName pname, ref Int64[] data)
		{
			i_OpenGL3_3.glGetInteger64v(pname, ref data);
		}
		public static void glGetIntegeri_v(TypeEnum target, UInt32 index, ref Int32[] data)
		{
			i_OpenGL3_3.glGetIntegeri_v(target, index, ref data);
		}
		public static void glGetIntegerv(GetPName pname, ref Int32[] data)
		{
			i_OpenGL3_3.glGetIntegerv(pname, ref data);
		}
		public static void glGetMultisamplefv(GLenum pname, UInt32 index, ref Single[] val)
		{
			i_OpenGL3_3.glGetMultisamplefv(pname, index, ref val);
		}
		public static void glGetProgramInfoLog(UInt32 program, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL3_3.glGetProgramInfoLog(program, bufSize, ref length, ref infoLog);
		}
		public static void glGetProgramiv(UInt32 program, ProgramPropertyARB pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetProgramiv(program, pname, ref @params);
		}
		public static void glGetQueryiv(QueryTarget target, QueryParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetQueryiv(target, pname, ref @params);
		}
		public static void glGetQueryObjecti64v(UInt32 id, QueryObjectParameterName pname, ref Int64[] @params)
		{
			i_OpenGL3_3.glGetQueryObjecti64v(id, pname, ref @params);
		}
		public static void glGetQueryObjectiv(UInt32 id, QueryObjectParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetQueryObjectiv(id, pname, ref @params);
		}
		public static void glGetQueryObjectui64v(UInt32 id, QueryObjectParameterName pname, ref UInt64[] @params)
		{
			i_OpenGL3_3.glGetQueryObjectui64v(id, pname, ref @params);
		}
		public static void glGetQueryObjectuiv(UInt32 id, QueryObjectParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL3_3.glGetQueryObjectuiv(id, pname, ref @params);
		}
		public static void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetRenderbufferParameteriv(target, pname, ref @params);
		}
		public static void glGetSamplerParameterfv(UInt32 sampler, SamplerParameterName pname, ref Single[] @params)
		{
			i_OpenGL3_3.glGetSamplerParameterfv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameterIiv(UInt32 sampler, SamplerParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetSamplerParameterIiv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameterIuiv(UInt32 sampler, SamplerParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL3_3.glGetSamplerParameterIuiv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameteriv(UInt32 sampler, SamplerParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetSamplerParameteriv(sampler, pname, ref @params);
		}
		public static void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL3_3.glGetShaderInfoLog(shader, bufSize, ref length, ref infoLog);
		}
		public static void glGetShaderiv(UInt32 shader, ShaderParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetShaderiv(shader, pname, ref @params);
		}
		public static void glGetShaderSource(UInt32 shader, Int32 bufSize, ref Int32 length, ref string source)
		{
			i_OpenGL3_3.glGetShaderSource(shader, bufSize, ref length, ref source);
		}
		public static Byte glGetString(StringName name)
		{
			return i_OpenGL3_3.glGetString(name);
		}
		public static Byte glGetStringi(StringName name, UInt32 index)
		{
			return i_OpenGL3_3.glGetStringi(name, index);
		}
		public static void glGetSynciv(IntPtr sync, SyncParameterName pname, Int32 bufSize, ref Int32 length, ref Int32[] values)
		{
			i_OpenGL3_3.glGetSynciv(sync, pname, bufSize, ref length, ref values);
		}
		public static void glGetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL3_3.glGetTexImage(target, level, format, type, pixels);
		}
		public static void glGetTexLevelParameterfv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL3_3.glGetTexLevelParameterfv(target, level, pname, ref @params);
		}
		public static void glGetTexLevelParameteriv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetTexLevelParameteriv(target, level, pname, ref @params);
		}
		public static void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL3_3.glGetTexParameterfv(target, pname, ref @params);
		}
		public static void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetTexParameterIiv(target, pname, ref @params);
		}
		public static void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, ref UInt32[] @params)
		{
			i_OpenGL3_3.glGetTexParameterIuiv(target, pname, ref @params);
		}
		public static void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetTexParameteriv(target, pname, ref @params);
		}
		public static void glGetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref GLenum type, ref string name)
		{
			i_OpenGL3_3.glGetTransformFeedbackVarying(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static UInt32 glGetUniformBlockIndex(UInt32 program, ref string uniformBlockName)
		{
			return i_OpenGL3_3.glGetUniformBlockIndex(program, ref uniformBlockName);
		}
		public static void glGetUniformfv(UInt32 program, Int32 location, ref Single[] @params)
		{
			i_OpenGL3_3.glGetUniformfv(program, location, ref @params);
		}
		public static void glGetUniformIndices(UInt32 program, Int32 uniformCount, ref string uniformNames, ref UInt32[] uniformIndices)
		{
			i_OpenGL3_3.glGetUniformIndices(program, uniformCount, ref uniformNames, ref uniformIndices);
		}
		public static void glGetUniformiv(UInt32 program, Int32 location, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetUniformiv(program, location, ref @params);
		}
		public static Int32 glGetUniformLocation(UInt32 program, ref Char name)
		{
			return i_OpenGL3_3.glGetUniformLocation(program, ref name);
		}
		public static void glGetUniformuiv(UInt32 program, Int32 location, ref UInt32[] @params)
		{
			i_OpenGL3_3.glGetUniformuiv(program, location, ref @params);
		}
		public static void glGetVertexAttribdv(UInt32 index, GLenum pname, ref Double[] @params)
		{
			i_OpenGL3_3.glGetVertexAttribdv(index, pname, ref @params);
		}
		public static void glGetVertexAttribfv(UInt32 index, GLenum pname, ref Single[] @params)
		{
			i_OpenGL3_3.glGetVertexAttribfv(index, pname, ref @params);
		}
		public static void glGetVertexAttribIiv(UInt32 index, VertexAttribEnum pname, ref Int32 @params)
		{
			i_OpenGL3_3.glGetVertexAttribIiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribIuiv(UInt32 index, VertexAttribEnum pname, ref UInt32 @params)
		{
			i_OpenGL3_3.glGetVertexAttribIuiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribiv(UInt32 index, GLenum pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glGetVertexAttribiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribPointerv(UInt32 index, GLenum pname, IntPtr pointer)
		{
			i_OpenGL3_3.glGetVertexAttribPointerv(index, pname, pointer);
		}
		public static void glHint(HintTarget target, HintMode mode)
		{
			i_OpenGL3_3.glHint(target, mode);
		}
		public static Boolean glIsBuffer(UInt32 buffer)
		{
			return i_OpenGL3_3.glIsBuffer(buffer);
		}
		public static Boolean glIsEnabled(EnableCap cap)
		{
			return i_OpenGL3_3.glIsEnabled(cap);
		}
		public static Boolean glIsEnabledi(EnableCap target, UInt32 index)
		{
			return i_OpenGL3_3.glIsEnabledi(target, index);
		}
		public static Boolean glIsFramebuffer(UInt32 framebuffer)
		{
			return i_OpenGL3_3.glIsFramebuffer(framebuffer);
		}
		public static Boolean glIsProgram(UInt32 program)
		{
			return i_OpenGL3_3.glIsProgram(program);
		}
		public static Boolean glIsQuery(UInt32 id)
		{
			return i_OpenGL3_3.glIsQuery(id);
		}
		public static Boolean glIsRenderbuffer(UInt32 renderbuffer)
		{
			return i_OpenGL3_3.glIsRenderbuffer(renderbuffer);
		}
		public static Boolean glIsSampler(UInt32 sampler)
		{
			return i_OpenGL3_3.glIsSampler(sampler);
		}
		public static Boolean glIsShader(UInt32 shader)
		{
			return i_OpenGL3_3.glIsShader(shader);
		}
		public static Boolean glIsSync(IntPtr sync)
		{
			return i_OpenGL3_3.glIsSync(sync);
		}
		public static Boolean glIsTexture(UInt32 texture)
		{
			return i_OpenGL3_3.glIsTexture(texture);
		}
		public static Boolean glIsVertexArray(UInt32 array)
		{
			return i_OpenGL3_3.glIsVertexArray(array);
		}
		public static void glLineWidth(Single width)
		{
			i_OpenGL3_3.glLineWidth(width);
		}
		public static void glLinkProgram(UInt32 program)
		{
			i_OpenGL3_3.glLinkProgram(program);
		}
		public static void glLogicOp(LogicOp opcode)
		{
			i_OpenGL3_3.glLogicOp(opcode);
		}
		public static IntPtr glMapBuffer(BufferTargetARB target, BufferAccessARB access)
		{
			return i_OpenGL3_3.glMapBuffer(target, access);
		}
		public static IntPtr glMapBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length, UInt32 access)
		{
			return i_OpenGL3_3.glMapBufferRange(target, offset, length, access);
		}
		public static void glMultiDrawArrays(PrimitiveType mode, ref Int32[] first, ref Int32[] count, Int32 drawcount)
		{
			i_OpenGL3_3.glMultiDrawArrays(mode, ref first, ref count, drawcount);
		}
		public static void glMultiDrawElements(PrimitiveType mode, ref Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount)
		{
			i_OpenGL3_3.glMultiDrawElements(mode, ref count, type, indices, drawcount);
		}
		public static void glMultiDrawElementsBaseVertex(PrimitiveType mode, ref Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount, ref Int32[] basevertex)
		{
			i_OpenGL3_3.glMultiDrawElementsBaseVertex(mode, ref count, type, indices, drawcount, ref basevertex);
		}
		public static void glMultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glMultiTexCoordP1ui(texture, type, coords);
		}
		public static void glMultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glMultiTexCoordP1uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glMultiTexCoordP2ui(texture, type, coords);
		}
		public static void glMultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glMultiTexCoordP2uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glMultiTexCoordP3ui(texture, type, coords);
		}
		public static void glMultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glMultiTexCoordP3uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glMultiTexCoordP4ui(texture, type, coords);
		}
		public static void glMultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glMultiTexCoordP4uiv(texture, type, ref coords);
		}
		public static void glNormalP3ui(NormalPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glNormalP3ui(type, coords);
		}
		public static void glNormalP3uiv(NormalPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glNormalP3uiv(type, ref coords);
		}
		public static void glPixelStoref(PixelStoreParameter pname, Single param)
		{
			i_OpenGL3_3.glPixelStoref(pname, param);
		}
		public static void glPixelStorei(PixelStoreParameter pname, Int32 param)
		{
			i_OpenGL3_3.glPixelStorei(pname, param);
		}
		public static void glPointParameterf(GLenum pname, Single param)
		{
			i_OpenGL3_3.glPointParameterf(pname, param);
		}
		public static void glPointParameterfv(GLenum pname, ref Single[] @params)
		{
			i_OpenGL3_3.glPointParameterfv(pname, ref @params);
		}
		public static void glPointParameteri(GLenum pname, Int32 param)
		{
			i_OpenGL3_3.glPointParameteri(pname, param);
		}
		public static void glPointParameteriv(GLenum pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glPointParameteriv(pname, ref @params);
		}
		public static void glPointSize(Single size)
		{
			i_OpenGL3_3.glPointSize(size);
		}
		public static void glPolygonMode(MaterialFace face, PolygonMode mode)
		{
			i_OpenGL3_3.glPolygonMode(face, mode);
		}
		public static void glPolygonOffset(Single factor, Single units)
		{
			i_OpenGL3_3.glPolygonOffset(factor, units);
		}
		public static void glPrimitiveRestartIndex(UInt32 index)
		{
			i_OpenGL3_3.glPrimitiveRestartIndex(index);
		}
		public static void glProvokingVertex(VertexProvokingMode mode)
		{
			i_OpenGL3_3.glProvokingVertex(mode);
		}
		public static void glQueryCounter(UInt32 id, QueryTarget target)
		{
			i_OpenGL3_3.glQueryCounter(id, target);
		}
		public static void glReadBuffer(ReadBufferMode src)
		{
			i_OpenGL3_3.glReadBuffer(src);
		}
		public static void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL3_3.glReadPixels(x, y, width, height, format, type, pixels);
		}
		public static void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL3_3.glRenderbufferStorage(target, internalformat, width, height);
		}
		public static void glRenderbufferStorageMultisample(RenderbufferTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL3_3.glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		}
		public static void glSampleCoverage(Single value, Boolean invert)
		{
			i_OpenGL3_3.glSampleCoverage(value, invert);
		}
		public static void glSampleMaski(UInt32 maskNumber, UInt32 mask)
		{
			i_OpenGL3_3.glSampleMaski(maskNumber, mask);
		}
		public static void glSamplerParameterf(UInt32 sampler, SamplerParameterName pname, Single param)
		{
			i_OpenGL3_3.glSamplerParameterf(sampler, pname, param);
		}
		public static void glSamplerParameterfv(UInt32 sampler, SamplerParameterName pname, ref Single[] param)
		{
			i_OpenGL3_3.glSamplerParameterfv(sampler, pname, ref param);
		}
		public static void glSamplerParameteri(UInt32 sampler, SamplerParameterName pname, Int32 param)
		{
			i_OpenGL3_3.glSamplerParameteri(sampler, pname, param);
		}
		public static void glSamplerParameterIiv(UInt32 sampler, SamplerParameterName pname, ref Int32[] param)
		{
			i_OpenGL3_3.glSamplerParameterIiv(sampler, pname, ref param);
		}
		public static void glSamplerParameterIuiv(UInt32 sampler, SamplerParameterName pname, ref UInt32[] param)
		{
			i_OpenGL3_3.glSamplerParameterIuiv(sampler, pname, ref param);
		}
		public static void glSamplerParameteriv(UInt32 sampler, SamplerParameterName pname, ref Int32[] param)
		{
			i_OpenGL3_3.glSamplerParameteriv(sampler, pname, ref param);
		}
		public static void glScissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL3_3.glScissor(x, y, width, height);
		}
		public static void glSecondaryColorP3ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL3_3.glSecondaryColorP3ui(type, color);
		}
		public static void glSecondaryColorP3uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL3_3.glSecondaryColorP3uiv(type, ref color);
		}
		public static void glShaderSource(UInt32 shader, Int32 count, ref string @string, ref Int32[] length)
		{
			i_OpenGL3_3.glShaderSource(shader, count, ref @string, ref length);
		}
		public static void glStencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL3_3.glStencilFunc(func, @ref, mask);
		}
		public static void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL3_3.glStencilFuncSeparate(face, func, @ref, mask);
		}
		public static void glStencilMask(UInt32 mask)
		{
			i_OpenGL3_3.glStencilMask(mask);
		}
		public static void glStencilMaskSeparate(StencilFaceDirection face, UInt32 mask)
		{
			i_OpenGL3_3.glStencilMaskSeparate(face, mask);
		}
		public static void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			i_OpenGL3_3.glStencilOp(fail, zfail, zpass);
		}
		public static void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			i_OpenGL3_3.glStencilOpSeparate(face, sfail, dpfail, dppass);
		}
		public static void glTexBuffer(TextureTarget target, InternalFormat internalformat, UInt32 buffer)
		{
			i_OpenGL3_3.glTexBuffer(target, internalformat, buffer);
		}
		public static void glTexCoordP1ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glTexCoordP1ui(type, coords);
		}
		public static void glTexCoordP1uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glTexCoordP1uiv(type, ref coords);
		}
		public static void glTexCoordP2ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glTexCoordP2ui(type, coords);
		}
		public static void glTexCoordP2uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glTexCoordP2uiv(type, ref coords);
		}
		public static void glTexCoordP3ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glTexCoordP3ui(type, coords);
		}
		public static void glTexCoordP3uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glTexCoordP3uiv(type, ref coords);
		}
		public static void glTexCoordP4ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL3_3.glTexCoordP4ui(type, coords);
		}
		public static void glTexCoordP4uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL3_3.glTexCoordP4uiv(type, ref coords);
		}
		public static void glTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL3_3.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}
		public static void glTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL3_3.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}
		public static void glTexImage2DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Boolean fixedsamplelocations)
		{
			i_OpenGL3_3.glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		public static void glTexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL3_3.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		public static void glTexImage3DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
		{
			i_OpenGL3_3.glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		public static void glTexParameterf(TextureTarget target, TextureParameterName pname, Single param)
		{
			i_OpenGL3_3.glTexParameterf(target, pname, param);
		}
		public static void glTexParameterfv(TextureTarget target, TextureParameterName pname, ref Single[] @params)
		{
			i_OpenGL3_3.glTexParameterfv(target, pname, ref @params);
		}
		public static void glTexParameteri(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			i_OpenGL3_3.glTexParameteri(target, pname, param);
		}
		public static void glTexParameterIiv(TextureTarget target, TextureParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glTexParameterIiv(target, pname, ref @params);
		}
		public static void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL3_3.glTexParameterIuiv(target, pname, ref @params);
		}
		public static void glTexParameteriv(TextureTarget target, TextureParameterName pname, ref Int32[] @params)
		{
			i_OpenGL3_3.glTexParameteriv(target, pname, ref @params);
		}
		public static void glTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL3_3.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}
		public static void glTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL3_3.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		public static void glTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL3_3.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public static void glTransformFeedbackVaryings(UInt32 program, Int32 count, ref string varyings, GLenum bufferMode)
		{
			i_OpenGL3_3.glTransformFeedbackVaryings(program, count, ref varyings, bufferMode);
		}
		public static void glUniform1f(Int32 location, Single v0)
		{
			i_OpenGL3_3.glUniform1f(location, v0);
		}
		public static void glUniform1fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL3_3.glUniform1fv(location, count, ref value);
		}
		public static void glUniform1i(Int32 location, Int32 v0)
		{
			i_OpenGL3_3.glUniform1i(location, v0);
		}
		public static void glUniform1iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL3_3.glUniform1iv(location, count, ref value);
		}
		public static void glUniform1ui(Int32 location, UInt32 v0)
		{
			i_OpenGL3_3.glUniform1ui(location, v0);
		}
		public static void glUniform1uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL3_3.glUniform1uiv(location, count, ref value);
		}
		public static void glUniform2f(Int32 location, Single v0, Single v1)
		{
			i_OpenGL3_3.glUniform2f(location, v0, v1);
		}
		public static void glUniform2fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL3_3.glUniform2fv(location, count, ref value);
		}
		public static void glUniform2i(Int32 location, Int32 v0, Int32 v1)
		{
			i_OpenGL3_3.glUniform2i(location, v0, v1);
		}
		public static void glUniform2iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL3_3.glUniform2iv(location, count, ref value);
		}
		public static void glUniform2ui(Int32 location, UInt32 v0, UInt32 v1)
		{
			i_OpenGL3_3.glUniform2ui(location, v0, v1);
		}
		public static void glUniform2uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL3_3.glUniform2uiv(location, count, ref value);
		}
		public static void glUniform3f(Int32 location, Single v0, Single v1, Single v2)
		{
			i_OpenGL3_3.glUniform3f(location, v0, v1, v2);
		}
		public static void glUniform3fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL3_3.glUniform3fv(location, count, ref value);
		}
		public static void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			i_OpenGL3_3.glUniform3i(location, v0, v1, v2);
		}
		public static void glUniform3iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL3_3.glUniform3iv(location, count, ref value);
		}
		public static void glUniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			i_OpenGL3_3.glUniform3ui(location, v0, v1, v2);
		}
		public static void glUniform3uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL3_3.glUniform3uiv(location, count, ref value);
		}
		public static void glUniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3)
		{
			i_OpenGL3_3.glUniform4f(location, v0, v1, v2, v3);
		}
		public static void glUniform4fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL3_3.glUniform4fv(location, count, ref value);
		}
		public static void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			i_OpenGL3_3.glUniform4i(location, v0, v1, v2, v3);
		}
		public static void glUniform4iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL3_3.glUniform4iv(location, count, ref value);
		}
		public static void glUniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			i_OpenGL3_3.glUniform4ui(location, v0, v1, v2, v3);
		}
		public static void glUniform4uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL3_3.glUniform4uiv(location, count, ref value);
		}
		public static void glUniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding)
		{
			i_OpenGL3_3.glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}
		public static void glUniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix2x3fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix2x4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix3fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix3x2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix3x4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix4x2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL3_3.glUniformMatrix4x3fv(location, count, transpose, ref value);
		}
		public static Boolean glUnmapBuffer(BufferTargetARB target)
		{
			return i_OpenGL3_3.glUnmapBuffer(target);
		}
		public static void glUseProgram(UInt32 program)
		{
			i_OpenGL3_3.glUseProgram(program);
		}
		public static void glValidateProgram(UInt32 program)
		{
			i_OpenGL3_3.glValidateProgram(program);
		}
		public static void glVertexAttrib1d(UInt32 index, Double x)
		{
			i_OpenGL3_3.glVertexAttrib1d(index, x);
		}
		public static void glVertexAttrib1dv(UInt32 index, ref Double v)
		{
			i_OpenGL3_3.glVertexAttrib1dv(index, ref v);
		}
		public static void glVertexAttrib1f(UInt32 index, Single x)
		{
			i_OpenGL3_3.glVertexAttrib1f(index, x);
		}
		public static void glVertexAttrib1fv(UInt32 index, ref Single v)
		{
			i_OpenGL3_3.glVertexAttrib1fv(index, ref v);
		}
		public static void glVertexAttrib1s(UInt32 index, Int16 x)
		{
			i_OpenGL3_3.glVertexAttrib1s(index, x);
		}
		public static void glVertexAttrib1sv(UInt32 index, ref Int16 v)
		{
			i_OpenGL3_3.glVertexAttrib1sv(index, ref v);
		}
		public static void glVertexAttrib2d(UInt32 index, Double x, Double y)
		{
			i_OpenGL3_3.glVertexAttrib2d(index, x, y);
		}
		public static void glVertexAttrib2dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL3_3.glVertexAttrib2dv(index, ref v);
		}
		public static void glVertexAttrib2f(UInt32 index, Single x, Single y)
		{
			i_OpenGL3_3.glVertexAttrib2f(index, x, y);
		}
		public static void glVertexAttrib2fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL3_3.glVertexAttrib2fv(index, ref v);
		}
		public static void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y)
		{
			i_OpenGL3_3.glVertexAttrib2s(index, x, y);
		}
		public static void glVertexAttrib2sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL3_3.glVertexAttrib2sv(index, ref v);
		}
		public static void glVertexAttrib3d(UInt32 index, Double x, Double y, Double z)
		{
			i_OpenGL3_3.glVertexAttrib3d(index, x, y, z);
		}
		public static void glVertexAttrib3dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL3_3.glVertexAttrib3dv(index, ref v);
		}
		public static void glVertexAttrib3f(UInt32 index, Single x, Single y, Single z)
		{
			i_OpenGL3_3.glVertexAttrib3f(index, x, y, z);
		}
		public static void glVertexAttrib3fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL3_3.glVertexAttrib3fv(index, ref v);
		}
		public static void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL3_3.glVertexAttrib3s(index, x, y, z);
		}
		public static void glVertexAttrib3sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL3_3.glVertexAttrib3sv(index, ref v);
		}
		public static void glVertexAttrib4bv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL3_3.glVertexAttrib4bv(index, ref v);
		}
		public static void glVertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w)
		{
			i_OpenGL3_3.glVertexAttrib4d(index, x, y, z, w);
		}
		public static void glVertexAttrib4dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL3_3.glVertexAttrib4dv(index, ref v);
		}
		public static void glVertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w)
		{
			i_OpenGL3_3.glVertexAttrib4f(index, x, y, z, w);
		}
		public static void glVertexAttrib4fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL3_3.glVertexAttrib4fv(index, ref v);
		}
		public static void glVertexAttrib4iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL3_3.glVertexAttrib4iv(index, ref v);
		}
		public static void glVertexAttrib4Nbv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL3_3.glVertexAttrib4Nbv(index, ref v);
		}
		public static void glVertexAttrib4Niv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL3_3.glVertexAttrib4Niv(index, ref v);
		}
		public static void glVertexAttrib4Nsv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL3_3.glVertexAttrib4Nsv(index, ref v);
		}
		public static void glVertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w)
		{
			i_OpenGL3_3.glVertexAttrib4Nub(index, x, y, z, w);
		}
		public static void glVertexAttrib4Nubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL3_3.glVertexAttrib4Nubv(index, ref v);
		}
		public static void glVertexAttrib4Nuiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL3_3.glVertexAttrib4Nuiv(index, ref v);
		}
		public static void glVertexAttrib4Nusv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL3_3.glVertexAttrib4Nusv(index, ref v);
		}
		public static void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			i_OpenGL3_3.glVertexAttrib4s(index, x, y, z, w);
		}
		public static void glVertexAttrib4sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL3_3.glVertexAttrib4sv(index, ref v);
		}
		public static void glVertexAttrib4ubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL3_3.glVertexAttrib4ubv(index, ref v);
		}
		public static void glVertexAttrib4uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL3_3.glVertexAttrib4uiv(index, ref v);
		}
		public static void glVertexAttrib4usv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL3_3.glVertexAttrib4usv(index, ref v);
		}
		public static void glVertexAttribDivisor(UInt32 index, UInt32 divisor)
		{
			i_OpenGL3_3.glVertexAttribDivisor(index, divisor);
		}
		public static void glVertexAttribI1i(UInt32 index, Int32 x)
		{
			i_OpenGL3_3.glVertexAttribI1i(index, x);
		}
		public static void glVertexAttribI1iv(UInt32 index, ref Int32 v)
		{
			i_OpenGL3_3.glVertexAttribI1iv(index, ref v);
		}
		public static void glVertexAttribI1ui(UInt32 index, UInt32 x)
		{
			i_OpenGL3_3.glVertexAttribI1ui(index, x);
		}
		public static void glVertexAttribI1uiv(UInt32 index, ref UInt32 v)
		{
			i_OpenGL3_3.glVertexAttribI1uiv(index, ref v);
		}
		public static void glVertexAttribI2i(UInt32 index, Int32 x, Int32 y)
		{
			i_OpenGL3_3.glVertexAttribI2i(index, x, y);
		}
		public static void glVertexAttribI2iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL3_3.glVertexAttribI2iv(index, ref v);
		}
		public static void glVertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y)
		{
			i_OpenGL3_3.glVertexAttribI2ui(index, x, y);
		}
		public static void glVertexAttribI2uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL3_3.glVertexAttribI2uiv(index, ref v);
		}
		public static void glVertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z)
		{
			i_OpenGL3_3.glVertexAttribI3i(index, x, y, z);
		}
		public static void glVertexAttribI3iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL3_3.glVertexAttribI3iv(index, ref v);
		}
		public static void glVertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z)
		{
			i_OpenGL3_3.glVertexAttribI3ui(index, x, y, z);
		}
		public static void glVertexAttribI3uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL3_3.glVertexAttribI3uiv(index, ref v);
		}
		public static void glVertexAttribI4bv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL3_3.glVertexAttribI4bv(index, ref v);
		}
		public static void glVertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			i_OpenGL3_3.glVertexAttribI4i(index, x, y, z, w);
		}
		public static void glVertexAttribI4iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL3_3.glVertexAttribI4iv(index, ref v);
		}
		public static void glVertexAttribI4sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL3_3.glVertexAttribI4sv(index, ref v);
		}
		public static void glVertexAttribI4ubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL3_3.glVertexAttribI4ubv(index, ref v);
		}
		public static void glVertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			i_OpenGL3_3.glVertexAttribI4ui(index, x, y, z, w);
		}
		public static void glVertexAttribI4uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL3_3.glVertexAttribI4uiv(index, ref v);
		}
		public static void glVertexAttribI4usv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL3_3.glVertexAttribI4usv(index, ref v);
		}
		public static void glVertexAttribIPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL3_3.glVertexAttribIPointer(index, size, type, stride, pointer);
		}
		public static void glVertexAttribP1ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL3_3.glVertexAttribP1ui(index, type, normalized, value);
		}
		public static void glVertexAttribP1uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL3_3.glVertexAttribP1uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP2ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL3_3.glVertexAttribP2ui(index, type, normalized, value);
		}
		public static void glVertexAttribP2uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL3_3.glVertexAttribP2uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP3ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL3_3.glVertexAttribP3ui(index, type, normalized, value);
		}
		public static void glVertexAttribP3uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL3_3.glVertexAttribP3uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP4ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL3_3.glVertexAttribP4ui(index, type, normalized, value);
		}
		public static void glVertexAttribP4uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL3_3.glVertexAttribP4uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer)
		{
			i_OpenGL3_3.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}
		public static void glVertexP2ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL3_3.glVertexP2ui(type, value);
		}
		public static void glVertexP2uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL3_3.glVertexP2uiv(type, ref value);
		}
		public static void glVertexP3ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL3_3.glVertexP3ui(type, value);
		}
		public static void glVertexP3uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL3_3.glVertexP3uiv(type, ref value);
		}
		public static void glVertexP4ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL3_3.glVertexP4ui(type, value);
		}
		public static void glVertexP4uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL3_3.glVertexP4uiv(type, ref value);
		}
		public static void glViewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL3_3.glViewport(x, y, width, height);
		}
		public static void glWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
		{
			i_OpenGL3_3.glWaitSync(sync, flags, timeout);
		}
	}
}

