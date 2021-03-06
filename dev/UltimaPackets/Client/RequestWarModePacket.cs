﻿/***************************************************************************
 *   RequestWarModePacket.cs
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
using UltimaXNA.Core.Network.Packets;
#endregion

namespace UltimaXNA.UltimaPackets.Client
{
    public class RequestWarModePacket : SendPacket
    {
        public RequestWarModePacket(bool warMode)
            : base(0x72, "Request War Mode", 5)
        {
            Stream.Write(warMode);
            Stream.Write((byte)0x00);
            Stream.Write((byte)0x32);
            Stream.Write((byte)0x00);
        }
    }
}
