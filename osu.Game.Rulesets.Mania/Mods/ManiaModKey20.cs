// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey20 : ManiaKeyMod
    {
        public override int KeyCount => 20;
        public override string Name => "Twenty Keys";
        public override string Acronym => "20K";
        public override LocalisableString Description => @"Play with twenty keys. Yeah, that's right, TWENTY. KEYS.";
        public override bool Ranked => false;
    }
}
