using Packaging_And_Delivery.Models;
using System.Collections.Generic;

namespace Packaging_And_Delivery.Repository
{
    public interface IPackagingAndDeliveryRepository
    {
        public Item GetPackagingDetails(PackagingAndDeliveryInputs packs);
        public Item GetDeliveryDetails(PackagingAndDeliveryInputs packs);

    }
}
