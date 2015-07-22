namespace MoqDemo
{
    public class ShipmentService:IShipmentService
    {
        private readonly IShipmentRepository _repository;

        public ShipmentService(IShipmentRepository repository)
        {
            _repository = repository;
        }

        public void ValidateShipment(Shipment shipment)// simplified. Assume that only cfr49 things are valid
        {
            
        }
    }
}
