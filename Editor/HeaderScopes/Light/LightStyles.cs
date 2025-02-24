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
                     $"{LightKeywordNames._HT_USE_MAIN_LIGHT_COOKIE_AS_SHADE}");

        public static readonly GUIContent UseMainLightSpecular = EditorGUIUtility.TrTextContent(
            text: "Use Specular",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.UseMainLightSpecular).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{LightKeywordNames._HT_USE_MAIN_LIGHT_SPECULAR}");

        public static readonly GUIContent MainLightSpecularIntensity = EditorGUIUtility.TrTextContent(
            "Intensity",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.MainLightSpecularIntensity).Prefix()}");

        public static readonly GUIContent AdditionalLightsColorWeight = EditorGUIUtility.TrTextContent(
            text: "Weight",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.AdditionalLightsColorWeight).Prefix()}");

        public static readonly GUIContent UseAdditionalLightsSpecular = EditorGUIUtility.TrTextContent(
            text: "Use Specular",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(P.UseAdditionalLightsSpecular).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{LightKeywordNames._HT_USE_ADDITIONAL_LIGHTS_SPECULAR}");

        public static readonly GUIContent AdditionalLightsSpecularIntensity = EditorGUIUtility.TrTextContent(
            "Intensity",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.AdditionalLightsSpecularIntensity).Prefix()}");

        public static readonly GUIContent ReceiveGI = EditorGUIUtility.TrTextContent(
            "Receive GI",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.ReceiveGI).Prefix()}{C.Ln}" +
            $"{C.Ln}" +
            $"{C.Keyword}{C.Ln}" +
            $"{LightKeywordNames._HT_RECEIVE_GI}");

        public static readonly GUIContent GIColorWeight = EditorGUIUtility.TrTextContent(
            "Weight",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.GIColorWeight).Prefix()}");

        public static readonly GUIContent UseSsao = EditorGUIUtility.TrTextContent(
            "Use SSAO",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.UseSsao).Prefix()}{C.Ln}" +
            $"{C.Ln}" +
            $"{C.Keyword}{C.Ln}" +
            $"{LightKeywordNames._HT_USE_SSAO}");

        public static readonly GUIContent SsaoWeight = EditorGUIUtility.TrTextContent(
            "Weight",
            $"{C.Property}{C.Ln}" +
            $"{nameof(P.SsaoWeight).Prefix()}");
    }
}
