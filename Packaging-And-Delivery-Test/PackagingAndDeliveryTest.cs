using System;
using Xunit;
using Packaging_And_Delivery.Repository;
using Packaging_And_Delivery.Models;
using Packaging_And_Delivery.Services;
using Packaging_And_Delivery.Controllers;

namespace Packaging_And_Delivery_Test
{
    public class PackagingAndDeliveryTest
    {
        private PackagingAndDeliveryRepository repo;
        private PackagingAndDeliveryChargeServices service;
        private PackagingAndDeliveryController controller;
        public PackagingAndDeliveryTest()
        {
            repo = new PackagingAndDeliveryRepository();
            service = new PackagingAndDeliveryChargeServices(repo);
            controller = new PackagingAndDeliveryController(service);
        }

        [Fact]
        public void Test_GetPackagingDetails()
        {
            PackagingAndDeliveryInputs packs = new PackagingAndDeliveryInputs { ComponentType= "Accessory", count= 10};

            Item data = repo.GetPackagingDetails(packs);
            /*Item d = new Item { ComponentType = "IntegralItem", Price = 100 };*/
            /*bool t = d.Equals(data);*/
            Assert.NotNull(data);
        }
        [Fact]
        public void Test_CalculateCharge()
        {
            PackagingAndDeliveryInputs packs = new PackagingAndDeliveryInputs { ComponentType = "Accessory", count = 1 };

            int data = service.CalculateCharge(packs);
            /*Item d = new Item { ComponentType = "IntegralItem", Price = 100 };*/
            bool t = data.Equals(150);
            Assert.True(t);
        }

        [Fact]
        public void Test_PackagingAndDelivery()
        {
            PackagingAndDeliveryInputs packs = new PackagingAndDeliveryInputs { ComponentType = "Accessory", count = 1 };

            var data = controller.PackagingAndDelivery(packs);
            Assert.NotNull(data);
        }
    }
}
