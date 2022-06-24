using System;
using System.Collections.Generic;

namespace Lamda
{
    enum Itemtype
    {
        weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public Itemtype Itemtype;
        public Rarity Rarity;
    }
    class Program
    {

        //Item 클래스를 인자로 들고 있는 배열 생성
        static List<Item> items = new List<Item>();

        //item을 인자로 받는 delegate
        delegate bool Itemselector(Item item);

        //delegate에 제네릭도 사용 가능
        delegate Return Func<T, Return>(T item);
         


        //밑에 함수랑 같은 의미
        /*static Item FindItem(Itemselector selector*/

        static Item FindItem(Func<Item, bool> selector)

        {
            foreach (Item item in items)
            {
                // T/F 판별
                if (selector(item))
                    Console.WriteLine("실행");
                return item;
            }
            Console.WriteLine("실행");
            return null;
        }

        //밑에 람다식으로 대체 가능
/*        static bool Isweapon(Item item)
        {
            return item.Itemtype == Itemtype.weapon;
        }*/

        static Item Findrareitem()
        {
            foreach (Item item in items)
            {
                if (item.Rarity == Rarity.Rare)
                    return item;
            }
            return null;
        }


        static void Main(string[] args)
        {
            items.Add(new Item() { Itemtype = Itemtype.weapon, Rarity = Rarity.Normal });
            items.Add(new Item() { Itemtype = Itemtype.Armor, Rarity = Rarity.Uncommon });
            items.Add(new Item() { Itemtype = Itemtype.Ring, Rarity = Rarity.Rare });

            /*Item item = FindItem(isweapon);*/

            //무명 함수, 이게 되네?
            /*Item item = FindItem(delegate (Item item) { return item.Itemtype == Itemtype.weapon; });*/

            //람다, 위보다 간결해보임
            /*Func<Item, bool> selector = (Item item) => { return item.Itemtype == Itemtype.weapon; };*/
        }
    }
}
