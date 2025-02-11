using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using C = Hum.HumToonCore.Editor.Utils.Const;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;
using P = Hum.HumToonCore.Editor.HeaderScopes.Light.LightPropertiesContainer;

namespace Hum.HumToonCore.Editor.HeaderScopes.Light
{
    public static class LightStyles
    {
        public static GUIContent LightFoldout =>
            EditorGUIUtility.TrTextContent(
                text: $"{L.Select(new string[] { "Lighting", "ライティング", "光照" })}",
                tooltip: String.Empty);

        public static readonly GUIContent MainLightColorWeight = EditorGUIUtility.TrTextContent(
            text: "Weight",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.MainLightColorWeight).Prefix()}");

        public static readonly GUIContent MainLightUpperLimit = EditorGUIUtility.TrTextContent(
            text: "Upper Limit",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.UseMainLightUpperLimit).Prefix()}{C.Ln}" +
                     $"{nameof(P.MainLightUpperLimit).Prefix()}");

        public static readonly GUIContent MainLightLowerLimit = EditorGUIUtility.TrTextContent(
            text: "Lower Limit",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.UseMainLightLowerLimit).Prefix()}{C.Ln}" +
                     $"{nameof(P.MainLightLowerLimit).Prefix()}");

        public static readonly GUIContent UseMainLightCookieAsShade = EditorGUIUtility.TrTextContent(
            text: "Use Light Cookie As Shade",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.UseMainLightCookieAsShade).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{LightKeywordNames._HUM_USE_MAIN_LIGHT_COOKIE_AS_SHADE}");

        public static readonly GUIContent AdditionalLightsColorWeight = EditorGUIUtility.TrTextContent(
            text: "Weight",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.AdditionalLightsColorWeight).Prefix()}");

        public static readonly GUIContent ReceiveGI = EditorGUIUtility.TrTextContent(
            "Receive GI",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.ReceiveGI).Prefix()}{C.Ln}" +
            $"{C.Ln}" +
            $"{C.Keyword}{C.Ln}" +
            $"{LightKeywordNames._HUM_RECEIVE_GI}");

        public static readonly GUIContent GIColorWeight = EditorGUIUtility.TrTextContent(
            "Weight",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.GIColorWeight).Prefix()}");
    }
}
