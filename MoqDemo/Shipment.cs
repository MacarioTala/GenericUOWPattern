using System;

namespace MoqDemo
{
    public class Shipment
    {
        public virtual Guid ShipmentId { get; protected set; }
        public virtual RegulationEnum Regulation { get; set; }
        public virtual String ShipmentDescription { get; set; }
    }
}
