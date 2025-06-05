// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Linq;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Mania.Beatmaps;
using osu.Game.Rulesets.Mods;

namespace osu.Game.Rulesets.Mania.Mods
{
    public abstract class ManiaKeyMod : Mod, IApplicableToBeatmapConverter
    {
        public override string Acronym => Name;
        public abstract int KeyCount { get; }
        public override ModType Type => ModType.Conversion;
        public override double ScoreMultiplier => 1; // TODO: Implement the mania key mod score multiplier
        public override bool Ranked => UsesDefaultConfiguration;

        public void ApplyToBeatmapConverter(IBeatmapConverter beatmapConverter)
        {
            var mbc = (ManiaBeatmapConverter)beatmapConverter;

            // Although this can work, for now let's not allow keymods for mania-specific beatmaps
            if (mbc.IsForCurrentRuleset)
                return;

            mbc.TargetColumns = KeyCount;
        }

        public override Type[] IncompatibleMods => new[]
        {
            typeof(ManiaModKey1),
            typeof(ManiaModKey2),
            typeof(ManiaModKey3),
            typeof(ManiaModKey4),
            typeof(ManiaModKey5),
            typeof(ManiaModKey6),
            typeof(ManiaModKey7),
            typeof(ManiaModKey8),
            typeof(ManiaModKey9),
            typeof(ManiaModKey10),
            typeof(ManiaModKey11),
            typeof(ManiaModKey12),
            typeof(ManiaModKey13),
            typeof(ManiaModKey14),
            typeof(ManiaModKey15),
            typeof(ManiaModKey16),
            typeof(ManiaModKey17),
            typeof(ManiaModKey18),
            typeof(ManiaModKey19),
            typeof(ManiaModKey20),
        }.Except(new[] { GetType() }).ToArray();
    }
}
