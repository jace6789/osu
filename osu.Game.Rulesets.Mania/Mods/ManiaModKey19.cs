// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey19 : ManiaKeyMod
    {
        public override int KeyCount => 19;
        public override string Name => "Nineteen Keys";
        public override string Acronym => "19K";
        public override LocalisableString Description => @"Play with nineteen keys.";
        public override bool Ranked => false;
    }
}
