using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask.Computer
{
    /*TODO: По хорошему я бы транзакции сюда прокинул, с корзиной. Саму систему магазина организовал бы
     через паттерны семейства MVX - был опыт работы с MVC, MVVM на JavaFx, C# 
    */
    
    public class Store
    {
        private List<ISaleable> goods;
        private float cash;

        public Store()
        {
            goods = new List<ISaleable>()
            {
                
            };
        }

        public void ShowGoods()
        {
            foreach (ISaleable good in goods)
            {
                Console.WriteLine($" Price: {good.GetPrice()}");
                Console.WriteLine($" Characteristics: {good.GetCharacteristics()}");
            }
        }

        public void SoldGood(string id)
        {
            ISaleable good = FindItemById(id);
            cash += good.GetPrice();
            RemoveItem(good);
        }
        
        
        private ISaleable FindItemById(string id) => 
            goods.FirstOrDefault(good => good.Id.Equals(id));

        
        
        private void AddItem(ISaleable good) => goods.Add(good);
        
        
        private void RemoveItem(ISaleable good) => goods.Remove(good);
    }
}