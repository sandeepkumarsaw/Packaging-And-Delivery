using Packaging_And_Delivery.Models;
using Packaging_And_Delivery.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Packaging_And_Delivery.Repository;

namespace Packaging_And_Delivery.Services
{
    public class PackagingAndDeliveryChargeServices : IPackagingAndDeliveryChargeServices
    {
        private readonly IPackagingAndDeliveryRepository repository;
        
        public PackagingAndDeliveryChargeServices(IPackagingAndDeliveryRepository repo)
        {
            repository = repo;
        }
        public int CalculateCharge(PackagingAndDeliveryInputs data)
        {
            
            Item package = repository.GetPackagingDetails(data);
            Item delivery = repository.GetDeliveryDetails(data);
            if (package == null)
            {
                return 0;
            }
            int packagingPrice = package.Price * data.count;

            if (delivery != null)
            {
                packagingPrice += delivery.Price;
            }
            
            return packagingPrice;
        }
    }
}
