using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal3.Interfaces
{
    interface IMarketableSales
    {
        //Satishlar
        void Sales();
        //Satish Elave Etmek
        void AddSales();

        //Umumi satisin geri qaytarilmasi
        string AllSales();
        // Verilen tarix araligina gore hemin tarix araligina olan satislarin qaytarilmasi
        string SalesForDate();
        // Verilen bir tarixe gore hemin tarix (il,ay,gun) ucun olan satislarin qaytarilmasi
        string SalesForExactDate();
        //Verilmis mebleg araligina gore edilmis satislarin qaytarilmasi
        string SalesForPrice();
        //Verilmis nomreye esasen satisin qaytarilmasi
        string SalesForNumber();
    }
}
