using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;

namespace Hum.HumToonCore.Editor.HeaderScopes.IndirectLighting
{
    public class IndirectLightingDrawer : HeaderScopeDrawerBase<IndirectLightingPropertiesContainer>
    {
        public IndirectLightingDrawer(IndirectLightingPropertiesContainer propContainer, Func<GUIContent> headerStyleFunc, uint expandable)
            : base(propContainer, headerStyleFunc, expandable)
        {
        }

        protected override void DrawMain(MaterialEditor materialEditor)
        {
            DrawDirectLightIntensity(materialEditor);
            HumToonGUIUtils.Space();
            DrawIndirect(materialEditor);
            HumToonGUIUtils.Space();
            DrawSsao(materialEditor);
        }

        private void DrawDirectLightIntensity(MaterialEditor materialEditor)
        {
            var receiveIndirectDiffuse = HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveIndirectDiffuse);
            var receiveIndirectSpecular = HumToonGUIUtils.GetFloatToggleProperty(PropContainer.ReceiveIndirectSpecular);
            using (new EditorGUI.DisabledScope(!(receiveIndirectDiffuse || receiveIndirectSpecular)))
            {
                materialEditor.ShaderProperty(PropContainer.IndirectLightIntensity, IndirectLightingtyles.IndirectLightIntensity);
            }
        }

        private void DrawIndirect(MaterialEditor materialEditor)
        {
            EditorGUILayout.LabelField("Indirect", EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope())
            {
                var receiveIndirectDiffuse = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveIndirectDiffuse, IndirectLightingtyles.ReceiveIndirectDiffuse);
                if (receiveIndirectDiffuse)
                {
                    materialEditor.ShaderProperty(PropContainer.IndirectDiffuseIntensity, IndirectLightingtyles.IndirectDiffuseIntensity);
                }

                var receiveIndirectSpecular = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveIndirectSpecular, IndirectLightingtyles.ReceiveIndirectSpecular);
                if (receiveIndirectSpecular)
                {
                    materialEditor.ShaderProperty(PropContainer.IndirectSpecularIntensity, IndirectLightingtyles.IndirectSpecularIntensity);
                }
            }
        }

        private void DrawSsao(MaterialEditor materialEditor)
        {
            EditorGUILayout.LabelField("SSAO", EditorStyles.boldLabel);

            using (new EditorGUI.IndentLevelScope())
            {
                var receiveSsao = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.ReceiveSsao, IndirectLightingtyles.ReceiveSsao);
                if (receiveSsao)
                {
                    materialEditor.ShaderProperty(PropContainer.SsaoIntensity, IndirectLightingtyles.SsaoIntensity);
                }
            }
        }
    }
}
