// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey17 : ManiaKeyMod
    {
        public override int KeyCount => 17;
        public override string Name => "Seventeen Keys";
        public override string Acronym => "17K";
        public override LocalisableString Description => @"Play with seventeen keys.";
        public override bool Ranked => false;
    }
}
