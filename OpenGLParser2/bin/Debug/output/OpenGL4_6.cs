// OpenGL 4.6 Commands.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;
using System.Runtime.InteropServices;

namespace fgtk.OpenGL
{
	public static class OpenGL4_6
	{
		public static void glActiveShaderProgram(UInt32 pipeline, UInt32 program)
		{
			i_OpenGL4_6.glActiveShaderProgram(pipeline, program);
		}
		public static void glActiveTexture(TextureUnit texture)
		{
			i_OpenGL4_6.glActiveTexture(texture);
		}
		public static void glAttachShader(UInt32 program, UInt32 shader)
		{
			i_OpenGL4_6.glAttachShader(program, shader);
		}
		public static void glBeginConditionalRender(UInt32 id, TypeEnum mode)
		{
			i_OpenGL4_6.glBeginConditionalRender(id, mode);
		}
		public static void glBeginQuery(QueryTarget target, UInt32 id)
		{
			i_OpenGL4_6.glBeginQuery(target, id);
		}
		public static void glBeginQueryIndexed(QueryTarget target, UInt32 index, UInt32 id)
		{
			i_OpenGL4_6.glBeginQueryIndexed(target, index, id);
		}
		public static void glBeginTransformFeedback(PrimitiveType primitiveMode)
		{
			i_OpenGL4_6.glBeginTransformFeedback(primitiveMode);
		}
		public static void glBindAttribLocation(UInt32 program, UInt32 index, ref Char name)
		{
			i_OpenGL4_6.glBindAttribLocation(program, index, ref name);
		}
		public static void glBindBuffer(BufferTargetARB target, UInt32 buffer)
		{
			i_OpenGL4_6.glBindBuffer(target, buffer);
		}
		public static void glBindBufferBase(BufferTargetARB target, UInt32 index, UInt32 buffer)
		{
			i_OpenGL4_6.glBindBufferBase(target, index, buffer);
		}
		public static void glBindBufferRange(BufferTargetARB target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size)
		{
			i_OpenGL4_6.glBindBufferRange(target, index, buffer, offset, size);
		}
		public static void glBindBuffersBase(BufferTargetARB target, UInt32 first, Int32 count, ref UInt32[] buffers)
		{
			i_OpenGL4_6.glBindBuffersBase(target, first, count, ref buffers);
		}
		public static void glBindBuffersRange(BufferTargetARB target, UInt32 first, Int32 count, ref UInt32[] buffers, IntPtr offsets, IntPtr sizes)
		{
			i_OpenGL4_6.glBindBuffersRange(target, first, count, ref buffers, offsets, sizes);
		}
		public static void glBindFragDataLocation(UInt32 program, UInt32 color, ref string name)
		{
			i_OpenGL4_6.glBindFragDataLocation(program, color, ref name);
		}
		public static void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, ref Char name)
		{
			i_OpenGL4_6.glBindFragDataLocationIndexed(program, colorNumber, index, ref name);
		}
		public static void glBindFramebuffer(FramebufferTarget target, UInt32 framebuffer)
		{
			i_OpenGL4_6.glBindFramebuffer(target, framebuffer);
		}
		public static void glBindImageTexture(UInt32 unit, UInt32 texture, Int32 level, Boolean layered, Int32 layer, BufferAccessARB access, InternalFormat format)
		{
			i_OpenGL4_6.glBindImageTexture(unit, texture, level, layered, layer, access, format);
		}
		public static void glBindImageTextures(UInt32 first, Int32 count, ref UInt32[] textures)
		{
			i_OpenGL4_6.glBindImageTextures(first, count, ref textures);
		}
		public static void glBindProgramPipeline(UInt32 pipeline)
		{
			i_OpenGL4_6.glBindProgramPipeline(pipeline);
		}
		public static void glBindRenderbuffer(RenderbufferTarget target, UInt32 renderbuffer)
		{
			i_OpenGL4_6.glBindRenderbuffer(target, renderbuffer);
		}
		public static void glBindSampler(UInt32 unit, UInt32 sampler)
		{
			i_OpenGL4_6.glBindSampler(unit, sampler);
		}
		public static void glBindSamplers(UInt32 first, Int32 count, ref UInt32[] samplers)
		{
			i_OpenGL4_6.glBindSamplers(first, count, ref samplers);
		}
		public static void glBindTexture(TextureTarget target, UInt32 texture)
		{
			i_OpenGL4_6.glBindTexture(target, texture);
		}
		public static void glBindTextures(UInt32 first, Int32 count, ref UInt32[] textures)
		{
			i_OpenGL4_6.glBindTextures(first, count, ref textures);
		}
		public static void glBindTextureUnit(UInt32 unit, UInt32 texture)
		{
			i_OpenGL4_6.glBindTextureUnit(unit, texture);
		}
		public static void glBindTransformFeedback(BindTransformFeedbackTarget target, UInt32 id)
		{
			i_OpenGL4_6.glBindTransformFeedback(target, id);
		}
		public static void glBindVertexArray(UInt32 array)
		{
			i_OpenGL4_6.glBindVertexArray(array);
		}
		public static void glBindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
		{
			i_OpenGL4_6.glBindVertexBuffer(bindingindex, buffer, offset, stride);
		}
		public static void glBindVertexBuffers(UInt32 first, Int32 count, ref UInt32[] buffers, IntPtr offsets, ref Int32[] strides)
		{
			i_OpenGL4_6.glBindVertexBuffers(first, count, ref buffers, offsets, ref strides);
		}
		public static void glBlendColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL4_6.glBlendColor(red, green, blue, alpha);
		}
		public static void glBlendEquation(BlendEquationModeEXT mode)
		{
			i_OpenGL4_6.glBlendEquation(mode);
		}
		public static void glBlendEquationi(UInt32 buf, BlendEquationModeEXT mode)
		{
			i_OpenGL4_6.glBlendEquationi(buf, mode);
		}
		public static void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			i_OpenGL4_6.glBlendEquationSeparate(modeRGB, modeAlpha);
		}
		public static void glBlendEquationSeparatei(UInt32 buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			i_OpenGL4_6.glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		}
		public static void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			i_OpenGL4_6.glBlendFunc(sfactor, dfactor);
		}
		public static void glBlendFunci(UInt32 buf, BlendingFactor src, BlendingFactor dst)
		{
			i_OpenGL4_6.glBlendFunci(buf, src, dst);
		}
		public static void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
		{
			i_OpenGL4_6.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		public static void glBlendFuncSeparatei(UInt32 buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
		{
			i_OpenGL4_6.glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		public static void glBlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, BlitFramebufferFilter filter)
		{
			i_OpenGL4_6.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		public static void glBlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, BlitFramebufferFilter filter)
		{
			i_OpenGL4_6.glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		public static void glBufferData(BufferTargetARB target, IntPtr size, IntPtr data, BufferUsageARB usage)
		{
			i_OpenGL4_6.glBufferData(target, size, data, usage);
		}
		public static void glBufferData<T>(BufferTargetARB target, IntPtr size, T[] data, BufferUsageARB usage) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			glBufferData(target, size, (IntPtr)ptr.AddrOfPinnedObject(), usage);
			ptr.Free();
		}
		public static void glBufferStorage(BufferStorageTarget target, IntPtr size, IntPtr data, UInt32 flags)
		{
			i_OpenGL4_6.glBufferStorage(target, size, data, flags);
		}
		public static void glBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL4_6.glBufferSubData(target, offset, size, data);
		}
		public static void glBufferSubData<T>(BufferTargetARB target, IntPtr offset, IntPtr size, T[] data) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			glBufferSubData(target, offset, size, (IntPtr)ptr.AddrOfPinnedObject());
			ptr.Free();
		}
		public static FramebufferStatus glCheckFramebufferStatus(FramebufferTarget target)
		{
			return i_OpenGL4_6.glCheckFramebufferStatus(target);
		}
		public static FramebufferStatus glCheckNamedFramebufferStatus(UInt32 framebuffer, FramebufferTarget target)
		{
			return i_OpenGL4_6.glCheckNamedFramebufferStatus(framebuffer, target);
		}
		public static void glClampColor(GLenum target, GLenum clamp)
		{
			i_OpenGL4_6.glClampColor(target, clamp);
		}
		public static void glClear(UInt32 mask)
		{
			i_OpenGL4_6.glClear(mask);
		}
		public static void glClearBufferData(BufferStorageTarget target, InternalFormat internalformat, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_6.glClearBufferData(target, internalformat, format, type, data);
		}
		public static void glClearBufferfi(Buffer buffer, Int32 drawbuffer, Single depth, Int32 stencil)
		{
			i_OpenGL4_6.glClearBufferfi(buffer, drawbuffer, depth, stencil);
		}
		public static void glClearBufferfv(Buffer buffer, Int32 drawbuffer, ref Single[] value)
		{
			i_OpenGL4_6.glClearBufferfv(buffer, drawbuffer, ref value);
		}
		public static void glClearBufferiv(Buffer buffer, Int32 drawbuffer, ref Int32[] value)
		{
			i_OpenGL4_6.glClearBufferiv(buffer, drawbuffer, ref value);
		}
		public static void glClearBufferSubData(GLenum target, InternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_6.glClearBufferSubData(target, internalformat, offset, size, format, type, data);
		}
		public static void glClearBufferuiv(Buffer buffer, Int32 drawbuffer, ref UInt32[] value)
		{
			i_OpenGL4_6.glClearBufferuiv(buffer, drawbuffer, ref value);
		}
		public static void glClearColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL4_6.glClearColor(red, green, blue, alpha);
		}
		public static void glClearDepth(Double depth)
		{
			i_OpenGL4_6.glClearDepth(depth);
		}
		public static void glClearDepthf(Single d)
		{
			i_OpenGL4_6.glClearDepthf(d);
		}
		public static void glClearNamedBufferData(UInt32 buffer, InternalFormat internalformat, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_6.glClearNamedBufferData(buffer, internalformat, format, type, data);
		}
		public static void glClearNamedBufferSubData(UInt32 buffer, InternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_6.glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
		}
		public static void glClearNamedFramebufferfi(UInt32 framebuffer, Buffer buffer, Int32 drawbuffer, Single depth, Int32 stencil)
		{
			i_OpenGL4_6.glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
		}
		public static void glClearNamedFramebufferfv(UInt32 framebuffer, Buffer buffer, Int32 drawbuffer, ref Single value)
		{
			i_OpenGL4_6.glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, ref value);
		}
		public static void glClearNamedFramebufferiv(UInt32 framebuffer, Buffer buffer, Int32 drawbuffer, ref Int32 value)
		{
			i_OpenGL4_6.glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, ref value);
		}
		public static void glClearNamedFramebufferuiv(UInt32 framebuffer, Buffer buffer, Int32 drawbuffer, ref UInt32 value)
		{
			i_OpenGL4_6.glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, ref value);
		}
		public static void glClearStencil(Int32 s)
		{
			i_OpenGL4_6.glClearStencil(s);
		}
		public static void glClearTexImage(UInt32 texture, Int32 level, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_6.glClearTexImage(texture, level, format, type, data);
		}
		public static void glClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_6.glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}
		public static SyncStatus glClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
		{
			return i_OpenGL4_6.glClientWaitSync(sync, flags, timeout);
		}
		public static void glClipControl(ClipControlOrigin origin, ClipControlDepth depth)
		{
			i_OpenGL4_6.glClipControl(origin, depth);
		}
		public static void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
		{
			i_OpenGL4_6.glColorMask(red, green, blue, alpha);
		}
		public static void glColorMaski(UInt32 index, Boolean r, Boolean g, Boolean b, Boolean a)
		{
			i_OpenGL4_6.glColorMaski(index, r, g, b, a);
		}
		public static void glColorP3ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL4_6.glColorP3ui(type, color);
		}
		public static void glColorP3uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL4_6.glColorP3uiv(type, ref color);
		}
		public static void glColorP4ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL4_6.glColorP4ui(type, color);
		}
		public static void glColorP4uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL4_6.glColorP4uiv(type, ref color);
		}
		public static void glCompileShader(UInt32 shader)
		{
			i_OpenGL4_6.glCompileShader(shader);
		}
		public static void glCompressedTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		}
		public static void glCompressedTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}
		public static void glCompressedTexImage3D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public static void glCompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		}
		public static void glCompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public static void glCompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public static void glCompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
		}
		public static void glCompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public static void glCompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_6.glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public static void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
		{
			i_OpenGL4_6.glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		}
		public static void glCopyImageSubData(UInt32 srcName, CopyBufferSubDataTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, CopyBufferSubDataTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
		{
			i_OpenGL4_6.glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}
		public static void glCopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
		{
			i_OpenGL4_6.glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}
		public static void glCopyTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			i_OpenGL4_6.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}
		public static void glCopyTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			i_OpenGL4_6.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}
		public static void glCopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			i_OpenGL4_6.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}
		public static void glCopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}
		public static void glCopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		public static void glCopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			i_OpenGL4_6.glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
		}
		public static void glCopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
		}
		public static void glCopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		public static void glCreateBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL4_6.glCreateBuffers(n, ref buffers);
		}
		public static void glCreateFramebuffers(Int32 n, ref UInt32[] framebuffers)
		{
			i_OpenGL4_6.glCreateFramebuffers(n, ref framebuffers);
		}
		public static UInt32 glCreateProgram()
		{
			return i_OpenGL4_6.glCreateProgram();
		}
		public static void glCreateProgramPipelines(Int32 n, ref UInt32[] pipelines)
		{
			i_OpenGL4_6.glCreateProgramPipelines(n, ref pipelines);
		}
		public static void glCreateQueries(QueryTarget target, Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_6.glCreateQueries(target, n, ref ids);
		}
		public static void glCreateRenderbuffers(Int32 n, ref UInt32[] renderbuffers)
		{
			i_OpenGL4_6.glCreateRenderbuffers(n, ref renderbuffers);
		}
		public static void glCreateSamplers(Int32 n, ref UInt32[] samplers)
		{
			i_OpenGL4_6.glCreateSamplers(n, ref samplers);
		}
		public static UInt32 glCreateShader(ShaderType type)
		{
			return i_OpenGL4_6.glCreateShader(type);
		}
		public static UInt32 glCreateShaderProgramv(ShaderType type, Int32 count, ref string strings)
		{
			return i_OpenGL4_6.glCreateShaderProgramv(type, count, ref strings);
		}
		public static void glCreateTextures(TextureTarget target, Int32 n, ref UInt32[] textures)
		{
			i_OpenGL4_6.glCreateTextures(target, n, ref textures);
		}
		public static void glCreateTransformFeedbacks(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_6.glCreateTransformFeedbacks(n, ref ids);
		}
		public static void glCreateVertexArrays(Int32 n, ref UInt32[] arrays)
		{
			i_OpenGL4_6.glCreateVertexArrays(n, ref arrays);
		}
		public static void glCullFace(CullFaceMode mode)
		{
			i_OpenGL4_6.glCullFace(mode);
		}
		public static void glDebugMessageCallback(Delegates.GLDEBUGPROC callback, IntPtr userParam)
		{
			i_OpenGL4_6.glDebugMessageCallback(callback, userParam);
		}
		public static void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, Int32 count, ref UInt32[] ids, Boolean enabled)
		{
			i_OpenGL4_6.glDebugMessageControl(source, type, severity, count, ref ids, enabled);
		}
		public static void glDebugMessageInsert(DebugSource source, DebugType type, UInt32 id, DebugSeverity severity, Int32 length, ref string buf)
		{
			i_OpenGL4_6.glDebugMessageInsert(source, type, id, severity, length, ref buf);
		}
		public static void glDeleteBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL4_6.glDeleteBuffers(n, ref buffers);
		}
		public static void glDeleteFramebuffers(Int32 n, ref UInt32[] framebuffers)
		{
			i_OpenGL4_6.glDeleteFramebuffers(n, ref framebuffers);
		}
		public static void glDeleteProgram(UInt32 program)
		{
			i_OpenGL4_6.glDeleteProgram(program);
		}
		public static void glDeleteProgramPipelines(Int32 n, ref UInt32[] pipelines)
		{
			i_OpenGL4_6.glDeleteProgramPipelines(n, ref pipelines);
		}
		public static void glDeleteQueries(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_6.glDeleteQueries(n, ref ids);
		}
		public static void glDeleteRenderbuffers(Int32 n, ref UInt32[] renderbuffers)
		{
			i_OpenGL4_6.glDeleteRenderbuffers(n, ref renderbuffers);
		}
		public static void glDeleteSamplers(Int32 count, ref UInt32[] samplers)
		{
			i_OpenGL4_6.glDeleteSamplers(count, ref samplers);
		}
		public static void glDeleteShader(UInt32 shader)
		{
			i_OpenGL4_6.glDeleteShader(shader);
		}
		public static void glDeleteSync(IntPtr sync)
		{
			i_OpenGL4_6.glDeleteSync(sync);
		}
		public static void glDeleteTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL4_6.glDeleteTextures(n, ref textures);
		}
		public static void glDeleteTransformFeedbacks(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_6.glDeleteTransformFeedbacks(n, ref ids);
		}
		public static void glDeleteVertexArrays(Int32 n, ref UInt32[] arrays)
		{
			i_OpenGL4_6.glDeleteVertexArrays(n, ref arrays);
		}
		public static void glDepthFunc(DepthFunction func)
		{
			i_OpenGL4_6.glDepthFunc(func);
		}
		public static void glDepthMask(Boolean flag)
		{
			i_OpenGL4_6.glDepthMask(flag);
		}
		public static void glDepthRange(Double n, Double f)
		{
			i_OpenGL4_6.glDepthRange(n, f);
		}
		public static void glDepthRangeArrayv(UInt32 first, Int32 count, ref Double[] v)
		{
			i_OpenGL4_6.glDepthRangeArrayv(first, count, ref v);
		}
		public static void glDepthRangef(Single n, Single f)
		{
			i_OpenGL4_6.glDepthRangef(n, f);
		}
		public static void glDepthRangeIndexed(UInt32 index, Double n, Double f)
		{
			i_OpenGL4_6.glDepthRangeIndexed(index, n, f);
		}
		public static void glDetachShader(UInt32 program, UInt32 shader)
		{
			i_OpenGL4_6.glDetachShader(program, shader);
		}
		public static void glDisable(EnableCap cap)
		{
			i_OpenGL4_6.glDisable(cap);
		}
		public static void glDisablei(EnableCap target, UInt32 index)
		{
			i_OpenGL4_6.glDisablei(target, index);
		}
		public static void glDisableVertexArrayAttrib(UInt32 vaobj, UInt32 index)
		{
			i_OpenGL4_6.glDisableVertexArrayAttrib(vaobj, index);
		}
		public static void glDisableVertexAttribArray(UInt32 index)
		{
			i_OpenGL4_6.glDisableVertexAttribArray(index);
		}
		public static void glDispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z)
		{
			i_OpenGL4_6.glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		}
		public static void glDispatchComputeIndirect(IntPtr indirect)
		{
			i_OpenGL4_6.glDispatchComputeIndirect(indirect);
		}
		public static void glDrawArrays(PrimitiveType mode, Int32 first, Int32 count)
		{
			i_OpenGL4_6.glDrawArrays(mode, first, count);
		}
		public static void glDrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
		{
			i_OpenGL4_6.glDrawArraysIndirect(mode, indirect);
		}
		public static void glDrawArraysInstanced(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount)
		{
			i_OpenGL4_6.glDrawArraysInstanced(mode, first, count, instancecount);
		}
		public static void glDrawArraysInstancedBaseInstance(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance)
		{
			i_OpenGL4_6.glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
		}
		public static void glDrawBuffer(DrawBufferMode buf)
		{
			i_OpenGL4_6.glDrawBuffer(buf);
		}
		public static void glDrawBuffers(Int32 n, ref GLenum[] bufs)
		{
			i_OpenGL4_6.glDrawBuffers(n, ref bufs);
		}
		public static void glDrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL4_6.glDrawElements(mode, count, type, indices);
		}
		public static void glDrawElementsBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			i_OpenGL4_6.glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}
		public static void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect)
		{
			i_OpenGL4_6.glDrawElementsIndirect(mode, type, indirect);
		}
		public static void glDrawElementsInstanced(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount)
		{
			i_OpenGL4_6.glDrawElementsInstanced(mode, count, type, indices, instancecount);
		}
		public static void glDrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, PrimitiveType type, IntPtr indices, Int32 instancecount, UInt32 baseinstance)
		{
			i_OpenGL4_6.glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
		}
		public static void glDrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			i_OpenGL4_6.glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}
		public static void glDrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, PrimitiveType type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			i_OpenGL4_6.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}
		public static void glDrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL4_6.glDrawRangeElements(mode, start, end, count, type, indices);
		}
		public static void glDrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			i_OpenGL4_6.glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}
		public static void glDrawTransformFeedback(PrimitiveType mode, UInt32 id)
		{
			i_OpenGL4_6.glDrawTransformFeedback(mode, id);
		}
		public static void glDrawTransformFeedbackInstanced(PrimitiveType mode, UInt32 id, Int32 instancecount)
		{
			i_OpenGL4_6.glDrawTransformFeedbackInstanced(mode, id, instancecount);
		}
		public static void glDrawTransformFeedbackStream(PrimitiveType mode, UInt32 id, UInt32 stream)
		{
			i_OpenGL4_6.glDrawTransformFeedbackStream(mode, id, stream);
		}
		public static void glDrawTransformFeedbackStreamInstanced(PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount)
		{
			i_OpenGL4_6.glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
		}
		public static void glEnable(EnableCap cap)
		{
			i_OpenGL4_6.glEnable(cap);
		}
		public static void glEnablei(EnableCap target, UInt32 index)
		{
			i_OpenGL4_6.glEnablei(target, index);
		}
		public static void glEnableVertexArrayAttrib(UInt32 vaobj, UInt32 index)
		{
			i_OpenGL4_6.glEnableVertexArrayAttrib(vaobj, index);
		}
		public static void glEnableVertexAttribArray(UInt32 index)
		{
			i_OpenGL4_6.glEnableVertexAttribArray(index);
		}
		public static void glEndConditionalRender()
		{
			i_OpenGL4_6.glEndConditionalRender();
		}
		public static void glEndQuery(QueryTarget target)
		{
			i_OpenGL4_6.glEndQuery(target);
		}
		public static void glEndQueryIndexed(QueryTarget target, UInt32 index)
		{
			i_OpenGL4_6.glEndQueryIndexed(target, index);
		}
		public static void glEndTransformFeedback()
		{
			i_OpenGL4_6.glEndTransformFeedback();
		}
		public static IntPtr glFenceSync(SyncCondition condition, UInt32 flags)
		{
			return i_OpenGL4_6.glFenceSync(condition, flags);
		}
		public static void glFinish()
		{
			i_OpenGL4_6.glFinish();
		}
		public static void glFlush()
		{
			i_OpenGL4_6.glFlush();
		}
		public static void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length)
		{
			i_OpenGL4_6.glFlushMappedBufferRange(target, offset, length);
		}
		public static void glFlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, IntPtr length)
		{
			i_OpenGL4_6.glFlushMappedNamedBufferRange(buffer, offset, length);
		}
		public static void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, Int32 param)
		{
			i_OpenGL4_6.glFramebufferParameteri(target, pname, param);
		}
		public static void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
		{
			i_OpenGL4_6.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}
		public static void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level)
		{
			i_OpenGL4_6.glFramebufferTexture(target, attachment, texture, level);
		}
		public static void glFramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			i_OpenGL4_6.glFramebufferTexture1D(target, attachment, textarget, texture, level);
		}
		public static void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			i_OpenGL4_6.glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}
		public static void glFramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset)
		{
			i_OpenGL4_6.glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
		}
		public static void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			i_OpenGL4_6.glFramebufferTextureLayer(target, attachment, texture, level, layer);
		}
		public static void glFrontFace(FrontFaceDirection mode)
		{
			i_OpenGL4_6.glFrontFace(mode);
		}
		public static void glGenBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL4_6.glGenBuffers(n, ref buffers);
		}
		public static void glGenerateMipmap(TextureTarget target)
		{
			i_OpenGL4_6.glGenerateMipmap(target);
		}
		public static void glGenerateTextureMipmap(UInt32 texture)
		{
			i_OpenGL4_6.glGenerateTextureMipmap(texture);
		}
		public static void glGenFramebuffers(Int32 n, ref UInt32[] framebuffers)
		{
			i_OpenGL4_6.glGenFramebuffers(n, ref framebuffers);
		}
		public static void glGenProgramPipelines(Int32 n, ref UInt32[] pipelines)
		{
			i_OpenGL4_6.glGenProgramPipelines(n, ref pipelines);
		}
		public static void glGenQueries(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_6.glGenQueries(n, ref ids);
		}
		public static void glGenRenderbuffers(Int32 n, ref UInt32[] renderbuffers)
		{
			i_OpenGL4_6.glGenRenderbuffers(n, ref renderbuffers);
		}
		public static void glGenSamplers(Int32 count, ref UInt32[] samplers)
		{
			i_OpenGL4_6.glGenSamplers(count, ref samplers);
		}
		public static void glGenTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL4_6.glGenTextures(n, ref textures);
		}
		public static void glGenTransformFeedbacks(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_6.glGenTransformFeedbacks(n, ref ids);
		}
		public static void glGenVertexArrays(Int32 n, ref UInt32[] arrays)
		{
			i_OpenGL4_6.glGenVertexArrays(n, ref arrays);
		}
		public static void glGetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, AtomicCounterBufferPName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, ref @params);
		}
		public static void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string name)
		{
			i_OpenGL4_6.glGetActiveAttrib(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static void glGetActiveSubroutineName(UInt32 program, ShaderType shadertype, UInt32 index, Int32 bufsize, ref Int32 length, ref string name)
		{
			i_OpenGL4_6.glGetActiveSubroutineName(program, shadertype, index, bufsize, ref length, ref name);
		}
		public static void glGetActiveSubroutineUniformiv(UInt32 program, ShaderType shadertype, UInt32 index, SubroutineParameterName pname, ref Int32[] values)
		{
			i_OpenGL4_6.glGetActiveSubroutineUniformiv(program, shadertype, index, pname, ref values);
		}
		public static void glGetActiveSubroutineUniformName(UInt32 program, ShaderType shadertype, UInt32 index, Int32 bufsize, ref Int32 length, ref string name)
		{
			i_OpenGL4_6.glGetActiveSubroutineUniformName(program, shadertype, index, bufsize, ref length, ref name);
		}
		public static void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string name)
		{
			i_OpenGL4_6.glGetActiveUniform(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static void glGetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, UniformBlockPName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, ref @params);
		}
		public static void glGetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, ref Int32 length, ref string uniformBlockName)
		{
			i_OpenGL4_6.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, ref length, ref uniformBlockName);
		}
		public static void glGetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, ref Int32 length, ref string uniformName)
		{
			i_OpenGL4_6.glGetActiveUniformName(program, uniformIndex, bufSize, ref length, ref uniformName);
		}
		public static void glGetActiveUniformsiv(UInt32 program, Int32 uniformCount, ref UInt32[] uniformIndices, UniformPName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetActiveUniformsiv(program, uniformCount, ref uniformIndices, pname, ref @params);
		}
		public static void glGetAttachedShaders(UInt32 program, Int32 maxCount, ref Int32 count, ref UInt32[] shaders)
		{
			i_OpenGL4_6.glGetAttachedShaders(program, maxCount, ref count, ref shaders);
		}
		public static Int32 glGetAttribLocation(UInt32 program, ref Char name)
		{
			return i_OpenGL4_6.glGetAttribLocation(program, ref name);
		}
		public static void glGetBooleani_v(BufferTargetARB target, UInt32 index, ref Boolean[] data)
		{
			i_OpenGL4_6.glGetBooleani_v(target, index, ref data);
		}
		public static void glGetBooleanv(GetPName pname, ref Boolean[] data)
		{
			i_OpenGL4_6.glGetBooleanv(pname, ref data);
		}
		public static void glGetBufferParameteri64v(BufferTargetARB target, GLenum pname, ref Int64[] @params)
		{
			i_OpenGL4_6.glGetBufferParameteri64v(target, pname, ref @params);
		}
		public static void glGetBufferParameteriv(BufferTargetARB target, GLenum pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetBufferParameteriv(target, pname, ref @params);
		}
		public static void glGetBufferPointerv(BufferTargetARB target, GLenum pname, IntPtr @params)
		{
			i_OpenGL4_6.glGetBufferPointerv(target, pname, @params);
		}
		public static void glGetBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL4_6.glGetBufferSubData(target, offset, size, data);
		}
		public static void glGetCompressedTexImage(TextureTarget target, Int32 level, IntPtr img)
		{
			i_OpenGL4_6.glGetCompressedTexImage(target, level, img);
		}
		public static void glGetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels)
		{
			i_OpenGL4_6.glGetCompressedTextureImage(texture, level, bufSize, pixels);
		}
		public static void glGetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels)
		{
			i_OpenGL4_6.glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		}
		public static UInt32 glGetDebugMessageLog(UInt32 count, Int32 bufSize, ref DebugSource[] sources, ref DebugType[] types, ref UInt32[] ids, ref DebugSeverity[] severities, ref Int32[] lengths, ref string messageLog)
		{
			return i_OpenGL4_6.glGetDebugMessageLog(count, bufSize, ref sources, ref types, ref ids, ref severities, ref lengths, ref messageLog);
		}
		public static void glGetDoublei_v(TypeEnum target, UInt32 index, ref Double[] data)
		{
			i_OpenGL4_6.glGetDoublei_v(target, index, ref data);
		}
		public static void glGetDoublev(GetPName pname, ref Double[] data)
		{
			i_OpenGL4_6.glGetDoublev(pname, ref data);
		}
		public static ErrorCode glGetError()
		{
			return i_OpenGL4_6.glGetError();
		}
		public static void glGetFloati_v(TypeEnum target, UInt32 index, ref Single[] data)
		{
			i_OpenGL4_6.glGetFloati_v(target, index, ref data);
		}
		public static void glGetFloatv(GetPName pname, ref Single[] data)
		{
			i_OpenGL4_6.glGetFloatv(pname, ref data);
		}
		public static Int32 glGetFragDataIndex(UInt32 program, ref Char name)
		{
			return i_OpenGL4_6.glGetFragDataIndex(program, ref name);
		}
		public static Int32 glGetFragDataLocation(UInt32 program, ref string name)
		{
			return i_OpenGL4_6.glGetFragDataLocation(program, ref name);
		}
		public static void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetFramebufferAttachmentParameteriv(target, attachment, pname, ref @params);
		}
		public static void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetFramebufferParameteriv(target, pname, ref @params);
		}
		public static GraphicsResetStatus glGetGraphicsResetStatus()
		{
			return i_OpenGL4_6.glGetGraphicsResetStatus();
		}
		public static void glGetInteger64i_v(TypeEnum target, UInt32 index, ref Int64[] data)
		{
			i_OpenGL4_6.glGetInteger64i_v(target, index, ref data);
		}
		public static void glGetInteger64v(GetPName pname, ref Int64[] data)
		{
			i_OpenGL4_6.glGetInteger64v(pname, ref data);
		}
		public static void glGetIntegeri_v(TypeEnum target, UInt32 index, ref Int32[] data)
		{
			i_OpenGL4_6.glGetIntegeri_v(target, index, ref data);
		}
		public static void glGetIntegerv(GetPName pname, ref Int32[] data)
		{
			i_OpenGL4_6.glGetIntegerv(pname, ref data);
		}
		public static void glGetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Int32 bufSize, ref Int64[] @params)
		{
			i_OpenGL4_6.glGetInternalformati64v(target, internalformat, pname, bufSize, ref @params);
		}
		public static void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Int32 bufSize, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetInternalformativ(target, internalformat, pname, bufSize, ref @params);
		}
		public static void glGetMultisamplefv(GLenum pname, UInt32 index, ref Single[] val)
		{
			i_OpenGL4_6.glGetMultisamplefv(pname, index, ref val);
		}
		public static void glGetNamedBufferParameteri64v(UInt32 buffer, VertexBufferObjectParameter pname, ref Int64 @params)
		{
			i_OpenGL4_6.glGetNamedBufferParameteri64v(buffer, pname, ref @params);
		}
		public static void glGetNamedBufferParameteriv(UInt32 buffer, VertexBufferObjectParameter pname, ref Int32 @params)
		{
			i_OpenGL4_6.glGetNamedBufferParameteriv(buffer, pname, ref @params);
		}
		public static void glGetNamedBufferPointerv(UInt32 buffer, VertexBufferObjectParameter pname, IntPtr @params)
		{
			i_OpenGL4_6.glGetNamedBufferPointerv(buffer, pname, @params);
		}
		public static void glGetNamedBufferSubData(UInt32 buffer, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL4_6.glGetNamedBufferSubData(buffer, offset, size, data);
		}
		public static void glGetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref Int32 @params)
		{
			i_OpenGL4_6.glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, ref @params);
		}
		public static void glGetNamedFramebufferParameteriv(UInt32 framebuffer, GetFramebufferParameter pname, ref Int32 param)
		{
			i_OpenGL4_6.glGetNamedFramebufferParameteriv(framebuffer, pname, ref param);
		}
		public static void glGetNamedRenderbufferParameteriv(UInt32 renderbuffer, RenderbufferParameterName pname, ref Int32 @params)
		{
			i_OpenGL4_6.glGetNamedRenderbufferParameteriv(renderbuffer, pname, ref @params);
		}
		public static void glGetnColorTable(ColorTableTarget target, PixelFormat format, PixelType type, Int32 bufSize, IntPtr table)
		{
			i_OpenGL4_6.glGetnColorTable(target, format, type, bufSize, table);
		}
		public static void glGetnCompressedTexImage(TextureTarget target, Int32 lod, Int32 bufSize, IntPtr pixels)
		{
			i_OpenGL4_6.glGetnCompressedTexImage(target, lod, bufSize, pixels);
		}
		public static void glGetnConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, Int32 bufSize, IntPtr image)
		{
			i_OpenGL4_6.glGetnConvolutionFilter(target, format, type, bufSize, image);
		}
		public static void glGetnHistogram(HistogramTargetEXT target, Boolean reset, PixelFormat format, PixelType type, Int32 bufSize, IntPtr values)
		{
			i_OpenGL4_6.glGetnHistogram(target, reset, format, type, bufSize, values);
		}
		public static void glGetnMapdv(MapTarget target, MapQuery query, Int32 bufSize, ref Double v)
		{
			i_OpenGL4_6.glGetnMapdv(target, query, bufSize, ref v);
		}
		public static void glGetnMapfv(MapTarget target, MapQuery query, Int32 bufSize, ref Single v)
		{
			i_OpenGL4_6.glGetnMapfv(target, query, bufSize, ref v);
		}
		public static void glGetnMapiv(MapTarget target, MapQuery query, Int32 bufSize, ref Int32 v)
		{
			i_OpenGL4_6.glGetnMapiv(target, query, bufSize, ref v);
		}
		public static void glGetnMinmax(MinmaxTargetEXT target, Boolean reset, PixelFormat format, PixelType type, Int32 bufSize, IntPtr values)
		{
			i_OpenGL4_6.glGetnMinmax(target, reset, format, type, bufSize, values);
		}
		public static void glGetnPixelMapfv(PixelMap map, Int32 bufSize, ref Single values)
		{
			i_OpenGL4_6.glGetnPixelMapfv(map, bufSize, ref values);
		}
		public static void glGetnPixelMapuiv(PixelMap map, Int32 bufSize, ref UInt32 values)
		{
			i_OpenGL4_6.glGetnPixelMapuiv(map, bufSize, ref values);
		}
		public static void glGetnPixelMapusv(PixelMap map, Int32 bufSize, ref UInt16 values)
		{
			i_OpenGL4_6.glGetnPixelMapusv(map, bufSize, ref values);
		}
		public static void glGetnPolygonStipple(Int32 bufSize, ref Byte pattern)
		{
			i_OpenGL4_6.glGetnPolygonStipple(bufSize, ref pattern);
		}
		public static void glGetnSeparableFilter(SeparableTargetEXT target, PixelFormat format, PixelType type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span)
		{
			i_OpenGL4_6.glGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
		}
		public static void glGetnTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, IntPtr pixels)
		{
			i_OpenGL4_6.glGetnTexImage(target, level, format, type, bufSize, pixels);
		}
		public static void glGetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, ref Double[] @params)
		{
			i_OpenGL4_6.glGetnUniformdv(program, location, bufSize, ref @params);
		}
		public static void glGetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, ref Single[] @params)
		{
			i_OpenGL4_6.glGetnUniformfv(program, location, bufSize, ref @params);
		}
		public static void glGetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetnUniformiv(program, location, bufSize, ref @params);
		}
		public static void glGetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, ref UInt32[] @params)
		{
			i_OpenGL4_6.glGetnUniformuiv(program, location, bufSize, ref @params);
		}
		public static void glGetObjectLabel(GLenum identifier, UInt32 name, Int32 bufSize, ref Int32 length, ref string label)
		{
			i_OpenGL4_6.glGetObjectLabel(identifier, name, bufSize, ref length, ref label);
		}
		public static void glGetObjectPtrLabel(IntPtr ptr, Int32 bufSize, ref Int32 length, ref string label)
		{
			i_OpenGL4_6.glGetObjectPtrLabel(ptr, bufSize, ref length, ref label);
		}
		public static void glGetPointerv(GetPointervPName pname, IntPtr @params)
		{
			i_OpenGL4_6.glGetPointerv(pname, @params);
		}
		public static void glGetProgramBinary(UInt32 program, Int32 bufSize, ref Int32 length, ref GLenum binaryFormat, IntPtr binary)
		{
			i_OpenGL4_6.glGetProgramBinary(program, bufSize, ref length, ref binaryFormat, binary);
		}
		public static void glGetProgramInfoLog(UInt32 program, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL4_6.glGetProgramInfoLog(program, bufSize, ref length, ref infoLog);
		}
		public static void glGetProgramInterfaceiv(UInt32 program, ProgramInterface programInterface, ProgramInterfacePName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetProgramInterfaceiv(program, programInterface, pname, ref @params);
		}
		public static void glGetProgramiv(UInt32 program, ProgramPropertyARB pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetProgramiv(program, pname, ref @params);
		}
		public static void glGetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL4_6.glGetProgramPipelineInfoLog(pipeline, bufSize, ref length, ref infoLog);
		}
		public static void glGetProgramPipelineiv(UInt32 pipeline, PipelineParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetProgramPipelineiv(pipeline, pname, ref @params);
		}
		public static UInt32 glGetProgramResourceIndex(UInt32 program, ProgramInterface programInterface, ref string name)
		{
			return i_OpenGL4_6.glGetProgramResourceIndex(program, programInterface, ref name);
		}
		public static void glGetProgramResourceiv(UInt32 program, ProgramInterface programInterface, UInt32 index, Int32 propCount, ref GLenum[] props, Int32 bufSize, ref Int32 length, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetProgramResourceiv(program, programInterface, index, propCount, ref props, bufSize, ref length, ref @params);
		}
		public static Int32 glGetProgramResourceLocation(UInt32 program, ProgramInterface programInterface, ref string name)
		{
			return i_OpenGL4_6.glGetProgramResourceLocation(program, programInterface, ref name);
		}
		public static Int32 glGetProgramResourceLocationIndex(UInt32 program, ProgramInterface programInterface, ref string name)
		{
			return i_OpenGL4_6.glGetProgramResourceLocationIndex(program, programInterface, ref name);
		}
		public static void glGetProgramResourceName(UInt32 program, ProgramInterface programInterface, UInt32 index, Int32 bufSize, ref Int32 length, ref string name)
		{
			i_OpenGL4_6.glGetProgramResourceName(program, programInterface, index, bufSize, ref length, ref name);
		}
		public static void glGetProgramStageiv(UInt32 program, ShaderType shadertype, ProgramStagePName pname, ref Int32 values)
		{
			i_OpenGL4_6.glGetProgramStageiv(program, shadertype, pname, ref values);
		}
		public static void glGetQueryBufferObjecti64v(UInt32 id, UInt32 buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			i_OpenGL4_6.glGetQueryBufferObjecti64v(id, buffer, pname, offset);
		}
		public static void glGetQueryBufferObjectiv(UInt32 id, UInt32 buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			i_OpenGL4_6.glGetQueryBufferObjectiv(id, buffer, pname, offset);
		}
		public static void glGetQueryBufferObjectui64v(UInt32 id, UInt32 buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			i_OpenGL4_6.glGetQueryBufferObjectui64v(id, buffer, pname, offset);
		}
		public static void glGetQueryBufferObjectuiv(UInt32 id, UInt32 buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			i_OpenGL4_6.glGetQueryBufferObjectuiv(id, buffer, pname, offset);
		}
		public static void glGetQueryIndexediv(GLenum target, UInt32 index, QueryParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetQueryIndexediv(target, index, pname, ref @params);
		}
		public static void glGetQueryiv(QueryTarget target, QueryParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetQueryiv(target, pname, ref @params);
		}
		public static void glGetQueryObjecti64v(UInt32 id, QueryObjectParameterName pname, ref Int64[] @params)
		{
			i_OpenGL4_6.glGetQueryObjecti64v(id, pname, ref @params);
		}
		public static void glGetQueryObjectiv(UInt32 id, QueryObjectParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetQueryObjectiv(id, pname, ref @params);
		}
		public static void glGetQueryObjectui64v(UInt32 id, QueryObjectParameterName pname, ref UInt64[] @params)
		{
			i_OpenGL4_6.glGetQueryObjectui64v(id, pname, ref @params);
		}
		public static void glGetQueryObjectuiv(UInt32 id, QueryObjectParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL4_6.glGetQueryObjectuiv(id, pname, ref @params);
		}
		public static void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetRenderbufferParameteriv(target, pname, ref @params);
		}
		public static void glGetSamplerParameterfv(UInt32 sampler, SamplerParameterName pname, ref Single[] @params)
		{
			i_OpenGL4_6.glGetSamplerParameterfv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameterIiv(UInt32 sampler, SamplerParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetSamplerParameterIiv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameterIuiv(UInt32 sampler, SamplerParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL4_6.glGetSamplerParameterIuiv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameteriv(UInt32 sampler, SamplerParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetSamplerParameteriv(sampler, pname, ref @params);
		}
		public static void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL4_6.glGetShaderInfoLog(shader, bufSize, ref length, ref infoLog);
		}
		public static void glGetShaderiv(UInt32 shader, ShaderParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetShaderiv(shader, pname, ref @params);
		}
		public static void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, ref Int32[] range, ref Int32 precision)
		{
			i_OpenGL4_6.glGetShaderPrecisionFormat(shadertype, precisiontype, ref range, ref precision);
		}
		public static void glGetShaderSource(UInt32 shader, Int32 bufSize, ref Int32 length, ref string source)
		{
			i_OpenGL4_6.glGetShaderSource(shader, bufSize, ref length, ref source);
		}
		public static Byte glGetString(StringName name)
		{
			return i_OpenGL4_6.glGetString(name);
		}
		public static Byte glGetStringi(StringName name, UInt32 index)
		{
			return i_OpenGL4_6.glGetStringi(name, index);
		}
		public static UInt32 glGetSubroutineIndex(UInt32 program, ShaderType shadertype, ref Char name)
		{
			return i_OpenGL4_6.glGetSubroutineIndex(program, shadertype, ref name);
		}
		public static Int32 glGetSubroutineUniformLocation(UInt32 program, ShaderType shadertype, ref Char name)
		{
			return i_OpenGL4_6.glGetSubroutineUniformLocation(program, shadertype, ref name);
		}
		public static void glGetSynciv(IntPtr sync, SyncParameterName pname, Int32 bufSize, ref Int32 length, ref Int32[] values)
		{
			i_OpenGL4_6.glGetSynciv(sync, pname, bufSize, ref length, ref values);
		}
		public static void glGetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glGetTexImage(target, level, format, type, pixels);
		}
		public static void glGetTexLevelParameterfv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL4_6.glGetTexLevelParameterfv(target, level, pname, ref @params);
		}
		public static void glGetTexLevelParameteriv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetTexLevelParameteriv(target, level, pname, ref @params);
		}
		public static void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL4_6.glGetTexParameterfv(target, pname, ref @params);
		}
		public static void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetTexParameterIiv(target, pname, ref @params);
		}
		public static void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, ref UInt32[] @params)
		{
			i_OpenGL4_6.glGetTexParameterIuiv(target, pname, ref @params);
		}
		public static void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetTexParameteriv(target, pname, ref @params);
		}
		public static void glGetTextureImage(UInt32 texture, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, IntPtr pixels)
		{
			i_OpenGL4_6.glGetTextureImage(texture, level, format, type, bufSize, pixels);
		}
		public static void glGetTextureLevelParameterfv(UInt32 texture, Int32 level, GetTextureParameter pname, ref Single @params)
		{
			i_OpenGL4_6.glGetTextureLevelParameterfv(texture, level, pname, ref @params);
		}
		public static void glGetTextureLevelParameteriv(UInt32 texture, Int32 level, GetTextureParameter pname, ref Int32 @params)
		{
			i_OpenGL4_6.glGetTextureLevelParameteriv(texture, level, pname, ref @params);
		}
		public static void glGetTextureParameterfv(UInt32 texture, GetTextureParameter pname, ref Single @params)
		{
			i_OpenGL4_6.glGetTextureParameterfv(texture, pname, ref @params);
		}
		public static void glGetTextureParameterIiv(UInt32 texture, GetTextureParameter pname, ref Int32 @params)
		{
			i_OpenGL4_6.glGetTextureParameterIiv(texture, pname, ref @params);
		}
		public static void glGetTextureParameterIuiv(UInt32 texture, GetTextureParameter pname, ref UInt32 @params)
		{
			i_OpenGL4_6.glGetTextureParameterIuiv(texture, pname, ref @params);
		}
		public static void glGetTextureParameteriv(UInt32 texture, GetTextureParameter pname, ref Int32 @params)
		{
			i_OpenGL4_6.glGetTextureParameteriv(texture, pname, ref @params);
		}
		public static void glGetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Int32 bufSize, IntPtr pixels)
		{
			i_OpenGL4_6.glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}
		public static void glGetTransformFeedbacki_v(UInt32 xfb, TransformFeedbackPName pname, UInt32 index, ref Int32 param)
		{
			i_OpenGL4_6.glGetTransformFeedbacki_v(xfb, pname, index, ref param);
		}
		public static void glGetTransformFeedbacki64_v(UInt32 xfb, TransformFeedbackPName pname, UInt32 index, ref Int64 param)
		{
			i_OpenGL4_6.glGetTransformFeedbacki64_v(xfb, pname, index, ref param);
		}
		public static void glGetTransformFeedbackiv(UInt32 xfb, TransformFeedbackPName pname, ref Int32 param)
		{
			i_OpenGL4_6.glGetTransformFeedbackiv(xfb, pname, ref param);
		}
		public static void glGetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref GLenum type, ref string name)
		{
			i_OpenGL4_6.glGetTransformFeedbackVarying(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static UInt32 glGetUniformBlockIndex(UInt32 program, ref string uniformBlockName)
		{
			return i_OpenGL4_6.glGetUniformBlockIndex(program, ref uniformBlockName);
		}
		public static void glGetUniformdv(UInt32 program, Int32 location, ref Double[] @params)
		{
			i_OpenGL4_6.glGetUniformdv(program, location, ref @params);
		}
		public static void glGetUniformfv(UInt32 program, Int32 location, ref Single[] @params)
		{
			i_OpenGL4_6.glGetUniformfv(program, location, ref @params);
		}
		public static void glGetUniformIndices(UInt32 program, Int32 uniformCount, ref string uniformNames, ref UInt32[] uniformIndices)
		{
			i_OpenGL4_6.glGetUniformIndices(program, uniformCount, ref uniformNames, ref uniformIndices);
		}
		public static void glGetUniformiv(UInt32 program, Int32 location, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetUniformiv(program, location, ref @params);
		}
		public static Int32 glGetUniformLocation(UInt32 program, ref Char name)
		{
			return i_OpenGL4_6.glGetUniformLocation(program, ref name);
		}
		public static void glGetUniformSubroutineuiv(ShaderType shadertype, Int32 location, ref UInt32 @params)
		{
			i_OpenGL4_6.glGetUniformSubroutineuiv(shadertype, location, ref @params);
		}
		public static void glGetUniformuiv(UInt32 program, Int32 location, ref UInt32[] @params)
		{
			i_OpenGL4_6.glGetUniformuiv(program, location, ref @params);
		}
		public static void glGetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, VertexArrayPName pname, ref Int64 param)
		{
			i_OpenGL4_6.glGetVertexArrayIndexed64iv(vaobj, index, pname, ref param);
		}
		public static void glGetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, VertexArrayPName pname, ref Int32 param)
		{
			i_OpenGL4_6.glGetVertexArrayIndexediv(vaobj, index, pname, ref param);
		}
		public static void glGetVertexArrayiv(UInt32 vaobj, VertexArrayPName pname, ref Int32 param)
		{
			i_OpenGL4_6.glGetVertexArrayiv(vaobj, pname, ref param);
		}
		public static void glGetVertexAttribdv(UInt32 index, GLenum pname, ref Double[] @params)
		{
			i_OpenGL4_6.glGetVertexAttribdv(index, pname, ref @params);
		}
		public static void glGetVertexAttribfv(UInt32 index, GLenum pname, ref Single[] @params)
		{
			i_OpenGL4_6.glGetVertexAttribfv(index, pname, ref @params);
		}
		public static void glGetVertexAttribIiv(UInt32 index, VertexAttribEnum pname, ref Int32 @params)
		{
			i_OpenGL4_6.glGetVertexAttribIiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribIuiv(UInt32 index, VertexAttribEnum pname, ref UInt32 @params)
		{
			i_OpenGL4_6.glGetVertexAttribIuiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribiv(UInt32 index, GLenum pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glGetVertexAttribiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribLdv(UInt32 index, VertexAttribEnum pname, ref Double[] @params)
		{
			i_OpenGL4_6.glGetVertexAttribLdv(index, pname, ref @params);
		}
		public static void glGetVertexAttribPointerv(UInt32 index, GLenum pname, IntPtr pointer)
		{
			i_OpenGL4_6.glGetVertexAttribPointerv(index, pname, pointer);
		}
		public static void glHint(HintTarget target, HintMode mode)
		{
			i_OpenGL4_6.glHint(target, mode);
		}
		public static void glInvalidateBufferData(UInt32 buffer)
		{
			i_OpenGL4_6.glInvalidateBufferData(buffer);
		}
		public static void glInvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length)
		{
			i_OpenGL4_6.glInvalidateBufferSubData(buffer, offset, length);
		}
		public static void glInvalidateFramebuffer(FramebufferTarget target, Int32 numAttachments, ref GLenum[] attachments)
		{
			i_OpenGL4_6.glInvalidateFramebuffer(target, numAttachments, ref attachments);
		}
		public static void glInvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, ref FramebufferAttachment attachments)
		{
			i_OpenGL4_6.glInvalidateNamedFramebufferData(framebuffer, numAttachments, ref attachments);
		}
		public static void glInvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, ref FramebufferAttachment attachments, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, ref attachments, x, y, width, height);
		}
		public static void glInvalidateSubFramebuffer(GLenum target, Int32 numAttachments, ref FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glInvalidateSubFramebuffer(target, numAttachments, ref attachments, x, y, width, height);
		}
		public static void glInvalidateTexImage(UInt32 texture, Int32 level)
		{
			i_OpenGL4_6.glInvalidateTexImage(texture, level);
		}
		public static void glInvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth)
		{
			i_OpenGL4_6.glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}
		public static Boolean glIsBuffer(UInt32 buffer)
		{
			return i_OpenGL4_6.glIsBuffer(buffer);
		}
		public static Boolean glIsEnabled(EnableCap cap)
		{
			return i_OpenGL4_6.glIsEnabled(cap);
		}
		public static Boolean glIsEnabledi(EnableCap target, UInt32 index)
		{
			return i_OpenGL4_6.glIsEnabledi(target, index);
		}
		public static Boolean glIsFramebuffer(UInt32 framebuffer)
		{
			return i_OpenGL4_6.glIsFramebuffer(framebuffer);
		}
		public static Boolean glIsProgram(UInt32 program)
		{
			return i_OpenGL4_6.glIsProgram(program);
		}
		public static Boolean glIsProgramPipeline(UInt32 pipeline)
		{
			return i_OpenGL4_6.glIsProgramPipeline(pipeline);
		}
		public static Boolean glIsQuery(UInt32 id)
		{
			return i_OpenGL4_6.glIsQuery(id);
		}
		public static Boolean glIsRenderbuffer(UInt32 renderbuffer)
		{
			return i_OpenGL4_6.glIsRenderbuffer(renderbuffer);
		}
		public static Boolean glIsSampler(UInt32 sampler)
		{
			return i_OpenGL4_6.glIsSampler(sampler);
		}
		public static Boolean glIsShader(UInt32 shader)
		{
			return i_OpenGL4_6.glIsShader(shader);
		}
		public static Boolean glIsSync(IntPtr sync)
		{
			return i_OpenGL4_6.glIsSync(sync);
		}
		public static Boolean glIsTexture(UInt32 texture)
		{
			return i_OpenGL4_6.glIsTexture(texture);
		}
		public static Boolean glIsTransformFeedback(UInt32 id)
		{
			return i_OpenGL4_6.glIsTransformFeedback(id);
		}
		public static Boolean glIsVertexArray(UInt32 array)
		{
			return i_OpenGL4_6.glIsVertexArray(array);
		}
		public static void glLineWidth(Single width)
		{
			i_OpenGL4_6.glLineWidth(width);
		}
		public static void glLinkProgram(UInt32 program)
		{
			i_OpenGL4_6.glLinkProgram(program);
		}
		public static void glLogicOp(LogicOp opcode)
		{
			i_OpenGL4_6.glLogicOp(opcode);
		}
		public static IntPtr glMapBuffer(BufferTargetARB target, BufferAccessARB access)
		{
			return i_OpenGL4_6.glMapBuffer(target, access);
		}
		public static IntPtr glMapBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length, UInt32 access)
		{
			return i_OpenGL4_6.glMapBufferRange(target, offset, length, access);
		}
		public static IntPtr glMapNamedBuffer(UInt32 buffer, BufferAccessARB access)
		{
			return i_OpenGL4_6.glMapNamedBuffer(buffer, access);
		}
		public static IntPtr glMapNamedBufferRange(UInt32 buffer, IntPtr offset, IntPtr length, UInt32 access)
		{
			return i_OpenGL4_6.glMapNamedBufferRange(buffer, offset, length, access);
		}
		public static void glMemoryBarrier(UInt32 barriers)
		{
			i_OpenGL4_6.glMemoryBarrier(barriers);
		}
		public static void glMemoryBarrierByRegion(UInt32 barriers)
		{
			i_OpenGL4_6.glMemoryBarrierByRegion(barriers);
		}
		public static void glMinSampleShading(Single value)
		{
			i_OpenGL4_6.glMinSampleShading(value);
		}
		public static void glMultiDrawArrays(PrimitiveType mode, ref Int32[] first, ref Int32[] count, Int32 drawcount)
		{
			i_OpenGL4_6.glMultiDrawArrays(mode, ref first, ref count, drawcount);
		}
		public static void glMultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			i_OpenGL4_6.glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
		}
		public static void glMultiDrawArraysIndirectCount(PrimitiveType mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride)
		{
			i_OpenGL4_6.glMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);
		}
		public static void glMultiDrawElements(PrimitiveType mode, ref Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount)
		{
			i_OpenGL4_6.glMultiDrawElements(mode, ref count, type, indices, drawcount);
		}
		public static void glMultiDrawElementsBaseVertex(PrimitiveType mode, ref Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount, ref Int32[] basevertex)
		{
			i_OpenGL4_6.glMultiDrawElementsBaseVertex(mode, ref count, type, indices, drawcount, ref basevertex);
		}
		public static void glMultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			i_OpenGL4_6.glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
		}
		public static void glMultiDrawElementsIndirectCount(PrimitiveType mode, GLenum type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride)
		{
			i_OpenGL4_6.glMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);
		}
		public static void glMultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glMultiTexCoordP1ui(texture, type, coords);
		}
		public static void glMultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glMultiTexCoordP1uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glMultiTexCoordP2ui(texture, type, coords);
		}
		public static void glMultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glMultiTexCoordP2uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glMultiTexCoordP3ui(texture, type, coords);
		}
		public static void glMultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glMultiTexCoordP3uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glMultiTexCoordP4ui(texture, type, coords);
		}
		public static void glMultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glMultiTexCoordP4uiv(texture, type, ref coords);
		}
		public static void glNamedBufferData(UInt32 buffer, IntPtr size, IntPtr data, VertexBufferObjectUsage usage)
		{
			i_OpenGL4_6.glNamedBufferData(buffer, size, data, usage);
		}
		public static void glNamedBufferStorage(UInt32 buffer, IntPtr size, IntPtr data, UInt32 flags)
		{
			i_OpenGL4_6.glNamedBufferStorage(buffer, size, data, flags);
		}
		public static void glNamedBufferSubData(UInt32 buffer, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL4_6.glNamedBufferSubData(buffer, offset, size, data);
		}
		public static void glNamedFramebufferDrawBuffer(UInt32 framebuffer, ColorBuffer buf)
		{
			i_OpenGL4_6.glNamedFramebufferDrawBuffer(framebuffer, buf);
		}
		public static void glNamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, ref ColorBuffer bufs)
		{
			i_OpenGL4_6.glNamedFramebufferDrawBuffers(framebuffer, n, ref bufs);
		}
		public static void glNamedFramebufferParameteri(UInt32 framebuffer, FramebufferParameterName pname, Int32 param)
		{
			i_OpenGL4_6.glNamedFramebufferParameteri(framebuffer, pname, param);
		}
		public static void glNamedFramebufferReadBuffer(UInt32 framebuffer, ColorBuffer src)
		{
			i_OpenGL4_6.glNamedFramebufferReadBuffer(framebuffer, src);
		}
		public static void glNamedFramebufferRenderbuffer(UInt32 framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
		{
			i_OpenGL4_6.glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}
		public static void glNamedFramebufferTexture(UInt32 framebuffer, FramebufferAttachment attachment, UInt32 texture, Int32 level)
		{
			i_OpenGL4_6.glNamedFramebufferTexture(framebuffer, attachment, texture, level);
		}
		public static void glNamedFramebufferTextureLayer(UInt32 framebuffer, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			i_OpenGL4_6.glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
		}
		public static void glNamedRenderbufferStorage(UInt32 renderbuffer, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
		}
		public static void glNamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
		}
		public static void glNormalP3ui(NormalPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glNormalP3ui(type, coords);
		}
		public static void glNormalP3uiv(NormalPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glNormalP3uiv(type, ref coords);
		}
		public static void glObjectLabel(ObjectIdentifier identifier, UInt32 name, Int32 length, ref string label)
		{
			i_OpenGL4_6.glObjectLabel(identifier, name, length, ref label);
		}
		public static void glObjectPtrLabel(IntPtr ptr, Int32 length, ref string label)
		{
			i_OpenGL4_6.glObjectPtrLabel(ptr, length, ref label);
		}
		public static void glPatchParameterfv(PatchParameterName pname, ref Single[] values)
		{
			i_OpenGL4_6.glPatchParameterfv(pname, ref values);
		}
		public static void glPatchParameteri(PatchParameterName pname, Int32 value)
		{
			i_OpenGL4_6.glPatchParameteri(pname, value);
		}
		public static void glPauseTransformFeedback()
		{
			i_OpenGL4_6.glPauseTransformFeedback();
		}
		public static void glPixelStoref(PixelStoreParameter pname, Single param)
		{
			i_OpenGL4_6.glPixelStoref(pname, param);
		}
		public static void glPixelStorei(PixelStoreParameter pname, Int32 param)
		{
			i_OpenGL4_6.glPixelStorei(pname, param);
		}
		public static void glPointParameterf(GLenum pname, Single param)
		{
			i_OpenGL4_6.glPointParameterf(pname, param);
		}
		public static void glPointParameterfv(GLenum pname, ref Single[] @params)
		{
			i_OpenGL4_6.glPointParameterfv(pname, ref @params);
		}
		public static void glPointParameteri(GLenum pname, Int32 param)
		{
			i_OpenGL4_6.glPointParameteri(pname, param);
		}
		public static void glPointParameteriv(GLenum pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glPointParameteriv(pname, ref @params);
		}
		public static void glPointSize(Single size)
		{
			i_OpenGL4_6.glPointSize(size);
		}
		public static void glPolygonMode(MaterialFace face, PolygonMode mode)
		{
			i_OpenGL4_6.glPolygonMode(face, mode);
		}
		public static void glPolygonOffset(Single factor, Single units)
		{
			i_OpenGL4_6.glPolygonOffset(factor, units);
		}
		public static void glPolygonOffsetClamp(Single factor, Single units, Single clamp)
		{
			i_OpenGL4_6.glPolygonOffsetClamp(factor, units, clamp);
		}
		public static void glPopDebugGroup()
		{
			i_OpenGL4_6.glPopDebugGroup();
		}
		public static void glPrimitiveRestartIndex(UInt32 index)
		{
			i_OpenGL4_6.glPrimitiveRestartIndex(index);
		}
		public static void glProgramBinary(UInt32 program, GLenum binaryFormat, IntPtr binary, Int32 length)
		{
			i_OpenGL4_6.glProgramBinary(program, binaryFormat, binary, length);
		}
		public static void glProgramParameteri(UInt32 program, ProgramParameterPName pname, Int32 value)
		{
			i_OpenGL4_6.glProgramParameteri(program, pname, value);
		}
		public static void glProgramUniform1d(UInt32 program, Int32 location, Double v0)
		{
			i_OpenGL4_6.glProgramUniform1d(program, location, v0);
		}
		public static void glProgramUniform1dv(UInt32 program, Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniform1dv(program, location, count, ref value);
		}
		public static void glProgramUniform1f(UInt32 program, Int32 location, Single v0)
		{
			i_OpenGL4_6.glProgramUniform1f(program, location, v0);
		}
		public static void glProgramUniform1fv(UInt32 program, Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniform1fv(program, location, count, ref value);
		}
		public static void glProgramUniform1i(UInt32 program, Int32 location, Int32 v0)
		{
			i_OpenGL4_6.glProgramUniform1i(program, location, v0);
		}
		public static void glProgramUniform1iv(UInt32 program, Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_6.glProgramUniform1iv(program, location, count, ref value);
		}
		public static void glProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0)
		{
			i_OpenGL4_6.glProgramUniform1ui(program, location, v0);
		}
		public static void glProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_6.glProgramUniform1uiv(program, location, count, ref value);
		}
		public static void glProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1)
		{
			i_OpenGL4_6.glProgramUniform2d(program, location, v0, v1);
		}
		public static void glProgramUniform2dv(UInt32 program, Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniform2dv(program, location, count, ref value);
		}
		public static void glProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1)
		{
			i_OpenGL4_6.glProgramUniform2f(program, location, v0, v1);
		}
		public static void glProgramUniform2fv(UInt32 program, Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniform2fv(program, location, count, ref value);
		}
		public static void glProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1)
		{
			i_OpenGL4_6.glProgramUniform2i(program, location, v0, v1);
		}
		public static void glProgramUniform2iv(UInt32 program, Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_6.glProgramUniform2iv(program, location, count, ref value);
		}
		public static void glProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1)
		{
			i_OpenGL4_6.glProgramUniform2ui(program, location, v0, v1);
		}
		public static void glProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_6.glProgramUniform2uiv(program, location, count, ref value);
		}
		public static void glProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2)
		{
			i_OpenGL4_6.glProgramUniform3d(program, location, v0, v1, v2);
		}
		public static void glProgramUniform3dv(UInt32 program, Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniform3dv(program, location, count, ref value);
		}
		public static void glProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2)
		{
			i_OpenGL4_6.glProgramUniform3f(program, location, v0, v1, v2);
		}
		public static void glProgramUniform3fv(UInt32 program, Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniform3fv(program, location, count, ref value);
		}
		public static void glProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			i_OpenGL4_6.glProgramUniform3i(program, location, v0, v1, v2);
		}
		public static void glProgramUniform3iv(UInt32 program, Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_6.glProgramUniform3iv(program, location, count, ref value);
		}
		public static void glProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			i_OpenGL4_6.glProgramUniform3ui(program, location, v0, v1, v2);
		}
		public static void glProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_6.glProgramUniform3uiv(program, location, count, ref value);
		}
		public static void glProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3)
		{
			i_OpenGL4_6.glProgramUniform4d(program, location, v0, v1, v2, v3);
		}
		public static void glProgramUniform4dv(UInt32 program, Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniform4dv(program, location, count, ref value);
		}
		public static void glProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3)
		{
			i_OpenGL4_6.glProgramUniform4f(program, location, v0, v1, v2, v3);
		}
		public static void glProgramUniform4fv(UInt32 program, Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniform4fv(program, location, count, ref value);
		}
		public static void glProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			i_OpenGL4_6.glProgramUniform4i(program, location, v0, v1, v2, v3);
		}
		public static void glProgramUniform4iv(UInt32 program, Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_6.glProgramUniform4iv(program, location, count, ref value);
		}
		public static void glProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			i_OpenGL4_6.glProgramUniform4ui(program, location, v0, v1, v2, v3);
		}
		public static void glProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_6.glProgramUniform4uiv(program, location, count, ref value);
		}
		public static void glProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix2dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix2fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix2x3dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix2x3fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix2x4dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix2x4fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix3dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix3fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix3x2dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix3x2fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix3x4dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix3x4fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix4dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix4fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix4x2dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix4x2fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix4x3dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glProgramUniformMatrix4x3fv(program, location, count, transpose, ref value);
		}
		public static void glProvokingVertex(VertexProvokingMode mode)
		{
			i_OpenGL4_6.glProvokingVertex(mode);
		}
		public static void glPushDebugGroup(DebugSource source, UInt32 id, Int32 length, ref string message)
		{
			i_OpenGL4_6.glPushDebugGroup(source, id, length, ref message);
		}
		public static void glQueryCounter(UInt32 id, QueryTarget target)
		{
			i_OpenGL4_6.glQueryCounter(id, target);
		}
		public static void glReadBuffer(ReadBufferMode src)
		{
			i_OpenGL4_6.glReadBuffer(src);
		}
		public static void glReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32 bufSize, IntPtr data)
		{
			i_OpenGL4_6.glReadnPixels(x, y, width, height, format, type, bufSize, data);
		}
		public static void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glReadPixels(x, y, width, height, format, type, pixels);
		}
		public static void glReleaseShaderCompiler()
		{
			i_OpenGL4_6.glReleaseShaderCompiler();
		}
		public static void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glRenderbufferStorage(target, internalformat, width, height);
		}
		public static void glRenderbufferStorageMultisample(RenderbufferTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		}
		public static void glResumeTransformFeedback()
		{
			i_OpenGL4_6.glResumeTransformFeedback();
		}
		public static void glSampleCoverage(Single value, Boolean invert)
		{
			i_OpenGL4_6.glSampleCoverage(value, invert);
		}
		public static void glSampleMaski(UInt32 maskNumber, UInt32 mask)
		{
			i_OpenGL4_6.glSampleMaski(maskNumber, mask);
		}
		public static void glSamplerParameterf(UInt32 sampler, SamplerParameterName pname, Single param)
		{
			i_OpenGL4_6.glSamplerParameterf(sampler, pname, param);
		}
		public static void glSamplerParameterfv(UInt32 sampler, SamplerParameterName pname, ref Single[] param)
		{
			i_OpenGL4_6.glSamplerParameterfv(sampler, pname, ref param);
		}
		public static void glSamplerParameteri(UInt32 sampler, SamplerParameterName pname, Int32 param)
		{
			i_OpenGL4_6.glSamplerParameteri(sampler, pname, param);
		}
		public static void glSamplerParameterIiv(UInt32 sampler, SamplerParameterName pname, ref Int32[] param)
		{
			i_OpenGL4_6.glSamplerParameterIiv(sampler, pname, ref param);
		}
		public static void glSamplerParameterIuiv(UInt32 sampler, SamplerParameterName pname, ref UInt32[] param)
		{
			i_OpenGL4_6.glSamplerParameterIuiv(sampler, pname, ref param);
		}
		public static void glSamplerParameteriv(UInt32 sampler, SamplerParameterName pname, ref Int32[] param)
		{
			i_OpenGL4_6.glSamplerParameteriv(sampler, pname, ref param);
		}
		public static void glScissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glScissor(x, y, width, height);
		}
		public static void glScissorArrayv(UInt32 first, Int32 count, ref Int32[] v)
		{
			i_OpenGL4_6.glScissorArrayv(first, count, ref v);
		}
		public static void glScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glScissorIndexed(index, left, bottom, width, height);
		}
		public static void glScissorIndexedv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_6.glScissorIndexedv(index, ref v);
		}
		public static void glSecondaryColorP3ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL4_6.glSecondaryColorP3ui(type, color);
		}
		public static void glSecondaryColorP3uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL4_6.glSecondaryColorP3uiv(type, ref color);
		}
		public static void glShaderBinary(Int32 count, ref UInt32[] shaders, GLenum binaryformat, IntPtr binary, Int32 length)
		{
			i_OpenGL4_6.glShaderBinary(count, ref shaders, binaryformat, binary, length);
		}
		public static void glShaderSource(UInt32 shader, Int32 count, ref string @string, ref Int32[] length)
		{
			i_OpenGL4_6.glShaderSource(shader, count, ref @string, ref length);
		}
		public static void glShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding)
		{
			i_OpenGL4_6.glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
		}
		public static void glSpecializeShader(UInt32 shader, ref Char pEntryPoint, UInt32 numSpecializationConstants, ref UInt32 pConstantIndex, ref UInt32 pConstantValue)
		{
			i_OpenGL4_6.glSpecializeShader(shader, ref pEntryPoint, numSpecializationConstants, ref pConstantIndex, ref pConstantValue);
		}
		public static void glStencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL4_6.glStencilFunc(func, @ref, mask);
		}
		public static void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL4_6.glStencilFuncSeparate(face, func, @ref, mask);
		}
		public static void glStencilMask(UInt32 mask)
		{
			i_OpenGL4_6.glStencilMask(mask);
		}
		public static void glStencilMaskSeparate(StencilFaceDirection face, UInt32 mask)
		{
			i_OpenGL4_6.glStencilMaskSeparate(face, mask);
		}
		public static void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			i_OpenGL4_6.glStencilOp(fail, zfail, zpass);
		}
		public static void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			i_OpenGL4_6.glStencilOpSeparate(face, sfail, dpfail, dppass);
		}
		public static void glTexBuffer(TextureTarget target, InternalFormat internalformat, UInt32 buffer)
		{
			i_OpenGL4_6.glTexBuffer(target, internalformat, buffer);
		}
		public static void glTexBufferRange(TextureTarget target, InternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size)
		{
			i_OpenGL4_6.glTexBufferRange(target, internalformat, buffer, offset, size);
		}
		public static void glTexCoordP1ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glTexCoordP1ui(type, coords);
		}
		public static void glTexCoordP1uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glTexCoordP1uiv(type, ref coords);
		}
		public static void glTexCoordP2ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glTexCoordP2ui(type, coords);
		}
		public static void glTexCoordP2uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glTexCoordP2uiv(type, ref coords);
		}
		public static void glTexCoordP3ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glTexCoordP3ui(type, coords);
		}
		public static void glTexCoordP3uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glTexCoordP3uiv(type, ref coords);
		}
		public static void glTexCoordP4ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_6.glTexCoordP4ui(type, coords);
		}
		public static void glTexCoordP4uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_6.glTexCoordP4uiv(type, ref coords);
		}
		public static void glTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}
		public static void glTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}
		public static void glTexImage2DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Boolean fixedsamplelocations)
		{
			i_OpenGL4_6.glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		public static void glTexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		public static void glTexImage3DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
		{
			i_OpenGL4_6.glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		public static void glTexParameterf(TextureTarget target, TextureParameterName pname, Single param)
		{
			i_OpenGL4_6.glTexParameterf(target, pname, param);
		}
		public static void glTexParameterfv(TextureTarget target, TextureParameterName pname, ref Single[] @params)
		{
			i_OpenGL4_6.glTexParameterfv(target, pname, ref @params);
		}
		public static void glTexParameteri(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			i_OpenGL4_6.glTexParameteri(target, pname, param);
		}
		public static void glTexParameterIiv(TextureTarget target, TextureParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glTexParameterIiv(target, pname, ref @params);
		}
		public static void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL4_6.glTexParameterIuiv(target, pname, ref @params);
		}
		public static void glTexParameteriv(TextureTarget target, TextureParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_6.glTexParameteriv(target, pname, ref @params);
		}
		public static void glTexStorage1D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width)
		{
			i_OpenGL4_6.glTexStorage1D(target, levels, internalformat, width);
		}
		public static void glTexStorage2D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glTexStorage2D(target, levels, internalformat, width, height);
		}
		public static void glTexStorage2DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Boolean fixedsamplelocations)
		{
			i_OpenGL4_6.glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		public static void glTexStorage3D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth)
		{
			i_OpenGL4_6.glTexStorage3D(target, levels, internalformat, width, height, depth);
		}
		public static void glTexStorage3DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
		{
			i_OpenGL4_6.glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		public static void glTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}
		public static void glTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		public static void glTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public static void glTextureBarrier()
		{
			i_OpenGL4_6.glTextureBarrier();
		}
		public static void glTextureBuffer(UInt32 texture, InternalFormat internalformat, UInt32 buffer)
		{
			i_OpenGL4_6.glTextureBuffer(texture, internalformat, buffer);
		}
		public static void glTextureBufferRange(UInt32 texture, InternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size)
		{
			i_OpenGL4_6.glTextureBufferRange(texture, internalformat, buffer, offset, size);
		}
		public static void glTextureParameterf(UInt32 texture, TextureParameterName pname, Single param)
		{
			i_OpenGL4_6.glTextureParameterf(texture, pname, param);
		}
		public static void glTextureParameterfv(UInt32 texture, TextureParameterName pname, ref Single param)
		{
			i_OpenGL4_6.glTextureParameterfv(texture, pname, ref param);
		}
		public static void glTextureParameteri(UInt32 texture, TextureParameterName pname, Int32 param)
		{
			i_OpenGL4_6.glTextureParameteri(texture, pname, param);
		}
		public static void glTextureParameterIiv(UInt32 texture, TextureParameterName pname, ref Int32 @params)
		{
			i_OpenGL4_6.glTextureParameterIiv(texture, pname, ref @params);
		}
		public static void glTextureParameterIuiv(UInt32 texture, TextureParameterName pname, ref UInt32 @params)
		{
			i_OpenGL4_6.glTextureParameterIuiv(texture, pname, ref @params);
		}
		public static void glTextureParameteriv(UInt32 texture, TextureParameterName pname, ref Int32 param)
		{
			i_OpenGL4_6.glTextureParameteriv(texture, pname, ref param);
		}
		public static void glTextureStorage1D(UInt32 texture, Int32 levels, InternalFormat internalformat, Int32 width)
		{
			i_OpenGL4_6.glTextureStorage1D(texture, levels, internalformat, width);
		}
		public static void glTextureStorage2D(UInt32 texture, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glTextureStorage2D(texture, levels, internalformat, width, height);
		}
		public static void glTextureStorage2DMultisample(UInt32 texture, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Boolean fixedsamplelocations)
		{
			i_OpenGL4_6.glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
		}
		public static void glTextureStorage3D(UInt32 texture, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth)
		{
			i_OpenGL4_6.glTextureStorage3D(texture, levels, internalformat, width, height, depth);
		}
		public static void glTextureStorage3DMultisample(UInt32 texture, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
		{
			i_OpenGL4_6.glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		public static void glTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
		}
		public static void glTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		public static void glTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_6.glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public static void glTextureView(UInt32 texture, TextureTarget target, UInt32 origtexture, InternalFormat internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
		{
			i_OpenGL4_6.glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}
		public static void glTransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer)
		{
			i_OpenGL4_6.glTransformFeedbackBufferBase(xfb, index, buffer);
		}
		public static void glTransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size)
		{
			i_OpenGL4_6.glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
		}
		public static void glTransformFeedbackVaryings(UInt32 program, Int32 count, ref string varyings, GLenum bufferMode)
		{
			i_OpenGL4_6.glTransformFeedbackVaryings(program, count, ref varyings, bufferMode);
		}
		public static void glUniform1d(Int32 location, Double x)
		{
			i_OpenGL4_6.glUniform1d(location, x);
		}
		public static void glUniform1dv(Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_6.glUniform1dv(location, count, ref value);
		}
		public static void glUniform1f(Int32 location, Single v0)
		{
			i_OpenGL4_6.glUniform1f(location, v0);
		}
		public static void glUniform1fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_6.glUniform1fv(location, count, ref value);
		}
		public static void glUniform1i(Int32 location, Int32 v0)
		{
			i_OpenGL4_6.glUniform1i(location, v0);
		}
		public static void glUniform1iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_6.glUniform1iv(location, count, ref value);
		}
		public static void glUniform1ui(Int32 location, UInt32 v0)
		{
			i_OpenGL4_6.glUniform1ui(location, v0);
		}
		public static void glUniform1uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_6.glUniform1uiv(location, count, ref value);
		}
		public static void glUniform2d(Int32 location, Double x, Double y)
		{
			i_OpenGL4_6.glUniform2d(location, x, y);
		}
		public static void glUniform2dv(Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_6.glUniform2dv(location, count, ref value);
		}
		public static void glUniform2f(Int32 location, Single v0, Single v1)
		{
			i_OpenGL4_6.glUniform2f(location, v0, v1);
		}
		public static void glUniform2fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_6.glUniform2fv(location, count, ref value);
		}
		public static void glUniform2i(Int32 location, Int32 v0, Int32 v1)
		{
			i_OpenGL4_6.glUniform2i(location, v0, v1);
		}
		public static void glUniform2iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_6.glUniform2iv(location, count, ref value);
		}
		public static void glUniform2ui(Int32 location, UInt32 v0, UInt32 v1)
		{
			i_OpenGL4_6.glUniform2ui(location, v0, v1);
		}
		public static void glUniform2uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_6.glUniform2uiv(location, count, ref value);
		}
		public static void glUniform3d(Int32 location, Double x, Double y, Double z)
		{
			i_OpenGL4_6.glUniform3d(location, x, y, z);
		}
		public static void glUniform3dv(Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_6.glUniform3dv(location, count, ref value);
		}
		public static void glUniform3f(Int32 location, Single v0, Single v1, Single v2)
		{
			i_OpenGL4_6.glUniform3f(location, v0, v1, v2);
		}
		public static void glUniform3fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_6.glUniform3fv(location, count, ref value);
		}
		public static void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			i_OpenGL4_6.glUniform3i(location, v0, v1, v2);
		}
		public static void glUniform3iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_6.glUniform3iv(location, count, ref value);
		}
		public static void glUniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			i_OpenGL4_6.glUniform3ui(location, v0, v1, v2);
		}
		public static void glUniform3uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_6.glUniform3uiv(location, count, ref value);
		}
		public static void glUniform4d(Int32 location, Double x, Double y, Double z, Double w)
		{
			i_OpenGL4_6.glUniform4d(location, x, y, z, w);
		}
		public static void glUniform4dv(Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_6.glUniform4dv(location, count, ref value);
		}
		public static void glUniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3)
		{
			i_OpenGL4_6.glUniform4f(location, v0, v1, v2, v3);
		}
		public static void glUniform4fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_6.glUniform4fv(location, count, ref value);
		}
		public static void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			i_OpenGL4_6.glUniform4i(location, v0, v1, v2, v3);
		}
		public static void glUniform4iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_6.glUniform4iv(location, count, ref value);
		}
		public static void glUniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			i_OpenGL4_6.glUniform4ui(location, v0, v1, v2, v3);
		}
		public static void glUniform4uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_6.glUniform4uiv(location, count, ref value);
		}
		public static void glUniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding)
		{
			i_OpenGL4_6.glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}
		public static void glUniformMatrix2dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix2dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x3dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix2x3dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix2x3fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x4dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix2x4dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix2x4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix3dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix3fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x2dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix3x2dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix3x2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x4dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix3x4dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix3x4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix4dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x2dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix4x2dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix4x2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x3dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_6.glUniformMatrix4x3dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_6.glUniformMatrix4x3fv(location, count, transpose, ref value);
		}
		public static void glUniformSubroutinesuiv(ShaderType shadertype, Int32 count, ref UInt32[] indices)
		{
			i_OpenGL4_6.glUniformSubroutinesuiv(shadertype, count, ref indices);
		}
		public static Boolean glUnmapBuffer(BufferTargetARB target)
		{
			return i_OpenGL4_6.glUnmapBuffer(target);
		}
		public static Boolean glUnmapNamedBuffer(UInt32 buffer)
		{
			return i_OpenGL4_6.glUnmapNamedBuffer(buffer);
		}
		public static void glUseProgram(UInt32 program)
		{
			i_OpenGL4_6.glUseProgram(program);
		}
		public static void glUseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program)
		{
			i_OpenGL4_6.glUseProgramStages(pipeline, stages, program);
		}
		public static void glValidateProgram(UInt32 program)
		{
			i_OpenGL4_6.glValidateProgram(program);
		}
		public static void glValidateProgramPipeline(UInt32 pipeline)
		{
			i_OpenGL4_6.glValidateProgramPipeline(pipeline);
		}
		public static void glVertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex)
		{
			i_OpenGL4_6.glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
		}
		public static void glVertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribType type, Boolean normalized, UInt32 relativeoffset)
		{
			i_OpenGL4_6.glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
		}
		public static void glVertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribType type, UInt32 relativeoffset)
		{
			i_OpenGL4_6.glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
		}
		public static void glVertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribType type, UInt32 relativeoffset)
		{
			i_OpenGL4_6.glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
		}
		public static void glVertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor)
		{
			i_OpenGL4_6.glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
		}
		public static void glVertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer)
		{
			i_OpenGL4_6.glVertexArrayElementBuffer(vaobj, buffer);
		}
		public static void glVertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
		{
			i_OpenGL4_6.glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
		}
		public static void glVertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, ref UInt32 buffers, IntPtr offsets, ref Int32 strides)
		{
			i_OpenGL4_6.glVertexArrayVertexBuffers(vaobj, first, count, ref buffers, offsets, ref strides);
		}
		public static void glVertexAttrib1d(UInt32 index, Double x)
		{
			i_OpenGL4_6.glVertexAttrib1d(index, x);
		}
		public static void glVertexAttrib1dv(UInt32 index, ref Double v)
		{
			i_OpenGL4_6.glVertexAttrib1dv(index, ref v);
		}
		public static void glVertexAttrib1f(UInt32 index, Single x)
		{
			i_OpenGL4_6.glVertexAttrib1f(index, x);
		}
		public static void glVertexAttrib1fv(UInt32 index, ref Single v)
		{
			i_OpenGL4_6.glVertexAttrib1fv(index, ref v);
		}
		public static void glVertexAttrib1s(UInt32 index, Int16 x)
		{
			i_OpenGL4_6.glVertexAttrib1s(index, x);
		}
		public static void glVertexAttrib1sv(UInt32 index, ref Int16 v)
		{
			i_OpenGL4_6.glVertexAttrib1sv(index, ref v);
		}
		public static void glVertexAttrib2d(UInt32 index, Double x, Double y)
		{
			i_OpenGL4_6.glVertexAttrib2d(index, x, y);
		}
		public static void glVertexAttrib2dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_6.glVertexAttrib2dv(index, ref v);
		}
		public static void glVertexAttrib2f(UInt32 index, Single x, Single y)
		{
			i_OpenGL4_6.glVertexAttrib2f(index, x, y);
		}
		public static void glVertexAttrib2fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL4_6.glVertexAttrib2fv(index, ref v);
		}
		public static void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y)
		{
			i_OpenGL4_6.glVertexAttrib2s(index, x, y);
		}
		public static void glVertexAttrib2sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_6.glVertexAttrib2sv(index, ref v);
		}
		public static void glVertexAttrib3d(UInt32 index, Double x, Double y, Double z)
		{
			i_OpenGL4_6.glVertexAttrib3d(index, x, y, z);
		}
		public static void glVertexAttrib3dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_6.glVertexAttrib3dv(index, ref v);
		}
		public static void glVertexAttrib3f(UInt32 index, Single x, Single y, Single z)
		{
			i_OpenGL4_6.glVertexAttrib3f(index, x, y, z);
		}
		public static void glVertexAttrib3fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL4_6.glVertexAttrib3fv(index, ref v);
		}
		public static void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL4_6.glVertexAttrib3s(index, x, y, z);
		}
		public static void glVertexAttrib3sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_6.glVertexAttrib3sv(index, ref v);
		}
		public static void glVertexAttrib4bv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL4_6.glVertexAttrib4bv(index, ref v);
		}
		public static void glVertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w)
		{
			i_OpenGL4_6.glVertexAttrib4d(index, x, y, z, w);
		}
		public static void glVertexAttrib4dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_6.glVertexAttrib4dv(index, ref v);
		}
		public static void glVertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w)
		{
			i_OpenGL4_6.glVertexAttrib4f(index, x, y, z, w);
		}
		public static void glVertexAttrib4fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL4_6.glVertexAttrib4fv(index, ref v);
		}
		public static void glVertexAttrib4iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_6.glVertexAttrib4iv(index, ref v);
		}
		public static void glVertexAttrib4Nbv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL4_6.glVertexAttrib4Nbv(index, ref v);
		}
		public static void glVertexAttrib4Niv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_6.glVertexAttrib4Niv(index, ref v);
		}
		public static void glVertexAttrib4Nsv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_6.glVertexAttrib4Nsv(index, ref v);
		}
		public static void glVertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w)
		{
			i_OpenGL4_6.glVertexAttrib4Nub(index, x, y, z, w);
		}
		public static void glVertexAttrib4Nubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL4_6.glVertexAttrib4Nubv(index, ref v);
		}
		public static void glVertexAttrib4Nuiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_6.glVertexAttrib4Nuiv(index, ref v);
		}
		public static void glVertexAttrib4Nusv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL4_6.glVertexAttrib4Nusv(index, ref v);
		}
		public static void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			i_OpenGL4_6.glVertexAttrib4s(index, x, y, z, w);
		}
		public static void glVertexAttrib4sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_6.glVertexAttrib4sv(index, ref v);
		}
		public static void glVertexAttrib4ubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL4_6.glVertexAttrib4ubv(index, ref v);
		}
		public static void glVertexAttrib4uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_6.glVertexAttrib4uiv(index, ref v);
		}
		public static void glVertexAttrib4usv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL4_6.glVertexAttrib4usv(index, ref v);
		}
		public static void glVertexAttribBinding(UInt32 attribindex, UInt32 bindingindex)
		{
			i_OpenGL4_6.glVertexAttribBinding(attribindex, bindingindex);
		}
		public static void glVertexAttribDivisor(UInt32 index, UInt32 divisor)
		{
			i_OpenGL4_6.glVertexAttribDivisor(index, divisor);
		}
		public static void glVertexAttribFormat(UInt32 attribindex, Int32 size, GLenum type, Boolean normalized, UInt32 relativeoffset)
		{
			i_OpenGL4_6.glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		}
		public static void glVertexAttribI1i(UInt32 index, Int32 x)
		{
			i_OpenGL4_6.glVertexAttribI1i(index, x);
		}
		public static void glVertexAttribI1iv(UInt32 index, ref Int32 v)
		{
			i_OpenGL4_6.glVertexAttribI1iv(index, ref v);
		}
		public static void glVertexAttribI1ui(UInt32 index, UInt32 x)
		{
			i_OpenGL4_6.glVertexAttribI1ui(index, x);
		}
		public static void glVertexAttribI1uiv(UInt32 index, ref UInt32 v)
		{
			i_OpenGL4_6.glVertexAttribI1uiv(index, ref v);
		}
		public static void glVertexAttribI2i(UInt32 index, Int32 x, Int32 y)
		{
			i_OpenGL4_6.glVertexAttribI2i(index, x, y);
		}
		public static void glVertexAttribI2iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_6.glVertexAttribI2iv(index, ref v);
		}
		public static void glVertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y)
		{
			i_OpenGL4_6.glVertexAttribI2ui(index, x, y);
		}
		public static void glVertexAttribI2uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_6.glVertexAttribI2uiv(index, ref v);
		}
		public static void glVertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z)
		{
			i_OpenGL4_6.glVertexAttribI3i(index, x, y, z);
		}
		public static void glVertexAttribI3iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_6.glVertexAttribI3iv(index, ref v);
		}
		public static void glVertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z)
		{
			i_OpenGL4_6.glVertexAttribI3ui(index, x, y, z);
		}
		public static void glVertexAttribI3uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_6.glVertexAttribI3uiv(index, ref v);
		}
		public static void glVertexAttribI4bv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL4_6.glVertexAttribI4bv(index, ref v);
		}
		public static void glVertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			i_OpenGL4_6.glVertexAttribI4i(index, x, y, z, w);
		}
		public static void glVertexAttribI4iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_6.glVertexAttribI4iv(index, ref v);
		}
		public static void glVertexAttribI4sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_6.glVertexAttribI4sv(index, ref v);
		}
		public static void glVertexAttribI4ubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL4_6.glVertexAttribI4ubv(index, ref v);
		}
		public static void glVertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			i_OpenGL4_6.glVertexAttribI4ui(index, x, y, z, w);
		}
		public static void glVertexAttribI4uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_6.glVertexAttribI4uiv(index, ref v);
		}
		public static void glVertexAttribI4usv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL4_6.glVertexAttribI4usv(index, ref v);
		}
		public static void glVertexAttribIFormat(UInt32 attribindex, Int32 size, GLenum type, UInt32 relativeoffset)
		{
			i_OpenGL4_6.glVertexAttribIFormat(attribindex, size, type, relativeoffset);
		}
		public static void glVertexAttribIPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL4_6.glVertexAttribIPointer(index, size, type, stride, pointer);
		}
		public static void glVertexAttribL1d(UInt32 index, Double x)
		{
			i_OpenGL4_6.glVertexAttribL1d(index, x);
		}
		public static void glVertexAttribL1dv(UInt32 index, ref Double v)
		{
			i_OpenGL4_6.glVertexAttribL1dv(index, ref v);
		}
		public static void glVertexAttribL2d(UInt32 index, Double x, Double y)
		{
			i_OpenGL4_6.glVertexAttribL2d(index, x, y);
		}
		public static void glVertexAttribL2dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_6.glVertexAttribL2dv(index, ref v);
		}
		public static void glVertexAttribL3d(UInt32 index, Double x, Double y, Double z)
		{
			i_OpenGL4_6.glVertexAttribL3d(index, x, y, z);
		}
		public static void glVertexAttribL3dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_6.glVertexAttribL3dv(index, ref v);
		}
		public static void glVertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w)
		{
			i_OpenGL4_6.glVertexAttribL4d(index, x, y, z, w);
		}
		public static void glVertexAttribL4dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_6.glVertexAttribL4dv(index, ref v);
		}
		public static void glVertexAttribLFormat(UInt32 attribindex, Int32 size, VertexAttribType type, UInt32 relativeoffset)
		{
			i_OpenGL4_6.glVertexAttribLFormat(attribindex, size, type, relativeoffset);
		}
		public static void glVertexAttribLPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL4_6.glVertexAttribLPointer(index, size, type, stride, pointer);
		}
		public static void glVertexAttribP1ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL4_6.glVertexAttribP1ui(index, type, normalized, value);
		}
		public static void glVertexAttribP1uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL4_6.glVertexAttribP1uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP2ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL4_6.glVertexAttribP2ui(index, type, normalized, value);
		}
		public static void glVertexAttribP2uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL4_6.glVertexAttribP2uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP3ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL4_6.glVertexAttribP3ui(index, type, normalized, value);
		}
		public static void glVertexAttribP3uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL4_6.glVertexAttribP3uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP4ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL4_6.glVertexAttribP4ui(index, type, normalized, value);
		}
		public static void glVertexAttribP4uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL4_6.glVertexAttribP4uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer)
		{
			i_OpenGL4_6.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}
		public static void glVertexBindingDivisor(UInt32 bindingindex, UInt32 divisor)
		{
			i_OpenGL4_6.glVertexBindingDivisor(bindingindex, divisor);
		}
		public static void glVertexP2ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL4_6.glVertexP2ui(type, value);
		}
		public static void glVertexP2uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL4_6.glVertexP2uiv(type, ref value);
		}
		public static void glVertexP3ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL4_6.glVertexP3ui(type, value);
		}
		public static void glVertexP3uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL4_6.glVertexP3uiv(type, ref value);
		}
		public static void glVertexP4ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL4_6.glVertexP4ui(type, value);
		}
		public static void glVertexP4uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL4_6.glVertexP4uiv(type, ref value);
		}
		public static void glViewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_6.glViewport(x, y, width, height);
		}
		public static void glViewportArrayv(UInt32 first, Int32 count, ref Single[] v)
		{
			i_OpenGL4_6.glViewportArrayv(first, count, ref v);
		}
		public static void glViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h)
		{
			i_OpenGL4_6.glViewportIndexedf(index, x, y, w, h);
		}
		public static void glViewportIndexedfv(UInt32 index, ref Single[] v)
		{
			i_OpenGL4_6.glViewportIndexedfv(index, ref v);
		}
		public static void glWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
		{
			i_OpenGL4_6.glWaitSync(sync, flags, timeout);
		}
	}
}

