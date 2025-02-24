using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;

namespace Hum.HumToonCore.Editor.HeaderScopes.DirectLighting
{
    public class DirectLightingDrawer : HeaderScopeDrawerBase<DirectLightingPropertiesContainer>
    {
        public DirectLightingDrawer(DirectLightingPropertiesContainer propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
            : base(propContainer, headerStyleFunc, expandable)
        {
        }

        protected override void DrawMain(MaterialEditor materialEditor)
        {
            DrawDirectLightIntensity(materialEditor);
            HumToonGUIUtils.Space();
            DrawMainLight(materialEditor);
            HumToonGUIUtils.Space();
            DrawAdditionalLights(materialEditor);
        }

        private void DrawDirectLightIntensity(MaterialEditor materialEditor)
        {
            var receiveMainLightDiffuse = HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveMainLightDiffuse);
            var receiveMainLightSpecular = HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveMainLightSpecular);
            var receiveAdditionalLightsDiffuse = HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveAdditionalLightsDiffuse);
            var receiveAdditionalLightsSpecular = HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveAdditionalLightsSpecular);
            var directLightEnabled = receiveMainLightDiffuse
                                     || receiveMainLightSpecular
                                     || receiveAdditionalLightsDiffuse
                                     || receiveAdditionalLightsSpecular;
            using (new EditorGUI.DisabledScope(!directLightEnabled))
            {
                materialEditor.ShaderProperty(PropContainer.DirectLightIntensity, DirectLightingtyles.DirectLightIntensity);
            }
        }

        private void DrawMainLight(MaterialEditor materialEditor)
        {
            EditorGUILayout.LabelField("Main Light", EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope())
            {
                var receiveMainLightDiffuse =
                    HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveMainLightDiffuse);
                var receiveMainLightSpecular =
                    HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveMainLightSpecular);
                using (new EditorGUI.DisabledScope(!(receiveMainLightDiffuse || receiveMainLightSpecular)))
                {

                    materialEditor.ShaderProperty(PropContainer.MainLightIntensity, DirectLightingtyles.MainLightIntensity);
                }

                HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveMainLightDiffuse,
                    DirectLightingtyles.ReceiveMainLightDiffuse);
                if (receiveMainLightDiffuse)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        materialEditor.ShaderProperty(PropContainer.MainLightDiffuseIntensity,
                            DirectLightingtyles.MainLightDiffuseIntensity);
                    }
                }

                HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveMainLightSpecular,
                    DirectLightingtyles.ReceiveMainLightSpecular);
                if (receiveMainLightSpecular)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        materialEditor.ShaderProperty(PropContainer.MainLightSpecularIntensity,
                            DirectLightingtyles.MainLightSpecularIntensity);
                    }
                }
            }
        }

        private void DrawAdditionalLights(MaterialEditor materialEditor)
        {
            EditorGUILayout.LabelField("Additional Lights", EditorStyles.boldLabel);

            using (new EditorGUI.IndentLevelScope())
            {
                var receiveAdditionalLightsDiffuse =
                    HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveAdditionalLightsDiffuse);
                var receiveAdditionalLightsSpecular =
                    HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveAdditionalLightsSpecular);
                using (new EditorGUI.DisabledScope(!(receiveAdditionalLightsDiffuse ||
                                                     receiveAdditionalLightsSpecular)))
                {
                    materialEditor.ShaderProperty(PropContainer.AdditionalLightsIntensity,
                        DirectLightingtyles.AdditionalLightsIntensity);
                }

                HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveAdditionalLightsDiffuse,
                    DirectLightingtyles.ReceiveAdditionalLightsDiffuse);
                if (receiveAdditionalLightsDiffuse)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        materialEditor.ShaderProperty(PropContainer.AdditionalLightsDiffuseIntensity,
                            DirectLightingtyles.AdditionalLightsDiffuseIntensity);
                    }
                }

                HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveAdditionalLightsSpecular,
                    DirectLightingtyles.ReceiveAdditionalLightsSpecular);
                if (receiveAdditionalLightsSpecular)
                {
                    using (new EditorGUI.IndentLevelScope())
                    {
                        materialEditor.ShaderProperty(PropContainer.AdditionalLightsSpecularIntensity,
                            DirectLightingtyles.AdditionalLightsSpecularIntensity);
                    }
                }
            }
        }
    }
}
