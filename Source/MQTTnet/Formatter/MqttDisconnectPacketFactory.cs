﻿using MQTTnet.Client.Disconnecting;
using MQTTnet.Packets;
using MQTTnet.Protocol;

namespace MQTTnet.Formatter
{
    public sealed class MqttDisconnectPacketFactory
    {
        public MqttDisconnectPacket Create(MqttClientDisconnectOptions clientDisconnectOptions)
        {
            var packet = new MqttDisconnectPacket();

            if (clientDisconnectOptions == null)
            {
                packet.ReasonCode = MqttDisconnectReasonCode.NormalDisconnection;
            }
            else
            {
                packet.ReasonCode = (MqttDisconnectReasonCode) clientDisconnectOptions.ReasonCode;
            }

            return packet;
        }
    }
}