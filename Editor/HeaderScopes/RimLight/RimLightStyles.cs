using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using C = Hum.HumToonCore.Editor.Utils.Const;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;
using P = Hum.HumToonCore.Editor.HeaderScopes.RimLight.RimLightPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.RimLight
{
    public static class RimLightStyles
    {
        public static GUIContent RimLightFoldout =>
            EditorGUIUtility.TrTextContent(
                text: $"{L.Select(new string[] { "Rim Light", "リムライト", "边缘光" })}",
                tooltip: string.Empty);

        public static readonly GUIContent UseRimLight = EditorGUIUtility.TrTextContent(
            text: "Use Rim Light",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.UseRimLight).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{RimLightKeywordNames._HUM_USE_RIM_LIGHT}");

        public static readonly GUIContent RimLightMap = EditorGUIUtility.TrTextContent(
            text: "Rim Light Map (RGB)",
            tooltip: $"{C.Properties}{C.Ln}" +
                     $"{nameof(P.RimLightMap).Prefix()}{C.Ln}" +
                     $"{nameof(P.RimLightColor).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{RimLightKeywordNames._HUM_USE_RIM_LIGHT_MAP}");

        public static readonly GUIContent RimLightIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.RimLightIntensity).Prefix()}");

        public static readonly GUIContent RimLightBorderPos = EditorGUIUtility.TrTextContent(
            text: "Border Pos",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.RimLightBorderPos).Prefix()}");

        public static readonly GUIContent RimLightBorderBlur = EditorGUIUtility.TrTextContent(
            text: "Border Blur",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.RimLightBorderBlur).Prefix()}");

        public static readonly GUIContent RimLightMainLightEffectiveness = EditorGUIUtility.TrTextContent(
            text: "Main Light Effectiveness",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.RimLightMainLightEffectiveness).Prefix()}");
    }
}
