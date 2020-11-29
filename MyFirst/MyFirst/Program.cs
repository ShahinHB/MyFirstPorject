using System;
using System.Text;
using MyFirst.Infrastructure.Services;
using ConsoleTables;
using MyFirst.Infrastructure.Models;
using MyFirst.Infrastructure.Enums;
using System.Collections.Generic;
using System.Linq;

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
#region Main menu
            int selectInt;
            do
            {
                Console.WriteLine("1. Məhsullar üzərində əməliyyat aparmaq");
                Console.WriteLine("2. Satışlar üzərində əməliyyat aparmaq");
                Console.WriteLine("0. Sistemdən çıxmaq");

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
                        ShowProductCategories();
                        break;
                    case 2:
                        ShowSaleCategories();
                        break;
                    default:
                        Console.WriteLine("Yalnız 0 ilə 3 arası seçim edə bilərsiniz");
                        break;
                }

            } while (selectInt != 0);
#endregion
        }
        static void ShowProductCategories()
        {
            int selectInt;
            do
            {
                #region ProductMenu
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
                    #endregion
                    default:
                        Console.WriteLine("Yalnız 0 ilə 7 arasında rəqəm daxil edə bilərsiniz");
                        break;
                }
            } while (selectInt != 0);
        } //title menu
        static void ShowSaleCategories()
        {
            int selectInt;
            do
            {
                #region Sale Menu
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
                        ShowAddSale(); //Adding Sale 
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
                    default:
                        Console.WriteLine("Yalnız 0 ilə 8 arasında rəqəm daxil edə bilərsiniz");
                        break;
                    #endregion
                }

            } while (selectInt != 0);
        }//title menu
        static void ShowAddProduct()
        {

            Console.WriteLine("------------------Məhsul əlavə et-------------------");
            Product product = new Product();
            int selectInt;
            do
            {
                #region CATEGORY
                Console.WriteLine("Kateqoriya daxil edin");
                Console.WriteLine("1. Televisions");
                Console.WriteLine("2. Phones");
                Console.WriteLine("3. Tablets");
                Console.WriteLine("4. ComputerAccesories");
                Console.WriteLine("5. Books");
                Console.WriteLine("6. Clothes");

                Console.WriteLine("");
                Console.Write("Rəqəm daxil etməlisiniz: ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("Rəqəm daxil etməlisiniz!: ");
                    select = Console.ReadLine();
                }
                switch (selectInt)
                {
                    case 1:
                        product.ProductCategory = Category.Televisions;
                        break;
                    case 2:
                        product.ProductCategory = Category.Phones;
                        break;
                    case 3:
                        product.ProductCategory = Category.Tablets;
                        break;
                    case 4:
                        product.ProductCategory = Category.ComputerAccesories;
                        break;
                    case 5:
                        product.ProductCategory = Category.Books;
                        break;
                    case 6:
                        product.ProductCategory = Category.Clothes;
                        break;
                    default:
                        Console.WriteLine("Yalnız 1 ilə 6 arasında seçim edə bilərsiniz");
                        ShowAddProduct();

                        break;
                        #endregion
                }

            } while (selectInt == 0);

            #region Product Code

            Console.WriteLine("Məhsulun kodunu daxil edin");
            string productCodeInput = Console.ReadLine();
            int ProductCode;

            while (!int.TryParse(productCodeInput, out ProductCode))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edə bilərsiniz");
                
                productCodeInput = Console.ReadLine();
            }
            product.ProductCode = ProductCode;

            #endregion

            #region Product Name
            Console.WriteLine("Məhsulun adını daxil edin");
            product.ProductName = Console.ReadLine();

            #endregion

            #region Product Price

            Console.WriteLine("Məhsulun qiymətini daxil edin");
            string productPriceInput = Console.ReadLine();
            double ProductPrice;

            while (!double.TryParse(productPriceInput, out ProductPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edə bilərsiniz");
                Console.ReadLine();
            }
            product.ProductPrice = ProductPrice;
            #endregion

            #region Product Count
            Console.WriteLine("Məhsulun miqdarını daxil edin");
            string productCountInput = Console.ReadLine();
            int Count;

            while (!int.TryParse(productCountInput, out Count))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edə bilərsiniz");
                Console.ReadLine();
                #endregion
            }
            product.Count = Count;
            _marketableService.AddProduct(product);
        } //completed
        static void ShowEditProduct()
        {
            Product product = new Product();

            Console.WriteLine("-------------- Məhsul üzərində düzəliş etmək --------------");
            Console.Write("Məhsulun kodunu daxil edin: ");
            int code = Convert.ToInt32(Console.ReadLine());

            List<Product> productCode = _marketableService.ChangeProductInfo(code);

            #region Input Price, Count, Name
            Console.WriteLine("");
            Console.Write("Məhsulun yeni adını daxil edin: ");
            string productName = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Məhsulun yeni sayını daxil edin: ");
            int count = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");
            Console.Write("Məhsulun yeni məbləğini daxil edin: ");
            double productPrice = Convert.ToDouble(Console.ReadLine());

            #endregion
            Console.WriteLine("");
            int selectInt;
            do
            {
                #region ChooseCategory
                Console.WriteLine("Kateqoriya daxil edin");
                Console.WriteLine("1. Televisions");
                Console.WriteLine("2. Phones");
                Console.WriteLine("3. Tablets");
                Console.WriteLine("4. ComputerAccesories");
                Console.WriteLine("5. Books");
                Console.WriteLine("6. Clothes");


                Console.WriteLine("");
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("Rəqəm daxil etməlisiniz!: ");
                    select = Console.ReadLine();
                }


                switch (selectInt)
                {
                    case 1:
                        product.ProductCategory = Category.Televisions;
                        break;
                    case 2:
                        product.ProductCategory = Category.Phones;
                        break;
                    case 3:
                        product.ProductCategory = Category.Tablets;
                        break;
                    case 4:
                        product.ProductCategory = Category.ComputerAccesories;
                        break;
                    case 5:
                        product.ProductCategory = Category.Books;
                        break;
                    case 6:
                        product.ProductCategory = Category.Clothes;
                        break;
                    default:
                        Console.WriteLine("Yalnız 1 ilə 6 arasında seçim edə bilərsiniz");
                        break;
                        #endregion
                }
            } while (selectInt > 6 || selectInt < 1);
            #region Product Informations
            foreach (var item in productCode)
            {
                item.ProductName = productName;
                item.Count = count;
                item.ProductPrice = productPrice;
                item.ProductCategory = (Category)selectInt;
            }
            #endregion
        } //completed
        static void ShowRemoveProduct()
        {

            Product product = new Product();
            Console.WriteLine("---------------------Məhsulu ləğv et----------------");


            Console.WriteLine("Məhsulun kodunu daxil edin");
            int code = Convert.ToInt32(Console.ReadLine());
            _marketableService.RemoveProduct(code);
            

            if (product != null)
            {
                Console.WriteLine("\n -------Məhsul silindi--------");
            }
            else
            {
                Console.WriteLine("Nəsə səhvlik var");
            }

        }  //completed
        static void ShowAllProduct()
        {
            #region table
            var table = new ConsoleTable("№", "Kodu", "Adı", "Qiyməti", "Kateqoriyası", "Anbarda qalıb");
            var i = 1;
            foreach (var item in _marketableService.Products)
            {
              table.AddRow(i, item.ProductCode, item.ProductName, item.ProductPrice, item.ProductCategory, item.Count);
                i++;

            }
            table.Write();
            #endregion
        }  //completed
        static void ShowCategoryProduct()
        {
            
            Console.WriteLine("Daxil edilmiş kateqoriyaya görə məhsulları çıxarmaq");
            Product product = new Product();

            int selectInt;
            do
            {
                #region inputeCategory
                Console.WriteLine("Kateqoriya daxil edin");
                Console.WriteLine("1. Televisions");
                Console.WriteLine("2. Phones");
                Console.WriteLine("3. Tablets");
                Console.WriteLine("4. ComputerAccesories");
                Console.WriteLine("5. Books");
                Console.WriteLine("6. Clothes");

                Console.WriteLine("");
                Console.Write("Rəqəm daxil etməlisiniz: ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("Rəqəm daxil etməlisiniz!: ");
                    select = Console.ReadLine();
                }
                switch (selectInt)
                {
                    case 1:
                        product.ProductCategory = Category.Televisions;
                        break;
                    case 2:
                        product.ProductCategory = Category.Phones;
                        break;
                    case 3:
                        product.ProductCategory = Category.Tablets;
                        break;
                    case 4:
                        product.ProductCategory = Category.ComputerAccesories;
                        break;
                    case 5:
                        product.ProductCategory = Category.Books;
                        break;
                    case 6:
                        product.ProductCategory = Category.Clothes;
                        break;
                    default:
                        Console.WriteLine("Yalnız 1 ilə 6 arasında seçim edə bilərsiniz");
                        break;
                        #endregion
                }

            } while (selectInt <1 || selectInt>6 );


            List<Product> result = _marketableService.CategoryProduct(product.ProductCategory);
            Console.WriteLine(result);


        } //completed
        static void ShowProductbyTwoPrice()
        {
            Console.WriteLine("------------ 2 qiymət aralığındakı məhsulları göstərin------------");
            Console.WriteLine();

            #region input Prices
            Console.WriteLine("Başlanğıc qiyməti daxil edin");
            string startPriceInput = Console.ReadLine();
            double StartPrice;
            Console.WriteLine();


            while (!double.TryParse(startPriceInput, out StartPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edin");
                Console.WriteLine();
                startPriceInput = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Son qiyməti daxil edin");
            Console.WriteLine();
            string endPriceInput = Console.ReadLine();
            double EndPrice;

            while (!double.TryParse(endPriceInput, out EndPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edin");
                Console.WriteLine();
                endPriceInput = Console.ReadLine();
                Console.WriteLine();
            }
            #endregion
            List<Product> result = _marketableService.ProductforTwoPrice(StartPrice, EndPrice);
            Console.WriteLine(result);
            
        } //completed
        static void ShowSearch()
        {

            Console.WriteLine("------------Axtarış edin-------------");
            Product product = new Product();

            #region input Your Searching word
            Console.WriteLine("Yazın: ");
            string result = Console.ReadLine();
            _marketableService.SearchingProduct(result);
            Console.WriteLine(result);
            #endregion
        } //completed
        static void ShowAddSale()
        {
            Console.WriteLine("Satış əlavə edin");
            Sale addSale = new Sale();

            #region SaleNumber
            DateTime Date;
            int itemCount;
            int productCode;

            do
            {
            Console.WriteLine("Satışın Nömrəsini daxil edin: ");
            string inputNumber = Console.ReadLine();
            int Number;
            while (!int.TryParse(inputNumber, out Number))
            {
                    
                Console.WriteLine("Yalnız rəqəm daxil edə bilərsiniz");
                    inputNumber = Console.ReadLine();
            }
            addSale.SaleNumber = Number;

            #endregion
            Console.WriteLine("Satış tarixini daxil edin");
            string inputDate = Console.ReadLine();

            while (!DateTime.TryParse(inputDate, out Date))
            {
                Console.WriteLine("Düzgün tarix daxil edin");
                    inputDate = Console.ReadLine();

            }
            addSale.Date = Date;

            SaleItem saleItem = new SaleItem();

            #region SaleItemCount

            Console.WriteLine("İtem Miqdarını daxil edin");
            string inputItemCount = Console.ReadLine();

            while (!int.TryParse(inputItemCount, out itemCount))
            {
                Console.WriteLine("Yalnız rəqəm daxil edə bilərsiniz");
                    inputItemCount = Console.ReadLine();
            }
            saleItem.SaleItemCount = itemCount;
            #endregion
                                             
            Product product = new Product();

            #region ProductCode

            Console.WriteLine("Kodu daxil edin: ");
            string inputItemCode = Console.ReadLine();
            while (!int.TryParse(inputItemCode, out productCode)) 
            {
                Console.WriteLine("Yalnız rəqəm daxil edə bilərsiniz");
                    inputItemCode = Console.ReadLine();
            }
            product.ProductCode = productCode;
            #endregion ProductCode

            _marketableService.AddSale(productCode, itemCount, Number, Date);
            } while (itemCount ==0);

        }
        static void ShowCancelledProductfromSale()
        {
            Console.WriteLine("-----------Satışdakı hansısa məhsulun geri qaytarılması------------") ;
            Console.WriteLine();
            Console.WriteLine();
            Product product = new Product();
            Sale sale = new Sale();
            SaleItem saleItem = new SaleItem();

            Console.WriteLine("Satışın nömrəsini daxil edin");
            string inputSaleNumber = Console.ReadLine();
            int SaleNumber;
            while (!int.TryParse(inputSaleNumber, out SaleNumber))
            {
                Console.WriteLine("Yalnız rəqəm daxil edə bilərsiniz");
                inputSaleNumber = Console.ReadLine();
            }
            sale.SaleNumber = SaleNumber;

            Console.WriteLine("Məhsulun kodunu daxil edin");
            string inputProductCode = Console.ReadLine();
            int productCode;
            while (!int.TryParse(inputProductCode, out productCode))
            {
                Console.WriteLine("Yalnız rəqəm daxil edə bilərsiniz");
                inputProductCode = Console.ReadLine();
            }
            product.ProductCode -= productCode;

            Console.WriteLine("Məhsulun miqdarını daxil edin");
            string inputSaleItemCount = Console.ReadLine();
            int SaleItemCount;
            while (!int.TryParse(inputSaleItemCount, out SaleItemCount))
            {
                Console.WriteLine("Yalnız rəqəm daxil edə bilərsiniz");
                inputSaleItemCount = Console.ReadLine();
            }
            saleItem.SaleItemCount = SaleItemCount;

            _marketableService.RemoveProductBySale(SaleNumber, SaleItemCount, productCode);
        }
        static void ShowRemovedSale()
        {
            Sale sale = new Sale();
            Console.WriteLine("-----------------------Satışı ləğv edin---------------------");
             
            Console.WriteLine("Satışın kodunu daxil edin");
            int code = Convert.ToInt32(Console.ReadLine());
            _marketableService.RemoveSale(code);

            
            if (sale != null)
            {
                Console.WriteLine("\n -------Məhsul silindi--------");
            }
            else
            {
                Console.WriteLine("Nəsə səhvlik var");
            }
        } //completed
        static void ShowAllSales()
        {
            #region Table
            var table = new ConsoleTable("№","Nömrəsi", "Qiyməti", "Tarix", "Sayı");
            var i = 1;
            foreach (var item in _marketableService.Sales)
            {
                table.AddRow(i, item.SaleNumber, item.SalePrice, item.Date.ToString("dd.MM.yyyy"), item.SaleItems.Count);
                i++;

            }
            table.Write();
            #endregion
        } // completed
        static void ShowSalesbyTwoDate()
        {
            Console.WriteLine("Müəyyən tarix intervalındakı ümumi satış");

            Console.Write("Başlanğıc tarixi daxil edin: ");

            #region StartDate
            string startDateİnput = Console.ReadLine();
            DateTime StartDate;
            while (!DateTime.TryParse(startDateİnput, out StartDate))
            {
                Console.WriteLine("Tarixi daxil etməlisiniz: ");
                startDateİnput = Console.ReadLine();
            }
            #endregion

            #region EndDate

            Console.Write("Bitiş tarixini daxil edin: ");
            string endDateInput = Console.ReadLine();
            DateTime EndDate;
            while (!DateTime.TryParse(endDateInput, out EndDate)) 
            {
                Console.WriteLine("Tarixi daxil etməlisiniz");
                endDateInput = Console.ReadLine();
            }
            Console.WriteLine();
            #endregion
            List<Sale> result = _marketableService.TotalSaleDatebyDate(StartDate,EndDate);

            
        } //completed
        static void ShowSalesbyTwoPrice()
        {
            Console.WriteLine("------------ 2 qiymət aralığındakı satışları göstərin------------");
            Console.WriteLine();

            #region input Prices
            Console.Write("Başlanğıc qiyməti daxil edin: ");
            string startPriceInput = Console.ReadLine();
            double StartPrice;

            while (!double.TryParse(startPriceInput, out StartPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edin");
                Console.WriteLine();
                startPriceInput = Console.ReadLine();
            }

            Console.Write("Son qiyməti daxil edin: ");
            string endPriceInput = Console.ReadLine();
            double EndPrice;

            while (!double.TryParse(endPriceInput, out EndPrice))
            {
                Console.WriteLine("Yalnız rəqəmlərdən istifadə edin");
                Console.WriteLine();
                endPriceInput = Console.ReadLine();
            }
            Console.WriteLine();
            #endregion
            List<Sale> result = _marketableService.TotalSaleForPrice(StartPrice, EndPrice);
            Console.WriteLine(result);
        } //completed
        static void ShowSaleforDate()
        {
            Console.WriteLine("---------------Verilən tarixdəki satış-----------");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Tarixi daxil edin: ");
            string date = Console.ReadLine();
            DateTime Date;
            Console.WriteLine();

            while (!DateTime.TryParse(date, out Date))
            {
                Console.Write("Tarixi daxil edin: ");
                date = Console.ReadLine();   
            }
            Sale sale = new Sale();
            if (sale.Date.Equals(date))
            {
            }
            else
            {
                Console.WriteLine("duzgun tarix daxil edin");
            }
            List<Sale> result = _marketableService.TotalSaleForDate(Date);

            Console.WriteLine();


            Console.WriteLine(result);
        } //completed
        static void ShowSaleforNumber()
        {
            Console.WriteLine("Nömrəyə görə satışın çıxarılması");
            Console.WriteLine();
            Console.WriteLine();

            #region Input SaleNumber
            Console.Write("Nömrəni daxil edin: ");
            string inputNumber = Console.ReadLine();
            int Number;
            Console.WriteLine();
            while (!int.TryParse(inputNumber,out Number))
            {
                Console.Write("Ədəd daxil edin: ");
                Console.WriteLine();
                inputNumber = Console.ReadLine();
            }
            #endregion

            List<Sale> result = _marketableService.SearchingSaleForNumber(Number);

            #region Show Sale Properties
            foreach (var item in result)
            {
                Console.WriteLine("");
                Console.WriteLine("Satış məbləği: " + item.SalePrice);
                Console.WriteLine("Miqdar: " + item.SaleItems.Count);
                Console.WriteLine("Satış tarixi: " + item.Date.ToString("dd.MM.yyyy"));
            }
            #endregion
            var list = _marketableService.ShowSaleItem(Number);

            #region Sale Item Properties
            foreach (var item in list)
            {
                Console.WriteLine("");
                Console.WriteLine("Item nömrəsi: " + item.SaleItemNumber);
                Console.WriteLine("Miqdarı: " + item.SaleItemCount);
                Console.WriteLine("Məhsul adı: " + item.ProductName.ProductName);
            }

            #endregion
        } //completed
    }
}