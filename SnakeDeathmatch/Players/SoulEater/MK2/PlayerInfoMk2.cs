﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SnakeDeathmatch.Interface;

namespace SnakeDeathmatch.Players.SoulEater.MK2
{
    public class PlayerInfoMk2
    {
        public PlayerInfoMk2(PointClass point, int identificator)
        {
            Point = point;
            Identificator = identificator;
            IsDown = false;
            Direction = null;
            PreviousPoints =new List<PointClass>();
        }

        public void UpdatePosition(PointClass newPoint)
        {
            IsDown = false;
        }

        public PointClass Point { get; set; }

        public IList<PointClass> PreviousPoints { get; set; }

        public int Identificator { get; set; }

        public Direction? Direction { get; set; }

        public bool IsDown { get; set; }
    }
}
