using System;
using System.Collections.Generic;
using System.Linq;
using Hum.HumToonCore.Editor.HeaderScopes.Base;
using Hum.HumToonCore.Editor.HeaderScopes.Emission;
using Hum.HumToonCore.Editor.HeaderScopes.DirectLighting;
using Hum.HumToonCore.Editor.HeaderScopes.IndirectLighting;
using Hum.HumToonCore.Editor.HeaderScopes.MatCap;
using Hum.HumToonCore.Editor.HeaderScopes.Normal;
using Hum.HumToonCore.Editor.HeaderScopes.PbrParameters;
using Hum.HumToonCore.Editor.HeaderScopes.RimLight;
using Hum.HumToonCore.Editor.HeaderScopes.Shade;
using Hum.HumToonCore.Editor.HeaderScopes.SurfaceOptions;
using Hum.HumToonCore.Editor.Utils;

namespace Hum.HumToonCore.Editor.HeaderScopes
{
    // TODO: VContainer等のライブラリを使用することを検討
    public class HeaderScopeFactory
    {
        public IEnumerable<IHeaderScopeDrawer> CreateDrawers()
        {
            var scopes = CreateHeaderScopes();
            return scopes
                .Select(x => x.drawer)
                .Where(HumToonUtils.IsNotNull);
        }

        public IEnumerable<IHeaderScopeValidator> CreateValidators()
        {
            var scopes = CreateHeaderScopes();
            return scopes
                .Select(x => x.validator)
                .Where(HumToonUtils.IsNotNull);
        }

        private IEnumerable<(IHeaderScopeDrawer drawer, IHeaderScopeValidator validator)>
            CreateHeaderScopes()
        {
            return new List<(IHeaderScopeDrawer, IHeaderScopeValidator)>
            {
                (CreateSurfaceOptionsDrawer(), new SurfaceOptionsValidator()),
                (CreateBaseDrawer(), null),
                (CreatePbrParametersDrawer(), null),
                (CreateNormalDrawer(), new NormalValidator()),
                (CreateShadeDrawer(), new ShadeValidator()),
                (CreateRimLightDrawer(), new RimLightValidator()),
                (CreateEmissionDrawer(), new EmissionValidator()),
                (CreateMatCapDrawer(), new MatCapValidator()),
                (CreateDirectLightingDrawer(), new DirectLightingValidator()),
                (CreateIndirectLightingDrawer(), new IndirectLightingValidator()),
            };
        }

        private SurfaceOptionsDrawer CreateSurfaceOptionsDrawer()
        {
            return new SurfaceOptionsDrawer(
                new SurfaceOptionsPropertiesContainer(),
                () => SurfaceOptionsStyles.SurfaceOptionsFoldout,
                Convert.ToUInt32(Expandable.SurfaceOptions));
        }

        private BaseDrawer CreateBaseDrawer()
        {
            return new BaseDrawer(
                new BasePropertiesContainer(),
                () => BaseStyles.SurfaceInputsFoldout,
                Convert.ToUInt32(Expandable.Base));
        }

        private PbrParametersDrawer CreatePbrParametersDrawer()
        {
            return new PbrParametersDrawer(
                new PbrParametersPropertiesContainer(),
                () => PbrParametersStyles.PbrParametersFoldout,
                Convert.ToUInt32(Expandable.PbrParameters));
        }

        private NormalDrawer CreateNormalDrawer()
        {
            return new NormalDrawer(
                new NormalPropertiesContainer(),
                () => NormalStyles.NormalFoldout,
                Convert.ToUInt32(Expandable.Normal));
        }

        private ShadeDrawer CreateShadeDrawer()
        {
            return new ShadeDrawer(
                new ShadePropertiesContainer(),
                () => ShadeStyles.ShadeFoldout,
                Convert.ToUInt32(Expandable.Shade));
        }

        private RimLightDrawer CreateRimLightDrawer()
        {
            return new RimLightDrawer(
                new RimLightPropertiesContainer(),
                () => RimLightStyles.RimLightFoldout,
                Convert.ToUInt32(Expandable.RimLight));
        }

        private EmissionDrawer CreateEmissionDrawer()
        {
            return new EmissionDrawer(
                new EmissionPropertiesContainer(),
                () => EmissionStyles.EmissionFoldout,
                Convert.ToUInt32(Expandable.Emission));
        }

        private MatCapDrawer CreateMatCapDrawer()
        {
            return new MatCapDrawer(
                new MatCapPropertiesContainer(),
                () => MatCapStyles.MatCapFoldout,
                Convert.ToUInt32(Expandable.MatCap));
        }

        private DirectLightingDrawer CreateDirectLightingDrawer()
        {
            return new DirectLightingDrawer(
                new DirectLightingPropertiesContainer(),
                () => DirectLightingtyles.DirectLightingFoldout,
                Convert.ToUInt32(Expandable.DirectLighting));
        }

        private IndirectLightingDrawer CreateIndirectLightingDrawer()
        {
            return new IndirectLightingDrawer(
                new IndirectLightingPropertiesContainer(),
                () => IndirectLightingtyles.IndirectLightingFoldout,
                Convert.ToUInt32(Expandable.IndirectLighting));
        }
    }
}
