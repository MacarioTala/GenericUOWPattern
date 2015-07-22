using FluentNHibernate.Mapping;

namespace MoqDemo
{
    public class ShipmentMap :ClassMap<Shipment>
    {
        public ShipmentMap()
        {
            Id(x => x.ShipmentId);
            References(x => x.Regulation);
            Map(x => x.ShipmentDescription);
        }
    }
}
