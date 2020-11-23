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
            Product product = _products.Where(s => s.ProductCategory == category).First();
            return product.ProductName;
        }

        public string CategoryProduct(double StartPrice, double EndPrice)
        {
            Product product = _products.Where(s => s.ProductPrice >= StartPrice && s.ProductPrice <= EndPrice).First();
            return product.ProductName;
        }

        public void ChangeProductInfo(int Code)
        {
            Product product = _products.Where(s => s.ProductCode == Code).First();
            Console.WriteLine(product.ProductCode);
            Console.WriteLine(product.ProductName);
            Console.WriteLine(product.ProductPrice);
            Console.WriteLine(product.ProductCategory);
            Console.Write("Yeni kod" + Console.ReadLine());
            Console.Write("Yeni ad" + Console.ReadLine());
            Console.Write("Yeni dəyər" + Console.ReadLine());
            Console.Write("Yeni kateqoriya" + Console.ReadLine());
            //qalib birde bax!!!!!
            //
            //
            //
        }

        public void RemoveProduct(int code, int Count)
        {
            Product product = _products.Where(s => s.ProductCode == code).First();
            for (Count = 0; Count <= product.Count; Count++)
            {               
                product.Count = Count;
                break;
            }
           int nowProductCount = product.Count - Count; // nowproductCount ---- satisdan cixarildiqdan sonra magazada qalan mehsul
            Console.WriteLine(nowProductCount);
            
        }

        public string SearchingResult(string Search)
        {
            Product product = _products.Where(s => s.ProductName.Contains(Search)).First();
            return product.ProductName;
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