﻿//
// ES11Obsolete.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;

namespace OpenTK.Graphics.ES11
{
    partial class GL
    {
        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        [Obsolete("Use GetClipPlane(..., float[]) instead. This method will return incorrect results.")]
        public static Single GetClipPlane(All plane) { throw new BindingsNotRewrittenException(); }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [Obsolete("Use GetClipPlane(..., int[]) instead. This method will return incorrect results.")]
        public static int GetClipPlanex(All plane) { throw new BindingsNotRewrittenException(); }
    }
}

