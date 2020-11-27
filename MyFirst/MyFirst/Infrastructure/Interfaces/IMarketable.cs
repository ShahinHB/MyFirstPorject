using MyFirst.Infrastructure.Models;
using System;
using System.Collections.Generic;
using MyFirst.Infrastructure.Enums;


namespace MyFirst.Infrastructure.Interfaces
{
    public interface IMarketable
    {
        List<Sale> Sales { get;}

        List<Product> Products { get; }
        void AddSale(int code, int Count);
        void RemoveProduct(int Code);
        List<Sale> TotalSaleDatebyDate(DateTime StartDate, DateTime EndDate);
        void RemoveProductBySale(int salecode, int count, int productcode);
        List<Sale> TotalSaleForDate(DateTime Date);
        List<Sale> TotalSaleForPrice(double StartPrice, double EndPrice);
        List<Sale> SearchingSaleForNumber(int Number);
        void AddProduct(Product product);
        List<Product> ChangeProductInfo(int Code);
        List<Product> CategoryProduct(Category category);
        List<Product> ProductforTwoPrice(double StartPrice, double EndPrice);
        List<Product> SearchingProduct(string Search);
        List<SaleItem> ShowSaleItem(int saleNumber);
        void RemoveSale(int Number);






    }
}
