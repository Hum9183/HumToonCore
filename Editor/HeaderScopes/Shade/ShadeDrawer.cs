using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;

namespace Hum.HumToonCore.Editor.HeaderScopes.Shade
{
    public class ShadeDrawer : HeaderScopeDrawerBase<ShadePropertiesContainer>
    {
        public ShadeDrawer(ShadePropertiesContainer propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
            : base(propContainer, headerStyleFunc, expandable)
        {
        }

        protected override void DrawMain(MaterialEditor materialEditor)
        {
            materialEditor.ShaderProperty(PropContainer.ShadeBorderPos, ShadeStyles.ShadeBorderPos);
            materialEditor.ShaderProperty(PropContainer.ShadeBorderBlur, ShadeStyles.ShadeBorderBlur);
        }
    }
}
