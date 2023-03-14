using System;
using System.Collections.Generic;
using System.Text;

namespace _7._기타_문법
{
    enum ItemType
    {
        Weapon,
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
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Lambda
    {
        static List<Item> items = new List<Item>();

        static Item FindItem(Func<Item, bool> selector)
        {
            foreach (Item item in items)
            {
                if (selector(item))
                {
                    return item;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            // Lambda : 일회용 함수를 만드는데 사용하는 문법
            items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            // delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없으면 Action

            Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });
        }
    }
}
