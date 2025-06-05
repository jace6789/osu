// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey12 : ManiaKeyMod
    {
        public override int KeyCount => 12;
        public override string Name => "Twelve Keys";
        public override string Acronym => "12K";
        public override LocalisableString Description => @"Play with twelve keys.";
        public override bool Ranked => false;
    }
}
