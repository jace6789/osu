// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey13 : ManiaKeyMod
    {
        public override int KeyCount => 13;
        public override string Name => "Thirteen Keys";
        public override string Acronym => "13K";
        public override LocalisableString Description => @"Play with thirteen keys.";
        public override bool Ranked => false;
    }
}
