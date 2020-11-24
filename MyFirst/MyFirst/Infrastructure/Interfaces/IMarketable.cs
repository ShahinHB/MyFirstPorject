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
        void AddSale(Sale sale);
        void RemoveProduct(int Code, int Count);
        double TotalSaleDatebyDate(DateTime StartDate, DateTime EndDate);
        double TotalSaleForDate(DateTime Date);
        int TotalSaleForPrice(double StartPrice, double EndPrice);
        double TotalSaleForNumber(int Number);
        void AddProduct(Product product);
        void ChangeProductInfo(int Code);
        string CategoryProduct(Category category);
        string CategoryProduct(double StartPrice, double EndPrice);
        string SearchingResult(string Search);







    }
}
