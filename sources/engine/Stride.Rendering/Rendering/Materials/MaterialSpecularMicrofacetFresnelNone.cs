// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Stride.Core;
using Stride.Shaders;

namespace Stride.Rendering.Materials
{
    /// <summary>
    /// No Fresnel applied.
    /// </summary>
    [DataContract("MaterialSpecularMicrofacetFresnelNone")]
    [Display("None")]
    public class MaterialSpecularMicrofacetFresnelNone : IMaterialSpecularMicrofacetFresnelFunction
    {
        public ShaderSource Generate(MaterialGeneratorContext context)
        {
            return new ShaderClassSource("MaterialSpecularMicrofacetFresnelNone");
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is MaterialSpecularMicrofacetFresnelNone;
        }

        public override int GetHashCode()
        {
            return typeof(MaterialSpecularMicrofacetFresnelNone).GetHashCode();
        }
    }
}
