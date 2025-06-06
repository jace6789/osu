﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Rulesets.Mania.Mods
{
    public class ManiaModKey14 : ManiaKeyMod
    {
        public override int KeyCount => 14;
        public override string Name => "Fourteen Keys";
        public override string Acronym => "14K";
        public override LocalisableString Description => @"Play with fourteen keys.";
        public override bool Ranked => false;
    }
}
