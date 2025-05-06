using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;

namespace Hum.HumToonCore.Editor.HeaderScopes.PbrParameters
{
    public class PbrParametersDrawer : HeaderScopeDrawerBase<PbrParametersPropertiesContainer>
    {
        public PbrParametersDrawer(PbrParametersPropertiesContainer propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
            : base(propContainer, headerStyleFunc, expandable)
        {
        }

        protected override void DrawMain(MaterialEditor materialEditor)
        {
            materialEditor.ShaderProperty(PropContainer.Smoothness, PbrParametersStyles.Smoothness);
            materialEditor.ShaderProperty(PropContainer.Metallic, PbrParametersStyles.Metallic);
        }
    }
}
