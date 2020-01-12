// OpenGL 4.4 Commands.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;
using System.Runtime.InteropServices;

namespace fgtk.OpenGL
{
	public static class OpenGL4_4
	{
		public static void glActiveShaderProgram(UInt32 pipeline, UInt32 program)
		{
			i_OpenGL4_4.glActiveShaderProgram(pipeline, program);
		}
		public static void glActiveTexture(TextureUnit texture)
		{
			i_OpenGL4_4.glActiveTexture(texture);
		}
		public static void glAttachShader(UInt32 program, UInt32 shader)
		{
			i_OpenGL4_4.glAttachShader(program, shader);
		}
		public static void glBeginConditionalRender(UInt32 id, TypeEnum mode)
		{
			i_OpenGL4_4.glBeginConditionalRender(id, mode);
		}
		public static void glBeginQuery(QueryTarget target, UInt32 id)
		{
			i_OpenGL4_4.glBeginQuery(target, id);
		}
		public static void glBeginQueryIndexed(QueryTarget target, UInt32 index, UInt32 id)
		{
			i_OpenGL4_4.glBeginQueryIndexed(target, index, id);
		}
		public static void glBeginTransformFeedback(PrimitiveType primitiveMode)
		{
			i_OpenGL4_4.glBeginTransformFeedback(primitiveMode);
		}
		public static void glBindAttribLocation(UInt32 program, UInt32 index, ref Char name)
		{
			i_OpenGL4_4.glBindAttribLocation(program, index, ref name);
		}
		public static void glBindBuffer(BufferTargetARB target, UInt32 buffer)
		{
			i_OpenGL4_4.glBindBuffer(target, buffer);
		}
		public static void glBindBufferBase(BufferTargetARB target, UInt32 index, UInt32 buffer)
		{
			i_OpenGL4_4.glBindBufferBase(target, index, buffer);
		}
		public static void glBindBufferRange(BufferTargetARB target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size)
		{
			i_OpenGL4_4.glBindBufferRange(target, index, buffer, offset, size);
		}
		public static void glBindBuffersBase(BufferTargetARB target, UInt32 first, Int32 count, ref UInt32[] buffers)
		{
			i_OpenGL4_4.glBindBuffersBase(target, first, count, ref buffers);
		}
		public static void glBindBuffersRange(BufferTargetARB target, UInt32 first, Int32 count, ref UInt32[] buffers, IntPtr offsets, IntPtr sizes)
		{
			i_OpenGL4_4.glBindBuffersRange(target, first, count, ref buffers, offsets, sizes);
		}
		public static void glBindFragDataLocation(UInt32 program, UInt32 color, ref string name)
		{
			i_OpenGL4_4.glBindFragDataLocation(program, color, ref name);
		}
		public static void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, ref Char name)
		{
			i_OpenGL4_4.glBindFragDataLocationIndexed(program, colorNumber, index, ref name);
		}
		public static void glBindFramebuffer(FramebufferTarget target, UInt32 framebuffer)
		{
			i_OpenGL4_4.glBindFramebuffer(target, framebuffer);
		}
		public static void glBindImageTexture(UInt32 unit, UInt32 texture, Int32 level, Boolean layered, Int32 layer, BufferAccessARB access, InternalFormat format)
		{
			i_OpenGL4_4.glBindImageTexture(unit, texture, level, layered, layer, access, format);
		}
		public static void glBindImageTextures(UInt32 first, Int32 count, ref UInt32[] textures)
		{
			i_OpenGL4_4.glBindImageTextures(first, count, ref textures);
		}
		public static void glBindProgramPipeline(UInt32 pipeline)
		{
			i_OpenGL4_4.glBindProgramPipeline(pipeline);
		}
		public static void glBindRenderbuffer(RenderbufferTarget target, UInt32 renderbuffer)
		{
			i_OpenGL4_4.glBindRenderbuffer(target, renderbuffer);
		}
		public static void glBindSampler(UInt32 unit, UInt32 sampler)
		{
			i_OpenGL4_4.glBindSampler(unit, sampler);
		}
		public static void glBindSamplers(UInt32 first, Int32 count, ref UInt32[] samplers)
		{
			i_OpenGL4_4.glBindSamplers(first, count, ref samplers);
		}
		public static void glBindTexture(TextureTarget target, UInt32 texture)
		{
			i_OpenGL4_4.glBindTexture(target, texture);
		}
		public static void glBindTextures(UInt32 first, Int32 count, ref UInt32[] textures)
		{
			i_OpenGL4_4.glBindTextures(first, count, ref textures);
		}
		public static void glBindTransformFeedback(BindTransformFeedbackTarget target, UInt32 id)
		{
			i_OpenGL4_4.glBindTransformFeedback(target, id);
		}
		public static void glBindVertexArray(UInt32 array)
		{
			i_OpenGL4_4.glBindVertexArray(array);
		}
		public static void glBindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
		{
			i_OpenGL4_4.glBindVertexBuffer(bindingindex, buffer, offset, stride);
		}
		public static void glBindVertexBuffers(UInt32 first, Int32 count, ref UInt32[] buffers, IntPtr offsets, ref Int32[] strides)
		{
			i_OpenGL4_4.glBindVertexBuffers(first, count, ref buffers, offsets, ref strides);
		}
		public static void glBlendColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL4_4.glBlendColor(red, green, blue, alpha);
		}
		public static void glBlendEquation(BlendEquationModeEXT mode)
		{
			i_OpenGL4_4.glBlendEquation(mode);
		}
		public static void glBlendEquationi(UInt32 buf, BlendEquationModeEXT mode)
		{
			i_OpenGL4_4.glBlendEquationi(buf, mode);
		}
		public static void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			i_OpenGL4_4.glBlendEquationSeparate(modeRGB, modeAlpha);
		}
		public static void glBlendEquationSeparatei(UInt32 buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			i_OpenGL4_4.glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		}
		public static void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			i_OpenGL4_4.glBlendFunc(sfactor, dfactor);
		}
		public static void glBlendFunci(UInt32 buf, BlendingFactor src, BlendingFactor dst)
		{
			i_OpenGL4_4.glBlendFunci(buf, src, dst);
		}
		public static void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
		{
			i_OpenGL4_4.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		public static void glBlendFuncSeparatei(UInt32 buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
		{
			i_OpenGL4_4.glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		public static void glBlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, BlitFramebufferFilter filter)
		{
			i_OpenGL4_4.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		public static void glBufferData(BufferTargetARB target, IntPtr size, IntPtr data, BufferUsageARB usage)
		{
			i_OpenGL4_4.glBufferData(target, size, data, usage);
		}
		public static void glBufferData<T>(BufferTargetARB target, IntPtr size, T[] data, BufferUsageARB usage) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			glBufferData(target, size, (IntPtr)ptr.AddrOfPinnedObject(), usage);
			ptr.Free();
		}
		public static void glBufferStorage(BufferStorageTarget target, IntPtr size, IntPtr data, UInt32 flags)
		{
			i_OpenGL4_4.glBufferStorage(target, size, data, flags);
		}
		public static void glBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL4_4.glBufferSubData(target, offset, size, data);
		}
		public static void glBufferSubData<T>(BufferTargetARB target, IntPtr offset, IntPtr size, T[] data) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			glBufferSubData(target, offset, size, (IntPtr)ptr.AddrOfPinnedObject());
			ptr.Free();
		}
		public static FramebufferStatus glCheckFramebufferStatus(FramebufferTarget target)
		{
			return i_OpenGL4_4.glCheckFramebufferStatus(target);
		}
		public static void glClampColor(GLenum target, GLenum clamp)
		{
			i_OpenGL4_4.glClampColor(target, clamp);
		}
		public static void glClear(UInt32 mask)
		{
			i_OpenGL4_4.glClear(mask);
		}
		public static void glClearBufferData(BufferStorageTarget target, InternalFormat internalformat, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_4.glClearBufferData(target, internalformat, format, type, data);
		}
		public static void glClearBufferfi(Buffer buffer, Int32 drawbuffer, Single depth, Int32 stencil)
		{
			i_OpenGL4_4.glClearBufferfi(buffer, drawbuffer, depth, stencil);
		}
		public static void glClearBufferfv(Buffer buffer, Int32 drawbuffer, ref Single[] value)
		{
			i_OpenGL4_4.glClearBufferfv(buffer, drawbuffer, ref value);
		}
		public static void glClearBufferiv(Buffer buffer, Int32 drawbuffer, ref Int32[] value)
		{
			i_OpenGL4_4.glClearBufferiv(buffer, drawbuffer, ref value);
		}
		public static void glClearBufferSubData(GLenum target, InternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_4.glClearBufferSubData(target, internalformat, offset, size, format, type, data);
		}
		public static void glClearBufferuiv(Buffer buffer, Int32 drawbuffer, ref UInt32[] value)
		{
			i_OpenGL4_4.glClearBufferuiv(buffer, drawbuffer, ref value);
		}
		public static void glClearColor(Single red, Single green, Single blue, Single alpha)
		{
			i_OpenGL4_4.glClearColor(red, green, blue, alpha);
		}
		public static void glClearDepth(Double depth)
		{
			i_OpenGL4_4.glClearDepth(depth);
		}
		public static void glClearDepthf(Single d)
		{
			i_OpenGL4_4.glClearDepthf(d);
		}
		public static void glClearStencil(Int32 s)
		{
			i_OpenGL4_4.glClearStencil(s);
		}
		public static void glClearTexImage(UInt32 texture, Int32 level, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_4.glClearTexImage(texture, level, format, type, data);
		}
		public static void glClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr data)
		{
			i_OpenGL4_4.glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}
		public static SyncStatus glClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
		{
			return i_OpenGL4_4.glClientWaitSync(sync, flags, timeout);
		}
		public static void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
		{
			i_OpenGL4_4.glColorMask(red, green, blue, alpha);
		}
		public static void glColorMaski(UInt32 index, Boolean r, Boolean g, Boolean b, Boolean a)
		{
			i_OpenGL4_4.glColorMaski(index, r, g, b, a);
		}
		public static void glColorP3ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL4_4.glColorP3ui(type, color);
		}
		public static void glColorP3uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL4_4.glColorP3uiv(type, ref color);
		}
		public static void glColorP4ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL4_4.glColorP4ui(type, color);
		}
		public static void glColorP4uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL4_4.glColorP4uiv(type, ref color);
		}
		public static void glCompileShader(UInt32 shader)
		{
			i_OpenGL4_4.glCompileShader(shader);
		}
		public static void glCompressedTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_4.glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		}
		public static void glCompressedTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_4.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}
		public static void glCompressedTexImage3D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_4.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public static void glCompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_4.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		}
		public static void glCompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_4.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public static void glCompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			i_OpenGL4_4.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public static void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
		{
			i_OpenGL4_4.glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		}
		public static void glCopyImageSubData(UInt32 srcName, CopyBufferSubDataTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, CopyBufferSubDataTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
		{
			i_OpenGL4_4.glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}
		public static void glCopyTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			i_OpenGL4_4.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}
		public static void glCopyTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			i_OpenGL4_4.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}
		public static void glCopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			i_OpenGL4_4.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}
		public static void glCopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}
		public static void glCopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		public static UInt32 glCreateProgram()
		{
			return i_OpenGL4_4.glCreateProgram();
		}
		public static UInt32 glCreateShader(ShaderType type)
		{
			return i_OpenGL4_4.glCreateShader(type);
		}
		public static UInt32 glCreateShaderProgramv(ShaderType type, Int32 count, ref string strings)
		{
			return i_OpenGL4_4.glCreateShaderProgramv(type, count, ref strings);
		}
		public static void glCullFace(CullFaceMode mode)
		{
			i_OpenGL4_4.glCullFace(mode);
		}
		public static void glDebugMessageCallback(Delegates.GLDEBUGPROC callback, IntPtr userParam)
		{
			i_OpenGL4_4.glDebugMessageCallback(callback, userParam);
		}
		public static void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, Int32 count, ref UInt32[] ids, Boolean enabled)
		{
			i_OpenGL4_4.glDebugMessageControl(source, type, severity, count, ref ids, enabled);
		}
		public static void glDebugMessageInsert(DebugSource source, DebugType type, UInt32 id, DebugSeverity severity, Int32 length, ref string buf)
		{
			i_OpenGL4_4.glDebugMessageInsert(source, type, id, severity, length, ref buf);
		}
		public static void glDeleteBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL4_4.glDeleteBuffers(n, ref buffers);
		}
		public static void glDeleteFramebuffers(Int32 n, ref UInt32[] framebuffers)
		{
			i_OpenGL4_4.glDeleteFramebuffers(n, ref framebuffers);
		}
		public static void glDeleteProgram(UInt32 program)
		{
			i_OpenGL4_4.glDeleteProgram(program);
		}
		public static void glDeleteProgramPipelines(Int32 n, ref UInt32[] pipelines)
		{
			i_OpenGL4_4.glDeleteProgramPipelines(n, ref pipelines);
		}
		public static void glDeleteQueries(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_4.glDeleteQueries(n, ref ids);
		}
		public static void glDeleteRenderbuffers(Int32 n, ref UInt32[] renderbuffers)
		{
			i_OpenGL4_4.glDeleteRenderbuffers(n, ref renderbuffers);
		}
		public static void glDeleteSamplers(Int32 count, ref UInt32[] samplers)
		{
			i_OpenGL4_4.glDeleteSamplers(count, ref samplers);
		}
		public static void glDeleteShader(UInt32 shader)
		{
			i_OpenGL4_4.glDeleteShader(shader);
		}
		public static void glDeleteSync(IntPtr sync)
		{
			i_OpenGL4_4.glDeleteSync(sync);
		}
		public static void glDeleteTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL4_4.glDeleteTextures(n, ref textures);
		}
		public static void glDeleteTransformFeedbacks(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_4.glDeleteTransformFeedbacks(n, ref ids);
		}
		public static void glDeleteVertexArrays(Int32 n, ref UInt32[] arrays)
		{
			i_OpenGL4_4.glDeleteVertexArrays(n, ref arrays);
		}
		public static void glDepthFunc(DepthFunction func)
		{
			i_OpenGL4_4.glDepthFunc(func);
		}
		public static void glDepthMask(Boolean flag)
		{
			i_OpenGL4_4.glDepthMask(flag);
		}
		public static void glDepthRange(Double n, Double f)
		{
			i_OpenGL4_4.glDepthRange(n, f);
		}
		public static void glDepthRangeArrayv(UInt32 first, Int32 count, ref Double[] v)
		{
			i_OpenGL4_4.glDepthRangeArrayv(first, count, ref v);
		}
		public static void glDepthRangef(Single n, Single f)
		{
			i_OpenGL4_4.glDepthRangef(n, f);
		}
		public static void glDepthRangeIndexed(UInt32 index, Double n, Double f)
		{
			i_OpenGL4_4.glDepthRangeIndexed(index, n, f);
		}
		public static void glDetachShader(UInt32 program, UInt32 shader)
		{
			i_OpenGL4_4.glDetachShader(program, shader);
		}
		public static void glDisable(EnableCap cap)
		{
			i_OpenGL4_4.glDisable(cap);
		}
		public static void glDisablei(EnableCap target, UInt32 index)
		{
			i_OpenGL4_4.glDisablei(target, index);
		}
		public static void glDisableVertexAttribArray(UInt32 index)
		{
			i_OpenGL4_4.glDisableVertexAttribArray(index);
		}
		public static void glDispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z)
		{
			i_OpenGL4_4.glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		}
		public static void glDispatchComputeIndirect(IntPtr indirect)
		{
			i_OpenGL4_4.glDispatchComputeIndirect(indirect);
		}
		public static void glDrawArrays(PrimitiveType mode, Int32 first, Int32 count)
		{
			i_OpenGL4_4.glDrawArrays(mode, first, count);
		}
		public static void glDrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
		{
			i_OpenGL4_4.glDrawArraysIndirect(mode, indirect);
		}
		public static void glDrawArraysInstanced(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount)
		{
			i_OpenGL4_4.glDrawArraysInstanced(mode, first, count, instancecount);
		}
		public static void glDrawArraysInstancedBaseInstance(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance)
		{
			i_OpenGL4_4.glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
		}
		public static void glDrawBuffer(DrawBufferMode buf)
		{
			i_OpenGL4_4.glDrawBuffer(buf);
		}
		public static void glDrawBuffers(Int32 n, ref GLenum[] bufs)
		{
			i_OpenGL4_4.glDrawBuffers(n, ref bufs);
		}
		public static void glDrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL4_4.glDrawElements(mode, count, type, indices);
		}
		public static void glDrawElementsBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			i_OpenGL4_4.glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}
		public static void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect)
		{
			i_OpenGL4_4.glDrawElementsIndirect(mode, type, indirect);
		}
		public static void glDrawElementsInstanced(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount)
		{
			i_OpenGL4_4.glDrawElementsInstanced(mode, count, type, indices, instancecount);
		}
		public static void glDrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, PrimitiveType type, IntPtr indices, Int32 instancecount, UInt32 baseinstance)
		{
			i_OpenGL4_4.glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
		}
		public static void glDrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex)
		{
			i_OpenGL4_4.glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}
		public static void glDrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, PrimitiveType type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
		{
			i_OpenGL4_4.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}
		public static void glDrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices)
		{
			i_OpenGL4_4.glDrawRangeElements(mode, start, end, count, type, indices);
		}
		public static void glDrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
		{
			i_OpenGL4_4.glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}
		public static void glDrawTransformFeedback(PrimitiveType mode, UInt32 id)
		{
			i_OpenGL4_4.glDrawTransformFeedback(mode, id);
		}
		public static void glDrawTransformFeedbackInstanced(PrimitiveType mode, UInt32 id, Int32 instancecount)
		{
			i_OpenGL4_4.glDrawTransformFeedbackInstanced(mode, id, instancecount);
		}
		public static void glDrawTransformFeedbackStream(PrimitiveType mode, UInt32 id, UInt32 stream)
		{
			i_OpenGL4_4.glDrawTransformFeedbackStream(mode, id, stream);
		}
		public static void glDrawTransformFeedbackStreamInstanced(PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount)
		{
			i_OpenGL4_4.glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
		}
		public static void glEnable(EnableCap cap)
		{
			i_OpenGL4_4.glEnable(cap);
		}
		public static void glEnablei(EnableCap target, UInt32 index)
		{
			i_OpenGL4_4.glEnablei(target, index);
		}
		public static void glEnableVertexAttribArray(UInt32 index)
		{
			i_OpenGL4_4.glEnableVertexAttribArray(index);
		}
		public static void glEndConditionalRender()
		{
			i_OpenGL4_4.glEndConditionalRender();
		}
		public static void glEndQuery(QueryTarget target)
		{
			i_OpenGL4_4.glEndQuery(target);
		}
		public static void glEndQueryIndexed(QueryTarget target, UInt32 index)
		{
			i_OpenGL4_4.glEndQueryIndexed(target, index);
		}
		public static void glEndTransformFeedback()
		{
			i_OpenGL4_4.glEndTransformFeedback();
		}
		public static IntPtr glFenceSync(SyncCondition condition, UInt32 flags)
		{
			return i_OpenGL4_4.glFenceSync(condition, flags);
		}
		public static void glFinish()
		{
			i_OpenGL4_4.glFinish();
		}
		public static void glFlush()
		{
			i_OpenGL4_4.glFlush();
		}
		public static void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length)
		{
			i_OpenGL4_4.glFlushMappedBufferRange(target, offset, length);
		}
		public static void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, Int32 param)
		{
			i_OpenGL4_4.glFramebufferParameteri(target, pname, param);
		}
		public static void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
		{
			i_OpenGL4_4.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}
		public static void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level)
		{
			i_OpenGL4_4.glFramebufferTexture(target, attachment, texture, level);
		}
		public static void glFramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			i_OpenGL4_4.glFramebufferTexture1D(target, attachment, textarget, texture, level);
		}
		public static void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			i_OpenGL4_4.glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}
		public static void glFramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset)
		{
			i_OpenGL4_4.glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
		}
		public static void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			i_OpenGL4_4.glFramebufferTextureLayer(target, attachment, texture, level, layer);
		}
		public static void glFrontFace(FrontFaceDirection mode)
		{
			i_OpenGL4_4.glFrontFace(mode);
		}
		public static void glGenBuffers(Int32 n, ref UInt32[] buffers)
		{
			i_OpenGL4_4.glGenBuffers(n, ref buffers);
		}
		public static void glGenerateMipmap(TextureTarget target)
		{
			i_OpenGL4_4.glGenerateMipmap(target);
		}
		public static void glGenFramebuffers(Int32 n, ref UInt32[] framebuffers)
		{
			i_OpenGL4_4.glGenFramebuffers(n, ref framebuffers);
		}
		public static void glGenProgramPipelines(Int32 n, ref UInt32[] pipelines)
		{
			i_OpenGL4_4.glGenProgramPipelines(n, ref pipelines);
		}
		public static void glGenQueries(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_4.glGenQueries(n, ref ids);
		}
		public static void glGenRenderbuffers(Int32 n, ref UInt32[] renderbuffers)
		{
			i_OpenGL4_4.glGenRenderbuffers(n, ref renderbuffers);
		}
		public static void glGenSamplers(Int32 count, ref UInt32[] samplers)
		{
			i_OpenGL4_4.glGenSamplers(count, ref samplers);
		}
		public static void glGenTextures(Int32 n, ref UInt32[] textures)
		{
			i_OpenGL4_4.glGenTextures(n, ref textures);
		}
		public static void glGenTransformFeedbacks(Int32 n, ref UInt32[] ids)
		{
			i_OpenGL4_4.glGenTransformFeedbacks(n, ref ids);
		}
		public static void glGenVertexArrays(Int32 n, ref UInt32[] arrays)
		{
			i_OpenGL4_4.glGenVertexArrays(n, ref arrays);
		}
		public static void glGetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, AtomicCounterBufferPName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, ref @params);
		}
		public static void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string name)
		{
			i_OpenGL4_4.glGetActiveAttrib(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static void glGetActiveSubroutineName(UInt32 program, ShaderType shadertype, UInt32 index, Int32 bufsize, ref Int32 length, ref string name)
		{
			i_OpenGL4_4.glGetActiveSubroutineName(program, shadertype, index, bufsize, ref length, ref name);
		}
		public static void glGetActiveSubroutineUniformiv(UInt32 program, ShaderType shadertype, UInt32 index, SubroutineParameterName pname, ref Int32[] values)
		{
			i_OpenGL4_4.glGetActiveSubroutineUniformiv(program, shadertype, index, pname, ref values);
		}
		public static void glGetActiveSubroutineUniformName(UInt32 program, ShaderType shadertype, UInt32 index, Int32 bufsize, ref Int32 length, ref string name)
		{
			i_OpenGL4_4.glGetActiveSubroutineUniformName(program, shadertype, index, bufsize, ref length, ref name);
		}
		public static void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string name)
		{
			i_OpenGL4_4.glGetActiveUniform(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static void glGetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, UniformBlockPName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, ref @params);
		}
		public static void glGetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, ref Int32 length, ref string uniformBlockName)
		{
			i_OpenGL4_4.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, ref length, ref uniformBlockName);
		}
		public static void glGetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, ref Int32 length, ref string uniformName)
		{
			i_OpenGL4_4.glGetActiveUniformName(program, uniformIndex, bufSize, ref length, ref uniformName);
		}
		public static void glGetActiveUniformsiv(UInt32 program, Int32 uniformCount, ref UInt32[] uniformIndices, UniformPName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetActiveUniformsiv(program, uniformCount, ref uniformIndices, pname, ref @params);
		}
		public static void glGetAttachedShaders(UInt32 program, Int32 maxCount, ref Int32 count, ref UInt32[] shaders)
		{
			i_OpenGL4_4.glGetAttachedShaders(program, maxCount, ref count, ref shaders);
		}
		public static Int32 glGetAttribLocation(UInt32 program, ref Char name)
		{
			return i_OpenGL4_4.glGetAttribLocation(program, ref name);
		}
		public static void glGetBooleani_v(BufferTargetARB target, UInt32 index, ref Boolean[] data)
		{
			i_OpenGL4_4.glGetBooleani_v(target, index, ref data);
		}
		public static void glGetBooleanv(GetPName pname, ref Boolean[] data)
		{
			i_OpenGL4_4.glGetBooleanv(pname, ref data);
		}
		public static void glGetBufferParameteri64v(BufferTargetARB target, GLenum pname, ref Int64[] @params)
		{
			i_OpenGL4_4.glGetBufferParameteri64v(target, pname, ref @params);
		}
		public static void glGetBufferParameteriv(BufferTargetARB target, GLenum pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetBufferParameteriv(target, pname, ref @params);
		}
		public static void glGetBufferPointerv(BufferTargetARB target, GLenum pname, IntPtr @params)
		{
			i_OpenGL4_4.glGetBufferPointerv(target, pname, @params);
		}
		public static void glGetBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
		{
			i_OpenGL4_4.glGetBufferSubData(target, offset, size, data);
		}
		public static void glGetCompressedTexImage(TextureTarget target, Int32 level, IntPtr img)
		{
			i_OpenGL4_4.glGetCompressedTexImage(target, level, img);
		}
		public static UInt32 glGetDebugMessageLog(UInt32 count, Int32 bufSize, ref DebugSource[] sources, ref DebugType[] types, ref UInt32[] ids, ref DebugSeverity[] severities, ref Int32[] lengths, ref string messageLog)
		{
			return i_OpenGL4_4.glGetDebugMessageLog(count, bufSize, ref sources, ref types, ref ids, ref severities, ref lengths, ref messageLog);
		}
		public static void glGetDoublei_v(TypeEnum target, UInt32 index, ref Double[] data)
		{
			i_OpenGL4_4.glGetDoublei_v(target, index, ref data);
		}
		public static void glGetDoublev(GetPName pname, ref Double[] data)
		{
			i_OpenGL4_4.glGetDoublev(pname, ref data);
		}
		public static ErrorCode glGetError()
		{
			return i_OpenGL4_4.glGetError();
		}
		public static void glGetFloati_v(TypeEnum target, UInt32 index, ref Single[] data)
		{
			i_OpenGL4_4.glGetFloati_v(target, index, ref data);
		}
		public static void glGetFloatv(GetPName pname, ref Single[] data)
		{
			i_OpenGL4_4.glGetFloatv(pname, ref data);
		}
		public static Int32 glGetFragDataIndex(UInt32 program, ref Char name)
		{
			return i_OpenGL4_4.glGetFragDataIndex(program, ref name);
		}
		public static Int32 glGetFragDataLocation(UInt32 program, ref string name)
		{
			return i_OpenGL4_4.glGetFragDataLocation(program, ref name);
		}
		public static void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetFramebufferAttachmentParameteriv(target, attachment, pname, ref @params);
		}
		public static void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetFramebufferParameteriv(target, pname, ref @params);
		}
		public static void glGetInteger64i_v(TypeEnum target, UInt32 index, ref Int64[] data)
		{
			i_OpenGL4_4.glGetInteger64i_v(target, index, ref data);
		}
		public static void glGetInteger64v(GetPName pname, ref Int64[] data)
		{
			i_OpenGL4_4.glGetInteger64v(pname, ref data);
		}
		public static void glGetIntegeri_v(TypeEnum target, UInt32 index, ref Int32[] data)
		{
			i_OpenGL4_4.glGetIntegeri_v(target, index, ref data);
		}
		public static void glGetIntegerv(GetPName pname, ref Int32[] data)
		{
			i_OpenGL4_4.glGetIntegerv(pname, ref data);
		}
		public static void glGetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Int32 bufSize, ref Int64[] @params)
		{
			i_OpenGL4_4.glGetInternalformati64v(target, internalformat, pname, bufSize, ref @params);
		}
		public static void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Int32 bufSize, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetInternalformativ(target, internalformat, pname, bufSize, ref @params);
		}
		public static void glGetMultisamplefv(GLenum pname, UInt32 index, ref Single[] val)
		{
			i_OpenGL4_4.glGetMultisamplefv(pname, index, ref val);
		}
		public static void glGetObjectLabel(GLenum identifier, UInt32 name, Int32 bufSize, ref Int32 length, ref string label)
		{
			i_OpenGL4_4.glGetObjectLabel(identifier, name, bufSize, ref length, ref label);
		}
		public static void glGetObjectPtrLabel(IntPtr ptr, Int32 bufSize, ref Int32 length, ref string label)
		{
			i_OpenGL4_4.glGetObjectPtrLabel(ptr, bufSize, ref length, ref label);
		}
		public static void glGetPointerv(GetPointervPName pname, IntPtr @params)
		{
			i_OpenGL4_4.glGetPointerv(pname, @params);
		}
		public static void glGetProgramBinary(UInt32 program, Int32 bufSize, ref Int32 length, ref GLenum binaryFormat, IntPtr binary)
		{
			i_OpenGL4_4.glGetProgramBinary(program, bufSize, ref length, ref binaryFormat, binary);
		}
		public static void glGetProgramInfoLog(UInt32 program, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL4_4.glGetProgramInfoLog(program, bufSize, ref length, ref infoLog);
		}
		public static void glGetProgramInterfaceiv(UInt32 program, ProgramInterface programInterface, ProgramInterfacePName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetProgramInterfaceiv(program, programInterface, pname, ref @params);
		}
		public static void glGetProgramiv(UInt32 program, ProgramPropertyARB pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetProgramiv(program, pname, ref @params);
		}
		public static void glGetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL4_4.glGetProgramPipelineInfoLog(pipeline, bufSize, ref length, ref infoLog);
		}
		public static void glGetProgramPipelineiv(UInt32 pipeline, PipelineParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetProgramPipelineiv(pipeline, pname, ref @params);
		}
		public static UInt32 glGetProgramResourceIndex(UInt32 program, ProgramInterface programInterface, ref string name)
		{
			return i_OpenGL4_4.glGetProgramResourceIndex(program, programInterface, ref name);
		}
		public static void glGetProgramResourceiv(UInt32 program, ProgramInterface programInterface, UInt32 index, Int32 propCount, ref GLenum[] props, Int32 bufSize, ref Int32 length, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetProgramResourceiv(program, programInterface, index, propCount, ref props, bufSize, ref length, ref @params);
		}
		public static Int32 glGetProgramResourceLocation(UInt32 program, ProgramInterface programInterface, ref string name)
		{
			return i_OpenGL4_4.glGetProgramResourceLocation(program, programInterface, ref name);
		}
		public static Int32 glGetProgramResourceLocationIndex(UInt32 program, ProgramInterface programInterface, ref string name)
		{
			return i_OpenGL4_4.glGetProgramResourceLocationIndex(program, programInterface, ref name);
		}
		public static void glGetProgramResourceName(UInt32 program, ProgramInterface programInterface, UInt32 index, Int32 bufSize, ref Int32 length, ref string name)
		{
			i_OpenGL4_4.glGetProgramResourceName(program, programInterface, index, bufSize, ref length, ref name);
		}
		public static void glGetProgramStageiv(UInt32 program, ShaderType shadertype, ProgramStagePName pname, ref Int32 values)
		{
			i_OpenGL4_4.glGetProgramStageiv(program, shadertype, pname, ref values);
		}
		public static void glGetQueryIndexediv(GLenum target, UInt32 index, QueryParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetQueryIndexediv(target, index, pname, ref @params);
		}
		public static void glGetQueryiv(QueryTarget target, QueryParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetQueryiv(target, pname, ref @params);
		}
		public static void glGetQueryObjecti64v(UInt32 id, QueryObjectParameterName pname, ref Int64[] @params)
		{
			i_OpenGL4_4.glGetQueryObjecti64v(id, pname, ref @params);
		}
		public static void glGetQueryObjectiv(UInt32 id, QueryObjectParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetQueryObjectiv(id, pname, ref @params);
		}
		public static void glGetQueryObjectui64v(UInt32 id, QueryObjectParameterName pname, ref UInt64[] @params)
		{
			i_OpenGL4_4.glGetQueryObjectui64v(id, pname, ref @params);
		}
		public static void glGetQueryObjectuiv(UInt32 id, QueryObjectParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL4_4.glGetQueryObjectuiv(id, pname, ref @params);
		}
		public static void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetRenderbufferParameteriv(target, pname, ref @params);
		}
		public static void glGetSamplerParameterfv(UInt32 sampler, SamplerParameterName pname, ref Single[] @params)
		{
			i_OpenGL4_4.glGetSamplerParameterfv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameterIiv(UInt32 sampler, SamplerParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetSamplerParameterIiv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameterIuiv(UInt32 sampler, SamplerParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL4_4.glGetSamplerParameterIuiv(sampler, pname, ref @params);
		}
		public static void glGetSamplerParameteriv(UInt32 sampler, SamplerParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetSamplerParameteriv(sampler, pname, ref @params);
		}
		public static void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, ref Int32 length, ref string infoLog)
		{
			i_OpenGL4_4.glGetShaderInfoLog(shader, bufSize, ref length, ref infoLog);
		}
		public static void glGetShaderiv(UInt32 shader, ShaderParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetShaderiv(shader, pname, ref @params);
		}
		public static void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, ref Int32[] range, ref Int32 precision)
		{
			i_OpenGL4_4.glGetShaderPrecisionFormat(shadertype, precisiontype, ref range, ref precision);
		}
		public static void glGetShaderSource(UInt32 shader, Int32 bufSize, ref Int32 length, ref string source)
		{
			i_OpenGL4_4.glGetShaderSource(shader, bufSize, ref length, ref source);
		}
		public static Byte glGetString(StringName name)
		{
			return i_OpenGL4_4.glGetString(name);
		}
		public static Byte glGetStringi(StringName name, UInt32 index)
		{
			return i_OpenGL4_4.glGetStringi(name, index);
		}
		public static UInt32 glGetSubroutineIndex(UInt32 program, ShaderType shadertype, ref Char name)
		{
			return i_OpenGL4_4.glGetSubroutineIndex(program, shadertype, ref name);
		}
		public static Int32 glGetSubroutineUniformLocation(UInt32 program, ShaderType shadertype, ref Char name)
		{
			return i_OpenGL4_4.glGetSubroutineUniformLocation(program, shadertype, ref name);
		}
		public static void glGetSynciv(IntPtr sync, SyncParameterName pname, Int32 bufSize, ref Int32 length, ref Int32[] values)
		{
			i_OpenGL4_4.glGetSynciv(sync, pname, bufSize, ref length, ref values);
		}
		public static void glGetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_4.glGetTexImage(target, level, format, type, pixels);
		}
		public static void glGetTexLevelParameterfv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL4_4.glGetTexLevelParameterfv(target, level, pname, ref @params);
		}
		public static void glGetTexLevelParameteriv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetTexLevelParameteriv(target, level, pname, ref @params);
		}
		public static void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, ref Single[] @params)
		{
			i_OpenGL4_4.glGetTexParameterfv(target, pname, ref @params);
		}
		public static void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetTexParameterIiv(target, pname, ref @params);
		}
		public static void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, ref UInt32[] @params)
		{
			i_OpenGL4_4.glGetTexParameterIuiv(target, pname, ref @params);
		}
		public static void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetTexParameteriv(target, pname, ref @params);
		}
		public static void glGetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref GLenum type, ref string name)
		{
			i_OpenGL4_4.glGetTransformFeedbackVarying(program, index, bufSize, ref length, ref size, ref type, ref name);
		}
		public static UInt32 glGetUniformBlockIndex(UInt32 program, ref string uniformBlockName)
		{
			return i_OpenGL4_4.glGetUniformBlockIndex(program, ref uniformBlockName);
		}
		public static void glGetUniformdv(UInt32 program, Int32 location, ref Double[] @params)
		{
			i_OpenGL4_4.glGetUniformdv(program, location, ref @params);
		}
		public static void glGetUniformfv(UInt32 program, Int32 location, ref Single[] @params)
		{
			i_OpenGL4_4.glGetUniformfv(program, location, ref @params);
		}
		public static void glGetUniformIndices(UInt32 program, Int32 uniformCount, ref string uniformNames, ref UInt32[] uniformIndices)
		{
			i_OpenGL4_4.glGetUniformIndices(program, uniformCount, ref uniformNames, ref uniformIndices);
		}
		public static void glGetUniformiv(UInt32 program, Int32 location, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetUniformiv(program, location, ref @params);
		}
		public static Int32 glGetUniformLocation(UInt32 program, ref Char name)
		{
			return i_OpenGL4_4.glGetUniformLocation(program, ref name);
		}
		public static void glGetUniformSubroutineuiv(ShaderType shadertype, Int32 location, ref UInt32 @params)
		{
			i_OpenGL4_4.glGetUniformSubroutineuiv(shadertype, location, ref @params);
		}
		public static void glGetUniformuiv(UInt32 program, Int32 location, ref UInt32[] @params)
		{
			i_OpenGL4_4.glGetUniformuiv(program, location, ref @params);
		}
		public static void glGetVertexAttribdv(UInt32 index, GLenum pname, ref Double[] @params)
		{
			i_OpenGL4_4.glGetVertexAttribdv(index, pname, ref @params);
		}
		public static void glGetVertexAttribfv(UInt32 index, GLenum pname, ref Single[] @params)
		{
			i_OpenGL4_4.glGetVertexAttribfv(index, pname, ref @params);
		}
		public static void glGetVertexAttribIiv(UInt32 index, VertexAttribEnum pname, ref Int32 @params)
		{
			i_OpenGL4_4.glGetVertexAttribIiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribIuiv(UInt32 index, VertexAttribEnum pname, ref UInt32 @params)
		{
			i_OpenGL4_4.glGetVertexAttribIuiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribiv(UInt32 index, GLenum pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glGetVertexAttribiv(index, pname, ref @params);
		}
		public static void glGetVertexAttribLdv(UInt32 index, VertexAttribEnum pname, ref Double[] @params)
		{
			i_OpenGL4_4.glGetVertexAttribLdv(index, pname, ref @params);
		}
		public static void glGetVertexAttribPointerv(UInt32 index, GLenum pname, IntPtr pointer)
		{
			i_OpenGL4_4.glGetVertexAttribPointerv(index, pname, pointer);
		}
		public static void glHint(HintTarget target, HintMode mode)
		{
			i_OpenGL4_4.glHint(target, mode);
		}
		public static void glInvalidateBufferData(UInt32 buffer)
		{
			i_OpenGL4_4.glInvalidateBufferData(buffer);
		}
		public static void glInvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length)
		{
			i_OpenGL4_4.glInvalidateBufferSubData(buffer, offset, length);
		}
		public static void glInvalidateFramebuffer(FramebufferTarget target, Int32 numAttachments, ref GLenum[] attachments)
		{
			i_OpenGL4_4.glInvalidateFramebuffer(target, numAttachments, ref attachments);
		}
		public static void glInvalidateSubFramebuffer(GLenum target, Int32 numAttachments, ref FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glInvalidateSubFramebuffer(target, numAttachments, ref attachments, x, y, width, height);
		}
		public static void glInvalidateTexImage(UInt32 texture, Int32 level)
		{
			i_OpenGL4_4.glInvalidateTexImage(texture, level);
		}
		public static void glInvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth)
		{
			i_OpenGL4_4.glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}
		public static Boolean glIsBuffer(UInt32 buffer)
		{
			return i_OpenGL4_4.glIsBuffer(buffer);
		}
		public static Boolean glIsEnabled(EnableCap cap)
		{
			return i_OpenGL4_4.glIsEnabled(cap);
		}
		public static Boolean glIsEnabledi(EnableCap target, UInt32 index)
		{
			return i_OpenGL4_4.glIsEnabledi(target, index);
		}
		public static Boolean glIsFramebuffer(UInt32 framebuffer)
		{
			return i_OpenGL4_4.glIsFramebuffer(framebuffer);
		}
		public static Boolean glIsProgram(UInt32 program)
		{
			return i_OpenGL4_4.glIsProgram(program);
		}
		public static Boolean glIsProgramPipeline(UInt32 pipeline)
		{
			return i_OpenGL4_4.glIsProgramPipeline(pipeline);
		}
		public static Boolean glIsQuery(UInt32 id)
		{
			return i_OpenGL4_4.glIsQuery(id);
		}
		public static Boolean glIsRenderbuffer(UInt32 renderbuffer)
		{
			return i_OpenGL4_4.glIsRenderbuffer(renderbuffer);
		}
		public static Boolean glIsSampler(UInt32 sampler)
		{
			return i_OpenGL4_4.glIsSampler(sampler);
		}
		public static Boolean glIsShader(UInt32 shader)
		{
			return i_OpenGL4_4.glIsShader(shader);
		}
		public static Boolean glIsSync(IntPtr sync)
		{
			return i_OpenGL4_4.glIsSync(sync);
		}
		public static Boolean glIsTexture(UInt32 texture)
		{
			return i_OpenGL4_4.glIsTexture(texture);
		}
		public static Boolean glIsTransformFeedback(UInt32 id)
		{
			return i_OpenGL4_4.glIsTransformFeedback(id);
		}
		public static Boolean glIsVertexArray(UInt32 array)
		{
			return i_OpenGL4_4.glIsVertexArray(array);
		}
		public static void glLineWidth(Single width)
		{
			i_OpenGL4_4.glLineWidth(width);
		}
		public static void glLinkProgram(UInt32 program)
		{
			i_OpenGL4_4.glLinkProgram(program);
		}
		public static void glLogicOp(LogicOp opcode)
		{
			i_OpenGL4_4.glLogicOp(opcode);
		}
		public static IntPtr glMapBuffer(BufferTargetARB target, BufferAccessARB access)
		{
			return i_OpenGL4_4.glMapBuffer(target, access);
		}
		public static IntPtr glMapBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length, UInt32 access)
		{
			return i_OpenGL4_4.glMapBufferRange(target, offset, length, access);
		}
		public static void glMemoryBarrier(UInt32 barriers)
		{
			i_OpenGL4_4.glMemoryBarrier(barriers);
		}
		public static void glMinSampleShading(Single value)
		{
			i_OpenGL4_4.glMinSampleShading(value);
		}
		public static void glMultiDrawArrays(PrimitiveType mode, ref Int32[] first, ref Int32[] count, Int32 drawcount)
		{
			i_OpenGL4_4.glMultiDrawArrays(mode, ref first, ref count, drawcount);
		}
		public static void glMultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			i_OpenGL4_4.glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
		}
		public static void glMultiDrawElements(PrimitiveType mode, ref Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount)
		{
			i_OpenGL4_4.glMultiDrawElements(mode, ref count, type, indices, drawcount);
		}
		public static void glMultiDrawElementsBaseVertex(PrimitiveType mode, ref Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount, ref Int32[] basevertex)
		{
			i_OpenGL4_4.glMultiDrawElementsBaseVertex(mode, ref count, type, indices, drawcount, ref basevertex);
		}
		public static void glMultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride)
		{
			i_OpenGL4_4.glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
		}
		public static void glMultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glMultiTexCoordP1ui(texture, type, coords);
		}
		public static void glMultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glMultiTexCoordP1uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glMultiTexCoordP2ui(texture, type, coords);
		}
		public static void glMultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glMultiTexCoordP2uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glMultiTexCoordP3ui(texture, type, coords);
		}
		public static void glMultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glMultiTexCoordP3uiv(texture, type, ref coords);
		}
		public static void glMultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glMultiTexCoordP4ui(texture, type, coords);
		}
		public static void glMultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glMultiTexCoordP4uiv(texture, type, ref coords);
		}
		public static void glNormalP3ui(NormalPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glNormalP3ui(type, coords);
		}
		public static void glNormalP3uiv(NormalPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glNormalP3uiv(type, ref coords);
		}
		public static void glObjectLabel(ObjectIdentifier identifier, UInt32 name, Int32 length, ref string label)
		{
			i_OpenGL4_4.glObjectLabel(identifier, name, length, ref label);
		}
		public static void glObjectPtrLabel(IntPtr ptr, Int32 length, ref string label)
		{
			i_OpenGL4_4.glObjectPtrLabel(ptr, length, ref label);
		}
		public static void glPatchParameterfv(PatchParameterName pname, ref Single[] values)
		{
			i_OpenGL4_4.glPatchParameterfv(pname, ref values);
		}
		public static void glPatchParameteri(PatchParameterName pname, Int32 value)
		{
			i_OpenGL4_4.glPatchParameteri(pname, value);
		}
		public static void glPauseTransformFeedback()
		{
			i_OpenGL4_4.glPauseTransformFeedback();
		}
		public static void glPixelStoref(PixelStoreParameter pname, Single param)
		{
			i_OpenGL4_4.glPixelStoref(pname, param);
		}
		public static void glPixelStorei(PixelStoreParameter pname, Int32 param)
		{
			i_OpenGL4_4.glPixelStorei(pname, param);
		}
		public static void glPointParameterf(GLenum pname, Single param)
		{
			i_OpenGL4_4.glPointParameterf(pname, param);
		}
		public static void glPointParameterfv(GLenum pname, ref Single[] @params)
		{
			i_OpenGL4_4.glPointParameterfv(pname, ref @params);
		}
		public static void glPointParameteri(GLenum pname, Int32 param)
		{
			i_OpenGL4_4.glPointParameteri(pname, param);
		}
		public static void glPointParameteriv(GLenum pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glPointParameteriv(pname, ref @params);
		}
		public static void glPointSize(Single size)
		{
			i_OpenGL4_4.glPointSize(size);
		}
		public static void glPolygonMode(MaterialFace face, PolygonMode mode)
		{
			i_OpenGL4_4.glPolygonMode(face, mode);
		}
		public static void glPolygonOffset(Single factor, Single units)
		{
			i_OpenGL4_4.glPolygonOffset(factor, units);
		}
		public static void glPopDebugGroup()
		{
			i_OpenGL4_4.glPopDebugGroup();
		}
		public static void glPrimitiveRestartIndex(UInt32 index)
		{
			i_OpenGL4_4.glPrimitiveRestartIndex(index);
		}
		public static void glProgramBinary(UInt32 program, GLenum binaryFormat, IntPtr binary, Int32 length)
		{
			i_OpenGL4_4.glProgramBinary(program, binaryFormat, binary, length);
		}
		public static void glProgramParameteri(UInt32 program, ProgramParameterPName pname, Int32 value)
		{
			i_OpenGL4_4.glProgramParameteri(program, pname, value);
		}
		public static void glProgramUniform1d(UInt32 program, Int32 location, Double v0)
		{
			i_OpenGL4_4.glProgramUniform1d(program, location, v0);
		}
		public static void glProgramUniform1dv(UInt32 program, Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniform1dv(program, location, count, ref value);
		}
		public static void glProgramUniform1f(UInt32 program, Int32 location, Single v0)
		{
			i_OpenGL4_4.glProgramUniform1f(program, location, v0);
		}
		public static void glProgramUniform1fv(UInt32 program, Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniform1fv(program, location, count, ref value);
		}
		public static void glProgramUniform1i(UInt32 program, Int32 location, Int32 v0)
		{
			i_OpenGL4_4.glProgramUniform1i(program, location, v0);
		}
		public static void glProgramUniform1iv(UInt32 program, Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_4.glProgramUniform1iv(program, location, count, ref value);
		}
		public static void glProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0)
		{
			i_OpenGL4_4.glProgramUniform1ui(program, location, v0);
		}
		public static void glProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_4.glProgramUniform1uiv(program, location, count, ref value);
		}
		public static void glProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1)
		{
			i_OpenGL4_4.glProgramUniform2d(program, location, v0, v1);
		}
		public static void glProgramUniform2dv(UInt32 program, Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniform2dv(program, location, count, ref value);
		}
		public static void glProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1)
		{
			i_OpenGL4_4.glProgramUniform2f(program, location, v0, v1);
		}
		public static void glProgramUniform2fv(UInt32 program, Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniform2fv(program, location, count, ref value);
		}
		public static void glProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1)
		{
			i_OpenGL4_4.glProgramUniform2i(program, location, v0, v1);
		}
		public static void glProgramUniform2iv(UInt32 program, Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_4.glProgramUniform2iv(program, location, count, ref value);
		}
		public static void glProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1)
		{
			i_OpenGL4_4.glProgramUniform2ui(program, location, v0, v1);
		}
		public static void glProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_4.glProgramUniform2uiv(program, location, count, ref value);
		}
		public static void glProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2)
		{
			i_OpenGL4_4.glProgramUniform3d(program, location, v0, v1, v2);
		}
		public static void glProgramUniform3dv(UInt32 program, Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniform3dv(program, location, count, ref value);
		}
		public static void glProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2)
		{
			i_OpenGL4_4.glProgramUniform3f(program, location, v0, v1, v2);
		}
		public static void glProgramUniform3fv(UInt32 program, Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniform3fv(program, location, count, ref value);
		}
		public static void glProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			i_OpenGL4_4.glProgramUniform3i(program, location, v0, v1, v2);
		}
		public static void glProgramUniform3iv(UInt32 program, Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_4.glProgramUniform3iv(program, location, count, ref value);
		}
		public static void glProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			i_OpenGL4_4.glProgramUniform3ui(program, location, v0, v1, v2);
		}
		public static void glProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_4.glProgramUniform3uiv(program, location, count, ref value);
		}
		public static void glProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3)
		{
			i_OpenGL4_4.glProgramUniform4d(program, location, v0, v1, v2, v3);
		}
		public static void glProgramUniform4dv(UInt32 program, Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniform4dv(program, location, count, ref value);
		}
		public static void glProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3)
		{
			i_OpenGL4_4.glProgramUniform4f(program, location, v0, v1, v2, v3);
		}
		public static void glProgramUniform4fv(UInt32 program, Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniform4fv(program, location, count, ref value);
		}
		public static void glProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			i_OpenGL4_4.glProgramUniform4i(program, location, v0, v1, v2, v3);
		}
		public static void glProgramUniform4iv(UInt32 program, Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_4.glProgramUniform4iv(program, location, count, ref value);
		}
		public static void glProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			i_OpenGL4_4.glProgramUniform4ui(program, location, v0, v1, v2, v3);
		}
		public static void glProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_4.glProgramUniform4uiv(program, location, count, ref value);
		}
		public static void glProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix2dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix2fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix2x3dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix2x3fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix2x4dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix2x4fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix3dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix3fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix3x2dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix3x2fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix3x4dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix3x4fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix4dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix4fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix4x2dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix4x2fv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix4x3dv(program, location, count, transpose, ref value);
		}
		public static void glProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glProgramUniformMatrix4x3fv(program, location, count, transpose, ref value);
		}
		public static void glProvokingVertex(VertexProvokingMode mode)
		{
			i_OpenGL4_4.glProvokingVertex(mode);
		}
		public static void glPushDebugGroup(DebugSource source, UInt32 id, Int32 length, ref string message)
		{
			i_OpenGL4_4.glPushDebugGroup(source, id, length, ref message);
		}
		public static void glQueryCounter(UInt32 id, QueryTarget target)
		{
			i_OpenGL4_4.glQueryCounter(id, target);
		}
		public static void glReadBuffer(ReadBufferMode src)
		{
			i_OpenGL4_4.glReadBuffer(src);
		}
		public static void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_4.glReadPixels(x, y, width, height, format, type, pixels);
		}
		public static void glReleaseShaderCompiler()
		{
			i_OpenGL4_4.glReleaseShaderCompiler();
		}
		public static void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glRenderbufferStorage(target, internalformat, width, height);
		}
		public static void glRenderbufferStorageMultisample(RenderbufferTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		}
		public static void glResumeTransformFeedback()
		{
			i_OpenGL4_4.glResumeTransformFeedback();
		}
		public static void glSampleCoverage(Single value, Boolean invert)
		{
			i_OpenGL4_4.glSampleCoverage(value, invert);
		}
		public static void glSampleMaski(UInt32 maskNumber, UInt32 mask)
		{
			i_OpenGL4_4.glSampleMaski(maskNumber, mask);
		}
		public static void glSamplerParameterf(UInt32 sampler, SamplerParameterName pname, Single param)
		{
			i_OpenGL4_4.glSamplerParameterf(sampler, pname, param);
		}
		public static void glSamplerParameterfv(UInt32 sampler, SamplerParameterName pname, ref Single[] param)
		{
			i_OpenGL4_4.glSamplerParameterfv(sampler, pname, ref param);
		}
		public static void glSamplerParameteri(UInt32 sampler, SamplerParameterName pname, Int32 param)
		{
			i_OpenGL4_4.glSamplerParameteri(sampler, pname, param);
		}
		public static void glSamplerParameterIiv(UInt32 sampler, SamplerParameterName pname, ref Int32[] param)
		{
			i_OpenGL4_4.glSamplerParameterIiv(sampler, pname, ref param);
		}
		public static void glSamplerParameterIuiv(UInt32 sampler, SamplerParameterName pname, ref UInt32[] param)
		{
			i_OpenGL4_4.glSamplerParameterIuiv(sampler, pname, ref param);
		}
		public static void glSamplerParameteriv(UInt32 sampler, SamplerParameterName pname, ref Int32[] param)
		{
			i_OpenGL4_4.glSamplerParameteriv(sampler, pname, ref param);
		}
		public static void glScissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glScissor(x, y, width, height);
		}
		public static void glScissorArrayv(UInt32 first, Int32 count, ref Int32[] v)
		{
			i_OpenGL4_4.glScissorArrayv(first, count, ref v);
		}
		public static void glScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glScissorIndexed(index, left, bottom, width, height);
		}
		public static void glScissorIndexedv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_4.glScissorIndexedv(index, ref v);
		}
		public static void glSecondaryColorP3ui(ColorPointerType type, UInt32 color)
		{
			i_OpenGL4_4.glSecondaryColorP3ui(type, color);
		}
		public static void glSecondaryColorP3uiv(ColorPointerType type, ref UInt32 color)
		{
			i_OpenGL4_4.glSecondaryColorP3uiv(type, ref color);
		}
		public static void glShaderBinary(Int32 count, ref UInt32[] shaders, GLenum binaryformat, IntPtr binary, Int32 length)
		{
			i_OpenGL4_4.glShaderBinary(count, ref shaders, binaryformat, binary, length);
		}
		public static void glShaderSource(UInt32 shader, Int32 count, ref string @string, ref Int32[] length)
		{
			i_OpenGL4_4.glShaderSource(shader, count, ref @string, ref length);
		}
		public static void glShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding)
		{
			i_OpenGL4_4.glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
		}
		public static void glStencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL4_4.glStencilFunc(func, @ref, mask);
		}
		public static void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, Int32 @ref, UInt32 mask)
		{
			i_OpenGL4_4.glStencilFuncSeparate(face, func, @ref, mask);
		}
		public static void glStencilMask(UInt32 mask)
		{
			i_OpenGL4_4.glStencilMask(mask);
		}
		public static void glStencilMaskSeparate(StencilFaceDirection face, UInt32 mask)
		{
			i_OpenGL4_4.glStencilMaskSeparate(face, mask);
		}
		public static void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			i_OpenGL4_4.glStencilOp(fail, zfail, zpass);
		}
		public static void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			i_OpenGL4_4.glStencilOpSeparate(face, sfail, dpfail, dppass);
		}
		public static void glTexBuffer(TextureTarget target, InternalFormat internalformat, UInt32 buffer)
		{
			i_OpenGL4_4.glTexBuffer(target, internalformat, buffer);
		}
		public static void glTexBufferRange(TextureTarget target, InternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size)
		{
			i_OpenGL4_4.glTexBufferRange(target, internalformat, buffer, offset, size);
		}
		public static void glTexCoordP1ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glTexCoordP1ui(type, coords);
		}
		public static void glTexCoordP1uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glTexCoordP1uiv(type, ref coords);
		}
		public static void glTexCoordP2ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glTexCoordP2ui(type, coords);
		}
		public static void glTexCoordP2uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glTexCoordP2uiv(type, ref coords);
		}
		public static void glTexCoordP3ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glTexCoordP3ui(type, coords);
		}
		public static void glTexCoordP3uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glTexCoordP3uiv(type, ref coords);
		}
		public static void glTexCoordP4ui(TexCoordPointerType type, UInt32 coords)
		{
			i_OpenGL4_4.glTexCoordP4ui(type, coords);
		}
		public static void glTexCoordP4uiv(TexCoordPointerType type, ref UInt32 coords)
		{
			i_OpenGL4_4.glTexCoordP4uiv(type, ref coords);
		}
		public static void glTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_4.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}
		public static void glTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_4.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}
		public static void glTexImage2DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Boolean fixedsamplelocations)
		{
			i_OpenGL4_4.glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		public static void glTexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_4.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		public static void glTexImage3DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
		{
			i_OpenGL4_4.glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		public static void glTexParameterf(TextureTarget target, TextureParameterName pname, Single param)
		{
			i_OpenGL4_4.glTexParameterf(target, pname, param);
		}
		public static void glTexParameterfv(TextureTarget target, TextureParameterName pname, ref Single[] @params)
		{
			i_OpenGL4_4.glTexParameterfv(target, pname, ref @params);
		}
		public static void glTexParameteri(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			i_OpenGL4_4.glTexParameteri(target, pname, param);
		}
		public static void glTexParameterIiv(TextureTarget target, TextureParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glTexParameterIiv(target, pname, ref @params);
		}
		public static void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, ref UInt32[] @params)
		{
			i_OpenGL4_4.glTexParameterIuiv(target, pname, ref @params);
		}
		public static void glTexParameteriv(TextureTarget target, TextureParameterName pname, ref Int32[] @params)
		{
			i_OpenGL4_4.glTexParameteriv(target, pname, ref @params);
		}
		public static void glTexStorage1D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width)
		{
			i_OpenGL4_4.glTexStorage1D(target, levels, internalformat, width);
		}
		public static void glTexStorage2D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glTexStorage2D(target, levels, internalformat, width, height);
		}
		public static void glTexStorage2DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Boolean fixedsamplelocations)
		{
			i_OpenGL4_4.glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		public static void glTexStorage3D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth)
		{
			i_OpenGL4_4.glTexStorage3D(target, levels, internalformat, width, height, depth);
		}
		public static void glTexStorage3DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
		{
			i_OpenGL4_4.glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		public static void glTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_4.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}
		public static void glTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_4.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		public static void glTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			i_OpenGL4_4.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public static void glTextureView(UInt32 texture, TextureTarget target, UInt32 origtexture, InternalFormat internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
		{
			i_OpenGL4_4.glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}
		public static void glTransformFeedbackVaryings(UInt32 program, Int32 count, ref string varyings, GLenum bufferMode)
		{
			i_OpenGL4_4.glTransformFeedbackVaryings(program, count, ref varyings, bufferMode);
		}
		public static void glUniform1d(Int32 location, Double x)
		{
			i_OpenGL4_4.glUniform1d(location, x);
		}
		public static void glUniform1dv(Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_4.glUniform1dv(location, count, ref value);
		}
		public static void glUniform1f(Int32 location, Single v0)
		{
			i_OpenGL4_4.glUniform1f(location, v0);
		}
		public static void glUniform1fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_4.glUniform1fv(location, count, ref value);
		}
		public static void glUniform1i(Int32 location, Int32 v0)
		{
			i_OpenGL4_4.glUniform1i(location, v0);
		}
		public static void glUniform1iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_4.glUniform1iv(location, count, ref value);
		}
		public static void glUniform1ui(Int32 location, UInt32 v0)
		{
			i_OpenGL4_4.glUniform1ui(location, v0);
		}
		public static void glUniform1uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_4.glUniform1uiv(location, count, ref value);
		}
		public static void glUniform2d(Int32 location, Double x, Double y)
		{
			i_OpenGL4_4.glUniform2d(location, x, y);
		}
		public static void glUniform2dv(Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_4.glUniform2dv(location, count, ref value);
		}
		public static void glUniform2f(Int32 location, Single v0, Single v1)
		{
			i_OpenGL4_4.glUniform2f(location, v0, v1);
		}
		public static void glUniform2fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_4.glUniform2fv(location, count, ref value);
		}
		public static void glUniform2i(Int32 location, Int32 v0, Int32 v1)
		{
			i_OpenGL4_4.glUniform2i(location, v0, v1);
		}
		public static void glUniform2iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_4.glUniform2iv(location, count, ref value);
		}
		public static void glUniform2ui(Int32 location, UInt32 v0, UInt32 v1)
		{
			i_OpenGL4_4.glUniform2ui(location, v0, v1);
		}
		public static void glUniform2uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_4.glUniform2uiv(location, count, ref value);
		}
		public static void glUniform3d(Int32 location, Double x, Double y, Double z)
		{
			i_OpenGL4_4.glUniform3d(location, x, y, z);
		}
		public static void glUniform3dv(Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_4.glUniform3dv(location, count, ref value);
		}
		public static void glUniform3f(Int32 location, Single v0, Single v1, Single v2)
		{
			i_OpenGL4_4.glUniform3f(location, v0, v1, v2);
		}
		public static void glUniform3fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_4.glUniform3fv(location, count, ref value);
		}
		public static void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			i_OpenGL4_4.glUniform3i(location, v0, v1, v2);
		}
		public static void glUniform3iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_4.glUniform3iv(location, count, ref value);
		}
		public static void glUniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			i_OpenGL4_4.glUniform3ui(location, v0, v1, v2);
		}
		public static void glUniform3uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_4.glUniform3uiv(location, count, ref value);
		}
		public static void glUniform4d(Int32 location, Double x, Double y, Double z, Double w)
		{
			i_OpenGL4_4.glUniform4d(location, x, y, z, w);
		}
		public static void glUniform4dv(Int32 location, Int32 count, ref Double[] value)
		{
			i_OpenGL4_4.glUniform4dv(location, count, ref value);
		}
		public static void glUniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3)
		{
			i_OpenGL4_4.glUniform4f(location, v0, v1, v2, v3);
		}
		public static void glUniform4fv(Int32 location, Int32 count, ref Single[] value)
		{
			i_OpenGL4_4.glUniform4fv(location, count, ref value);
		}
		public static void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			i_OpenGL4_4.glUniform4i(location, v0, v1, v2, v3);
		}
		public static void glUniform4iv(Int32 location, Int32 count, ref Int32[] value)
		{
			i_OpenGL4_4.glUniform4iv(location, count, ref value);
		}
		public static void glUniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			i_OpenGL4_4.glUniform4ui(location, v0, v1, v2, v3);
		}
		public static void glUniform4uiv(Int32 location, Int32 count, ref UInt32[] value)
		{
			i_OpenGL4_4.glUniform4uiv(location, count, ref value);
		}
		public static void glUniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding)
		{
			i_OpenGL4_4.glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}
		public static void glUniformMatrix2dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix2dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x3dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix2x3dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix2x3fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x4dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix2x4dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix2x4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix3dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix3fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x2dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix3x2dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix3x2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x4dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix3x4dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix3x4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix4dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix4fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x2dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix4x2dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix4x2fv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x3dv(Int32 location, Int32 count, Boolean transpose, ref Double[] value)
		{
			i_OpenGL4_4.glUniformMatrix4x3dv(location, count, transpose, ref value);
		}
		public static void glUniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, ref Single[] value)
		{
			i_OpenGL4_4.glUniformMatrix4x3fv(location, count, transpose, ref value);
		}
		public static void glUniformSubroutinesuiv(ShaderType shadertype, Int32 count, ref UInt32[] indices)
		{
			i_OpenGL4_4.glUniformSubroutinesuiv(shadertype, count, ref indices);
		}
		public static Boolean glUnmapBuffer(BufferTargetARB target)
		{
			return i_OpenGL4_4.glUnmapBuffer(target);
		}
		public static void glUseProgram(UInt32 program)
		{
			i_OpenGL4_4.glUseProgram(program);
		}
		public static void glUseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program)
		{
			i_OpenGL4_4.glUseProgramStages(pipeline, stages, program);
		}
		public static void glValidateProgram(UInt32 program)
		{
			i_OpenGL4_4.glValidateProgram(program);
		}
		public static void glValidateProgramPipeline(UInt32 pipeline)
		{
			i_OpenGL4_4.glValidateProgramPipeline(pipeline);
		}
		public static void glVertexAttrib1d(UInt32 index, Double x)
		{
			i_OpenGL4_4.glVertexAttrib1d(index, x);
		}
		public static void glVertexAttrib1dv(UInt32 index, ref Double v)
		{
			i_OpenGL4_4.glVertexAttrib1dv(index, ref v);
		}
		public static void glVertexAttrib1f(UInt32 index, Single x)
		{
			i_OpenGL4_4.glVertexAttrib1f(index, x);
		}
		public static void glVertexAttrib1fv(UInt32 index, ref Single v)
		{
			i_OpenGL4_4.glVertexAttrib1fv(index, ref v);
		}
		public static void glVertexAttrib1s(UInt32 index, Int16 x)
		{
			i_OpenGL4_4.glVertexAttrib1s(index, x);
		}
		public static void glVertexAttrib1sv(UInt32 index, ref Int16 v)
		{
			i_OpenGL4_4.glVertexAttrib1sv(index, ref v);
		}
		public static void glVertexAttrib2d(UInt32 index, Double x, Double y)
		{
			i_OpenGL4_4.glVertexAttrib2d(index, x, y);
		}
		public static void glVertexAttrib2dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_4.glVertexAttrib2dv(index, ref v);
		}
		public static void glVertexAttrib2f(UInt32 index, Single x, Single y)
		{
			i_OpenGL4_4.glVertexAttrib2f(index, x, y);
		}
		public static void glVertexAttrib2fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL4_4.glVertexAttrib2fv(index, ref v);
		}
		public static void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y)
		{
			i_OpenGL4_4.glVertexAttrib2s(index, x, y);
		}
		public static void glVertexAttrib2sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_4.glVertexAttrib2sv(index, ref v);
		}
		public static void glVertexAttrib3d(UInt32 index, Double x, Double y, Double z)
		{
			i_OpenGL4_4.glVertexAttrib3d(index, x, y, z);
		}
		public static void glVertexAttrib3dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_4.glVertexAttrib3dv(index, ref v);
		}
		public static void glVertexAttrib3f(UInt32 index, Single x, Single y, Single z)
		{
			i_OpenGL4_4.glVertexAttrib3f(index, x, y, z);
		}
		public static void glVertexAttrib3fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL4_4.glVertexAttrib3fv(index, ref v);
		}
		public static void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z)
		{
			i_OpenGL4_4.glVertexAttrib3s(index, x, y, z);
		}
		public static void glVertexAttrib3sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_4.glVertexAttrib3sv(index, ref v);
		}
		public static void glVertexAttrib4bv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL4_4.glVertexAttrib4bv(index, ref v);
		}
		public static void glVertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w)
		{
			i_OpenGL4_4.glVertexAttrib4d(index, x, y, z, w);
		}
		public static void glVertexAttrib4dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_4.glVertexAttrib4dv(index, ref v);
		}
		public static void glVertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w)
		{
			i_OpenGL4_4.glVertexAttrib4f(index, x, y, z, w);
		}
		public static void glVertexAttrib4fv(UInt32 index, ref Single[] v)
		{
			i_OpenGL4_4.glVertexAttrib4fv(index, ref v);
		}
		public static void glVertexAttrib4iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_4.glVertexAttrib4iv(index, ref v);
		}
		public static void glVertexAttrib4Nbv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL4_4.glVertexAttrib4Nbv(index, ref v);
		}
		public static void glVertexAttrib4Niv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_4.glVertexAttrib4Niv(index, ref v);
		}
		public static void glVertexAttrib4Nsv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_4.glVertexAttrib4Nsv(index, ref v);
		}
		public static void glVertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w)
		{
			i_OpenGL4_4.glVertexAttrib4Nub(index, x, y, z, w);
		}
		public static void glVertexAttrib4Nubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL4_4.glVertexAttrib4Nubv(index, ref v);
		}
		public static void glVertexAttrib4Nuiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_4.glVertexAttrib4Nuiv(index, ref v);
		}
		public static void glVertexAttrib4Nusv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL4_4.glVertexAttrib4Nusv(index, ref v);
		}
		public static void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			i_OpenGL4_4.glVertexAttrib4s(index, x, y, z, w);
		}
		public static void glVertexAttrib4sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_4.glVertexAttrib4sv(index, ref v);
		}
		public static void glVertexAttrib4ubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL4_4.glVertexAttrib4ubv(index, ref v);
		}
		public static void glVertexAttrib4uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_4.glVertexAttrib4uiv(index, ref v);
		}
		public static void glVertexAttrib4usv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL4_4.glVertexAttrib4usv(index, ref v);
		}
		public static void glVertexAttribBinding(UInt32 attribindex, UInt32 bindingindex)
		{
			i_OpenGL4_4.glVertexAttribBinding(attribindex, bindingindex);
		}
		public static void glVertexAttribDivisor(UInt32 index, UInt32 divisor)
		{
			i_OpenGL4_4.glVertexAttribDivisor(index, divisor);
		}
		public static void glVertexAttribFormat(UInt32 attribindex, Int32 size, GLenum type, Boolean normalized, UInt32 relativeoffset)
		{
			i_OpenGL4_4.glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		}
		public static void glVertexAttribI1i(UInt32 index, Int32 x)
		{
			i_OpenGL4_4.glVertexAttribI1i(index, x);
		}
		public static void glVertexAttribI1iv(UInt32 index, ref Int32 v)
		{
			i_OpenGL4_4.glVertexAttribI1iv(index, ref v);
		}
		public static void glVertexAttribI1ui(UInt32 index, UInt32 x)
		{
			i_OpenGL4_4.glVertexAttribI1ui(index, x);
		}
		public static void glVertexAttribI1uiv(UInt32 index, ref UInt32 v)
		{
			i_OpenGL4_4.glVertexAttribI1uiv(index, ref v);
		}
		public static void glVertexAttribI2i(UInt32 index, Int32 x, Int32 y)
		{
			i_OpenGL4_4.glVertexAttribI2i(index, x, y);
		}
		public static void glVertexAttribI2iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_4.glVertexAttribI2iv(index, ref v);
		}
		public static void glVertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y)
		{
			i_OpenGL4_4.glVertexAttribI2ui(index, x, y);
		}
		public static void glVertexAttribI2uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_4.glVertexAttribI2uiv(index, ref v);
		}
		public static void glVertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z)
		{
			i_OpenGL4_4.glVertexAttribI3i(index, x, y, z);
		}
		public static void glVertexAttribI3iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_4.glVertexAttribI3iv(index, ref v);
		}
		public static void glVertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z)
		{
			i_OpenGL4_4.glVertexAttribI3ui(index, x, y, z);
		}
		public static void glVertexAttribI3uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_4.glVertexAttribI3uiv(index, ref v);
		}
		public static void glVertexAttribI4bv(UInt32 index, ref SByte[] v)
		{
			i_OpenGL4_4.glVertexAttribI4bv(index, ref v);
		}
		public static void glVertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			i_OpenGL4_4.glVertexAttribI4i(index, x, y, z, w);
		}
		public static void glVertexAttribI4iv(UInt32 index, ref Int32[] v)
		{
			i_OpenGL4_4.glVertexAttribI4iv(index, ref v);
		}
		public static void glVertexAttribI4sv(UInt32 index, ref Int16[] v)
		{
			i_OpenGL4_4.glVertexAttribI4sv(index, ref v);
		}
		public static void glVertexAttribI4ubv(UInt32 index, ref Byte[] v)
		{
			i_OpenGL4_4.glVertexAttribI4ubv(index, ref v);
		}
		public static void glVertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			i_OpenGL4_4.glVertexAttribI4ui(index, x, y, z, w);
		}
		public static void glVertexAttribI4uiv(UInt32 index, ref UInt32[] v)
		{
			i_OpenGL4_4.glVertexAttribI4uiv(index, ref v);
		}
		public static void glVertexAttribI4usv(UInt32 index, ref UInt16[] v)
		{
			i_OpenGL4_4.glVertexAttribI4usv(index, ref v);
		}
		public static void glVertexAttribIFormat(UInt32 attribindex, Int32 size, GLenum type, UInt32 relativeoffset)
		{
			i_OpenGL4_4.glVertexAttribIFormat(attribindex, size, type, relativeoffset);
		}
		public static void glVertexAttribIPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL4_4.glVertexAttribIPointer(index, size, type, stride, pointer);
		}
		public static void glVertexAttribL1d(UInt32 index, Double x)
		{
			i_OpenGL4_4.glVertexAttribL1d(index, x);
		}
		public static void glVertexAttribL1dv(UInt32 index, ref Double v)
		{
			i_OpenGL4_4.glVertexAttribL1dv(index, ref v);
		}
		public static void glVertexAttribL2d(UInt32 index, Double x, Double y)
		{
			i_OpenGL4_4.glVertexAttribL2d(index, x, y);
		}
		public static void glVertexAttribL2dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_4.glVertexAttribL2dv(index, ref v);
		}
		public static void glVertexAttribL3d(UInt32 index, Double x, Double y, Double z)
		{
			i_OpenGL4_4.glVertexAttribL3d(index, x, y, z);
		}
		public static void glVertexAttribL3dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_4.glVertexAttribL3dv(index, ref v);
		}
		public static void glVertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w)
		{
			i_OpenGL4_4.glVertexAttribL4d(index, x, y, z, w);
		}
		public static void glVertexAttribL4dv(UInt32 index, ref Double[] v)
		{
			i_OpenGL4_4.glVertexAttribL4dv(index, ref v);
		}
		public static void glVertexAttribLFormat(UInt32 attribindex, Int32 size, VertexAttribType type, UInt32 relativeoffset)
		{
			i_OpenGL4_4.glVertexAttribLFormat(attribindex, size, type, relativeoffset);
		}
		public static void glVertexAttribLPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
		{
			i_OpenGL4_4.glVertexAttribLPointer(index, size, type, stride, pointer);
		}
		public static void glVertexAttribP1ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL4_4.glVertexAttribP1ui(index, type, normalized, value);
		}
		public static void glVertexAttribP1uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL4_4.glVertexAttribP1uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP2ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL4_4.glVertexAttribP2ui(index, type, normalized, value);
		}
		public static void glVertexAttribP2uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL4_4.glVertexAttribP2uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP3ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL4_4.glVertexAttribP3ui(index, type, normalized, value);
		}
		public static void glVertexAttribP3uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL4_4.glVertexAttribP3uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribP4ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value)
		{
			i_OpenGL4_4.glVertexAttribP4ui(index, type, normalized, value);
		}
		public static void glVertexAttribP4uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value)
		{
			i_OpenGL4_4.glVertexAttribP4uiv(index, type, normalized, ref value);
		}
		public static void glVertexAttribPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer)
		{
			i_OpenGL4_4.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}
		public static void glVertexBindingDivisor(UInt32 bindingindex, UInt32 divisor)
		{
			i_OpenGL4_4.glVertexBindingDivisor(bindingindex, divisor);
		}
		public static void glVertexP2ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL4_4.glVertexP2ui(type, value);
		}
		public static void glVertexP2uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL4_4.glVertexP2uiv(type, ref value);
		}
		public static void glVertexP3ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL4_4.glVertexP3ui(type, value);
		}
		public static void glVertexP3uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL4_4.glVertexP3uiv(type, ref value);
		}
		public static void glVertexP4ui(VertexPointerType type, UInt32 value)
		{
			i_OpenGL4_4.glVertexP4ui(type, value);
		}
		public static void glVertexP4uiv(VertexPointerType type, ref UInt32 value)
		{
			i_OpenGL4_4.glVertexP4uiv(type, ref value);
		}
		public static void glViewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			i_OpenGL4_4.glViewport(x, y, width, height);
		}
		public static void glViewportArrayv(UInt32 first, Int32 count, ref Single[] v)
		{
			i_OpenGL4_4.glViewportArrayv(first, count, ref v);
		}
		public static void glViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h)
		{
			i_OpenGL4_4.glViewportIndexedf(index, x, y, w, h);
		}
		public static void glViewportIndexedfv(UInt32 index, ref Single[] v)
		{
			i_OpenGL4_4.glViewportIndexedfv(index, ref v);
		}
		public static void glWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
		{
			i_OpenGL4_4.glWaitSync(sync, flags, timeout);
		}
	}
}

