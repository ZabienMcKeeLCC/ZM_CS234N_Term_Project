using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using ZM_CS234N_Term_Project.Models;
namespace EFClassTests
{
    public class Supplier_Tests
    {
        bitsContext dbContext = new bitsContext();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllSuppliers()
        {
            var supplierList = dbContext.Suppliers.ToList();
            Assert.AreEqual("BSG Craft Brewing", supplierList[0].Name);
        }

        [Test]
        public void GetSupplierById()
        {
            Supplier s = dbContext.Suppliers.Find(1);
            Assert.AreEqual("BSG Craft Brewing", s.Name);
        }

        [Test]
        public void CreateSupplier()
        {
            Supplier s = CreateNewSupplier();

            dbContext.Suppliers.Add(s);
            dbContext.SaveChanges();

            
            int supID = dbContext.Suppliers.OrderByDescending(s => s.SupplierId).ToList()[0].SupplierId;
            Supplier b = dbContext.Suppliers.Find(supID);
            
            Assert.AreEqual("Test Brewery",b.Name);
            dbContext.Remove(s);
            dbContext.SaveChanges();
        }

        [Test]
        public void UpdateSupplier()
        {
            Supplier s = CreateNewSupplier();

            dbContext.Suppliers.Add(s);
            dbContext.SaveChanges();


            int supID = dbContext.Suppliers.OrderByDescending(s => s.SupplierId).ToList()[0].SupplierId;
            Supplier b = dbContext.Suppliers.Find(supID);

            Assert.AreEqual("Test Brewery", b.Name);

            s.Name = "Testers Brewery";
            
            dbContext.Update(s);
            dbContext.SaveChanges();
            b = dbContext.Suppliers.Find(supID);

            Assert.AreEqual("Testers Brewery", b.Name);

            dbContext.Remove(s);
            dbContext.SaveChanges();
        }

        [Test]
        public void DeleteAddress()
        {
            Supplier s = CreateNewSupplier();

            dbContext.Suppliers.Add(s);
            dbContext.SaveChanges();


            int supID = dbContext.Suppliers.OrderByDescending(s => s.SupplierId).ToList()[0].SupplierId;
            Supplier b = dbContext.Suppliers.Find(supID);

            Assert.AreEqual("Test Brewery", b.Name);
            dbContext.Remove(s);
            dbContext.SaveChanges();

            Assert.IsNull(dbContext.Suppliers.Find(supID));
        }

        public Supplier CreateNewSupplier()
        {
            Supplier s = new Supplier();
            s.Name = "Test Brewery";
            s.Phone = "54163686";
            s.Email = "TestEmail@Email.com";

            return s;
        }
    }
}