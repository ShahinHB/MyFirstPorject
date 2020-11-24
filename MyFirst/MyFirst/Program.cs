using System;
using System.Text;
using MyFirst.Infrastructure.Services;


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
        static void ShowAddProduct() { }
        static void ShowEditProduct() { }
        static void ShowRemoveProduct() { }
        static void ShowAllProduct() { }
        static void ShowCategoryProduct() { }
        static void ShowProductbyTwoPrice() { }
        static void ShowSearch() { }
        static void ShowAddSale() { }
        static void ShowCancelledProductfromSale() { }
        static void ShowRemovedSale() { }
        static void ShowAllSales() { }
        static void ShowSalesbyTwoDate() { }
        static void ShowSalesbyTwoPrice() { }
        static void ShowSaleforDate() { }
        static void ShowSaleforNumber() { }

    }
}