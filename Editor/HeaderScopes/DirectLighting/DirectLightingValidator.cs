using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;

namespace Hum.HumToonCore.Editor.HeaderScopes.DirectLighting
{
    public class DirectLightingValidator : IHeaderScopeValidator
    {
        private static readonly int IDReceiveMainLightDiffuse = Shader.PropertyToID(nameof(DirectLightingPropertiesContainer.ReceiveMainLightDiffuse).Prefix());
        private static readonly int IDReceiveMainLightSpecular = Shader.PropertyToID(nameof(DirectLightingPropertiesContainer.ReceiveMainLightSpecular).Prefix());
        private static readonly int IDReceiveAdditionalLightsDiffuse = Shader.PropertyToID(nameof(DirectLightingPropertiesContainer.ReceiveAdditionalLightsDiffuse).Prefix());
        private static readonly int IDReceiveAdditionalLightsSpecular = Shader.PropertyToID(nameof(DirectLightingPropertiesContainer.ReceiveAdditionalLightsSpecular).Prefix());

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private void SetKeywords(Material material)
        {
            bool receiveMainLightDiffuse = material.GetFloat(IDReceiveMainLightDiffuse).ToBool();
            CoreUtils.SetKeyword(material, DirectLightingKeywordNames._HT_RECEIVE_MAIN_LIGHT_DIFFUSE, receiveMainLightDiffuse);

            bool receiveMainLightSpecular = material.GetFloat(IDReceiveMainLightSpecular).ToBool();
            CoreUtils.SetKeyword(material, DirectLightingKeywordNames._HT_RECEIVE_MAIN_LIGHT_SPECULAR, receiveMainLightSpecular);

            bool receiveAdditionalLightsDiffuse = material.GetFloat(IDReceiveAdditionalLightsDiffuse).ToBool();
            CoreUtils.SetKeyword(material, DirectLightingKeywordNames._HT_RECEIVE_ADDITIONAL_LIGHTS_DIFFUSE, receiveAdditionalLightsDiffuse);

            bool receiveAdditionalLightsSpecular = material.GetFloat(IDReceiveAdditionalLightsSpecular).ToBool();
            CoreUtils.SetKeyword(material, DirectLightingKeywordNames._HT_RECEIVE_ADDITIONAL_LIGHTS_SPECULAR, receiveAdditionalLightsSpecular);
        }
    }
}
