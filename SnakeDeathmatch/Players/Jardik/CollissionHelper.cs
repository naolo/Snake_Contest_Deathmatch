﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeDeathmatch.Players.Jardik
{
    class CollissionHelper
    {
        private int _max;

        public CollissionHelper(int max)
        {
            _max = max;
        }

        public bool Collission(Direction direction, int[,] gameSurround, Position position)
        {
            if (CrossColision(direction, gameSurround, position)) return true;
            if (position.IsInCollission(_max)) return true;
            if (gameSurround[position.X, position.Y] != 0) return true;
            return false;
        }

        bool CrossColision(Direction direction, int[,] gameSurround, Position position)
        {
            if (position.X <= 0 || position.Y <= 0 || position.X >= _max - 1 || position.Y >= _max - 1) return false;

            return (direction == Direction.TopRight && (gameSurround[position.X, position.Y + 1] != 0) && (gameSurround[position.X - 1, position.Y] != 0)) ||
                    (direction == Direction.BottomRight && (gameSurround[position.X, position.Y - 1] != 0) && (gameSurround[position.X - 1, position.Y] != 0)) ||
                    (direction == Direction.BottomLeft && (gameSurround[position.X, position.Y - 1] != 0) && (gameSurround[position.X + 1, position.Y] != 0)) ||
                    (direction == Direction.TopLeft && (gameSurround[position.X, position.Y + 1] != 0) && (gameSurround[position.X + 1, position.Y] != 0));
        }
    }
}
