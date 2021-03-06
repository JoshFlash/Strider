﻿// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System.ComponentModel;
using Stride.Engine;

namespace Stride.Rendering
{
    public class SimpleGroupToRenderStageSelector : RenderStageSelector
    {
        [DefaultValue(RenderGroupMask.All)]
        public RenderGroupMask RenderGroup { get; set; } = RenderGroupMask.All;

        public RenderStage RenderStage { get; set; }

        public string EffectName { get; set; }

        public override void Process(RenderObject renderObject)
        {
            if (RenderStage != null && ((RenderGroupMask)(1U << (int)renderObject.RenderGroup) & RenderGroup) != 0)
            {
                renderObject.ActiveRenderStages[RenderStage.Index] = new ActiveRenderStage(EffectName);
            }
        }
    }
}
