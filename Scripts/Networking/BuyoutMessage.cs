﻿using LiteNetLib.Utils;

namespace MultiplayerARPG.Auction
{
    public struct BuyoutMessage : INetSerializable
    {
        public int auctionId;

        public void Deserialize(NetDataReader reader)
        {
            auctionId = reader.GetPackedInt();
        }

        public void Serialize(NetDataWriter writer)
        {
            writer.PutPackedInt(auctionId);
        }
    }
}
