using Hum.HumToonCore.Editor.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using P = Hum.HumToonCore.Editor.HeaderScopes.GI.GIPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.GI
{
    public class GIValidator : IHeaderScopeValidator
    {
        private static readonly int IDReceiveGI = Shader.PropertyToID(nameof(P.ReceiveGI).Prefix());

        public void Validate(Material material)
        {
            SetKeywords(material);
        }

        private void SetKeywords(Material material)
        {
            bool receiveGI = material.GetFloat(IDReceiveGI).ToBool();
            CoreUtils.SetKeyword(material, GIKeywordNames._HUM_RECEIVE_GI, receiveGI);
        }
    }
}
