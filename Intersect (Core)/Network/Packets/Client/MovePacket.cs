﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Network.Packets.Client
{
    public class MovePacket : CerasPacket
    {
        public Guid MapId { get; set; }
        public byte X { get; set; }
        public byte Y { get; set; }
        public byte Dir { get; set; }

        public MovePacket(Guid mapId, byte x, byte y, byte dir)
        {
            MapId = mapId;
            X = x;
            Y = y;
            Dir = dir;
        }
    }
}