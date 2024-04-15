using UnityEngine;

namespace Hum.HumToonCore.Editor.Archives.URPBased
{
    public static class GraphUtil
    {
        public static bool IsShaderGraph(this Material material)
        {
            var shaderGraphTag = material.GetTag("ShaderGraphShader", false, null);
            return !string.IsNullOrEmpty(shaderGraphTag);
        }
    }

    internal enum Expandable
    {
        /// <summary>
        /// Use this for surface options foldout.
        /// </summary>
        SurfaceOptions = 1 << 0,

        /// <summary>
        /// Use this for surface input foldout.
        /// </summary>
        SurfaceInputs = 1 << 1,

        /// <summary>
        /// Use this for advanced foldout.
        /// </summary>
        Advanced = 1 << 2,

        /// <summary>
        /// Use this for additional details foldout.
        /// </summary>
        Details = 1 << 3,
    }

    /// <summary>
    /// The surface type for your object.
    /// </summary>
    public enum SurfaceType
    {
        /// <summary>
        /// Use this for opaque surfaces.
        /// </summary>
        Opaque,

        /// <summary>
        /// Use this for transparent surfaces.
        /// </summary>
        Transparent
    }

    /// <summary>
    /// The blend mode for your material.
    /// </summary>
    public enum BlendMode
    {
        /// <summary>
        /// Use this for alpha blend mode.
        /// </summary>
        Alpha,   // Old school alpha-blending mode, fresnel does not affect amount of transparency

        /// <summary>
        /// Use this for premultiply blend mode.
        /// </summary>
        Premultiply, // Physically plausible transparency mode, implemented as alpha pre-multiply

        /// <summary>
        /// Use this for additive blend mode.
        /// </summary>
        Additive,

        /// <summary>
        /// Use this for multiply blend mode.
        /// </summary>
        Multiply
    }

    /// <summary>
    /// Options to select the texture channel where the smoothness value is stored.
    /// </summary>
    public enum HumToggle
    {
        /// <summary>
        /// Use this when smoothness is stored in the alpha channel of the specular map.
        /// </summary>
        Off,

        /// <summary>
        /// Use this when smoothness is stored in the alpha channel of the base map.
        /// </summary>
        On
    }

    /// <summary>
    /// The face options to render your geometry.
    /// </summary>
    public enum RenderFace
    {
        /// <summary>
        /// Use this to render only front face.
        /// </summary>
        Front = 2,

        /// <summary>
        /// Use this to render only back face.
        /// </summary>
        Back = 1,

        /// <summary>
        /// Use this to render both faces.
        /// </summary>
        Both = 0
    }

    /// <summary>
    /// The options for controlling the render queue.
    /// </summary>
    public enum QueueControl
    {
        /// <summary>
        /// Use this to select automatic behavior.
        /// </summary>
        Auto = 0,

        /// <summary>
        /// Use this for explicitly selecting a render queue.
        /// </summary>
        UserOverride = 1
    }

    /// <summary>
    /// Options for the material type.
    /// </summary>
    public enum MaterialType
    {
        /// <summary>
        /// Use this for URP lit.
        /// </summary>
        Lit,

        /// <summary>
        /// Use this for URP unlit.
        /// </summary>
        Unlit,

        /// <summary>
        /// Use this for sprite lit.
        /// </summary>
        SpriteLit,

        /// <summary>
        /// Use this for Sprite unlit.
        /// </summary>
        SpriteUnlit,
    }

    /// <summary>
    /// Workflow modes for the shader.
    /// </summary>
    public enum WorkflowMode
    {
        /// <summary>
        /// Use this for specular workflow.
        /// </summary>
        Specular,

        /// <summary>
        /// Use this for metallic workflow.
        /// </summary>
        Metallic,
    }

    enum ZWriteControl
    {
        Auto = 0,
        ForceEnabled = 1,
        ForceDisabled = 2
    }

    enum ZTestMode  // the values here match UnityEngine.Rendering.CompareFunction
    {
        Disabled = 0,
        Never = 1,
        Less = 2,
        Equal = 3,
        LEqual = 4,     // default for most rendering
        Greater = 5,
        NotEqual = 6,
        GEqual = 7,
        Always = 8,
    }

    enum AlphaMode
    {
        Alpha,
        Premultiply,
        Additive,
        Multiply,
    }
}
