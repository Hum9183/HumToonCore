using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using P = Hum.HumToonCore.Editor.HeaderScopes.Emission.EmissionPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.Emission
{
    public class EmissionValidator : IHeaderScopeValidator
    {
        private static readonly int IDUseEmission = Shader.PropertyToID($"{nameof(P.UseEmission).Prefix()}");
        private static readonly int IDEmissionMap = Shader.PropertyToID($"{nameof(P.EmissionMap).Prefix()}");
        private static readonly int IDOverrideEmissionColor = Shader.PropertyToID($"{nameof(P.OverrideEmissionColor).Prefix()}");

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private void SetKeywords(Material material)
        {
            bool useEmission = material.GetFloat(IDUseEmission).ToBool();
            CoreUtils.SetKeyword(material, EmissionKeywordNames._HUM_USE_EMISSION, useEmission);

            bool emissionMapExists = material.GetTexture(IDEmissionMap) is not null;
            CoreUtils.SetKeyword(material, EmissionKeywordNames._HUM_USE_EMISSION_MAP, emissionMapExists && useEmission);

            bool overrideEmissionColor = material.GetFloat(IDOverrideEmissionColor).ToBool();
            CoreUtils.SetKeyword(material, EmissionKeywordNames._HUM_OVERRIDE_EMISSION_COLOR, overrideEmissionColor && useEmission);
        }
    }
}
