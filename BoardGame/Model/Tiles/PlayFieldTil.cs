﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model.Tiles
{
    public class PlayFieldTil
    {
        public int Id { get; set; }
        public TileType Type { get; set; }
        public int NodeCount { get; set; }
        public List<NodeProp> NodeProps { get; set; }
        public bool Visible { get; set; }
    }
}