using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using P = Hum.HumToonCore.Editor.HeaderScopes.Light.LightPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.Light
{
    public class LightValidator : IHeaderScopeValidator
    {
        private static readonly int IDUseMainLightCookieAsShade = Shader.PropertyToID(nameof(P.UseMainLightCookieAsShade).Prefix());

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private void SetKeywords(Material material)
        {
            bool useMainLightCookieAsShade = material.GetFloat(IDUseMainLightCookieAsShade).ToBool();
            CoreUtils.SetKeyword(material, LightKeywordNames._HUM_USE_MAIN_LIGHT_COOKIE_AS_SHADE, useMainLightCookieAsShade);
        }
    }
}
