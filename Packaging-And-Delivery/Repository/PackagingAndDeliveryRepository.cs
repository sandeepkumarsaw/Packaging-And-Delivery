using Packaging_And_Delivery.Models;
using System.Collections.Generic;

namespace Packaging_And_Delivery.Repository
{
    public class PackagingAndDeliveryRepository : IPackagingAndDeliveryRepository
    {
        private static List<Item> Packaging = new List<Item>()
        {
            new Item{ ComponentType = "IntegralItem", Price = 100 },
            new Item{ ComponentType = "Accessory", Price = 50 },
            new Item{ ComponentType = "ProtectiveSheath", Price = 50 }
        };
        private static List<Item> Delivery = new List<Item>()
        {
            new Item{ ComponentType = "IntegralItem", Price = 200 },
            new Item{ ComponentType = "Accessory", Price = 100 }
        };
        public Item GetPackagingDetails(PackagingAndDeliveryInputs packs)
        {

            Item details = Packaging.Find(c => c.ComponentType == packs.ComponentType);
            return details;
        }

        public Item GetDeliveryDetails(PackagingAndDeliveryInputs packs)
        {

            Item details = Delivery.Find(c => c.ComponentType == packs.ComponentType);
            return details;
        }

    }
}
