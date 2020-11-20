using MyFirstProject.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructure.Enums


namespace MyFirst.Infrastructure.Interfaces
{
    public interface IMarketable
    {
        List<Sale> Sales { get;}

        List<Sale> Products { get; }
        void AddSale(string Name);
        void RemoveProduct(string Sale);
        double TotalSaleDatebyDate(DateTime StartDate, DateTime EndDate);
        double TotalSaleWithDate(DateTime Date);
        int TotalSaleForPrice(double StartPrice, double EndPrice);
        double TotalSaleForNumber(int Number);
        string AddProduct(string ProductName);
        void ChangeProductInfo(string Name, int Count, double Price, Category category);
        string CategoryProduct(Category category);
        string CategoryProduct(double StartPrice, double EndPrice);
        string SearchingResult(string Search);







    }
}
