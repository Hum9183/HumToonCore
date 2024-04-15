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

        protected override void DrawInternal(MaterialEditor materialEditor)
        {
            ShadeMode shadeMode = HumToonGUIUtils.DoPopup<ShadeMode>(materialEditor, PropContainer.ShadeMode, ShadeStyles.ShadeMode);

            switch (shadeMode)
            {
                case ShadeMode.PosAndBlur:
                    DrawPosAndBlur(materialEditor);
                    break;
                case ShadeMode.Ramp:
                    DrawRamp(materialEditor);
                    break;
                default:
                    throw new NotImplementedException(nameof(shadeMode));
            }

            DrawControlMap(materialEditor);
        }

        private void DrawPosAndBlur(MaterialEditor materialEditor)
        {
            bool useFirstShade = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseFirstShade, ShadeStyles.UseFirstShade);
            if (useFirstShade)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    materialEditor.TexturePropertySingleLine(ShadeStyles.FirstShadeMap, PropContainer.FirstShadeMap, PropContainer.FirstShadeColor);
                    materialEditor.ShaderProperty(PropContainer.FirstShadeBorderPos, ShadeStyles.FirstShadeBorderPos);
                    materialEditor.ShaderProperty(PropContainer.FirstShadeBorderBlur, ShadeStyles.FirstShadeBorderBlur);

                    bool useExFirstShade = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseExFirstShade, ShadeStyles.UseExFirstShade);
                    if (useExFirstShade)
                    {
                        using (new EditorGUI.IndentLevelScope())
                        {
                            materialEditor.ShaderProperty(PropContainer.ExFirstShadeColor, ShadeStyles.ExFirstShadeColor);
                            materialEditor.ShaderProperty(PropContainer.ExFirstShadeWidth, ShadeStyles.ExFirstShadeWidth);
                        }
                    }
                }
                HumToonGUIUtils.Space();
            }

            bool useSecondShade = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseSecondShade, ShadeStyles.UseSecondShade);
            if (useSecondShade)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    materialEditor.TexturePropertySingleLine(ShadeStyles.SecondShadeMap, PropContainer.SecondShadeMap, PropContainer.SecondShadeColor);
                    materialEditor.ShaderProperty(PropContainer.SecondShadeBorderPos, ShadeStyles.SecondShadeBorderPos);
                    materialEditor.ShaderProperty(PropContainer.SecondShadeBorderBlur, ShadeStyles.SecondShadeBorderBlur);
                }
                HumToonGUIUtils.Space();
            }
        }

        private void DrawRamp(MaterialEditor materialEditor)
        {
            bool useRampShade = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseRampShade, ShadeStyles.UseRampShade);
            if (useRampShade)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    materialEditor.TexturePropertySingleLine(ShadeStyles.RampShadeMap, PropContainer.RampShadeMap);
                }
            }
        }

        private void DrawControlMap(MaterialEditor materialEditor)
        {
            bool useShadeControlMap = HumToonGUIUtils.DrawFloatToggleProperty(PropContainer.UseShadeControlMap, ShadeStyles.UseShadeControlMap);
            if (useShadeControlMap)
            {
                using (new EditorGUI.IndentLevelScope())
                {
                    materialEditor.TexturePropertySingleLine(ShadeStyles.ShadeControlMap, PropContainer.ShadeControlMap, PropContainer.ShadeControlMapIntensity);
                }
            }
        }
    }
}
