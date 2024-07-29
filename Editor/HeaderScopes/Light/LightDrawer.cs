using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;

namespace Hum.HumToonCore.Editor.HeaderScopes.Light
{
    public class LightDrawer : HeaderScopeDrawerBase<LightPropertiesContainer>
    {
        public LightDrawer(LightPropertiesContainer propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
            : base(propContainer, headerStyleFunc, expandable)
        {
        }

        protected override void DrawMain(MaterialEditor materialEditor)
        {
            DrawMainLight(materialEditor);
            HumToonGUIUtils.Space();
            DrawAdditionalLights(materialEditor);
        }

        private void DrawMainLight(MaterialEditor materialEditor)
        {
            EditorGUILayout.LabelField("Main Light", EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope())
            {
                materialEditor.ShaderProperty(PropContainer.MainLightColorWeight, LightStyles.MainLightColorWeight);
                HumToonGUIUtils.FloatToggleAndRangePropertiesSingleLine(materialEditor,PropContainer.UseMainLightUpperLimit, PropContainer.MainLightUpperLimit, LightStyles.MainLightUpperLimit);
                HumToonGUIUtils.FloatToggleAndRangePropertiesSingleLine(materialEditor,PropContainer.UseMainLightLowerLimit, PropContainer.MainLightLowerLimit, LightStyles.MainLightLowerLimit);
                HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseMainLightCookieAsShade, LightStyles.UseMainLightCookieAsShade);
            }
        }

        private void DrawAdditionalLights(MaterialEditor materialEditor)
        {
            EditorGUILayout.LabelField("Additional Lights", EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope())
            {
                materialEditor.ShaderProperty(PropContainer.AdditionalLightsColorWeight, LightStyles.AdditionalLightsColorWeight);
            }
        }
    }
}
