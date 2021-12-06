using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using ZM_CS234N_Term_Project.Models;
namespace EFClassTests
{
    public class Address_Tests
    {
        bitsContext dbContext = new bitsContext();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllAddresses()
        {
            var addressList = dbContext.Addresses.ToList();
            Assert.AreEqual(7, addressList.Count);
        }

        [Test]
        public void GetAddressById()
        {
            var address = dbContext.Addresses.Find(1);
            Assert.AreEqual("800 West 1st Ave", address.StreetLine1);
        }

        [Test]
        public void CreateAddress()
        {
            Address a = new Address();
            a.StreetLine1 = "1234 Test Drive";
            a.City = "Test City";
            a.State = "OR";
            a.Zipcode = "858393";
            a.Country = "USA";
            a.SupplierId = 2;
            a.Note = "Test Address";
            
            dbContext.Add(a);
            dbContext.SaveChanges();
            int adrID = dbContext.Addresses.OrderByDescending(s => s.AddressId).ToList()[0].AddressId;
            
            Address b = dbContext.Addresses.Find(adrID);
            Assert.AreEqual("1234 Test Drive", b.StreetLine1);
            dbContext.Addresses.Remove(a);
            dbContext.SaveChanges();
        }

        [Test]
        public void UpdateAddress()
        {
            Address a = new Address();
            a.StreetLine1 = "1234 Test Drive";
            a.City = "Test City";
            a.State = "OR";
            a.Zipcode = "858393";
            a.Country = "USA";
            a.SupplierId = 2;
            a.Note = "Test Address";
            
            dbContext.Add(a);
            dbContext.SaveChanges();
            int adrID = dbContext.Addresses.OrderByDescending(s => s.AddressId).ToList()[0].AddressId;

            Address b = dbContext.Addresses.Find(adrID);
            Assert.AreEqual("1234 Test Drive", b.StreetLine1);


            a.StreetLine1 = "45678 Test Rd";
            dbContext.Update(a);

            b = dbContext.Addresses.Find(adrID);
            Assert.AreEqual("45678 Test Rd", b.StreetLine1);
            dbContext.Addresses.Remove(a);
            dbContext.SaveChanges();
        }

        [Test]
        public void DeleteAddress()
        {
            Address a = new Address();
            a.StreetLine1 = "1234 Test Drive";
            a.City = "Test City";
            a.State = "OR";
            a.Zipcode = "858393";
            a.Country = "USA";
            a.SupplierId = 2;
            a.Note = "Test Address";
            
            dbContext.Add(a);
            dbContext.SaveChanges();
            int adrID = dbContext.Addresses.OrderByDescending(s => s.AddressId).ToList()[0].AddressId;


            Address b = dbContext.Addresses.Find(adrID);
            Assert.AreEqual("1234 Test Drive", b.StreetLine1);
            dbContext.Addresses.Remove(a);
            dbContext.SaveChanges();
            Assert.IsNull(dbContext.Addresses.Find(adrID));
        }
    }
}