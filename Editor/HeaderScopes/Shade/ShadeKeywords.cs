#pragma warning disable CS0414

using System;
using System.Reflection;
using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using ID = Hum.HumToonCore.Editor.HeaderScopes.Shade.ShadePropertiesID;
// ReSharper disable InconsistentNaming

namespace Hum.HumToonCore.Editor.HeaderScopes.Shade
{
    public class ShadeKeywords
    {
        // Shade Mode
        private bool _HT_SHADE_MODE_POS_AND_BLUR;
        private bool _HT_SHADE_MODE_RAMP;

        // Pos And Blur
        private bool _HT_USE_FIRST_SHADE;
        private bool _HT_USE_FIRST_SHADE_MAP;
        private bool _HT_USE_EX_FIRST_SHADE;
        private bool _HT_USE_SECOND_SHADE;
        private bool _HT_USE_SECOND_SHADE_MAP;

        // Ramp
        private bool _HT_USE_RAMP_SHADE;

        // Control Map
        private bool _HT_USE_SHADE_CONTROL_MAP;

        public void Setup(Material material)
        {
            // WARNING: 呼び出し順に依存あり
            SetupShadeMode(material);
            SetupControlMap(material);
        }

        private void SetupShadeMode(Material material)
        {
            ShadeMode shadeMode = material.GetFloatEnum<ShadeMode>(ID.ShadeMode);
            switch (shadeMode)
            {
                case ShadeMode.PosAndBlur:
                    _HT_SHADE_MODE_POS_AND_BLUR = true;
                    SetupPosAndBlur();
                    break;
                case ShadeMode.Ramp:
                    _HT_SHADE_MODE_RAMP = true;
                    SetupRamp();
                    break;
                default:
                    throw new NotImplementedException(nameof(shadeMode));
            }

            return;

            void SetupPosAndBlur()
            {
                _HT_USE_FIRST_SHADE = material.GetFloat(ID.UseFirstShade).ToBool();
                _HT_USE_FIRST_SHADE_MAP = material.GetTexture(ID.FirstShadeMap) is not null;
                _HT_USE_EX_FIRST_SHADE = material.GetFloat(ID.UseExFirstShade).ToBool() && _HT_USE_FIRST_SHADE;
                _HT_USE_SECOND_SHADE = material.GetFloat(ID.UseSecondShade).ToBool();
                _HT_USE_SECOND_SHADE_MAP = material.GetTexture(ID.SecondShadeMap) is not null;
            }

            void SetupRamp()
            {
                bool useRampShade = material.GetFloat(ID.UseRampShade).ToBool();
                bool rampShadeMapExists = material.GetTexture(ID.RampShadeMap) is not null;
                _HT_USE_RAMP_SHADE = useRampShade && rampShadeMapExists;
            }
        }

        private void SetupControlMap(Material material)
        {
            bool useShadeControlMap = material.GetFloat(ID.UseShadeControlMap).ToBool();
            bool shadeControlMapExists = material.GetTexture(ID.ShadeControlMap) is not null;
            bool isAtLeastOneShadeValid = _HT_USE_FIRST_SHADE || _HT_USE_SECOND_SHADE || _HT_USE_RAMP_SHADE;
            _HT_USE_SHADE_CONTROL_MAP = useShadeControlMap && shadeControlMapExists && isAtLeastOneShadeValid;
        }

        public void SetToMaterial(Material material)
        {
            var fieldInfos = typeof(ShadeKeywords).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var fieldInfo in fieldInfos)
            {
                string keywordName = fieldInfo.Name;
                bool state = (bool)fieldInfo.GetValue(this);
                CoreUtils.SetKeyword(material, keywordName, state);
            }
        }
    }

}
