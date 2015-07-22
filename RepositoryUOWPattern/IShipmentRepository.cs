using System.Linq;

namespace MoqDemo
{
    public interface IShipmentRepository
    {
        Shipment GetShipment(int shipmentID);
        void SaveShipment(Shipment shipment);
        void UpdateShipment(Shipment shipment);
        IQueryable<Shipment> GetShipmentByRegulation(RegulationEnum regulation);
    }

    
}
