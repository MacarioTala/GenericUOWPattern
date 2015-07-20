

using System.Linq;
using NHibernate.Persister.Entity;

namespace MoqDemo
{
    interface IShipmentRepository
    {
        Shipment GetShipment(int shipmentID);
        void SaveShipment(Shipment shipment);
        void UpdateShipment(Shipment shipment);
        IQueryable<Shipment> GetShipmentByRegulation(RegulationEnum regulation);
    }

    
}
