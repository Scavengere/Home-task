using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Shop
    {
        public static int TotalNumberOfOrders = 0;              //Общее кол-во заказов за сегодня
        private static Order[] Orders;                          //Массив заказов за сегодня
        public static string NameOfSeller;                      //Имя продавца
        private static Product[] Keyboards;                     //Массивы товаров
        private static Product[] Mouses;
        public Customer CurrentCustomer;                        //Текущий покупатель
        public Shop(string nameOfSeller)
        {
            Shop.NameOfSeller = nameOfSeller;
        }
        public void LoadAssortment()                                       //Подгрузка данных из файла
        {
            Keyboards = WorkingWithFile.ReadFromFile("Keyboards.txt");
            Mouses = WorkingWithFile.ReadFromFile("Mouses.txt");
        }
        public void NewClient(string nameOfClient, string productToCustomer, int priceOfProduct)    //Создние нового клиента
        {
            CurrentCustomer = new Customer(nameOfClient);
            TotalNumberOfOrders++;
            Array.Resize(ref Orders, TotalNumberOfOrders);
            Orders[TotalNumberOfOrders-1] = new Order(TotalNumberOfOrders, nameOfClient, productToCustomer, priceOfProduct);    //Создание заказа для текущего клиента
        }
        public int SearchingProductToCustomer(string typeOfPeripheral, string productToCustomer)            //Поиск товара для покупателя
        {                                                                                                   //Возвращает -1, если товар нет в наличии
            if(typeOfPeripheral == "keyboard")                                                              //            0, если товара нет в ассортименте
            {                                                                                               //  цену товара, если он есть
                for(int i = 0; i < Keyboards.Length; i++)
                {
                    if (productToCustomer == Keyboards[i].NameOfProduct)
                        if (Keyboards[i].AmountOfProduct > 0)
                            return Keyboards[i].PriceOfProduct;
                        else return -1;
                }
            }
            if (typeOfPeripheral == "mouse")
            {
                for (int i = 0; i < Mouses.Length; i++)
                {
                    if (productToCustomer == Mouses[i].NameOfProduct)
                        if (Mouses[i].AmountOfProduct > 0)
                            return Mouses[i].PriceOfProduct;
                        else return -1;
                }
            }
            return 0;
        }
        public bool ProductInformation(string typeOfPeripheral, string productToCustomer, int thePriceOfTheProduct)             //Вывод информации о товара, если он есть
        {
            if (thePriceOfTheProduct > 0)
            {
                Console.WriteLine($"The product is in stock. The {typeOfPeripheral} {productToCustomer} costs: {thePriceOfTheProduct}");
                return true;
            }
            else if (thePriceOfTheProduct == -1)
            {
                Console.WriteLine("The product is out of stock.");
                return false;
            }
            else
            {
                Console.WriteLine("This product is not in our product range.");
                return false;
            }
        }
        public bool PaymentOfPurchase()                                                             //Проверка баланса текущего покупателя
        {                                                                                           //Если средств хватает, то они списываются и статусу заказа присваивается "завершено"
            if(CurrentCustomer.BalanceOfCustomer >= Orders[TotalNumberOfOrders-1].PriceOfProduct)   //Если не хватает, статусу заказа присваивается "нехватка средств"
            {
                CurrentCustomer.BalanceOfCustomer -= Orders[TotalNumberOfOrders-1].PriceOfProduct;
                Orders[TotalNumberOfOrders-1].CompletedOrder();
                return true;
            }
            else
            {
                Orders[TotalNumberOfOrders-1].LackOfFunds();
                return false;
            }
        }
        public static void OutputAllOrders()                //Вывод информации о всех заказах за сегодня
        {
            Console.WriteLine(" _________________________________________________________________________________________________ ");
            Console.WriteLine("|Number Of Order|Name Of Customer|        Name Of Product        |Price Of Product|Status Of Order|");
            Console.WriteLine("|_______________|________________|_______________________________|________________|_______________|");
            for (int i = 0; i < Orders.Length; i++)
            {
                Console.WriteLine($"|{Orders[i].NumberOfOrder,15}|{Orders[i].NameOfCustomer,16}|{Orders[i].NameOfProduct,31}|{Orders[i].PriceOfProduct,16}|{Orders[i].StatusOfOrder,15}|");
            Console.WriteLine("|_______________|________________|_______________________________|________________|_______________|");
            }
        }
    }
}
