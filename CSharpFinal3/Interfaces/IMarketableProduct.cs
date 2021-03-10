using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal3.Interfaces
{
    interface IMarketableProduct
    {
        //Mehsullar
        void Products();
        //Satishdan Mehsulun Geri Qaytarilmasi
        string ProductSales();
        //Yeni Mehsul Elave Etmek
        void AddProduct();
        // Mehsulun adini,sayini ve meblegini,categoriyasini deyismek (code-a gore tapilacaq)
        void ChangeProductInfo();
        //Verilmis kateqoriyaya esasen hemin kateqoriyada olan mehsullarin qaytarilmasi
        string ProductForCategory();
        //Verilmis qiymet araligina esasen hemin araliqda olan mehsullarin qaytarilmasi
        string ProductForPrice();
        //Verilmis ada esasen mehsullarin search edilib qaytarilmasi
         void ShowProductForName();
    }
}
