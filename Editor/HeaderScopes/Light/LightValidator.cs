using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using P = Hum.HumToonCore.Editor.HeaderScopes.Light.LightPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.Light
{
    public class LightValidator : IHeaderScopeValidator
    {
        private static readonly int IDUseMainLightCookieAsShade = Shader.PropertyToID(nameof(P.UseMainLightCookieAsShade).Prefix());
        private static readonly int IDUseMainLightSpecular = Shader.PropertyToID(nameof(P.UseMainLightSpecular).Prefix());
        private static readonly int IDUseAdditionalLightsSpecular = Shader.PropertyToID(nameof(P.UseAdditionalLightsSpecular).Prefix());
        private static readonly int IDReceiveGI = Shader.PropertyToID(nameof(P.ReceiveGI).Prefix());

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private void SetKeywords(Material material)
        {
            bool useMainLightCookieAsShade = material.GetFloat(IDUseMainLightCookieAsShade).ToBool();
            CoreUtils.SetKeyword(material, LightKeywordNames._HT_USE_MAIN_LIGHT_COOKIE_AS_SHADE, useMainLightCookieAsShade);

            bool useMainLightSpecular = material.GetFloat(IDUseMainLightSpecular).ToBool();
            CoreUtils.SetKeyword(material, LightKeywordNames._HT_USE_MAIN_LIGHT_SPECULAR, useMainLightSpecular);

            bool useAdditionalLightsSpecular = material.GetFloat(IDUseAdditionalLightsSpecular).ToBool();
            CoreUtils.SetKeyword(material, LightKeywordNames._HT_USE_ADDITIONAL_LIGHTS_SPECULAR, useAdditionalLightsSpecular);

            bool receiveGI = material.GetFloat(IDReceiveGI).ToBool();
            CoreUtils.SetKeyword(material, LightKeywordNames._HT_RECEIVE_GI, receiveGI);
        }
    }
}
