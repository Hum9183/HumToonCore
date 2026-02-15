using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;

namespace Hum.HumToonCore.Editor.HeaderScopes.NormalOverride
{
    public class NormalOverrideDrawer : HeaderScopeDrawerBase<NormalOverridePropertiesContainer>
    {
        public NormalOverrideDrawer(NormalOverridePropertiesContainer propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
            : base(propContainer, headerStyleFunc, expandable)
        {
        }

        protected override void DrawMain(MaterialEditor materialEditor)
        {
            bool useNormalOverride = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseNormalOverride, NormalOverrideStyles.UseNormalOverride);
            if (useNormalOverride)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    HumToonGUIUtils.TextureAndRangePropertiesSingleLine(
                        materialEditor,
                        PropContainer.NormalOverrideMask,
                        PropContainer.NormalOverrideIntensity,
                        NormalOverrideStyles.NormalOverrideMask);
                    HumToonGUIUtils.DrawFloat3Property(PropContainer.NormalOverrideDirection, NormalOverrideStyles.NormalOverrideDirection);
                }
            }
        }
    }
}
