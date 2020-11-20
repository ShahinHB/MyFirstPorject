using MyFirstProject.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirst.Infrastructure.Interfaces
{
    public interface IMarketable
    {
        List<Sale> Sales { get;}

        List<Sale> Products { get; }
        void AddSale(string Name);
        void RemoveProduct(int Sale);
        double TotalSaleDatebyDate(DateTime StartDate, DateTime EndDate);
        double TotalSaleWithDate(DateTime Date);
        double TotalSalWithPrice(double StartPrice, double EndPrice);
        double 





    }
}
