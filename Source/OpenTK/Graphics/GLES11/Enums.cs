#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;

namespace OpenTK.Graphics.GLES11
{
    #pragma warning disable 1591

    public enum All
    {
        False = ((int)0),
        Noerror = ((int)0),
        Zero = ((int)0),
        Points = ((int)0X0000),
        Depthbufferbit = ((int)0X00000100),
        Stencilbufferbit = ((int)0X00000400),
        Colorbufferbit = ((int)0X00004000),
        Lines = ((int)0X0001),
        Lineloop = ((int)0X0002),
        Linestrip = ((int)0X0003),
        Triangles = ((int)0X0004),
        Trianglestrip = ((int)0X0005),
        Trianglefan = ((int)0X0006),
        Add = ((int)0X0104),
        Never = ((int)0X0200),
        Less = ((int)0X0201),
        Equal = ((int)0X0202),
        Lequal = ((int)0X0203),
        Greater = ((int)0X0204),
        Notequal = ((int)0X0205),
        Gequal = ((int)0X0206),
        Always = ((int)0X0207),
        Srccolor = ((int)0X0300),
        Oneminussrccolor = ((int)0X0301),
        Srcalpha = ((int)0X0302),
        Oneminussrcalpha = ((int)0X0303),
        Dstalpha = ((int)0X0304),
        Oneminusdstalpha = ((int)0X0305),
        Dstcolor = ((int)0X0306),
        Oneminusdstcolor = ((int)0X0307),
        Srcalphasaturate = ((int)0X0308),
        Front = ((int)0X0404),
        Back = ((int)0X0405),
        Frontandback = ((int)0X0408),
        Invalidenum = ((int)0X0500),
        Invalidvalue = ((int)0X0501),
        Invalidoperation = ((int)0X0502),
        Stackoverflow = ((int)0X0503),
        Stackunderflow = ((int)0X0504),
        Outofmemory = ((int)0X0505),
        Exp = ((int)0X0800),
        Exp2 = ((int)0X0801),
        Cw = ((int)0X0900),
        Ccw = ((int)0X0901),
        Currentcolor = ((int)0X0b00),
        Currentnormal = ((int)0X0b02),
        Currenttexturecoords = ((int)0X0b03),
        Pointsmooth = ((int)0X0b10),
        Pointsize = ((int)0X0b11),
        Smoothpointsizerange = ((int)0X0b12),
        Linesmooth = ((int)0X0b20),
        Linewidth = ((int)0X0b21),
        Smoothlinewidthrange = ((int)0X0b22),
        Cullface = ((int)0X0b44),
        Cullfacemode = ((int)0X0b45),
        Frontface = ((int)0X0b46),
        Lighting = ((int)0X0b50),
        Lightmodeltwoside = ((int)0X0b52),
        Lightmodelambient = ((int)0X0b53),
        Shademodel = ((int)0X0b54),
        Colormaterial = ((int)0X0b57),
        Fog = ((int)0X0b60),
        Fogdensity = ((int)0X0b62),
        Fogstart = ((int)0X0b63),
        Fogend = ((int)0X0b64),
        Fogmode = ((int)0X0b65),
        Fogcolor = ((int)0X0b66),
        Depthrange = ((int)0X0b70),
        Depthtest = ((int)0X0b71),
        Depthwritemask = ((int)0X0b72),
        Depthclearvalue = ((int)0X0b73),
        Depthfunc = ((int)0X0b74),
        Stenciltest = ((int)0X0b90),
        Stencilclearvalue = ((int)0X0b91),
        Stencilfunc = ((int)0X0b92),
        Stencilvaluemask = ((int)0X0b93),
        Stencilfail = ((int)0X0b94),
        Stencilpassdepthfail = ((int)0X0b95),
        Stencilpassdepthpass = ((int)0X0b96),
        Stencilref = ((int)0X0b97),
        Stencilwritemask = ((int)0X0b98),
        Matrixmode = ((int)0X0ba0),
        Normalize = ((int)0X0ba1),
        Viewport = ((int)0X0ba2),
        Modelviewstackdepth = ((int)0X0ba3),
        Projectionstackdepth = ((int)0X0ba4),
        Texturestackdepth = ((int)0X0ba5),
        Modelviewmatrix = ((int)0X0ba6),
        Projectionmatrix = ((int)0X0ba7),
        Texturematrix = ((int)0X0ba8),
        Alphatest = ((int)0X0bc0),
        Alphatestfunc = ((int)0X0bc1),
        Alphatestref = ((int)0X0bc2),
        Dither = ((int)0X0bd0),
        Blenddst = ((int)0X0be0),
        Blendsrc = ((int)0X0be1),
        Blend = ((int)0X0be2),
        Logicopmode = ((int)0X0bf0),
        Colorlogicop = ((int)0X0bf2),
        Scissorbox = ((int)0X0c10),
        Scissortest = ((int)0X0c11),
        Colorclearvalue = ((int)0X0c22),
        Colorwritemask = ((int)0X0c23),
        Perspectivecorrectionhint = ((int)0X0c50),
        Pointsmoothhint = ((int)0X0c51),
        Linesmoothhint = ((int)0X0c52),
        Foghint = ((int)0X0c54),
        Unpackalignment = ((int)0X0cf5),
        Packalignment = ((int)0X0d05),
        Alphascale = ((int)0X0d1c),
        Maxlights = ((int)0X0d31),
        Maxclipplanes = ((int)0X0d32),
        Maxtexturesize = ((int)0X0d33),
        Maxmodelviewstackdepth = ((int)0X0d36),
        Maxprojectionstackdepth = ((int)0X0d38),
        Maxtexturestackdepth = ((int)0X0d39),
        Maxviewportdims = ((int)0X0d3a),
        Subpixelbits = ((int)0X0d50),
        Redbits = ((int)0X0d52),
        Greenbits = ((int)0X0d53),
        Bluebits = ((int)0X0d54),
        Alphabits = ((int)0X0d55),
        Depthbits = ((int)0X0d56),
        Stencilbits = ((int)0X0d57),
        Texture2D = ((int)0X0de1),
        Dontcare = ((int)0X1100),
        Fastest = ((int)0X1101),
        Nicest = ((int)0X1102),
        Ambient = ((int)0X1200),
        Diffuse = ((int)0X1201),
        Specular = ((int)0X1202),
        Position = ((int)0X1203),
        Spotdirection = ((int)0X1204),
        Spotexponent = ((int)0X1205),
        Spotcutoff = ((int)0X1206),
        Constantattenuation = ((int)0X1207),
        Linearattenuation = ((int)0X1208),
        Quadraticattenuation = ((int)0X1209),
        Byte = ((int)0X1400),
        Unsignedbyte = ((int)0X1401),
        Short = ((int)0X1402),
        Unsignedshort = ((int)0X1403),
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
        Clear = ((int)0X1500),
        And = ((int)0X1501),
        Andreverse = ((int)0X1502),
        Copy = ((int)0X1503),
        Andinverted = ((int)0X1504),
        Noop = ((int)0X1505),
        Xor = ((int)0X1506),
        Or = ((int)0X1507),
        Nor = ((int)0X1508),
        Equiv = ((int)0X1509),
        Invert = ((int)0X150a),
        Orreverse = ((int)0X150b),
        Copyinverted = ((int)0X150c),
        Orinverted = ((int)0X150d),
        Nand = ((int)0X150e),
        Set = ((int)0X150f),
        Emission = ((int)0X1600),
        Shininess = ((int)0X1601),
        Ambientanddiffuse = ((int)0X1602),
        Modelview = ((int)0X1700),
        Projection = ((int)0X1701),
        Texture = ((int)0X1702),
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        Luminancealpha = ((int)0X190a),
        Flat = ((int)0X1d00),
        Smooth = ((int)0X1d01),
        Keep = ((int)0X1e00),
        Replace = ((int)0X1e01),
        Incr = ((int)0X1e02),
        Decr = ((int)0X1e03),
        Vendor = ((int)0X1f00),
        Renderer = ((int)0X1f01),
        Version = ((int)0X1f02),
        Extensions = ((int)0X1f03),
        Modulate = ((int)0X2100),
        Decal = ((int)0X2101),
        Textureenvmode = ((int)0X2200),
        Textureenvcolor = ((int)0X2201),
        Textureenv = ((int)0X2300),
        Nearest = ((int)0X2600),
        Linear = ((int)0X2601),
        Nearestmipmapnearest = ((int)0X2700),
        Linearmipmapnearest = ((int)0X2701),
        Nearestmipmaplinear = ((int)0X2702),
        Linearmipmaplinear = ((int)0X2703),
        Texturemagfilter = ((int)0X2800),
        Textureminfilter = ((int)0X2801),
        Texturewraps = ((int)0X2802),
        Texturewrapt = ((int)0X2803),
        Repeat = ((int)0X2901),
        Polygonoffsetunits = ((int)0X2a00),
        Clipplane0 = ((int)0X3000),
        Clipplane1 = ((int)0X3001),
        Clipplane2 = ((int)0X3002),
        Clipplane3 = ((int)0X3003),
        Clipplane4 = ((int)0X3004),
        Clipplane5 = ((int)0X3005),
        Light0 = ((int)0X4000),
        Light1 = ((int)0X4001),
        Light2 = ((int)0X4002),
        Light3 = ((int)0X4003),
        Light4 = ((int)0X4004),
        Light5 = ((int)0X4005),
        Light6 = ((int)0X4006),
        Light7 = ((int)0X4007),
        Unsignedshort4444 = ((int)0X8033),
        Unsignedshort5551 = ((int)0X8034),
        Polygonoffsetfill = ((int)0X8037),
        Polygonoffsetfactor = ((int)0X8038),
        Rescalenormal = ((int)0X803a),
        Texturebinding2D = ((int)0X8069),
        Vertexarray = ((int)0X8074),
        Normalarray = ((int)0X8075),
        Colorarray = ((int)0X8076),
        Texturecoordarray = ((int)0X8078),
        Vertexarraysize = ((int)0X807a),
        Vertexarraytype = ((int)0X807b),
        Vertexarraystride = ((int)0X807c),
        Normalarraytype = ((int)0X807e),
        Normalarraystride = ((int)0X807f),
        Colorarraysize = ((int)0X8081),
        Colorarraytype = ((int)0X8082),
        Colorarraystride = ((int)0X8083),
        Texturecoordarraysize = ((int)0X8088),
        Texturecoordarraytype = ((int)0X8089),
        Texturecoordarraystride = ((int)0X808a),
        Vertexarraypointer = ((int)0X808e),
        Normalarraypointer = ((int)0X808f),
        Colorarraypointer = ((int)0X8090),
        Texturecoordarraypointer = ((int)0X8092),
        Multisample = ((int)0X809d),
        Samplealphatocoverage = ((int)0X809e),
        Samplealphatoone = ((int)0X809f),
        Samplecoverage = ((int)0X80a0),
        Samplebuffers = ((int)0X80a8),
        Samples = ((int)0X80a9),
        Samplecoveragevalue = ((int)0X80aa),
        Samplecoverageinvert = ((int)0X80ab),
        Pointsizemin = ((int)0X8126),
        Pointsizemax = ((int)0X8127),
        Pointfadethresholdsize = ((int)0X8128),
        Pointdistanceattenuation = ((int)0X8129),
        Clamptoedge = ((int)0X812f),
        Generatemipmap = ((int)0X8191),
        Generatemipmaphint = ((int)0X8192),
        Unsignedshort565 = ((int)0X8363),
        Aliasedpointsizerange = ((int)0X846d),
        Aliasedlinewidthrange = ((int)0X846e),
        Texture0 = ((int)0X84c0),
        Texture1 = ((int)0X84c1),
        Texture2 = ((int)0X84c2),
        Texture3 = ((int)0X84c3),
        Texture4 = ((int)0X84c4),
        Texture5 = ((int)0X84c5),
        Texture6 = ((int)0X84c6),
        Texture7 = ((int)0X84c7),
        Texture8 = ((int)0X84c8),
        Texture9 = ((int)0X84c9),
        Texture10 = ((int)0X84ca),
        Texture11 = ((int)0X84cb),
        Texture12 = ((int)0X84cc),
        Texture13 = ((int)0X84cd),
        Texture14 = ((int)0X84ce),
        Texture15 = ((int)0X84cf),
        Texture16 = ((int)0X84d0),
        Texture17 = ((int)0X84d1),
        Texture18 = ((int)0X84d2),
        Texture19 = ((int)0X84d3),
        Texture20 = ((int)0X84d4),
        Texture21 = ((int)0X84d5),
        Texture22 = ((int)0X84d6),
        Texture23 = ((int)0X84d7),
        Texture24 = ((int)0X84d8),
        Texture25 = ((int)0X84d9),
        Texture26 = ((int)0X84da),
        Texture27 = ((int)0X84db),
        Texture28 = ((int)0X84dc),
        Texture29 = ((int)0X84dd),
        Texture30 = ((int)0X84de),
        Texture31 = ((int)0X84df),
        Activetexture = ((int)0X84e0),
        Clientactivetexture = ((int)0X84e1),
        Maxtextureunits = ((int)0X84e2),
        Subtract = ((int)0X84e7),
        Combine = ((int)0X8570),
        Combinergb = ((int)0X8571),
        Combinealpha = ((int)0X8572),
        Rgbscale = ((int)0X8573),
        Addsigned = ((int)0X8574),
        Interpolate = ((int)0X8575),
        Constant = ((int)0X8576),
        Primarycolor = ((int)0X8577),
        Previous = ((int)0X8578),
        Src0rgb = ((int)0X8580),
        Src1rgb = ((int)0X8581),
        Src2rgb = ((int)0X8582),
        Src0alpha = ((int)0X8588),
        Src1alpha = ((int)0X8589),
        Src2alpha = ((int)0X858a),
        Operand0rgb = ((int)0X8590),
        Operand1rgb = ((int)0X8591),
        Operand2rgb = ((int)0X8592),
        Operand0alpha = ((int)0X8598),
        Operand1alpha = ((int)0X8599),
        Operand2alpha = ((int)0X859a),
        Numcompressedtextureformats = ((int)0X86a2),
        Compressedtextureformats = ((int)0X86a3),
        Dot3rgb = ((int)0X86ae),
        Dot3rgba = ((int)0X86af),
        Buffersize = ((int)0X8764),
        Bufferusage = ((int)0X8765),
        Pointspriteoes = ((int)0X8861),
        Coordreplaceoes = ((int)0X8862),
        Arraybuffer = ((int)0X8892),
        Elementarraybuffer = ((int)0X8893),
        Arraybufferbinding = ((int)0X8894),
        Elementarraybufferbinding = ((int)0X8895),
        Vertexarraybufferbinding = ((int)0X8896),
        Normalarraybufferbinding = ((int)0X8897),
        Colorarraybufferbinding = ((int)0X8898),
        Texturecoordarraybufferbinding = ((int)0X889a),
        Staticdraw = ((int)0X88e4),
        Dynamicdraw = ((int)0X88e8),
        Pointsizearraytypeoes = ((int)0X898a),
        Pointsizearraystrideoes = ((int)0X898b),
        Pointsizearraypointeroes = ((int)0X898c),
        Palette4rgb8oes = ((int)0X8b90),
        Palette4rgba8oes = ((int)0X8b91),
        Palette4r5g6b5oes = ((int)0X8b92),
        Palette4rgba4oes = ((int)0X8b93),
        Palette4rgb5a1oes = ((int)0X8b94),
        Palette8rgb8oes = ((int)0X8b95),
        Palette8rgba8oes = ((int)0X8b96),
        Palette8r5g6b5oes = ((int)0X8b97),
        Palette8rgba4oes = ((int)0X8b98),
        Palette8rgb5a1oes = ((int)0X8b99),
        Implementationcolorreadtypeoes = ((int)0X8b9a),
        Implementationcolorreadformatoes = ((int)0X8b9b),
        Pointsizearrayoes = ((int)0X8b9c),
        Pointsizearraybufferbindingoes = ((int)0X8b9f),
        One = ((int)1),
        True = ((int)1),
        Versionescl10 = ((int)1),
        Versionescl11 = ((int)1),
        Versionescm10 = ((int)1),
        Versionescm11 = ((int)1),
    }

    public enum AlphaFunction
    {
        Never = ((int)0X0200),
        Less = ((int)0X0201),
        Equal = ((int)0X0202),
        Lequal = ((int)0X0203),
        Greater = ((int)0X0204),
        Notequal = ((int)0X0205),
        Gequal = ((int)0X0206),
        Always = ((int)0X0207),
    }

    public enum BeginMode
    {
        Points = ((int)0X0000),
        Lines = ((int)0X0001),
        Lineloop = ((int)0X0002),
        Linestrip = ((int)0X0003),
        Triangles = ((int)0X0004),
        Trianglestrip = ((int)0X0005),
        Trianglefan = ((int)0X0006),
    }

    public enum BlendingFactorDest
    {
        Zero = ((int)0),
        Srccolor = ((int)0X0300),
        Oneminussrccolor = ((int)0X0301),
        Srcalpha = ((int)0X0302),
        Oneminussrcalpha = ((int)0X0303),
        Dstalpha = ((int)0X0304),
        Oneminusdstalpha = ((int)0X0305),
        One = ((int)1),
    }

    public enum BlendingFactorSrc
    {
        Dstcolor = ((int)0X0306),
        Oneminusdstcolor = ((int)0X0307),
        Srcalphasaturate = ((int)0X0308),
    }

    public enum Boolean
    {
        False = ((int)0),
        True = ((int)1),
    }

    public enum BufferObjects
    {
        Buffersize = ((int)0X8764),
        Bufferusage = ((int)0X8765),
        Arraybuffer = ((int)0X8892),
        Elementarraybuffer = ((int)0X8893),
        Arraybufferbinding = ((int)0X8894),
        Elementarraybufferbinding = ((int)0X8895),
        Vertexarraybufferbinding = ((int)0X8896),
        Normalarraybufferbinding = ((int)0X8897),
        Colorarraybufferbinding = ((int)0X8898),
        Texturecoordarraybufferbinding = ((int)0X889a),
        Staticdraw = ((int)0X88e4),
        Dynamicdraw = ((int)0X88e8),
    }

    [Flags]
    public enum ClearBufferMask
    {
        Depthbufferbit = ((int)0X00000100),
        Stencilbufferbit = ((int)0X00000400),
        Colorbufferbit = ((int)0X00004000),
    }

    public enum ClipPlaneName
    {
        Clipplane0 = ((int)0X3000),
        Clipplane1 = ((int)0X3001),
        Clipplane2 = ((int)0X3002),
        Clipplane3 = ((int)0X3003),
        Clipplane4 = ((int)0X3004),
        Clipplane5 = ((int)0X3005),
    }

    public enum CullFaceMode
    {
        Front = ((int)0X0404),
        Back = ((int)0X0405),
        Frontandback = ((int)0X0408),
    }

    public enum DataType
    {
        Byte = ((int)0X1400),
        Unsignedbyte = ((int)0X1401),
        Short = ((int)0X1402),
        Unsignedshort = ((int)0X1403),
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
    }

    public enum EnableCap
    {
        Pointsmooth = ((int)0X0b10),
        Linesmooth = ((int)0X0b20),
        Cullface = ((int)0X0b44),
        Lighting = ((int)0X0b50),
        Colormaterial = ((int)0X0b57),
        Fog = ((int)0X0b60),
        Depthtest = ((int)0X0b71),
        Stenciltest = ((int)0X0b90),
        Normalize = ((int)0X0ba1),
        Alphatest = ((int)0X0bc0),
        Dither = ((int)0X0bd0),
        Blend = ((int)0X0be2),
        Colorlogicop = ((int)0X0bf2),
        Scissortest = ((int)0X0c11),
        Texture2D = ((int)0X0de1),
        Polygonoffsetfill = ((int)0X8037),
        Rescalenormal = ((int)0X803a),
        Vertexarray = ((int)0X8074),
        Normalarray = ((int)0X8075),
        Colorarray = ((int)0X8076),
        Texturecoordarray = ((int)0X8078),
        Multisample = ((int)0X809d),
        Samplealphatocoverage = ((int)0X809e),
        Samplealphatoone = ((int)0X809f),
        Samplecoverage = ((int)0X80a0),
    }

    public enum ErrorCode
    {
        Noerror = ((int)0),
        Invalidenum = ((int)0X0500),
        Invalidvalue = ((int)0X0501),
        Invalidoperation = ((int)0X0502),
        Stackoverflow = ((int)0X0503),
        Stackunderflow = ((int)0X0504),
        Outofmemory = ((int)0X0505),
    }

    public enum FogMode
    {
        Exp = ((int)0X0800),
        Exp2 = ((int)0X0801),
    }

    public enum FogParameter
    {
        Fogdensity = ((int)0X0b62),
        Fogstart = ((int)0X0b63),
        Fogend = ((int)0X0b64),
        Fogmode = ((int)0X0b65),
        Fogcolor = ((int)0X0b66),
    }

    public enum FrontFaceDirection
    {
        Cw = ((int)0X0900),
        Ccw = ((int)0X0901),
    }

    public enum GetPName
    {
        Currentcolor = ((int)0X0b00),
        Currentnormal = ((int)0X0b02),
        Currenttexturecoords = ((int)0X0b03),
        Pointsize = ((int)0X0b11),
        Smoothpointsizerange = ((int)0X0b12),
        Linewidth = ((int)0X0b21),
        Smoothlinewidthrange = ((int)0X0b22),
        Cullfacemode = ((int)0X0b45),
        Frontface = ((int)0X0b46),
        Shademodel = ((int)0X0b54),
        Depthrange = ((int)0X0b70),
        Depthwritemask = ((int)0X0b72),
        Depthclearvalue = ((int)0X0b73),
        Depthfunc = ((int)0X0b74),
        Stencilclearvalue = ((int)0X0b91),
        Stencilfunc = ((int)0X0b92),
        Stencilvaluemask = ((int)0X0b93),
        Stencilfail = ((int)0X0b94),
        Stencilpassdepthfail = ((int)0X0b95),
        Stencilpassdepthpass = ((int)0X0b96),
        Stencilref = ((int)0X0b97),
        Stencilwritemask = ((int)0X0b98),
        Matrixmode = ((int)0X0ba0),
        Viewport = ((int)0X0ba2),
        Modelviewstackdepth = ((int)0X0ba3),
        Projectionstackdepth = ((int)0X0ba4),
        Texturestackdepth = ((int)0X0ba5),
        Modelviewmatrix = ((int)0X0ba6),
        Projectionmatrix = ((int)0X0ba7),
        Texturematrix = ((int)0X0ba8),
        Alphatestfunc = ((int)0X0bc1),
        Alphatestref = ((int)0X0bc2),
        Blenddst = ((int)0X0be0),
        Blendsrc = ((int)0X0be1),
        Logicopmode = ((int)0X0bf0),
        Scissorbox = ((int)0X0c10),
        Scissortest = ((int)0X0c11),
        Colorclearvalue = ((int)0X0c22),
        Colorwritemask = ((int)0X0c23),
        Unpackalignment = ((int)0X0cf5),
        Packalignment = ((int)0X0d05),
        Maxlights = ((int)0X0d31),
        Maxclipplanes = ((int)0X0d32),
        Maxtexturesize = ((int)0X0d33),
        Maxmodelviewstackdepth = ((int)0X0d36),
        Maxprojectionstackdepth = ((int)0X0d38),
        Maxtexturestackdepth = ((int)0X0d39),
        Maxviewportdims = ((int)0X0d3a),
        Subpixelbits = ((int)0X0d50),
        Redbits = ((int)0X0d52),
        Greenbits = ((int)0X0d53),
        Bluebits = ((int)0X0d54),
        Alphabits = ((int)0X0d55),
        Depthbits = ((int)0X0d56),
        Stencilbits = ((int)0X0d57),
        Polygonoffsetunits = ((int)0X2a00),
        Polygonoffsetfill = ((int)0X8037),
        Polygonoffsetfactor = ((int)0X8038),
        Texturebinding2D = ((int)0X8069),
        Vertexarraysize = ((int)0X807a),
        Vertexarraytype = ((int)0X807b),
        Vertexarraystride = ((int)0X807c),
        Normalarraytype = ((int)0X807e),
        Normalarraystride = ((int)0X807f),
        Colorarraysize = ((int)0X8081),
        Colorarraytype = ((int)0X8082),
        Colorarraystride = ((int)0X8083),
        Texturecoordarraysize = ((int)0X8088),
        Texturecoordarraytype = ((int)0X8089),
        Texturecoordarraystride = ((int)0X808a),
        Vertexarraypointer = ((int)0X808e),
        Normalarraypointer = ((int)0X808f),
        Colorarraypointer = ((int)0X8090),
        Texturecoordarraypointer = ((int)0X8092),
        Samplebuffers = ((int)0X80a8),
        Samples = ((int)0X80a9),
        Samplecoveragevalue = ((int)0X80aa),
        Samplecoverageinvert = ((int)0X80ab),
        Pointsizemin = ((int)0X8126),
        Pointsizemax = ((int)0X8127),
        Pointfadethresholdsize = ((int)0X8128),
        Pointdistanceattenuation = ((int)0X8129),
        Aliasedpointsizerange = ((int)0X846d),
        Aliasedlinewidthrange = ((int)0X846e),
        Maxtextureunits = ((int)0X84e2),
    }

    public enum GetTextureParameter
    {
        Numcompressedtextureformats = ((int)0X86a2),
        Compressedtextureformats = ((int)0X86a3),
    }

    public enum HintMode
    {
        Dontcare = ((int)0X1100),
        Fastest = ((int)0X1101),
        Nicest = ((int)0X1102),
    }

    public enum HintTarget
    {
        Perspectivecorrectionhint = ((int)0X0c50),
        Pointsmoothhint = ((int)0X0c51),
        Linesmoothhint = ((int)0X0c52),
        Foghint = ((int)0X0c54),
        Generatemipmaphint = ((int)0X8192),
    }

    public enum LightModelParameter
    {
        Lightmodeltwoside = ((int)0X0b52),
        Lightmodelambient = ((int)0X0b53),
    }

    public enum LightName
    {
        Light0 = ((int)0X4000),
        Light1 = ((int)0X4001),
        Light2 = ((int)0X4002),
        Light3 = ((int)0X4003),
        Light4 = ((int)0X4004),
        Light5 = ((int)0X4005),
        Light6 = ((int)0X4006),
        Light7 = ((int)0X4007),
    }

    public enum LightParameter
    {
        Ambient = ((int)0X1200),
        Diffuse = ((int)0X1201),
        Specular = ((int)0X1202),
        Position = ((int)0X1203),
        Spotdirection = ((int)0X1204),
        Spotexponent = ((int)0X1205),
        Spotcutoff = ((int)0X1206),
        Constantattenuation = ((int)0X1207),
        Linearattenuation = ((int)0X1208),
        Quadraticattenuation = ((int)0X1209),
    }

    public enum LogicOp
    {
        Clear = ((int)0X1500),
        And = ((int)0X1501),
        Andreverse = ((int)0X1502),
        Copy = ((int)0X1503),
        Andinverted = ((int)0X1504),
        Noop = ((int)0X1505),
        Xor = ((int)0X1506),
        Or = ((int)0X1507),
        Nor = ((int)0X1508),
        Equiv = ((int)0X1509),
        Invert = ((int)0X150a),
        Orreverse = ((int)0X150b),
        Copyinverted = ((int)0X150c),
        Orinverted = ((int)0X150d),
        Nand = ((int)0X150e),
        Set = ((int)0X150f),
    }

    public enum MaterialParameter
    {
        Emission = ((int)0X1600),
        Shininess = ((int)0X1601),
        Ambientanddiffuse = ((int)0X1602),
    }

    public enum MatrixMode
    {
        Modelview = ((int)0X1700),
        Projection = ((int)0X1701),
        Texture = ((int)0X1702),
    }

    public enum OesCompressedPalettedTexture
    {
        Palette4rgb8oes = ((int)0X8b90),
        Palette4rgba8oes = ((int)0X8b91),
        Palette4r5g6b5oes = ((int)0X8b92),
        Palette4rgba4oes = ((int)0X8b93),
        Palette4rgb5a1oes = ((int)0X8b94),
        Palette8rgb8oes = ((int)0X8b95),
        Palette8rgba8oes = ((int)0X8b96),
        Palette8r5g6b5oes = ((int)0X8b97),
        Palette8rgba4oes = ((int)0X8b98),
        Palette8rgb5a1oes = ((int)0X8b99),
    }

    public enum OesPointSizeArray
    {
        Pointsizearraytypeoes = ((int)0X898a),
        Pointsizearraystrideoes = ((int)0X898b),
        Pointsizearraypointeroes = ((int)0X898c),
        Pointsizearrayoes = ((int)0X8b9c),
        Pointsizearraybufferbindingoes = ((int)0X8b9f),
    }

    public enum OesPointSprite
    {
        Pointspriteoes = ((int)0X8861),
        Coordreplaceoes = ((int)0X8862),
    }

    public enum OesReadFormat
    {
        Implementationcolorreadtypeoes = ((int)0X8b9a),
        Implementationcolorreadformatoes = ((int)0X8b9b),
    }

    public enum OpenGlescoreVersions
    {
        Versionescl10 = ((int)1),
        Versionescl11 = ((int)1),
        Versionescm10 = ((int)1),
        Versionescm11 = ((int)1),
    }

    public enum PixelFormat
    {
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        Luminancealpha = ((int)0X190a),
    }

    public enum PixelStoreParameter
    {
        Unpackalignment = ((int)0X0cf5),
        Packalignment = ((int)0X0d05),
    }

    public enum PixelType
    {
        Unsignedshort4444 = ((int)0X8033),
        Unsignedshort5551 = ((int)0X8034),
        Unsignedshort565 = ((int)0X8363),
    }

    public enum ShadingModel
    {
        Flat = ((int)0X1d00),
        Smooth = ((int)0X1d01),
    }

    public enum StencilOp
    {
        Keep = ((int)0X1e00),
        Replace = ((int)0X1e01),
        Incr = ((int)0X1e02),
        Decr = ((int)0X1e03),
    }

    public enum StringName
    {
        Vendor = ((int)0X1f00),
        Renderer = ((int)0X1f01),
        Version = ((int)0X1f02),
        Extensions = ((int)0X1f03),
    }

    public enum TextureCombine
    {
        Alphascale = ((int)0X0d1c),
        Subtract = ((int)0X84e7),
        Combine = ((int)0X8570),
        Combinergb = ((int)0X8571),
        Combinealpha = ((int)0X8572),
        Rgbscale = ((int)0X8573),
        Addsigned = ((int)0X8574),
        Interpolate = ((int)0X8575),
        Constant = ((int)0X8576),
        Primarycolor = ((int)0X8577),
        Previous = ((int)0X8578),
        Src0rgb = ((int)0X8580),
        Src1rgb = ((int)0X8581),
        Src2rgb = ((int)0X8582),
        Src0alpha = ((int)0X8588),
        Src1alpha = ((int)0X8589),
        Src2alpha = ((int)0X858a),
        Operand0rgb = ((int)0X8590),
        Operand1rgb = ((int)0X8591),
        Operand2rgb = ((int)0X8592),
        Operand0alpha = ((int)0X8598),
        Operand1alpha = ((int)0X8599),
        Operand2alpha = ((int)0X859a),
        Dot3rgb = ((int)0X86ae),
        Dot3rgba = ((int)0X86af),
    }

    public enum TextureEnvMode
    {
        Add = ((int)0X0104),
        Modulate = ((int)0X2100),
        Decal = ((int)0X2101),
    }

    public enum TextureEnvParameter
    {
        Textureenvmode = ((int)0X2200),
        Textureenvcolor = ((int)0X2201),
    }

    public enum TextureEnvTarget
    {
        Textureenv = ((int)0X2300),
    }

    public enum TextureMagFilter
    {
        Nearest = ((int)0X2600),
        Linear = ((int)0X2601),
    }

    public enum TextureMinFilter
    {
        Nearestmipmapnearest = ((int)0X2700),
        Linearmipmapnearest = ((int)0X2701),
        Nearestmipmaplinear = ((int)0X2702),
        Linearmipmaplinear = ((int)0X2703),
    }

    public enum TextureParameterName
    {
        Texturemagfilter = ((int)0X2800),
        Textureminfilter = ((int)0X2801),
        Texturewraps = ((int)0X2802),
        Texturewrapt = ((int)0X2803),
        Generatemipmap = ((int)0X8191),
    }

    public enum TextureUnit
    {
        Texture0 = ((int)0X84c0),
        Texture1 = ((int)0X84c1),
        Texture2 = ((int)0X84c2),
        Texture3 = ((int)0X84c3),
        Texture4 = ((int)0X84c4),
        Texture5 = ((int)0X84c5),
        Texture6 = ((int)0X84c6),
        Texture7 = ((int)0X84c7),
        Texture8 = ((int)0X84c8),
        Texture9 = ((int)0X84c9),
        Texture10 = ((int)0X84ca),
        Texture11 = ((int)0X84cb),
        Texture12 = ((int)0X84cc),
        Texture13 = ((int)0X84cd),
        Texture14 = ((int)0X84ce),
        Texture15 = ((int)0X84cf),
        Texture16 = ((int)0X84d0),
        Texture17 = ((int)0X84d1),
        Texture18 = ((int)0X84d2),
        Texture19 = ((int)0X84d3),
        Texture20 = ((int)0X84d4),
        Texture21 = ((int)0X84d5),
        Texture22 = ((int)0X84d6),
        Texture23 = ((int)0X84d7),
        Texture24 = ((int)0X84d8),
        Texture25 = ((int)0X84d9),
        Texture26 = ((int)0X84da),
        Texture27 = ((int)0X84db),
        Texture28 = ((int)0X84dc),
        Texture29 = ((int)0X84dd),
        Texture30 = ((int)0X84de),
        Texture31 = ((int)0X84df),
        Activetexture = ((int)0X84e0),
        Clientactivetexture = ((int)0X84e1),
    }

    public enum TextureWrapMode
    {
        Repeat = ((int)0X2901),
        Clamptoedge = ((int)0X812f),
    }

}