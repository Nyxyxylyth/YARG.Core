﻿using System;
using Newtonsoft.Json;

namespace YARG.Core.Game
{
    public class YargProfile
    {
        [JsonConverter(typeof(GuidConverter))]
        public Guid Id;

        public string Name;

        public GameMode GameMode;

        [JsonIgnore]
        public Instrument Instrument;

        [JsonIgnore]
        public Difficulty Difficulty;

        public float NoteSpeed;
        public float HighwayLength;

        public bool LeftyFlip;

        public bool IsBot;

        public YargProfile()
        {
            Id = Guid.NewGuid();
            Name = "Default";
            GameMode = GameMode.FiveFretGuitar;
            Instrument = Instrument.FiveFretGuitar;
            Difficulty = Difficulty.Expert;
            NoteSpeed = 6;
            HighwayLength = 1;
            LeftyFlip = false;
        }

        public YargProfile(Guid id) : this()
        {
            Id = id;
        }
    }
}