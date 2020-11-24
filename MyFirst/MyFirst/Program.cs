using System;
using System.Text;
using MyFirst.Infrastructure.Services;
using ConsoleTables;
using MyFirst.Infrastructure.Models;

namespace MyFirst
{
    class Program
    {
        private static MarketableService _marketableService = new MarketableService();
        public Program()
        {
            _marketableService = new MarketableService();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int selectInt;
            do
            {
                Console.WriteLine("1. Məhsullar üzərində əməliyyat aparmaq");
                Console.WriteLine("2. Satışlar üzərində əməliyyat aparmaq");
                Console.WriteLine("Sistemdən çıxmaq");

                Console.WriteLine("Seçiminizi edin");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }

                switch (selectInt)
                {
                    case 0:
                        continue;
                    case 1:
                        ShowSaleCategories();
                        break;
                    case 2:
                        ShowProductCategories();
                        break;
                    default:
                        Console.WriteLine("Yalnız 0 ilə 3 arası seçim edə bilərsiniz");
                        break;
                }

            } while (selectInt != 0);

        } 
        static void ShowSaleCategories()
        {
            int selectInt;
            do
            {
                Console.WriteLine("1. Yeni məhsul əlavə et");
                Console.WriteLine("2. Məhsul üzərində düzəliş et");
                Console.WriteLine("3. Məhsulu sil");
                Console.WriteLine("4. Bütün məhsulları göstər");
                Console.WriteLine("5. Kateqoriyasına görə məhsulları göstər");
                Console.WriteLine("6. Qiymət aralığına görə məhsulları göstər");
                Console.WriteLine("7. Axtarış");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }
                switch (selectInt)
                {
                    case 0:
                        continue;
                    case 1:
                        ShowAddProduct();
                        break;
                    case 2:
                        ShowEditProduct();
                        break;
                    case 3:
                        ShowRemoveProduct();
                        break;
                    case 4:
                        ShowAllProduct();
                        break;
                    case 5:
                        ShowCategoryProduct();
                        break;
                    case 6:
                        ShowProductbyTwoPrice();
                        break;
                    case 7:
                        ShowSearch();
                        break;

                }
            } while (selectInt != 0);
        }
        static void ShowProductCategories()
        {
            int selectInt;
            do
            {
                Console.WriteLine("1. Yeni satış əlavə et");
                Console.WriteLine("2. Məhsulu geri qaytar");
                Console.WriteLine("3. Satışı sil");
                Console.WriteLine("4. Bütün satışları göstər");
                Console.WriteLine("5. 2 Tarix aralığındakı satışı göstər");
                Console.WriteLine("6. 2 məbləğ aralığındakı satışı göstər");
                Console.WriteLine("7. Daxil edilmiş tarixdə olan satışı göstər");
                Console.WriteLine("8. Daxil edilmiş nömrəyə görə satışı göstər");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }
                switch (selectInt)
                {
                    case 0:
                        continue;
                    case 1:
                        ShowAddSale();
                        break;
                    case 2:
                        ShowCancelledProductfromSale();
                        break;
                    case 3:
                        ShowRemovedSale();
                        break;
                    case 4:
                        ShowAllSales();
                        break;
                    case 5:
                        ShowSalesbyTwoDate();
                        break;
                    case 6:
                        ShowSalesbyTwoPrice();
                        break;
                    case 7:
                        ShowSaleforDate();
                        break;
                    case 8:
                        ShowSaleforNumber();
                        break;
                    
                }

            } while (selectInt != 0);
        }
        static void ShowAddProduct()
        {

            Console.WriteLine("------------------Məhsul əlavə et-------------------");
            Product product = new Product();

            Console.WriteLine("Kateqoriya daxil edin");
            product.ProductCategory = Console.ReadLine();


            Console.WriteLine("Məhsulun kodunu daxil edin");
            product.ProductCode = Console.ReadLine();

            Console.WriteLine("Məhsulun adını daxil edin");
            product.ProductName = Console.ReadLine();

            Console.WriteLine("Məhsulun qiymətini daxil edin");
            product.ProductPrice = Console.ReadLine();

            Console.WriteLine("Məhsulun miqdarını daxil edin");
            product.Count = Console.ReadLine();

        }
        static void ShowEditProduct() { }
        static void ShowRemoveProduct()
        {
            Console.WriteLine("---------------------Satışı ləğv et----------------");

            Console.WriteLine("Satış sayını daxil edin");
            string codeinput = Console.ReadLine();
            int code;
            while (!int.TryParse(codeinput, out code))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                codeinput = Console.ReadLine();
            }
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

        }
        static void ShowAllProduct()
        {
            var table = new ConsoleTable("№", "Kodu", "Adı", "Qiyməti", "Kateqoriyası", "Anbarda qalıb");
            var i = 0;
            foreach (var item in _marketableService.Products)
            {
                i++;
                Console.WriteLine(table.AddRow(i, item.ProductCode, item.ProductName, item.ProductPrice, item.ProductCategory, item.Count));
            }
            table.Write();
        }
        static void ShowCategoryProduct() { }
        static void ShowProductbyTwoPrice()
        {
            Console.WriteLine(" 2 qiymət aralığındakı məhsulları göstərin");

            Console.WriteLine("Başlanğıc qiyməti daxil edin");
            string startPriceInput = Console.ReadLine();
            double StartPrice;

            while (!double.TryParse(startPriceInput, out StartPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edin");
            }

            Console.WriteLine("Son qiyməti daxil edin");
            string endPriceInput = Console.ReadLine();
            double EndPrice;

            while (!double.TryParse(endPriceInput, out EndPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edin");
            }

            double result = _marketableService.TotalSaleForPrice(StartPrice, EndPrice);

            if (result != 0)
            {
                Console.WriteLine(StartPrice + " " + EndPrice + " aralığında bu məhsullar satılmışdır");
            }
            else
            {
                Console.WriteLine("Bu tarixdə məhsul satışı olmayıb");
            }
        }
        static void ShowSearch() { }
        static void ShowAddSale() { }
        static void ShowCancelledProductfromSale() { }
        static void ShowRemovedSale() { }
        static void ShowAllSales() { }
        static void ShowSalesbyTwoDate()
        {
            Console.WriteLine("Müəyyən tarix intervalındakı ümumi satış");

            Console.WriteLine("Başlanğıc tarixi daxil edin");
            string startDateİnput = Console.ReadLine();
            DateTime StartDate;
            while (!DateTime.TryParse(startDateİnput, out StartDate))
            {
                Console.WriteLine("Tarixi daxil etməlisiniz");
            }

            Console.WriteLine("Bitiş tarixini daxil edin");
            string endDateInput = Console.ReadLine();
            DateTime EndDate;
            while (!DateTime.TryParse(endDateInput, out EndDate)) 
            {
                Console.WriteLine("Tarixi daxil etməlisiniz");
            }
            double result = _marketableService.TotalSaleDatebyDate(StartDate,EndDate);

            if (result != 0)
            {
                Console.WriteLine(StartDate.ToString("dd.MM.yyyy") + "-" + EndDate.ToString("dd.MM.yyyy") + " " + "aralığındakı satış toplamı" + " " + result + " " + "qədərdir");
            }
            else
            {
                Console.WriteLine(StartDate.ToString("dd.MM.yyyy") + " -" + EndDate.ToString("dd.MM.yyyy") + "aralığındakı satış olmayıb");
            }
        }
        static void ShowSalesbyTwoPrice()
        {
            Console.WriteLine(" 2 qiymət aralığındakı satışları göstərin");

            Console.WriteLine("Başlanğıc qiyməti daxil edin");
            string startPriceInput = Console.ReadLine();
            double StartPrice;

            while (!double.TryParse(startPriceInput, out StartPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edin");
            }

            Console.WriteLine("Son qiyməti daxil edin");
            string endPriceInput = Console.ReadLine();
            double EndPrice;

            while (!double.TryParse(endPriceInput, out EndPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edin");
            }

            double result = _marketableService.TotalSaleForPrice(StartPrice, EndPrice);

            if (result != 0)
            {
                Console.WriteLine(StartPrice + " " + EndPrice + " aralığında bu məhsullar satılmışdır");
            }
            else
            {
                Console.WriteLine("Bu tarixdə məhsul satışı olmayıb");
            }
        }
        static void ShowSaleforDate()
        {
            Console.WriteLine("Verilən tarixdəki satış");

            Console.WriteLine("Tarixi daxil edin");
            string date = Console.ReadLine();
            DateTime Date;

            while (!DateTime.TryParse(date, out Date))
            {
                Console.WriteLine("Tarixi daxil edin");
            }

            double result = _marketableService.TotalSaleForDate(Date);

            if (result != 0)
            {
                Console.WriteLine(Date + "tarixində aşağıdakı satış olmuşdur");
            }
            else
            {
                Console.WriteLine("Qeyd edilən tarixdə heç bir satış olmamışdır");
            }
        }
        static void ShowSaleforNumber()
        {
            Console.WriteLine("Nömrəyə görə satışın çıxarılması");

            Console.WriteLine("Nömrəni daxil edin");
            string inputNumber = Console.ReadLine();
            int Number;

            while (!int.TryParse(inputNumber,out Number))
            {
                Console.WriteLine("Ədəd daxil edin");
            }

            double result = _marketableService.TotalSaleForNumber(Number);

            if (result != 0)
            {
                Console.WriteLine(Number + "nömrəli məhsul satış məlumatları aşağıdakı kimidir");
            }
            else
            {
                Console.WriteLine("Bu nömrəli məhsula aid heçbir satış məlumatı yoxdur");
            }
        }

    }
}