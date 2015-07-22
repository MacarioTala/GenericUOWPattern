using System.Linq;
using NHibernate;
using NHibernate.Linq;

namespace MoqDemo
{
    public class ShipmentRepository:IShipmentRepository
    {
        private readonly UnitOfWork _unitOfWork;

        public ShipmentRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        protected ISession Session { get { return _unitOfWork.Session; } }
     
        public Shipment GetShipment(int shipmentID)
        {
            return Session.Get<Shipment>(shipmentID);
        }

        public void SaveShipment(Shipment shipment)
        {
            Session.Save(shipment);
        }

        public void UpdateShipment(Shipment shipment)
        {
            Session.Update(shipment);
        }

        public IQueryable<Shipment> GetShipmentByRegulation(RegulationEnum regulation)
        {
            return Session.Query<Shipment>().Where(x => x.Regulation == regulation);
        }
    }
}
