using MyFirst.Infrastructure.Interfaces;
using MyFirstProject.Infrastructure.Enums;
using MyFirstProject.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirst.Infrastructure.Services
{
    public class MarketableService : IMarketable
    {
        private List<Sale> _sales;
        private List<Product> _products;
        public List<Sale> Sales => _sales;

        public List<Product> Products => _products;

        public void AddSale(Sale sale)
        {
            _sales.Add(sale);
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
           
        }
           

        public string CategoryProduct(Category category)
        {
            return _products.Where(p => p.ProductCategory == category)();
        }

        public string CategoryProduct(double StartPrice, double EndPrice)
        {
            throw new NotImplementedException();
        }

        public void ChangeProductInfo(string Name, int Count, double Price, Category category)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(string Sale)
        {
            throw new NotImplementedException();
        }

        public string SearchingResult(string Search)
        {
            return _products.Where(s => s.ProductName == Search).(s => s.ProductName);
        }

        public double TotalSaleDatebyDate(DateTime StartDate, DateTime EndDate)
        {
            return _sales.Where(s => s.Date >= StartDate && s.Date <= EndDate).Sum(s=>s.SalePrice);
        }

        public double TotalSaleForNumber(int Number)
        {
            return _sales.Where(s => s.SaleNumber == Number ).Sum(s=>s.SalePrice);
        }

        public int TotalSaleForPrice(double StartPrice, double EndPrice)
        {
            return _sales.Where(s => s.SalePrice >= StartPrice && s.SalePrice <= EndPrice).Count();
        }

        public double TotalSaleWithDate(DateTime Date)
        {
            return _sales.Where(s => s.Date == Date).Sum(s => s.SalePrice);
        }
    }
}