using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using C = Hum.HumToonCore.Editor.Utils.Const;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;

namespace Hum.HumToonCore.Editor.HeaderScopes.DirectLighting
{
    public static class DirectLightingtyles
    {
        public static GUIContent DirectLightingFoldout =>
            EditorGUIUtility.TrTextContent(
                text: $"{L.Select(new string[] { "Direct Lighting", "直接光", "直接光照" })}",
                tooltip: String.Empty);

        public static readonly GUIContent DirectLightIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.DirectLightIntensity).Prefix()}");

        public static readonly GUIContent MainLightIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.MainLightIntensity).Prefix()}");

        public static readonly GUIContent ReceiveMainLightDiffuse = EditorGUIUtility.TrTextContent(
            text: "Receive Diffuse",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.ReceiveMainLightDiffuse).Prefix()}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{DirectLightingKeywordNames._HT_RECEIVE_MAIN_LIGHT_DIFFUSE}");

        public static readonly GUIContent MainLightDiffuseIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.MainLightDiffuseIntensity).Prefix()}");

        public static readonly GUIContent ReceiveMainLightSpecular = EditorGUIUtility.TrTextContent(
            text: "Receive Specular",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.ReceiveMainLightSpecular).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{DirectLightingKeywordNames._HT_RECEIVE_MAIN_LIGHT_SPECULAR}");

        public static readonly GUIContent MainLightSpecularIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.MainLightSpecularIntensity).Prefix()}");

        public static readonly GUIContent AdditionalLightsIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.AdditionalLightsIntensity).Prefix()}");

        public static readonly GUIContent ReceiveAdditionalLightsDiffuse = EditorGUIUtility.TrTextContent(
            text: "Receive Diffuse",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.ReceiveAdditionalLightsDiffuse).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{DirectLightingKeywordNames._HT_RECEIVE_ADDITIONAL_LIGHTS_DIFFUSE}");

        public static readonly GUIContent AdditionalLightsDiffuseIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.AdditionalLightsDiffuseIntensity).Prefix()}");

        public static readonly GUIContent ReceiveAdditionalLightsSpecular = EditorGUIUtility.TrTextContent(
            text: "Receive Specular",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.ReceiveAdditionalLightsSpecular).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{DirectLightingKeywordNames._HT_RECEIVE_ADDITIONAL_LIGHTS_SPECULAR}");

        public static readonly GUIContent AdditionalLightsSpecularIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(DirectLightingPropertiesContainer.AdditionalLightsSpecularIntensity).Prefix()}");
    }
}
