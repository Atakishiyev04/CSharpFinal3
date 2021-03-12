using CSharpFinal3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal3
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Product product = new Product();
            List<Product> products = new List<Product>();
            products.Add(product);
        }
        public static void Start()
        {
            Console.WriteLine("Duzgun Reqem Daxil Edin");
            string number = Console.ReadLine();
            if (number == "1")
            {
                Console.WriteLine("1 Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("Reqem Daxil Edin");
                string number1 = Console.ReadLine();
                switch (number1)
                {
                    case "1":
                        Console.WriteLine("Yeni Mehsul  Elave Et");
                        Console.WriteLine("Mehsulun Adini Daxil Edin");
                        string productname = Console.ReadLine();
                        Console.WriteLine("Mehsulun Qiymetini Daxil Edin");
                        try
                        {
                            double productprice = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Duzgun Qiymet Daxil Edin");
                        }
                        double productprice1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Mehsulun Sayini Daxil Edin");
                        int productnumber = Convert.ToInt32(Console.ReadLine());
                        Product product = new Product(productname, productprice1, productnumber);


                        break;
                    case "2":
                        Console.WriteLine("Mehsul Uzreinde Duzelish Et");
                        break;
                    case "3":
                        Console.WriteLine("Mehsulu Sil");
                        break;
                         case "4":
                        Console.WriteLine("Butun Mehsullari Goster");
                        break;
                    case "5":
                        Console.WriteLine("categoriyasina gore mehsullari goster");
                        break;
                    case "6":
                        Console.WriteLine("Qiymet araligina gore mehsullari goster");
                        break;
                    case "7":
                        Console.WriteLine("Mehsullar arasinda ada gore axtarish et");
                        break;
                    default:
                        Console.WriteLine("Duzgun Reqem Daxil Edin");
                        break;
                }

            }
           
            {
                Console.WriteLine("Duzgun Reqem Daxil Edin");
            }
        }
    }
}
