using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using C = Hum.HumToonCore.Editor.Utils.Const;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;
using P = Hum.HumToonCore.Editor.HeaderScopes.GI.GIPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.GI
{
    public static class GIStyles
    {
        public static GUIContent GIFoldout =>
            EditorGUIUtility.TrTextContent(
                $"{L.Select(new[] { "GI", "GI", "全局光照" })}",
                $"{C.Description}{C.Ln}" +
                "Controls the effect of Global illumination");

        public static readonly GUIContent ReceiveGI = EditorGUIUtility.TrTextContent(
            "Receive GI",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.ReceiveGI).Prefix()}{C.Ln}" +
            $"{C.Ln}" +
            $"{C.Keyword}{C.Ln}" +
            $"{GIKeywordNames._HUM_RECEIVE_GI}");

        public static readonly GUIContent GIColorWeight = EditorGUIUtility.TrTextContent(
            "Weight",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.GIColorWeight).Prefix()}");
    }
}
