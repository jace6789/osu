// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey16 : ManiaKeyMod
    {
        public override int KeyCount => 16;
        public override string Name => "Sixteen Keys";
        public override string Acronym => "16K";
        public override LocalisableString Description => @"Play with sixteen keys.";
        public override bool Ranked => false;
    }
}
