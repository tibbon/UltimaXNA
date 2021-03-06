﻿/***************************************************************************
 *   ChangeCombatantPacket.cs
 *   
 *   begin                : May 31, 2009
 *   email                : poplicola@ultimaxna.com
 *
 ***************************************************************************/

/***************************************************************************
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/
#region usings
using UltimaXNA.Core.Network;
using UltimaXNA.Core.Network.Packets;
#endregion

namespace UltimaXNA.UltimaPackets.Server
{
    public class ChangeCombatantPacket : RecvPacket
    {
        public readonly Serial Serial;
        public ChangeCombatantPacket(PacketReader reader)
            : base(0xAA, "Change Combatant")
        {
            Serial = reader.ReadInt32();
        }
    }
}
