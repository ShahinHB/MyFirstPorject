using MyFirst.Infrastructure.Interfaces;
using MyFirst.Infrastructure.Enums;
using MyFirst.Infrastructure.Models;
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

        public MarketableService()
        {

            _sales = new List<Sale>(){
                new Sale
            {
                SaleNumber = 1019210,
                SalePrice = 4050.87,
                SaleItems = ,
                Date = new DateTime(2020, 11, 15)
            },
            new Sale
            {
                SaleNumber = 1005673,
                SalePrice = 12600.65,
                SaleItems = ,
                Date = new DateTime(2020, 12, 30)
            },
            new Sale
            {
                SaleNumber = 1065109,
                SalePrice = 3605.33,
                SaleItems = ,
                Date = new DateTime(2019, 05, 15)
            }
        };



            #region Product List
            _products = new List<Product>()
            {
                new Product
                {
                    ProductCode = 109665,
                    ProductName = "SAMSUNG 50-inch Class QLED Q60T Series",
                    ProductCategory = Category.Televisions,
                    ProductPrice = 699.99,
                    Count = 14
                },
                new Product
            {
                ProductCode = 105012,
                ProductName = "BLU G90 - 6.5” HD + Smartphone",
                ProductCategory = Category.Phones,
                ProductPrice = 290.48,
                Count = 67
            },
            new Product
            {
                ProductCode = 103992,
                ProductName = "Amazon Fire 7 tablet ",
                ProductCategory = Category.Tablets,
                ProductPrice = 49.99,
                Count = 1
            },
            new Product
            {
                ProductCode = 175662,
                ProductName = "Xiaomi Mi 9 T Redmi K20",
                ProductCategory = Category.Phones,
                ProductPrice = 279,
                Count = 97

            },
            new Product
            {
                ProductCode = 281883,
                ProductName = "Gigabyte GeForce RTX 2070 Gaming OC 8G",
                ProductCategory = Category.ComputerAccesories,
                ProductPrice = 1189,
                Count = 5
            },
            new Product
            {
                ProductCode = 215615,
                ProductName = "Deadly Cross (Alex Cross Book 28)",
                ProductCategory = Category.Books,
                ProductPrice = 14.99,
                Count = 14
            },
            new Product
            {
                ProductCode = 221690,
                ProductName = "Cutiefox 3D Print Crew Neck Pullover Ugly Christmas Sweater Sweatshirts",
                ProductCategory = Category.Clothes,
                ProductPrice = 23.99,
                Count = 21
            }
            #endregion
        };
        }
        public void AddSale(Sale sale)
        {
            _sales.Add(sale);
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);

        }
        public List<Product> CategoryProduct(Category category)
        {
            var list = _products.FindAll(s => s.ProductCategory==category).ToList();

            foreach (var item in list)
            {
                Console.WriteLine("Sayı: " + item.Count);
                Console.WriteLine("Kodu: " + item.ProductCode);
                Console.WriteLine("Adı: " + item.ProductName);
                Console.WriteLine("Qiyməti: " + item.ProductPrice);
                Console.WriteLine();
                Console.WriteLine();
            }



            return list;
        }

        public List<Product> ProductforTwoPrice(double StartPrice, double EndPrice)
        {
            
            var list = _products.FindAll(s => s.ProductPrice >= StartPrice && s.ProductPrice <= EndPrice).ToList();
            foreach (var item in list)
            {
                Console.WriteLine("Sayı: " + item.Count);
                Console.WriteLine("Kodu: " + item.ProductCode);
                Console.WriteLine("Adı: " + item.ProductName);
                Console.WriteLine("Qiyməti: " + item.ProductPrice);
                Console.WriteLine();
                Console.WriteLine();

            }

            return list;
        }

        public List<Product> ChangeProductInfo(int Code)
        {
            return _products.FindAll(p => p.ProductCode == Code).ToList();
        }

        public void RemoveProduct(int code )
        {
            _products.Clear();
          
        }
        public void RemoveProductBySale(int code)
        {

        }
        public List<Product> SearchingResult(string Search)
        {
            
            var list = _products.FindAll(s => s.ProductName.Contains(Search)).ToList();
            foreach (var item in list)
            {
                Console.WriteLine("Sayı: " + item.Count);
                Console.WriteLine("Kodu: " + item.ProductCode);
                Console.WriteLine("Adı: " + item.ProductName);
                Console.WriteLine("Qiyməti: " + item.ProductPrice);
                Console.WriteLine("Kateqoriya " + item.ProductCategory);
                Console.WriteLine();
                Console.WriteLine();

            }

            return list;
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

        public double TotalSaleForDate(DateTime Date)
        {
            return _sales.Where(s => s.Date == Date).Sum(s => s.SalePrice);
        }
    }
}