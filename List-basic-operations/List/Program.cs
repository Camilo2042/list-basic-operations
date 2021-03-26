using System;
using System.Collections.Generic;
using System.Text;

namespace List_basic_operations.List
{
    public class Program
    {
        public static void Main(String[] args)
        {
            JewelsList jewelsList = new JewelsList();

            Jewels j1 = new Jewels();
            j1.SaleDay = "Miercoles";
            j1.Branchoffice = "Meridian Avenue North";
            jewelsList.Add(j1);

            Jewels j2 = new Jewels();
            j2.SaleDay = "Viernes";
            j2.Branchoffice = "Northeast Campus Parkway";
            jewelsList.Add(j2);

            Jewels j3 = new Jewels();
            j3.SaleDay = "Lunes";
            j3.Branchoffice = "East Yesler Way";
            jewelsList.Add(j3);

            Jewels j4 = new Jewels();
            j4.SaleDay = "Martes";
            j4.Branchoffice = "Maiden Lane";
            jewelsList.Add(j4);

            Jewels j5 = new Jewels();
            j5.SaleDay = "Insert Example";
            j5.Branchoffice = "Insert Example";
            jewelsList.InsertP(j5, 3);

            jewelsList.Print();
        }
    }
}
