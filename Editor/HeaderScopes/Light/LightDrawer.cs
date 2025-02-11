using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;

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
            HumToonGUIUtils.Space();
            DrawGI(materialEditor);
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

                var useMainLightSpecular = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseMainLightSpecular, LightStyles.UseMainLightSpecular);
                if (useMainLightSpecular)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        materialEditor.ShaderProperty(PropContainer.MainLightSpecularIntensity, LightStyles.MainLightSpecularIntensity);
                    }
                }
            }
        }

        private void DrawAdditionalLights(MaterialEditor materialEditor)
        {
            EditorGUILayout.LabelField("Additional Lights", EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope())
            {
                materialEditor.ShaderProperty(PropContainer.AdditionalLightsColorWeight, LightStyles.AdditionalLightsColorWeight);

                var useAdditionalLightsSpecular = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseAdditionalLightsSpecular, LightStyles.UseAdditionalLightsSpecular);
                if (useAdditionalLightsSpecular)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        materialEditor.ShaderProperty(PropContainer.AdditionalLightsSpecularIntensity, LightStyles.AdditionalLightsSpecularIntensity);
                    }
                }
            }
        }

        private void DrawGI(MaterialEditor materialEditor)
        {
            EditorGUILayout.LabelField(L.Select(new[] { "GI", "GI", "全局光照" }), EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope())
            {
                var useMarCap = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveGI, LightStyles.ReceiveGI);
                if (useMarCap)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        materialEditor.ShaderProperty(PropContainer.GIColorWeight, LightStyles.GIColorWeight);
                    }
                }
            }
        }
    }
}
