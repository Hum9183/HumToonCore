using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;

namespace Hum.HumToonCore.Editor.HeaderScopes.IndirectLighting
{
    public class IndirectLightingValidator : IHeaderScopeValidator
    {
        private static readonly int IDReceiveIndirectDiffuse = Shader.PropertyToID(nameof(IndirectLightingPropertiesContainer.ReceiveIndirectDiffuse).Prefix());
        private static readonly int IDReceiveIndirectSpecular = Shader.PropertyToID(nameof(IndirectLightingPropertiesContainer.ReceiveIndirectSpecular).Prefix());
        private static readonly int IDReceiveSsao = Shader.PropertyToID(nameof(IndirectLightingPropertiesContainer.ReceiveSsao).Prefix());

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private void SetKeywords(Material material)
        {
            bool receiveIndirectDiffuse = material.GetFloat(IDReceiveIndirectDiffuse).ToBool();
            CoreUtils.SetKeyword(material, IndirectLightingKeywordNames._HT_RECEIVE_INDIRECT_DIFFUSE, receiveIndirectDiffuse);

            bool receiveIndirectSpecular = material.GetFloat(IDReceiveIndirectSpecular).ToBool();
            CoreUtils.SetKeyword(material, IndirectLightingKeywordNames._HT_RECEIVE_INDIRECT_SPECULAR, receiveIndirectSpecular);

            bool receiveSsao = material.GetFloat(IDReceiveSsao).ToBool();
            CoreUtils.SetKeyword(material, IndirectLightingKeywordNames._HT_RECEIVE_SSAO, receiveSsao); }
    }
}
