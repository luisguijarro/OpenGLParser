// OpenGL 1.1 delegate Commands.
// File Created with OpenGL Parser 2.
// OpenGL Parser 2, Developed by
// BROTHERHOOD OF THE BLACK SWORD.

using System;

namespace fgtk.OpenGL
{
	internal static class d_OpenGL1_1
	{
		internal delegate void glAccum(AccumOp op, Single value);

		internal delegate void glAlphaFunc(AlphaFunction func, Single @ref);

		internal delegate Boolean glAreTexturesResident(Int32 n, ref UInt32 [] textures, ref Boolean [] residences);

		internal delegate void glArrayElement(Int32 i);

		internal delegate void glBegin(PrimitiveType mode);

		internal delegate void glBindTexture(TextureTarget target, UInt32 texture);

		internal delegate void glBitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, ref Byte [] bitmap);

		internal delegate void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor);

		internal delegate void glCallList(UInt32 list);

		internal delegate void glCallLists(Int32 n, ListNameType type, IntPtr lists);

		internal delegate void glClear(UInt32 mask);

		internal delegate void glClearAccum(Single red, Single green, Single blue, Single alpha);

		internal delegate void glClearColor(Single red, Single green, Single blue, Single alpha);

		internal delegate void glClearDepth(Double depth);

		internal delegate void glClearIndex(Single c);

		internal delegate void glClearStencil(Int32 s);

		internal delegate void glClipPlane(ClipPlaneName plane, ref Double [] equation);

		internal delegate void glColor3b(SByte red, SByte green, SByte blue);

		internal delegate void glColor3bv(ref SByte [] v);

		internal delegate void glColor3d(Double red, Double green, Double blue);

		internal delegate void glColor3dv(ref Double [] v);

		internal delegate void glColor3f(Single red, Single green, Single blue);

		internal delegate void glColor3fv(ref Single [] v);

		internal delegate void glColor3i(Int32 red, Int32 green, Int32 blue);

		internal delegate void glColor3iv(ref Int32 [] v);

		internal delegate void glColor3s(Int16 red, Int16 green, Int16 blue);

		internal delegate void glColor3sv(ref Int16 [] v);

		internal delegate void glColor3ub(Byte red, Byte green, Byte blue);

		internal delegate void glColor3ubv(ref Byte [] v);

		internal delegate void glColor3ui(UInt32 red, UInt32 green, UInt32 blue);

		internal delegate void glColor3uiv(ref UInt32 [] v);

		internal delegate void glColor3us(UInt16 red, UInt16 green, UInt16 blue);

		internal delegate void glColor3usv(ref UInt16 [] v);

		internal delegate void glColor4b(SByte red, SByte green, SByte blue, SByte alpha);

		internal delegate void glColor4bv(ref SByte [] v);

		internal delegate void glColor4d(Double red, Double green, Double blue, Double alpha);

		internal delegate void glColor4dv(ref Double [] v);

		internal delegate void glColor4f(Single red, Single green, Single blue, Single alpha);

		internal delegate void glColor4fv(ref Single [] v);

		internal delegate void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);

		internal delegate void glColor4iv(ref Int32 [] v);

		internal delegate void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);

		internal delegate void glColor4sv(ref Int16 [] v);

		internal delegate void glColor4ub(Byte red, Byte green, Byte blue, Byte alpha);

		internal delegate void glColor4ubv(ref Byte [] v);

		internal delegate void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

		internal delegate void glColor4uiv(ref UInt32 [] v);

		internal delegate void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

		internal delegate void glColor4usv(ref UInt16 [] v);

		internal delegate void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha);

		internal delegate void glColorMaterial(MaterialFace face, ColorMaterialParameter mode);

		internal delegate void glColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer);

		internal delegate void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelCopyType type);

		internal delegate void glCopyTexImage1D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

		internal delegate void glCopyTexImage2D(TextureTarget target, Int32 level, InternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

		internal delegate void glCopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

		internal delegate void glCopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

		internal delegate void glCullFace(CullFaceMode mode);

		internal delegate void glDeleteLists(UInt32 list, Int32 range);

		internal delegate void glDeleteTextures(Int32 n, ref UInt32 [] textures);

		internal delegate void glDepthFunc(DepthFunction func);

		internal delegate void glDepthMask(Boolean flag);

		internal delegate void glDepthRange(Double n, Double f);

		internal delegate void glDisable(EnableCap cap);

		internal delegate void glDisableClientState(EnableCap array);

		internal delegate void glDrawArrays(PrimitiveType mode, Int32 first, Int32 count);

		internal delegate void glDrawBuffer(DrawBufferMode buf);

		internal delegate void glDrawElements(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices);

		internal delegate void glDrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glEdgeFlag(Boolean flag);

		internal delegate void glEdgeFlagPointer(Int32 stride, IntPtr pointer);

		internal delegate void glEdgeFlagv(ref Boolean flag);

		internal delegate void glEnable(EnableCap cap);

		internal delegate void glEnableClientState(EnableCap array);

		internal delegate void glEnd();

		internal delegate void glEndList();

		internal delegate void glEvalCoord1d(Double u);

		internal delegate void glEvalCoord1dv(ref Double u);

		internal delegate void glEvalCoord1f(Single u);

		internal delegate void glEvalCoord1fv(ref Single u);

		internal delegate void glEvalCoord2d(Double u, Double v);

		internal delegate void glEvalCoord2dv(ref Double [] u);

		internal delegate void glEvalCoord2f(Single u, Single v);

		internal delegate void glEvalCoord2fv(ref Single [] u);

		internal delegate void glEvalMesh1(MeshMode1 mode, Int32 i1, Int32 i2);

		internal delegate void glEvalMesh2(MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);

		internal delegate void glEvalPoint1(Int32 i);

		internal delegate void glEvalPoint2(Int32 i, Int32 j);

		internal delegate void glFeedbackBuffer(Int32 size, FeedbackType type, ref Single [] buffer);

		internal delegate void glFinish();

		internal delegate void glFlush();

		internal delegate void glFogf(FogParameter pname, Single param);

		internal delegate void glFogfv(FogParameter pname, ref Single [] @params);

		internal delegate void glFogi(FogParameter pname, Int32 param);

		internal delegate void glFogiv(FogParameter pname, ref Int32 [] @params);

		internal delegate void glFrontFace(FrontFaceDirection mode);

		internal delegate void glFrustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);

		internal delegate UInt32 glGenLists(Int32 range);

		internal delegate void glGenTextures(Int32 n, ref UInt32 [] textures);

		internal delegate void glGetBooleanv(GetPName pname, ref Boolean [] data);

		internal delegate void glGetClipPlane(ClipPlaneName plane, ref Double [] equation);

		internal delegate void glGetDoublev(GetPName pname, ref Double [] data);

		internal delegate ErrorCode glGetError();

		internal delegate void glGetFloatv(GetPName pname, ref Single [] data);

		internal delegate void glGetIntegerv(GetPName pname, ref Int32 [] data);

		internal delegate void glGetLightfv(LightName light, LightParameter pname, ref Single [] @params);

		internal delegate void glGetLightiv(LightName light, LightParameter pname, ref Int32 [] @params);

		internal delegate void glGetMapdv(MapTarget target, GetMapQuery query, ref Double [] v);

		internal delegate void glGetMapfv(MapTarget target, GetMapQuery query, ref Single [] v);

		internal delegate void glGetMapiv(MapTarget target, GetMapQuery query, ref Int32 [] v);

		internal delegate void glGetMaterialfv(MaterialFace face, MaterialParameter pname, ref Single [] @params);

		internal delegate void glGetMaterialiv(MaterialFace face, MaterialParameter pname, ref Int32 [] @params);

		internal delegate void glGetPixelMapfv(PixelMap map, ref Single [] values);

		internal delegate void glGetPixelMapuiv(PixelMap map, ref UInt32 [] values);

		internal delegate void glGetPixelMapusv(PixelMap map, ref UInt16 [] values);

		internal delegate void glGetPointerv(GetPointervPName pname, IntPtr @params);

		internal delegate void glGetPolygonStipple(ref Byte [] mask);

		internal delegate Byte glGetString(StringName name);

		internal delegate void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, ref Single [] @params);

		internal delegate void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, ref Int32 [] @params);

		internal delegate void glGetTexGendv(TextureCoordName coord, TextureGenParameter pname, ref Double [] @params);

		internal delegate void glGetTexGenfv(TextureCoordName coord, TextureGenParameter pname, ref Single [] @params);

		internal delegate void glGetTexGeniv(TextureCoordName coord, TextureGenParameter pname, ref Int32 [] @params);

		internal delegate void glGetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glGetTexLevelParameterfv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Single [] @params);

		internal delegate void glGetTexLevelParameteriv(TextureTarget target, Int32 level, GetTextureParameter pname, ref Int32 [] @params);

		internal delegate void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, ref Single [] @params);

		internal delegate void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, ref Int32 [] @params);

		internal delegate void glHint(HintTarget target, HintMode mode);

		internal delegate void glIndexd(Double c);

		internal delegate void glIndexdv(ref Double c);

		internal delegate void glIndexf(Single c);

		internal delegate void glIndexfv(ref Single c);

		internal delegate void glIndexi(Int32 c);

		internal delegate void glIndexiv(ref Int32 c);

		internal delegate void glIndexMask(UInt32 mask);

		internal delegate void glIndexPointer(IndexPointerType type, Int32 stride, IntPtr pointer);

		internal delegate void glIndexs(Int16 c);

		internal delegate void glIndexsv(ref Int16 c);

		internal delegate void glIndexub(Byte c);

		internal delegate void glIndexubv(ref Byte c);

		internal delegate void glInitNames();

		internal delegate void glInterleavedArrays(InterleavedArrayFormat format, Int32 stride, IntPtr pointer);

		internal delegate Boolean glIsEnabled(EnableCap cap);

		internal delegate Boolean glIsList(UInt32 list);

		internal delegate Boolean glIsTexture(UInt32 texture);

		internal delegate void glLightf(LightName light, LightParameter pname, Single param);

		internal delegate void glLightfv(LightName light, LightParameter pname, ref Single [] @params);

		internal delegate void glLighti(LightName light, LightParameter pname, Int32 param);

		internal delegate void glLightiv(LightName light, LightParameter pname, ref Int32 [] @params);

		internal delegate void glLightModelf(LightModelParameter pname, Single param);

		internal delegate void glLightModelfv(LightModelParameter pname, ref Single [] @params);

		internal delegate void glLightModeli(LightModelParameter pname, Int32 param);

		internal delegate void glLightModeliv(LightModelParameter pname, ref Int32 [] @params);

		internal delegate void glLineStipple(Int32 factor, UInt16 pattern);

		internal delegate void glLineWidth(Single width);

		internal delegate void glListBase(UInt32 @base);

		internal delegate void glLoadIdentity();

		internal delegate void glLoadMatrixd(ref Double [] m);

		internal delegate void glLoadMatrixf(ref Single [] m);

		internal delegate void glLoadName(UInt32 name);

		internal delegate void glLogicOp(LogicOp opcode);

		internal delegate void glMap1d(MapTarget target, Double u1, Double u2, Int32 stride, Int32 order, ref Double [] points);

		internal delegate void glMap1f(MapTarget target, Single u1, Single u2, Int32 stride, Int32 order, ref Single [] points);

		internal delegate void glMap2d(MapTarget target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, ref Double [] points);

		internal delegate void glMap2f(MapTarget target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, ref Single [] points);

		internal delegate void glMapGrid1d(Int32 un, Double u1, Double u2);

		internal delegate void glMapGrid1f(Int32 un, Single u1, Single u2);

		internal delegate void glMapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);

		internal delegate void glMapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);

		internal delegate void glMaterialf(MaterialFace face, MaterialParameter pname, Single param);

		internal delegate void glMaterialfv(MaterialFace face, MaterialParameter pname, ref Single [] @params);

		internal delegate void glMateriali(MaterialFace face, MaterialParameter pname, Int32 param);

		internal delegate void glMaterialiv(MaterialFace face, MaterialParameter pname, ref Int32 [] @params);

		internal delegate void glMatrixMode(MatrixMode mode);

		internal delegate void glMultMatrixd(ref Double [] m);

		internal delegate void glMultMatrixf(ref Single [] m);

		internal delegate void glNewList(UInt32 list, ListMode mode);

		internal delegate void glNormal3b(SByte nx, SByte ny, SByte nz);

		internal delegate void glNormal3bv(ref SByte [] v);

		internal delegate void glNormal3d(Double nx, Double ny, Double nz);

		internal delegate void glNormal3dv(ref Double [] v);

		internal delegate void glNormal3f(Single nx, Single ny, Single nz);

		internal delegate void glNormal3fv(ref Single [] v);

		internal delegate void glNormal3i(Int32 nx, Int32 ny, Int32 nz);

		internal delegate void glNormal3iv(ref Int32 [] v);

		internal delegate void glNormal3s(Int16 nx, Int16 ny, Int16 nz);

		internal delegate void glNormal3sv(ref Int16 [] v);

		internal delegate void glNormalPointer(NormalPointerType type, Int32 stride, IntPtr pointer);

		internal delegate void glOrtho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);

		internal delegate void glPassThrough(Single token);

		internal delegate void glPixelMapfv(PixelMap map, Int32 mapsize, ref Single [] values);

		internal delegate void glPixelMapuiv(PixelMap map, Int32 mapsize, ref UInt32 [] values);

		internal delegate void glPixelMapusv(PixelMap map, Int32 mapsize, ref UInt16 [] values);

		internal delegate void glPixelStoref(PixelStoreParameter pname, Single param);

		internal delegate void glPixelStorei(PixelStoreParameter pname, Int32 param);

		internal delegate void glPixelTransferf(PixelTransferParameter pname, Single param);

		internal delegate void glPixelTransferi(PixelTransferParameter pname, Int32 param);

		internal delegate void glPixelZoom(Single xfactor, Single yfactor);

		internal delegate void glPointSize(Single size);

		internal delegate void glPolygonMode(MaterialFace face, PolygonMode mode);

		internal delegate void glPolygonOffset(Single factor, Single units);

		internal delegate void glPolygonStipple(ref Byte [] mask);

		internal delegate void glPopAttrib();

		internal delegate void glPopClientAttrib();

		internal delegate void glPopMatrix();

		internal delegate void glPopName();

		internal delegate void glPrioritizeTextures(Int32 n, ref UInt32 [] textures, ref Single [] priorities);

		internal delegate void glPushAttrib(UInt32 mask);

		internal delegate void glPushClientAttrib(UInt32 mask);

		internal delegate void glPushMatrix();

		internal delegate void glPushName(UInt32 name);

		internal delegate void glRasterPos2d(Double x, Double y);

		internal delegate void glRasterPos2dv(ref Double [] v);

		internal delegate void glRasterPos2f(Single x, Single y);

		internal delegate void glRasterPos2fv(ref Single [] v);

		internal delegate void glRasterPos2i(Int32 x, Int32 y);

		internal delegate void glRasterPos2iv(ref Int32 [] v);

		internal delegate void glRasterPos2s(Int16 x, Int16 y);

		internal delegate void glRasterPos2sv(ref Int16 [] v);

		internal delegate void glRasterPos3d(Double x, Double y, Double z);

		internal delegate void glRasterPos3dv(ref Double [] v);

		internal delegate void glRasterPos3f(Single x, Single y, Single z);

		internal delegate void glRasterPos3fv(ref Single [] v);

		internal delegate void glRasterPos3i(Int32 x, Int32 y, Int32 z);

		internal delegate void glRasterPos3iv(ref Int32 [] v);

		internal delegate void glRasterPos3s(Int16 x, Int16 y, Int16 z);

		internal delegate void glRasterPos3sv(ref Int16 [] v);

		internal delegate void glRasterPos4d(Double x, Double y, Double z, Double w);

		internal delegate void glRasterPos4dv(ref Double [] v);

		internal delegate void glRasterPos4f(Single x, Single y, Single z, Single w);

		internal delegate void glRasterPos4fv(ref Single [] v);

		internal delegate void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);

		internal delegate void glRasterPos4iv(ref Int32 [] v);

		internal delegate void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);

		internal delegate void glRasterPos4sv(ref Int16 [] v);

		internal delegate void glReadBuffer(ReadBufferMode src);

		internal delegate void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glRectd(Double x1, Double y1, Double x2, Double y2);

		internal delegate void glRectdv(ref Double [] v1, ref Double [] v2);

		internal delegate void glRectf(Single x1, Single y1, Single x2, Single y2);

		internal delegate void glRectfv(ref Single [] v1, ref Single [] v2);

		internal delegate void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);

		internal delegate void glRectiv(ref Int32 [] v1, ref Int32 [] v2);

		internal delegate void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);

		internal delegate void glRectsv(ref Int16 [] v1, ref Int16 [] v2);

		internal delegate Int32 glRenderMode(RenderingMode mode);

		internal delegate void glRotated(Double angle, Double x, Double y, Double z);

		internal delegate void glRotatef(Single angle, Single x, Single y, Single z);

		internal delegate void glScaled(Double x, Double y, Double z);

		internal delegate void glScalef(Single x, Single y, Single z);

		internal delegate void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);

		internal delegate void glSelectBuffer(Int32 size, ref UInt32 [] buffer);

		internal delegate void glShadeModel(ShadingModel mode);

		internal delegate void glStencilFunc(StencilFunction func, Int32 @ref, UInt32 mask);

		internal delegate void glStencilMask(UInt32 mask);

		internal delegate void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass);

		internal delegate void glTexCoord1d(Double s);

		internal delegate void glTexCoord1dv(ref Double v);

		internal delegate void glTexCoord1f(Single s);

		internal delegate void glTexCoord1fv(ref Single v);

		internal delegate void glTexCoord1i(Int32 s);

		internal delegate void glTexCoord1iv(ref Int32 v);

		internal delegate void glTexCoord1s(Int16 s);

		internal delegate void glTexCoord1sv(ref Int16 v);

		internal delegate void glTexCoord2d(Double s, Double t);

		internal delegate void glTexCoord2dv(ref Double [] v);

		internal delegate void glTexCoord2f(Single s, Single t);

		internal delegate void glTexCoord2fv(ref Single [] v);

		internal delegate void glTexCoord2i(Int32 s, Int32 t);

		internal delegate void glTexCoord2iv(ref Int32 [] v);

		internal delegate void glTexCoord2s(Int16 s, Int16 t);

		internal delegate void glTexCoord2sv(ref Int16 [] v);

		internal delegate void glTexCoord3d(Double s, Double t, Double r);

		internal delegate void glTexCoord3dv(ref Double [] v);

		internal delegate void glTexCoord3f(Single s, Single t, Single r);

		internal delegate void glTexCoord3fv(ref Single [] v);

		internal delegate void glTexCoord3i(Int32 s, Int32 t, Int32 r);

		internal delegate void glTexCoord3iv(ref Int32 [] v);

		internal delegate void glTexCoord3s(Int16 s, Int16 t, Int16 r);

		internal delegate void glTexCoord3sv(ref Int16 [] v);

		internal delegate void glTexCoord4d(Double s, Double t, Double r, Double q);

		internal delegate void glTexCoord4dv(ref Double [] v);

		internal delegate void glTexCoord4f(Single s, Single t, Single r, Single q);

		internal delegate void glTexCoord4fv(ref Single [] v);

		internal delegate void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);

		internal delegate void glTexCoord4iv(ref Int32 [] v);

		internal delegate void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);

		internal delegate void glTexCoord4sv(ref Int16 [] v);

		internal delegate void glTexCoordPointer(Int32 size, TexCoordPointerType type, Int32 stride, IntPtr pointer);

		internal delegate void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, Single param);

		internal delegate void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, ref Single [] @params);

		internal delegate void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, Int32 param);

		internal delegate void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, ref Int32 [] @params);

		internal delegate void glTexGend(TextureCoordName coord, TextureGenParameter pname, Double param);

		internal delegate void glTexGendv(TextureCoordName coord, TextureGenParameter pname, ref Double [] @params);

		internal delegate void glTexGenf(TextureCoordName coord, TextureGenParameter pname, Single param);

		internal delegate void glTexGenfv(TextureCoordName coord, TextureGenParameter pname, ref Single [] @params);

		internal delegate void glTexGeni(TextureCoordName coord, TextureGenParameter pname, Int32 param);

		internal delegate void glTexGeniv(TextureCoordName coord, TextureGenParameter pname, ref Int32 [] @params);

		internal delegate void glTexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTexParameterf(TextureTarget target, TextureParameterName pname, Single param);

		internal delegate void glTexParameterfv(TextureTarget target, TextureParameterName pname, ref Single [] @params);

		internal delegate void glTexParameteri(TextureTarget target, TextureParameterName pname, Int32 param);

		internal delegate void glTexParameteriv(TextureTarget target, TextureParameterName pname, ref Int32 [] @params);

		internal delegate void glTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels);

		internal delegate void glTranslated(Double x, Double y, Double z);

		internal delegate void glTranslatef(Single x, Single y, Single z);

		internal delegate void glVertex2d(Double x, Double y);

		internal delegate void glVertex2dv(ref Double [] v);

		internal delegate void glVertex2f(Single x, Single y);

		internal delegate void glVertex2fv(ref Single [] v);

		internal delegate void glVertex2i(Int32 x, Int32 y);

		internal delegate void glVertex2iv(ref Int32 [] v);

		internal delegate void glVertex2s(Int16 x, Int16 y);

		internal delegate void glVertex2sv(ref Int16 [] v);

		internal delegate void glVertex3d(Double x, Double y, Double z);

		internal delegate void glVertex3dv(ref Double [] v);

		internal delegate void glVertex3f(Single x, Single y, Single z);

		internal delegate void glVertex3fv(ref Single [] v);

		internal delegate void glVertex3i(Int32 x, Int32 y, Int32 z);

		internal delegate void glVertex3iv(ref Int32 [] v);

		internal delegate void glVertex3s(Int16 x, Int16 y, Int16 z);

		internal delegate void glVertex3sv(ref Int16 [] v);

		internal delegate void glVertex4d(Double x, Double y, Double z, Double w);

		internal delegate void glVertex4dv(ref Double [] v);

		internal delegate void glVertex4f(Single x, Single y, Single z, Single w);

		internal delegate void glVertex4fv(ref Single [] v);

		internal delegate void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w);

		internal delegate void glVertex4iv(ref Int32 [] v);

		internal delegate void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w);

		internal delegate void glVertex4sv(ref Int16 [] v);

		internal delegate void glVertexPointer(Int32 size, VertexPointerType type, Int32 stride, IntPtr pointer);

		internal delegate void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);

	}
}

