using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using C = Hum.HumToonCore.Editor.Utils.Const;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;
using P = Hum.HumToonCore.Editor.HeaderScopes.PbrParameters.PbrParametersPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.PbrParameters
{
    /// <summary>
    /// Container for the text and tooltips used to display the shader.
    /// </summary>
    public static class PbrParametersStyles
    {
        public static GUIContent PbrParametersFoldout =>
            EditorGUIUtility.TrTextContent(
                text: $"{L.Select(new string[] { "PBR Parameters", "PBRパラメーター", "PBR Parameters" })}",
                tooltip: string.Empty);

        public static readonly GUIContent Smoothness = EditorGUIUtility.TrTextContent(
            text: "Smoothness",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.Smoothness).Prefix()}");

        public static readonly GUIContent Metallic = EditorGUIUtility.TrTextContent(
            text: "Metallic",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.Metallic).Prefix()}");
    }
}
