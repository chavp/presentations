using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionCode.App.Unit.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void Purchase_succeeds_when_enough_inventory()
        {
            Store store = CreateStoreWithInventory(ProductMenu.Shampoo, 10);
            Customer sut = CreateCustomer();

            bool success = sut.Purchase(store, ProductMenu.Shampoo, 5);

            Assert.True(success);
            Assert.Equal(5, store.GetInventory(ProductMenu.Shampoo));
        }

        [Fact]
        public void Purchase_fails_when_not_enough_inventory()
        {
            Store store = CreateStoreWithInventory(ProductMenu.Shampoo, 10);
            Customer sut = CreateCustomer();

            bool success = sut.Purchase(store, ProductMenu.Shampoo, 15);

            Assert.False(success);
            Assert.Equal(10, store.GetInventory(ProductMenu.Shampoo));
        }

        private Store CreateStoreWithInventory(ProductMenu product, int quantity)
        {
            Store store = new Store();
            store.AddInventory(product, quantity);
            return store;
        }
        private static Customer CreateCustomer()
        {
            return new Customer();
        }
    }
}
