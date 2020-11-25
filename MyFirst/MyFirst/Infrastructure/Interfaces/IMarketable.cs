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
        void RemoveProduct(int Code);
        double TotalSaleDatebyDate(DateTime StartDate, DateTime EndDate);
        void RemoveProductBySale(int code);
        double TotalSaleForDate(DateTime Date);
        int TotalSaleForPrice(double StartPrice, double EndPrice);
        double TotalSaleForNumber(int Number);
        void AddProduct(Product product);
        void ChangeProductInfo(int Code);
        List<Product> CategoryProduct(Category category);
        List<Product> ProductforTwoPrice(double StartPrice, double EndPrice);
        string SearchingResult(string Search);







    }
}
