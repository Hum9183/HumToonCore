using System;
using Hum.HumToonCore.Editor.Utils;
using UnityEditor;
using UnityEngine;
using C = Hum.HumToonCore.Editor.Utils.Const;
using L = Hum.HumToonCore.Editor.Language.LanguageSelector;

namespace Hum.HumToonCore.Editor.HeaderScopes.IndirectLighting
{
    public static class IndirectLightingtyles
    {
        public static GUIContent IndirectLightingFoldout =>
            EditorGUIUtility.TrTextContent(
                text: $"{L.Select(new string[] { "Indirect Lighting(GI)", "間接光(GI)", "间接光照(GI)" })}",
                tooltip: String.Empty);

        public static readonly GUIContent IndirectLightIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(IndirectLightingPropertiesContainer.IndirectLightIntensity).Prefix()}");

        public static readonly GUIContent ReceiveIndirectDiffuse = EditorGUIUtility.TrTextContent(
            text: "Receive Diffuse",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(IndirectLightingPropertiesContainer.ReceiveIndirectDiffuse).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{IndirectLightingKeywordNames._HT_RECEIVE_INDIRECT_DIFFUSE}");

        public static readonly GUIContent IndirectDiffuseIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(IndirectLightingPropertiesContainer.IndirectDiffuseIntensity).Prefix()}");

        public static readonly GUIContent ReceiveIndirectSpecular = EditorGUIUtility.TrTextContent(
            text: "Receive Specular",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(IndirectLightingPropertiesContainer.ReceiveIndirectSpecular).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{IndirectLightingKeywordNames._HT_RECEIVE_INDIRECT_SPECULAR}");

        public static readonly GUIContent IndirectSpecularIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(IndirectLightingPropertiesContainer.IndirectSpecularIntensity).Prefix()}");

        public static readonly GUIContent ReceiveSsao = EditorGUIUtility.TrTextContent(
            text: "Receive SSAO",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(IndirectLightingPropertiesContainer.ReceiveSsao).Prefix()}{C.Ln}" +
                     $"{C.Ln}" +
                     $"{C.Keyword}{C.Ln}" +
                     $"{IndirectLightingKeywordNames._HT_RECEIVE_SSAO}");

        public static readonly GUIContent SsaoIntensity = EditorGUIUtility.TrTextContent(
            text: "Intensity",
            tooltip: $"{C.Property}{C.Ln}" +
                     $"{nameof(IndirectLightingPropertiesContainer.SsaoIntensity).Prefix()}");
    }
}
