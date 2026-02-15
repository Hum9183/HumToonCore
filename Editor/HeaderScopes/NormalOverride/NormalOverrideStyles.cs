using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using C = Hum.HumToonCore.Editor.Utils.Const;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;
using P = Hum.HumToonCore.Editor.HeaderScopes.NormalOverride.NormalOverridePropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.NormalOverride
{
    public static class NormalOverrideStyles
    {
        public static GUIContent NormalOverrideFoldout =>
            EditorGUIUtility.TrTextContent(
                text: $"{L.Select(new string[] { "Normal Override", "法線オーバーライド", "" })}",
                tooltip: string.Empty);

        public static readonly GUIContent UseNormalOverride = EditorGUIUtility.TrTextContent(
            text: "Use Normal Override",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.UseNormalOverride).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{NormalOverrideKeywordNames._HT_USE_NORMAL_OVERRIDE}");

        public static readonly GUIContent NormalOverrideMask = EditorGUIUtility.TrTextContent(
            text: "Normal Override Mask (R)",
            tooltip: $"{C.Description}{C.Ln}" +
                     $"Target region mask. R channel is used. White = override area.{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Property}{C.Ln}" +
                     $"{nameof(P.NormalOverrideMask).Prefix()}");

        public static readonly GUIContent NormalOverrideDirection = EditorGUIUtility.TrTextContent(
            text: "Override Direction",
            tooltip: $"{C.Description}{C.Ln}" +
                     $"Direction to override normal to (in object space).{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Property}{C.Ln}" +
                     $"{nameof(P.NormalOverrideDirection).Prefix()}");

        public static readonly GUIContent NormalOverrideIntensity = EditorGUIUtility.TrTextContent(
            text: "Override Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.NormalOverrideIntensity).Prefix()}");
    }
}
