using Packaging_And_Delivery.Models;

namespace Packaging_And_Delivery.Services
{
    public interface IPackagingAndDeliveryChargeServices
    {
        public int CalculateCharge(PackagingAndDeliveryInputs data);
    }
}
