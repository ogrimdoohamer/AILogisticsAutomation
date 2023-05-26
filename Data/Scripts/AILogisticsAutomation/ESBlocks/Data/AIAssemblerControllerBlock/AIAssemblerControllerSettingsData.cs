﻿using ProtoBuf;
using VRage.ObjectBuilders;

namespace AILogisticsAutomation
{

    [ProtoContract]
    public class AIAssemblerControllerSettingsData
    {

        [ProtoMember(1)]
        public float powerConsumption;

        [ProtoMember(2)]
        public bool enabled;

        [ProtoMember(3)]
        public AIAssemblerControllerStockSettingsData stock = new AIAssemblerControllerStockSettingsData();

        [ProtoMember(4)]
        public SerializableDefinitionId[] defaultPriority = new SerializableDefinitionId[] { };

        [ProtoMember(4)]
        public AIAssemblerControllerAssemblerSettingsData[] definitions = new AIAssemblerControllerAssemblerSettingsData[] { };

        [ProtoMember(5)]
        public long[] ignoreAssembler = new long[] { };

        [ProtoMember(6)]
        public AIAssemblerControllerTriggerSettingsData[] triggers = new AIAssemblerControllerTriggerSettingsData[] { };

    }

}