namespace MonoKit.Domain.Data
{
    using System;
    using System.Runtime.Serialization;

    [DataContract(Name="StoredEvent", Namespace="http://sgmunn.com/MonoKit/Domain")]
    public class StoredEvent : IEventStoreContract
    {
        [DataMember]
        public Guid EventId { get; set; }
  
        [DataMember]
        public Guid AggregateId { get; set; }
  
        [DataMember]
        public int Version { get; set; }
  
        [DataMember]
        public string Event { get; set; }
    }
}
