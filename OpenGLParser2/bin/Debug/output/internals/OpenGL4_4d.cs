// OpenGL 4.4 delegate Commands.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;

namespace fgtk.OpenGL
{
	internal static class d_OpenGL4_4
	{
		internal delegate void glActiveShaderProgram(UInt32 pipeline, UInt32 program);

		internal delegate void glActiveTexture(TextureUnit texture);

		internal delegate void glAttachShader(UInt32 program, UInt32 shader);

		internal delegate void glBeginConditionalRender(UInt32 id, TypeEnum mode);

		internal delegate void glBeginQuery(QueryTarget target, UInt32 id);

		internal delegate void glBeginQueryIndexed(QueryTarget target, UInt32 index, UInt32 id);

		internal delegate void glBeginTransformFeedback(PrimitiveType primitiveMode);

		internal delegate void glBindAttribLocation(UInt32 program, UInt32 index, ref Char name);

		internal delegate void glBindBuffer(BufferTargetARB target, UInt32 buffer);

		internal delegate void glBindBufferBase(BufferTargetARB target, UInt32 index, UInt32 buffer);

		internal delegate void glBindBufferRange(BufferTargetARB target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);

		internal delegate void glBindBuffersBase(BufferTargetARB target, UInt32 first, Int32 count, ref UInt32 [] buffers);

		internal delegate void glBindBuffersRange(BufferTargetARB target, UInt32 first, Int32 count, ref UInt32 [] buffers, IntPtr offsets, IntPtr sizes);

		internal delegate void glBindFragDataLocation(UInt32 program, UInt32 color, ref string  name);

		internal delegate void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, ref Char name);

		internal delegate void glBindFramebuffer(FramebufferTarget target, UInt32 framebuffer);

		internal delegate void glBindImageTexture(UInt32 unit, UInt32 texture, Int32 level, Boolean layered, Int32 layer, BufferAccessARB access, InternalFormat format);

		internal delegate void glBindImageTextures(UInt32 first, Int32 count, ref UInt32 [] textures);

		internal delegate void glBindProgramPipeline(UInt32 pipeline);

		internal delegate void glBindRenderbuffer(RenderbufferTarget target, UInt32 renderbuffer);

		internal delegate void glBindSampler(UInt32 unit, UInt32 sampler);

		internal delegate void glBindSamplers(UInt32 first, Int32 count, ref UInt32 [] samplers);

		internal delegate void glBindTexture(TextureTarget target, UInt32 texture);

		internal delegate void glBindTextures(UInt32 first, Int32 count, ref UInt32 [] textures);

		internal delegate void glBindTransformFeedback(BindTransformFeedbackTarget target, UInt32 id);

		internal delegate void glBindVertexArray(UInt32 array);

		internal delegate void glBindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

		internal delegate void glBindVertexBuffers(UInt32 first, Int32 count, ref UInt32 [] buffers, IntPtr offsets, ref Int32 [] strides);

		internal delegate void glBlendColor(Single red, Single green, Single blue, Single alpha);

		internal delegate void glBlendEquation(BlendEquationModeEXT mode);

		internal delegate void glBlendEquationi(UInt32 buf, BlendEquationModeEXT mode);

		internal delegate void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);

		internal delegate void glBlendEquationSeparatei(UInt32 buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);

		internal delegate void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor);

		internal delegate void glBlendFunci(UInt32 buf, BlendingFactor src, BlendingFactor dst);

		internal delegate void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha);

		internal delegate void glBlendFuncSeparatei(UInt32 buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);

		internal delegate void glBlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, BlitFramebufferFilter filter);

		internal delegate void glBufferData(BufferTargetARB target, IntPtr size, IntPtr data, BufferUsageARB usage);

		internal delegate void glBufferStorage(BufferStorageTarget target, IntPtr size, IntPtr data, UInt32 flags);

		internal delegate void glBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data);

		internal delegate FramebufferStatus glCheckFramebufferStatus(FramebufferTarget target);

		internal delegate void glClampColor(GLenum target, GLenum clamp);

		internal delegate void glClear(UInt32 mask);

		internal delegate void glClearBufferData(BufferStorageTarget target, InternalFormat internalformat, PixelFormat format, PixelType type, IntPtr data);

		internal delegate void glClearBufferfi(Buffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);

		internal delegate void glClearBufferfv(Buffer buffer, Int32 drawbuffer, ref Single [] value);

		internal delegate void glClearBufferiv(Buffer buffer, Int32 drawbuffer, ref Int32 [] value);

		internal delegate void glClearBufferSubData(GLenum target, InternalFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, PixelType type, IntPtr data);

		internal delegate void glClearBufferuiv(Buffer buffer, Int32 drawbuffer, ref UInt32 [] value);

		internal delegate void glClearColor(Single red, Single green, Single blue, Single alpha);

		internal delegate void glClearDepth(Double depth);

		internal delegate void glClearDepthf(Single d);

		internal delegate void glClearStencil(Int32 s);

		internal delegate void glClearTexImage(UInt32 texture, Int32 level, PixelFormat format, PixelType type, IntPtr data);

		internal delegate void glClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr data);

		internal delegate SyncStatus glClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);

		internal delegate void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha);

		internal delegate void glColorMaski(UInt32 index, Boolean r, Boolean g, Boolean b, Boolean a);

		internal delegate void glColorP3ui(ColorPointerType type, UInt32 color);

		internal delegate void glColorP3uiv(ColorPointerType type, ref UInt32 color);

		internal delegate void glColorP4ui(ColorPointerType type, UInt32 color);

		internal delegate void glColorP4uiv(ColorPointerType type, ref UInt32 color);

		internal delegate void glCompileShader(UInt32 shader);

		internal delegate void glCompressedTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);

		internal delegate void glCompressedTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

		internal delegate void glCompressedTexImage3D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);

		internal delegate void glCompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data);

		internal delegate void glCompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data);

		internal delegate void glCompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data);

		internal delegate void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);

		internal delegate void glCopyImageSubData(UInt32 srcName, CopyBufferSubDataTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, CopyBufferSubDataTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

		internal delegate void glCopyTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

		internal delegate void glCopyTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

		internal delegate void glCopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

		internal delegate void glCopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

		internal delegate void glCopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

		internal delegate UInt32 glCreateProgram();

		internal delegate UInt32 glCreateShader(ShaderType type);

		internal delegate UInt32 glCreateShaderProgramv(ShaderType type, Int32 count, ref string  strings);

		internal delegate void glCullFace(CullFaceMode mode);

		internal delegate void glDebugMessageCallback(Delegates.GLDEBUGPROC callback, IntPtr userParam);

		internal delegate void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, Int32 count, ref UInt32 [] ids, Boolean enabled);

		internal delegate void glDebugMessageInsert(DebugSource source, DebugType type, UInt32 id, DebugSeverity severity, Int32 length, ref string  buf);

		internal delegate void glDeleteBuffers(Int32 n, ref UInt32 [] buffers);

		internal delegate void glDeleteFramebuffers(Int32 n, ref UInt32 [] framebuffers);

		internal delegate void glDeleteProgram(UInt32 program);

		internal delegate void glDeleteProgramPipelines(Int32 n, ref UInt32 [] pipelines);

		internal delegate void glDeleteQueries(Int32 n, ref UInt32 [] ids);

		internal delegate void glDeleteRenderbuffers(Int32 n, ref UInt32 [] renderbuffers);

		internal delegate void glDeleteSamplers(Int32 count, ref UInt32 [] samplers);

		internal delegate void glDeleteShader(UInt32 shader);

		internal delegate void glDeleteSync(IntPtr sync);

		internal delegate void glDeleteTextures(Int32 n, ref UInt32 [] textures);

		internal delegate void glDeleteTransformFeedbacks(Int32 n, ref UInt32 [] ids);

		internal delegate void glDeleteVertexArrays(Int32 n, ref UInt32 [] arrays);

		internal delegate void glDepthFunc(DepthFunction func);

		internal delegate void glDepthMask(Boolean flag);

		internal delegate void glDepthRange(Double n, Double f);

		internal delegate void glDepthRangeArrayv(UInt32 first, Int32 count, ref Double [] v);

		internal delegate void glDepthRangef(Single n, Single f);

		internal delegate void glDepthRangeIndexed(UInt32 index, Double n, Double f);

		internal delegate void glDetachShader(UInt32 program, UInt32 shader);

		internal delegate void glDisable(EnableCap cap);

		internal delegate void glDisablei(EnableCap target, UInt32 index);

		internal delegate void glDisableVertexAttribArray(UInt32 index);

		internal delegate void glDispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);

		internal delegate void glDispatchComputeIndirect(IntPtr indirect);

		internal delegate void glDrawArrays(PrimitiveType mode, Int32 first, Int32 count);

		internal delegate void glDrawArraysIndirect(PrimitiveType mode, IntPtr indirect);

		internal delegate void glDrawArraysInstanced(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount);

		internal delegate void glDrawArraysInstancedBaseInstance(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);

		internal delegate void glDrawBuffer(DrawBufferMode buf);

		internal delegate void glDrawBuffers(Int32 n, ref GLenum [] bufs);

		internal delegate void glDrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices);

		internal delegate void glDrawElementsBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex);

		internal delegate void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect);

		internal delegate void glDrawElementsInstanced(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount);

		internal delegate void glDrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, PrimitiveType type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);

		internal delegate void glDrawElementsInstancedBaseVertex(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex);

		internal delegate void glDrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, PrimitiveType type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);

		internal delegate void glDrawRangeElements(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices);

		internal delegate void glDrawRangeElementsBaseVertex(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex);

		internal delegate void glDrawTransformFeedback(PrimitiveType mode, UInt32 id);

		internal delegate void glDrawTransformFeedbackInstanced(PrimitiveType mode, UInt32 id, Int32 instancecount);

		internal delegate void glDrawTransformFeedbackStream(PrimitiveType mode, UInt32 id, UInt32 stream);

		internal delegate void glDrawTransformFeedbackStreamInstanced(PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount);

		internal delegate void glEnable(EnableCap cap);

		internal delegate void glEnablei(EnableCap target, UInt32 index);

		internal delegate void glEnableVertexAttribArray(UInt32 index);

		internal delegate void glEndConditionalRender();

		internal delegate void glEndQuery(QueryTarget target);

		internal delegate void glEndQueryIndexed(QueryTarget target, UInt32 index);

		internal delegate void glEndTransformFeedback();

		internal delegate IntPtr glFenceSync(SyncCondition condition, UInt32 flags);

		internal delegate void glFinish();

		internal delegate void glFlush();

		internal delegate void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length);

		internal delegate void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, Int32 param);

		internal delegate void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);

		internal delegate void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level);

		internal delegate void glFramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level);

		internal delegate void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level);

		internal delegate void glFramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);

		internal delegate void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);

		internal delegate void glFrontFace(FrontFaceDirection mode);

		internal delegate void glGenBuffers(Int32 n, ref UInt32 [] buffers);

		internal delegate void glGenerateMipmap(TextureTarget target);

		internal delegate void glGenFramebuffers(Int32 n, ref UInt32 [] framebuffers);

		internal delegate void glGenProgramPipelines(Int32 n, ref UInt32 [] pipelines);

		internal delegate void glGenQueries(Int32 n, ref UInt32 [] ids);

		internal delegate void glGenRenderbuffers(Int32 n, ref UInt32 [] renderbuffers);

		internal delegate void glGenSamplers(Int32 count, ref UInt32 [] samplers);

		internal delegate void glGenTextures(Int32 n, ref UInt32 [] textures);

		internal delegate void glGenTransformFeedbacks(Int32 n, ref UInt32 [] ids);

		internal delegate void glGenVertexArrays(Int32 n, ref UInt32 [] arrays);

		internal delegate void glGetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, AtomicCounterBufferPName pname, ref Int32 [] @params);

		internal delegate void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string  name);

		internal delegate void glGetActiveSubroutineName(UInt32 program, ShaderType shadertype, UInt32 index, Int32 bufsize, ref Int32 length, ref string  name);

		internal delegate void glGetActiveSubroutineUniformiv(UInt32 program, ShaderType shadertype, UInt32 index, SubroutineParameterName pname, ref Int32 [] values);

		internal delegate void glGetActiveSubroutineUniformName(UInt32 program, ShaderType shadertype, UInt32 index, Int32 bufsize, ref Int32 length, ref string  name);

		internal delegate void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref AttributeType type, ref string  name);

		internal delegate void glGetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, UniformBlockPName pname, ref Int32 [] @params);

		internal delegate void glGetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, ref Int32 length, ref string  uniformBlockName);

		internal delegate void glGetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, ref Int32 length, ref string  uniformName);

		internal delegate void glGetActiveUniformsiv(UInt32 program, Int32 uniformCount, ref UInt32 [] uniformIndices, UniformPName pname, ref Int32 [] @params);

		internal delegate void glGetAttachedShaders(UInt32 program, Int32 maxCount, ref Int32 count, ref UInt32 [] shaders);

		internal delegate Int32 glGetAttribLocation(UInt32 program, ref Char name);

		internal delegate void glGetBooleani_v(BufferTargetARB target, UInt32 index, ref Boolean [] data);

		internal delegate void glGetBooleanv(GetPName pname, ref Boolean [] data);

		internal delegate void glGetBufferParameteri64v(BufferTargetARB target, GLenum pname, ref Int64 [] @params);

		internal delegate void glGetBufferParameteriv(BufferTargetARB target, GLenum pname, ref Int32 [] @params);

		internal delegate void glGetBufferPointerv(BufferTargetARB target, GLenum pname, IntPtr @params);

		internal delegate void glGetBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data);

		internal delegate void glGetCompressedTexImage(TextureTarget target, Int32 level, IntPtr img);

		internal delegate UInt32 glGetDebugMessageLog(UInt32 count, Int32 bufSize, ref DebugSource [] sources, ref DebugType [] types, ref UInt32 [] ids, ref DebugSeverity [] severities, ref Int32 [] lengths, ref string  messageLog);

		internal delegate void glGetDoublei_v(TypeEnum target, UInt32 index, ref Double [] data);

		internal delegate void glGetDoublev(GetPName pname, ref Double [] data);

		internal delegate ErrorCode glGetError();

		internal delegate void glGetFloati_v(TypeEnum target, UInt32 index, ref Single [] data);

		internal delegate void glGetFloatv(GetPName pname, ref Single [] data);

		internal delegate Int32 glGetFragDataIndex(UInt32 program, ref Char name);

		internal delegate Int32 glGetFragDataLocation(UInt32 program, ref string  name);

		internal delegate void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, ref Int32 [] @params);

		internal delegate void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, ref Int32 [] @params);

		internal delegate void glGetInteger64i_v(TypeEnum target, UInt32 index, ref Int64 [] data);

		internal delegate void glGetInteger64v(GetPName pname, ref Int64 [] data);

		internal delegate void glGetIntegeri_v(TypeEnum target, UInt32 index, ref Int32 [] data);

		internal delegate void glGetIntegerv(GetPName pname, ref Int32 [] data);

		internal delegate void glGetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Int32 bufSize, ref Int64 [] @params);

		internal delegate void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, Int32 bufSize, ref Int32 [] @params);

		internal delegate void glGetMultisamplefv(GLenum pname, UInt32 index, ref Single [] val);

		internal delegate void glGetObjectLabel(GLenum identifier, UInt32 name, Int32 bufSize, ref Int32 length, ref string  label);

		internal delegate void glGetObjectPtrLabel(IntPtr ptr, Int32 bufSize, ref Int32 length, ref string  label);

		internal delegate void glGetPointerv(GetPointervPName pname, IntPtr @params);

		internal delegate void glGetProgramBinary(UInt32 program, Int32 bufSize, ref Int32 length, ref GLenum binaryFormat, IntPtr binary);

		internal delegate void glGetProgramInfoLog(UInt32 program, Int32 bufSize, ref Int32 length, ref string  infoLog);

		internal delegate void glGetProgramInterfaceiv(UInt32 program, ProgramInterface programInterface, ProgramInterfacePName pname, ref Int32 [] @params);

		internal delegate void glGetProgramiv(UInt32 program, ProgramPropertyARB pname, ref Int32 [] @params);

		internal delegate void glGetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, ref Int32 length, ref string  infoLog);

		internal delegate void glGetProgramPipelineiv(UInt32 pipeline, PipelineParameterName pname, ref Int32 [] @params);

		internal delegate UInt32 glGetProgramResourceIndex(UInt32 program, ProgramInterface programInterface, ref string  name);

		internal delegate void glGetProgramResourceiv(UInt32 program, ProgramInterface programInterface, UInt32 index, Int32 propCount, ref GLenum [] props, Int32 bufSize, ref Int32 length, ref Int32 [] @params);

		internal delegate Int32 glGetProgramResourceLocation(UInt32 program, ProgramInterface programInterface, ref string  name);

		internal delegate Int32 glGetProgramResourceLocationIndex(UInt32 program, ProgramInterface programInterface, ref string  name);

		internal delegate void glGetProgramResourceName(UInt32 program, ProgramInterface programInterface, UInt32 index, Int32 bufSize, ref Int32 length, ref string  name);

		internal delegate void glGetProgramStageiv(UInt32 program, ShaderType shadertype, ProgramStagePName pname, ref Int32 values);

		internal delegate void glGetQueryIndexediv(GLenum target, UInt32 index, QueryParameterName pname, ref Int32 [] @params);

		internal delegate void glGetQueryiv(QueryTarget target, QueryParameterName pname, ref Int32 [] @params);

		internal delegate void glGetQueryObjecti64v(UInt32 id, QueryObjectParameterName pname, ref Int64 [] @params);

		internal delegate void glGetQueryObjectiv(UInt32 id, QueryObjectParameterName pname, ref Int32 [] @params);

		internal delegate void glGetQueryObjectui64v(UInt32 id, QueryObjectParameterName pname, ref UInt64 [] @params);

		internal delegate void glGetQueryObjectuiv(UInt32 id, QueryObjectParameterName pname, ref UInt32 [] @params);

		internal delegate void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, ref Int32 [] @params);

		internal delegate void glGetSamplerParameterfv(UInt32 sampler, SamplerParameterName pname, ref Single [] @params);

		internal delegate void glGetSamplerParameterIiv(UInt32 sampler, SamplerParameterName pname, ref Int32 [] @params);

		internal delegate void glGetSamplerParameterIuiv(UInt32 sampler, SamplerParameterName pname, ref UInt32 [] @params);

		internal delegate void glGetSamplerParameteriv(UInt32 sampler, SamplerParameterName pname, ref Int32 [] @params);

		internal delegate void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, ref Int32 length, ref string  infoLog);

		internal delegate void glGetShaderiv(UInt32 shader, ShaderParameterName pname, ref Int32 [] @params);

		internal delegate void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, ref Int32 [] range, ref Int32 precision);

		internal delegate void glGetShaderSource(UInt32 shader, Int32 bufSize, ref Int32 length, ref string  source);

		internal delegate Byte glGetString(StringName name);

		internal delegate Byte glGetStringi(StringName name, UInt32 index);

		internal delegate UInt32 glGetSubroutineIndex(UInt32 program, ShaderType shadertype, ref Char name);

		internal delegate Int32 glGetSubroutineUniformLocation(UInt32 program, ShaderType shadertype, ref Char name);

		internal delegate void glGetSynciv(IntPtr sync, SyncParameterName pname, Int32 bufSize, ref Int32 length, ref Int32 [] values);

		internal delegate void glGetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glGetTexLevelParameterfv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Single [] @params);

		internal delegate void glGetTexLevelParameteriv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Int32 [] @params);

		internal delegate void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, ref Single [] @params);

		internal delegate void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, ref Int32 [] @params);

		internal delegate void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, ref UInt32 [] @params);

		internal delegate void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, ref Int32 [] @params);

		internal delegate void glGetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref GLenum type, ref string  name);

		internal delegate UInt32 glGetUniformBlockIndex(UInt32 program, ref string  uniformBlockName);

		internal delegate void glGetUniformdv(UInt32 program, Int32 location, ref Double [] @params);

		internal delegate void glGetUniformfv(UInt32 program, Int32 location, ref Single [] @params);

		internal delegate void glGetUniformIndices(UInt32 program, Int32 uniformCount, ref string  uniformNames, ref UInt32 [] uniformIndices);

		internal delegate void glGetUniformiv(UInt32 program, Int32 location, ref Int32 [] @params);

		internal delegate Int32 glGetUniformLocation(UInt32 program, ref Char name);

		internal delegate void glGetUniformSubroutineuiv(ShaderType shadertype, Int32 location, ref UInt32 @params);

		internal delegate void glGetUniformuiv(UInt32 program, Int32 location, ref UInt32 [] @params);

		internal delegate void glGetVertexAttribdv(UInt32 index, GLenum pname, ref Double [] @params);

		internal delegate void glGetVertexAttribfv(UInt32 index, GLenum pname, ref Single [] @params);

		internal delegate void glGetVertexAttribIiv(UInt32 index, VertexAttribEnum pname, ref Int32 @params);

		internal delegate void glGetVertexAttribIuiv(UInt32 index, VertexAttribEnum pname, ref UInt32 @params);

		internal delegate void glGetVertexAttribiv(UInt32 index, GLenum pname, ref Int32 [] @params);

		internal delegate void glGetVertexAttribLdv(UInt32 index, VertexAttribEnum pname, ref Double [] @params);

		internal delegate void glGetVertexAttribPointerv(UInt32 index, GLenum pname, IntPtr pointer);

		internal delegate void glHint(HintTarget target, HintMode mode);

		internal delegate void glInvalidateBufferData(UInt32 buffer);

		internal delegate void glInvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);

		internal delegate void glInvalidateFramebuffer(FramebufferTarget target, Int32 numAttachments, ref GLenum [] attachments);

		internal delegate void glInvalidateSubFramebuffer(GLenum target, Int32 numAttachments, ref FramebufferAttachment [] attachments, Int32 x, Int32 y, Int32 width, Int32 height);

		internal delegate void glInvalidateTexImage(UInt32 texture, Int32 level);

		internal delegate void glInvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);

		internal delegate Boolean glIsBuffer(UInt32 buffer);

		internal delegate Boolean glIsEnabled(EnableCap cap);

		internal delegate Boolean glIsEnabledi(EnableCap target, UInt32 index);

		internal delegate Boolean glIsFramebuffer(UInt32 framebuffer);

		internal delegate Boolean glIsProgram(UInt32 program);

		internal delegate Boolean glIsProgramPipeline(UInt32 pipeline);

		internal delegate Boolean glIsQuery(UInt32 id);

		internal delegate Boolean glIsRenderbuffer(UInt32 renderbuffer);

		internal delegate Boolean glIsSampler(UInt32 sampler);

		internal delegate Boolean glIsShader(UInt32 shader);

		internal delegate Boolean glIsSync(IntPtr sync);

		internal delegate Boolean glIsTexture(UInt32 texture);

		internal delegate Boolean glIsTransformFeedback(UInt32 id);

		internal delegate Boolean glIsVertexArray(UInt32 array);

		internal delegate void glLineWidth(Single width);

		internal delegate void glLinkProgram(UInt32 program);

		internal delegate void glLogicOp(LogicOp opcode);

		internal delegate IntPtr glMapBuffer(BufferTargetARB target, BufferAccessARB access);

		internal delegate IntPtr glMapBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length, UInt32 access);

		internal delegate void glMemoryBarrier(UInt32 barriers);

		internal delegate void glMinSampleShading(Single value);

		internal delegate void glMultiDrawArrays(PrimitiveType mode, ref Int32 [] first, ref Int32 [] count, Int32 drawcount);

		internal delegate void glMultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, Int32 drawcount, Int32 stride);

		internal delegate void glMultiDrawElements(PrimitiveType mode, ref Int32 [] count, DrawElementsType type, IntPtr indices, Int32 drawcount);

		internal delegate void glMultiDrawElementsBaseVertex(PrimitiveType mode, ref Int32 [] count, DrawElementsType type, IntPtr indices, Int32 drawcount, ref Int32 [] basevertex);

		internal delegate void glMultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride);

		internal delegate void glMultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords);

		internal delegate void glMultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords);

		internal delegate void glMultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords);

		internal delegate void glMultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords);

		internal delegate void glMultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords);

		internal delegate void glMultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords);

		internal delegate void glMultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, UInt32 coords);

		internal delegate void glMultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, ref UInt32 coords);

		internal delegate void glNormalP3ui(NormalPointerType type, UInt32 coords);

		internal delegate void glNormalP3uiv(NormalPointerType type, ref UInt32 coords);

		internal delegate void glObjectLabel(ObjectIdentifier identifier, UInt32 name, Int32 length, ref string  label);

		internal delegate void glObjectPtrLabel(IntPtr ptr, Int32 length, ref string  label);

		internal delegate void glPatchParameterfv(PatchParameterName pname, ref Single [] values);

		internal delegate void glPatchParameteri(PatchParameterName pname, Int32 value);

		internal delegate void glPauseTransformFeedback();

		internal delegate void glPixelStoref(PixelStoreParameter pname, Single param);

		internal delegate void glPixelStorei(PixelStoreParameter pname, Int32 param);

		internal delegate void glPointParameterf(GLenum pname, Single param);

		internal delegate void glPointParameterfv(GLenum pname, ref Single [] @params);

		internal delegate void glPointParameteri(GLenum pname, Int32 param);

		internal delegate void glPointParameteriv(GLenum pname, ref Int32 [] @params);

		internal delegate void glPointSize(Single size);

		internal delegate void glPolygonMode(MaterialFace face, PolygonMode mode);

		internal delegate void glPolygonOffset(Single factor, Single units);

		internal delegate void glPopDebugGroup();

		internal delegate void glPrimitiveRestartIndex(UInt32 index);

		internal delegate void glProgramBinary(UInt32 program, GLenum binaryFormat, IntPtr binary, Int32 length);

		internal delegate void glProgramParameteri(UInt32 program, ProgramParameterPName pname, Int32 value);

		internal delegate void glProgramUniform1d(UInt32 program, Int32 location, Double v0);

		internal delegate void glProgramUniform1dv(UInt32 program, Int32 location, Int32 count, ref Double [] value);

		internal delegate void glProgramUniform1f(UInt32 program, Int32 location, Single v0);

		internal delegate void glProgramUniform1fv(UInt32 program, Int32 location, Int32 count, ref Single [] value);

		internal delegate void glProgramUniform1i(UInt32 program, Int32 location, Int32 v0);

		internal delegate void glProgramUniform1iv(UInt32 program, Int32 location, Int32 count, ref Int32 [] value);

		internal delegate void glProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);

		internal delegate void glProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, ref UInt32 [] value);

		internal delegate void glProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1);

		internal delegate void glProgramUniform2dv(UInt32 program, Int32 location, Int32 count, ref Double [] value);

		internal delegate void glProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);

		internal delegate void glProgramUniform2fv(UInt32 program, Int32 location, Int32 count, ref Single [] value);

		internal delegate void glProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);

		internal delegate void glProgramUniform2iv(UInt32 program, Int32 location, Int32 count, ref Int32 [] value);

		internal delegate void glProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);

		internal delegate void glProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, ref UInt32 [] value);

		internal delegate void glProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2);

		internal delegate void glProgramUniform3dv(UInt32 program, Int32 location, Int32 count, ref Double [] value);

		internal delegate void glProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);

		internal delegate void glProgramUniform3fv(UInt32 program, Int32 location, Int32 count, ref Single [] value);

		internal delegate void glProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);

		internal delegate void glProgramUniform3iv(UInt32 program, Int32 location, Int32 count, ref Int32 [] value);

		internal delegate void glProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

		internal delegate void glProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, ref UInt32 [] value);

		internal delegate void glProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3);

		internal delegate void glProgramUniform4dv(UInt32 program, Int32 location, Int32 count, ref Double [] value);

		internal delegate void glProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);

		internal delegate void glProgramUniform4fv(UInt32 program, Int32 location, Int32 count, ref Single [] value);

		internal delegate void glProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

		internal delegate void glProgramUniform4iv(UInt32 program, Int32 location, Int32 count, ref Int32 [] value);

		internal delegate void glProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

		internal delegate void glProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, ref UInt32 [] value);

		internal delegate void glProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glProvokingVertex(VertexProvokingMode mode);

		internal delegate void glPushDebugGroup(DebugSource source, UInt32 id, Int32 length, ref string  message);

		internal delegate void glQueryCounter(UInt32 id, QueryTarget target);

		internal delegate void glReadBuffer(ReadBufferMode src);

		internal delegate void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glReleaseShaderCompiler();

		internal delegate void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, Int32 width, Int32 height);

		internal delegate void glRenderbufferStorageMultisample(RenderbufferTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height);

		internal delegate void glResumeTransformFeedback();

		internal delegate void glSampleCoverage(Single value, Boolean invert);

		internal delegate void glSampleMaski(UInt32 maskNumber, UInt32 mask);

		internal delegate void glSamplerParameterf(UInt32 sampler, SamplerParameterName pname, Single param);

		internal delegate void glSamplerParameterfv(UInt32 sampler, SamplerParameterName pname, ref Single [] param);

		internal delegate void glSamplerParameteri(UInt32 sampler, SamplerParameterName pname, Int32 param);

		internal delegate void glSamplerParameterIiv(UInt32 sampler, SamplerParameterName pname, ref Int32 [] param);

		internal delegate void glSamplerParameterIuiv(UInt32 sampler, SamplerParameterName pname, ref UInt32 [] param);

		internal delegate void glSamplerParameteriv(UInt32 sampler, SamplerParameterName pname, ref Int32 [] param);

		internal delegate void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);

		internal delegate void glScissorArrayv(UInt32 first, Int32 count, ref Int32 [] v);

		internal delegate void glScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);

		internal delegate void glScissorIndexedv(UInt32 index, ref Int32 [] v);

		internal delegate void glSecondaryColorP3ui(ColorPointerType type, UInt32 color);

		internal delegate void glSecondaryColorP3uiv(ColorPointerType type, ref UInt32 color);

		internal delegate void glShaderBinary(Int32 count, ref UInt32 [] shaders, GLenum binaryformat, IntPtr binary, Int32 length);

		internal delegate void glShaderSource(UInt32 shader, Int32 count, ref string  @string, ref Int32 [] length);

		internal delegate void glShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);

		internal delegate void glStencilFunc(StencilFunction func, Int32 @ref, UInt32 mask);

		internal delegate void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, Int32 @ref, UInt32 mask);

		internal delegate void glStencilMask(UInt32 mask);

		internal delegate void glStencilMaskSeparate(StencilFaceDirection face, UInt32 mask);

		internal delegate void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass);

		internal delegate void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);

		internal delegate void glTexBuffer(TextureTarget target, InternalFormat internalformat, UInt32 buffer);

		internal delegate void glTexBufferRange(TextureTarget target, InternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size);

		internal delegate void glTexCoordP1ui(TexCoordPointerType type, UInt32 coords);

		internal delegate void glTexCoordP1uiv(TexCoordPointerType type, ref UInt32 coords);

		internal delegate void glTexCoordP2ui(TexCoordPointerType type, UInt32 coords);

		internal delegate void glTexCoordP2uiv(TexCoordPointerType type, ref UInt32 coords);

		internal delegate void glTexCoordP3ui(TexCoordPointerType type, UInt32 coords);

		internal delegate void glTexCoordP3uiv(TexCoordPointerType type, ref UInt32 coords);

		internal delegate void glTexCoordP4ui(TexCoordPointerType type, UInt32 coords);

		internal delegate void glTexCoordP4uiv(TexCoordPointerType type, ref UInt32 coords);

		internal delegate void glTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTexImage2DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Boolean fixedsamplelocations);

		internal delegate void glTexImage3D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTexImage3DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);

		internal delegate void glTexParameterf(TextureTarget target, TextureParameterName pname, Single param);

		internal delegate void glTexParameterfv(TextureTarget target, TextureParameterName pname, ref Single [] @params);

		internal delegate void glTexParameteri(TextureTarget target, TextureParameterName pname, Int32 param);

		internal delegate void glTexParameterIiv(TextureTarget target, TextureParameterName pname, ref Int32 [] @params);

		internal delegate void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, ref UInt32 [] @params);

		internal delegate void glTexParameteriv(TextureTarget target, TextureParameterName pname, ref Int32 [] @params);

		internal delegate void glTexStorage1D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width);

		internal delegate void glTexStorage2D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height);

		internal delegate void glTexStorage2DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Boolean fixedsamplelocations);

		internal delegate void glTexStorage3D(TextureTarget target, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth);

		internal delegate void glTexStorage3DMultisample(TextureTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);

		internal delegate void glTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTextureView(UInt32 texture, TextureTarget target, UInt32 origtexture, InternalFormat internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);

		internal delegate void glTransformFeedbackVaryings(UInt32 program, Int32 count, ref string  varyings, GLenum bufferMode);

		internal delegate void glUniform1d(Int32 location, Double x);

		internal delegate void glUniform1dv(Int32 location, Int32 count, ref Double [] value);

		internal delegate void glUniform1f(Int32 location, Single v0);

		internal delegate void glUniform1fv(Int32 location, Int32 count, ref Single [] value);

		internal delegate void glUniform1i(Int32 location, Int32 v0);

		internal delegate void glUniform1iv(Int32 location, Int32 count, ref Int32 [] value);

		internal delegate void glUniform1ui(Int32 location, UInt32 v0);

		internal delegate void glUniform1uiv(Int32 location, Int32 count, ref UInt32 [] value);

		internal delegate void glUniform2d(Int32 location, Double x, Double y);

		internal delegate void glUniform2dv(Int32 location, Int32 count, ref Double [] value);

		internal delegate void glUniform2f(Int32 location, Single v0, Single v1);

		internal delegate void glUniform2fv(Int32 location, Int32 count, ref Single [] value);

		internal delegate void glUniform2i(Int32 location, Int32 v0, Int32 v1);

		internal delegate void glUniform2iv(Int32 location, Int32 count, ref Int32 [] value);

		internal delegate void glUniform2ui(Int32 location, UInt32 v0, UInt32 v1);

		internal delegate void glUniform2uiv(Int32 location, Int32 count, ref UInt32 [] value);

		internal delegate void glUniform3d(Int32 location, Double x, Double y, Double z);

		internal delegate void glUniform3dv(Int32 location, Int32 count, ref Double [] value);

		internal delegate void glUniform3f(Int32 location, Single v0, Single v1, Single v2);

		internal delegate void glUniform3fv(Int32 location, Int32 count, ref Single [] value);

		internal delegate void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);

		internal delegate void glUniform3iv(Int32 location, Int32 count, ref Int32 [] value);

		internal delegate void glUniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);

		internal delegate void glUniform3uiv(Int32 location, Int32 count, ref UInt32 [] value);

		internal delegate void glUniform4d(Int32 location, Double x, Double y, Double z, Double w);

		internal delegate void glUniform4dv(Int32 location, Int32 count, ref Double [] value);

		internal delegate void glUniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);

		internal delegate void glUniform4fv(Int32 location, Int32 count, ref Single [] value);

		internal delegate void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

		internal delegate void glUniform4iv(Int32 location, Int32 count, ref Int32 [] value);

		internal delegate void glUniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);

		internal delegate void glUniform4uiv(Int32 location, Int32 count, ref UInt32 [] value);

		internal delegate void glUniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);

		internal delegate void glUniformMatrix2dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformMatrix2x3dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformMatrix2x4dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformMatrix3dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformMatrix3x2dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformMatrix3x4dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformMatrix4dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformMatrix4x2dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformMatrix4x3dv(Int32 location, Int32 count, Boolean transpose, ref Double [] value);

		internal delegate void glUniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, ref Single [] value);

		internal delegate void glUniformSubroutinesuiv(ShaderType shadertype, Int32 count, ref UInt32 [] indices);

		internal delegate Boolean glUnmapBuffer(BufferTargetARB target);

		internal delegate void glUseProgram(UInt32 program);

		internal delegate void glUseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);

		internal delegate void glValidateProgram(UInt32 program);

		internal delegate void glValidateProgramPipeline(UInt32 pipeline);

		internal delegate void glVertexAttrib1d(UInt32 index, Double x);

		internal delegate void glVertexAttrib1dv(UInt32 index, ref Double v);

		internal delegate void glVertexAttrib1f(UInt32 index, Single x);

		internal delegate void glVertexAttrib1fv(UInt32 index, ref Single v);

		internal delegate void glVertexAttrib1s(UInt32 index, Int16 x);

		internal delegate void glVertexAttrib1sv(UInt32 index, ref Int16 v);

		internal delegate void glVertexAttrib2d(UInt32 index, Double x, Double y);

		internal delegate void glVertexAttrib2dv(UInt32 index, ref Double [] v);

		internal delegate void glVertexAttrib2f(UInt32 index, Single x, Single y);

		internal delegate void glVertexAttrib2fv(UInt32 index, ref Single [] v);

		internal delegate void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y);

		internal delegate void glVertexAttrib2sv(UInt32 index, ref Int16 [] v);

		internal delegate void glVertexAttrib3d(UInt32 index, Double x, Double y, Double z);

		internal delegate void glVertexAttrib3dv(UInt32 index, ref Double [] v);

		internal delegate void glVertexAttrib3f(UInt32 index, Single x, Single y, Single z);

		internal delegate void glVertexAttrib3fv(UInt32 index, ref Single [] v);

		internal delegate void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);

		internal delegate void glVertexAttrib3sv(UInt32 index, ref Int16 [] v);

		internal delegate void glVertexAttrib4bv(UInt32 index, ref SByte [] v);

		internal delegate void glVertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);

		internal delegate void glVertexAttrib4dv(UInt32 index, ref Double [] v);

		internal delegate void glVertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);

		internal delegate void glVertexAttrib4fv(UInt32 index, ref Single [] v);

		internal delegate void glVertexAttrib4iv(UInt32 index, ref Int32 [] v);

		internal delegate void glVertexAttrib4Nbv(UInt32 index, ref SByte [] v);

		internal delegate void glVertexAttrib4Niv(UInt32 index, ref Int32 [] v);

		internal delegate void glVertexAttrib4Nsv(UInt32 index, ref Int16 [] v);

		internal delegate void glVertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);

		internal delegate void glVertexAttrib4Nubv(UInt32 index, ref Byte [] v);

		internal delegate void glVertexAttrib4Nuiv(UInt32 index, ref UInt32 [] v);

		internal delegate void glVertexAttrib4Nusv(UInt32 index, ref UInt16 [] v);

		internal delegate void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);

		internal delegate void glVertexAttrib4sv(UInt32 index, ref Int16 [] v);

		internal delegate void glVertexAttrib4ubv(UInt32 index, ref Byte [] v);

		internal delegate void glVertexAttrib4uiv(UInt32 index, ref UInt32 [] v);

		internal delegate void glVertexAttrib4usv(UInt32 index, ref UInt16 [] v);

		internal delegate void glVertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);

		internal delegate void glVertexAttribDivisor(UInt32 index, UInt32 divisor);

		internal delegate void glVertexAttribFormat(UInt32 attribindex, Int32 size, GLenum type, Boolean normalized, UInt32 relativeoffset);

		internal delegate void glVertexAttribI1i(UInt32 index, Int32 x);

		internal delegate void glVertexAttribI1iv(UInt32 index, ref Int32 v);

		internal delegate void glVertexAttribI1ui(UInt32 index, UInt32 x);

		internal delegate void glVertexAttribI1uiv(UInt32 index, ref UInt32 v);

		internal delegate void glVertexAttribI2i(UInt32 index, Int32 x, Int32 y);

		internal delegate void glVertexAttribI2iv(UInt32 index, ref Int32 [] v);

		internal delegate void glVertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);

		internal delegate void glVertexAttribI2uiv(UInt32 index, ref UInt32 [] v);

		internal delegate void glVertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);

		internal delegate void glVertexAttribI3iv(UInt32 index, ref Int32 [] v);

		internal delegate void glVertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);

		internal delegate void glVertexAttribI3uiv(UInt32 index, ref UInt32 [] v);

		internal delegate void glVertexAttribI4bv(UInt32 index, ref SByte [] v);

		internal delegate void glVertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

		internal delegate void glVertexAttribI4iv(UInt32 index, ref Int32 [] v);

		internal delegate void glVertexAttribI4sv(UInt32 index, ref Int16 [] v);

		internal delegate void glVertexAttribI4ubv(UInt32 index, ref Byte [] v);

		internal delegate void glVertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

		internal delegate void glVertexAttribI4uiv(UInt32 index, ref UInt32 [] v);

		internal delegate void glVertexAttribI4usv(UInt32 index, ref UInt16 [] v);

		internal delegate void glVertexAttribIFormat(UInt32 attribindex, Int32 size, GLenum type, UInt32 relativeoffset);

		internal delegate void glVertexAttribIPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer);

		internal delegate void glVertexAttribL1d(UInt32 index, Double x);

		internal delegate void glVertexAttribL1dv(UInt32 index, ref Double v);

		internal delegate void glVertexAttribL2d(UInt32 index, Double x, Double y);

		internal delegate void glVertexAttribL2dv(UInt32 index, ref Double [] v);

		internal delegate void glVertexAttribL3d(UInt32 index, Double x, Double y, Double z);

		internal delegate void glVertexAttribL3dv(UInt32 index, ref Double [] v);

		internal delegate void glVertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w);

		internal delegate void glVertexAttribL4dv(UInt32 index, ref Double [] v);

		internal delegate void glVertexAttribLFormat(UInt32 attribindex, Int32 size, VertexAttribType type, UInt32 relativeoffset);

		internal delegate void glVertexAttribLPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer);

		internal delegate void glVertexAttribP1ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value);

		internal delegate void glVertexAttribP1uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value);

		internal delegate void glVertexAttribP2ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value);

		internal delegate void glVertexAttribP2uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value);

		internal delegate void glVertexAttribP3ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value);

		internal delegate void glVertexAttribP3uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value);

		internal delegate void glVertexAttribP4ui(UInt32 index, VertexAttribPointerType type, Boolean normalized, UInt32 value);

		internal delegate void glVertexAttribP4uiv(UInt32 index, VertexAttribPointerType type, Boolean normalized, ref UInt32 value);

		internal delegate void glVertexAttribPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer);

		internal delegate void glVertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);

		internal delegate void glVertexP2ui(VertexPointerType type, UInt32 value);

		internal delegate void glVertexP2uiv(VertexPointerType type, ref UInt32 value);

		internal delegate void glVertexP3ui(VertexPointerType type, UInt32 value);

		internal delegate void glVertexP3uiv(VertexPointerType type, ref UInt32 value);

		internal delegate void glVertexP4ui(VertexPointerType type, UInt32 value);

		internal delegate void glVertexP4uiv(VertexPointerType type, ref UInt32 value);

		internal delegate void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);

		internal delegate void glViewportArrayv(UInt32 first, Int32 count, ref Single [] v);

		internal delegate void glViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);

		internal delegate void glViewportIndexedfv(UInt32 index, ref Single [] v);

		internal delegate void glWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);

	}
}

