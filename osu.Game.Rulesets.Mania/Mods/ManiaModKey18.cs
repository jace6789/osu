// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey18 : ManiaKeyMod
    {
        public override int KeyCount => 18;
        public override string Name => "Eighteen Keys";
        public override string Acronym => "18K";
        public override LocalisableString Description => @"Play with eighteen keys.";
        public override bool Ranked => false;
    }
}
