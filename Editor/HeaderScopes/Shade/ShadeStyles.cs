using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using C = Hum.HumToonCore.Editor.Utils.Const;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;
using P = Hum.HumToonCore.Editor.HeaderScopes.Shade.ShadePropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.Shade
{
    public static class ShadeStyles
    {
        public static GUIContent ShadeFoldout =>
            EditorGUIUtility.TrTextContent(
                text: $"{L.Select(new string[] { "Shade", "陰", "背阴" })}",
                tooltip: string.Empty);

        public static readonly GUIContent ShadeBorderPos = EditorGUIUtility.TrTextContent(
            text: "Border Pos",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.ShadeBorderPos).Prefix()}");

        public static readonly GUIContent ShadeBorderBlur = EditorGUIUtility.TrTextContent(
            text: "Border Blur",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.ShadeBorderBlur).Prefix()}");
    }
}
