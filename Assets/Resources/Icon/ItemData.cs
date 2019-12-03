 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        // name, value, damage, attack speed, health increase
        int _amount = 0;
        int _value = 0;
        int _damage = 0;
        int _armour = 0;
        int _heal = 0;
        int _durability = 0;
        int _mana = 0;
        string _icon = "";
        string _mesh = "";
        string _name = "";
        string _description = "";
        string _rarity = "";
        ItemType _type = ItemType.UNASSIGNED;
        switch (itemID)
        {
            #region Ingredient 0 - 99
            case 0:
                _name = "Forest Mushroom";
                _description = "A hearty mushroom used for cooking with basic ingredients";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredients/Mushroom1";
                _mesh = "Ingredients/Mushroom1";
                _damage = 0;
                _armour = 0;
                _heal = 2;
                _rarity = "common";
                break;
            case 1:
                _name = "Cave Mushroom";
                _description = "Found in caves this mushroom is used to craft posionous foods, death is guaranteed";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredients/Mushroom2";
                _mesh = "Ingredients/Mushroom2";
                _damage = 0;
                _armour = 0;
                _heal = -7;
                _rarity = "common";
                break;
            case 2:
                _name = "Witch Hat Mushroom";
                _description = "Located near witch huts these mushrooms pack a stronger poison effect than cave mushrooms, death is extra guranateed";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredients/Mushroom3";
                _mesh = "Ingredients/Mushroom3";
                _damage = 0;
                _armour = 0;
                _heal = -15;
                _rarity = "uncommon";
                break;
            #endregion
            #region Potion 100 - 199
            case 100:
                _name = "Mana Potion";
                _description = "A potion that grants quick mana recovery, every mage should have one y'know";
                _amount = 1;
                _value = 1;
                _type = ItemType.Potion;
                _icon = "Potions/Potion1";
                _mesh = "Potions/Potion1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "uncommon";
                _mana = 50;
                break;
            case 101:
                _name = "Blinding Potion";
                _description = "A potion used to blind enemies or nearby players, flashbang in a glass";
                _amount = 1;
                _value = 1;
                _type = ItemType.Potion;
                _icon = "Potions/Potion2";
                _mesh = "Potions/Potion2";
                _damage = 5;
                _armour = 0;
                _heal = 0;
                _rarity = "uncommon";
                _mana = 0;
                break;
            case 102:
                _name = "Potion of Sight";
                _description = "A potion usefull for dark caves or jorneys in night, pitch black is not a problem anymore";
                _amount = 1;
                _value = 1;
                _type = ItemType.Potion;
                _icon = "Potions/Potion3";
                _mesh = "Potions/Potion3";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "uncommon";
                _mana = 0;
                break;
            #endregion
            #region Scroll 200 - 299
            case 200:
                _name = "Fire Scroll";
                _description = "Grants the user powerful fire attacks while activated";
                _amount = 1;
                _value = 1;
                _type = ItemType.Potion;
                _icon = "Scrolls/Scroll1";
                _mesh = "Scrolls/Scroll1";
                _damage = 20;
                _armour = 0;
                _heal = 0;
                _rarity = "uncommon";
                break;
            case 201:
                _name = "Ice Scroll";
                _description = "Grants the user powerful ice attacks while activated";
                _amount = 1;
                _value = 1;
                _type = ItemType.Potion;
                _icon = "Scrolls/Scroll2";
                _mesh = "Scrolls/Scroll2";
                _damage = 25;
                _armour = 0;
                _heal = 0;
                _rarity = "uncommon";
                break;
            case 202:
                _name = "Earth Scroll";
                _description = "Grants the user powerful earth attacks while activated";
                _amount = 1;
                _value = 1;
                _type = ItemType.Potion;
                _icon = "Scrolls/Scroll3";
                _mesh = "Scrolls/Scroll3";
                _damage = 50;
                _armour = 0;
                _heal = 0;
                _rarity = "uncommon";
                break;
            #endregion
            #region Food 300 - 399
            case 300:
                _name = "Bread";
                _description = "A basic meal that heals a reasonable amount for its cost, not gluten free";
                _amount = 1;
                _value = 1;
                _type = ItemType.Food;
                _icon = "Food/Bread1";
                _mesh = "Food/Bread1";
                _damage = 0;
                _armour = 0;
                _heal = 10;
                _rarity = "common";
                break;
            case 301:
                _name = "Pizza";
                _description = "A meal that heals a large amount with its variety of ingredients";
                _amount = 1;
                _value = 1;
                _type = ItemType.Food;
                _icon = "Food/Pizza1";
                _mesh = "Food/Pizza1";
                _damage = 0;
                _armour = 0;
                _heal = 30;
                _rarity = "common";
                break;
            case 302:
                _name = "Cooked Prawns";
                _description = "A meal that heals a large amount for the rarity that it has, cooks would kill to use them";
                _amount = 1;
                _value = 1;
                _type = ItemType.Food;
                _icon = "Food/CookedPrawn1";
                _mesh = "Food/CookPrawn1";
                _damage = 0;
                _armour = 0;
                _heal = 50;
                _rarity = "rare";
                break;
            #endregion
            #region Apparel 400 - 499
            case 400:
                _name = "Neck Clothing";
                _description = "A creative piece of clothing to impress everyone with your bold and unusual fashion sense, no armour added";
                _amount = 1;
                _value = 1;
                _type = ItemType.Apparel;
                _icon = "Apparel/Neck1";
                _mesh = "Apparel/Neck1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            case 401:
                _name = "Cloth Shirt";
                _description = "A cheap and reliable way to stay warm on journeys";
                _amount = 1;
                _value = 1;
                _type = ItemType.Apparel;
                _icon = "Apparel/Shirt1";
                _mesh = "Apparel/Shirt1";
                _damage = 0;
                _armour = 5;
                _heal = 0;
                _rarity = "common";
                break;
            #endregion
            #region Weapon 500 - 599
            case 500:
                _name = "Axe";
                _description = "A war axe useful for dominating masses of minions with fast and chaotic swings";
                _amount = 1;
                _value = 1;
                _type = ItemType.Weapon;
                _icon = "Weapons/Axe1";
                _mesh = "Weapons/Axe1";
                _damage = 10;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            case 501:
                _name = "Bow";
                _description = "A Cheap bow but it'll shoot to kill";
                _amount = 1;
                _value = 1;
                _type = ItemType.Weapon;
                _icon = "Weapons/Bow1";
                _mesh = "Weapons/Bow1";
                _damage = 5;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            case 502:
                _name = "Sword";
                _description = "Sword used for stabbing, cutting and thrusting through your enemies";
                _amount = 1;
                _value = 1;
                _type = ItemType.Weapon;
                _icon = "Weapons/Sword1";
                _mesh = "Weapons/Sword1";
                _damage = 25;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            #endregion
            #region Resource 600 - 699
            case 600:
                _name = "Stick";
                _description = "A bunch of sticks used to start campires or...      other fires(arsony is illegal)";
                _amount = 1;
                _value = 1;
                _type = ItemType.Resource;
                _icon = "Resources/Stick1";
                _mesh = "Resources/Stick1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            case 601:
                _name = "Oak Wood";
                _description = "Wood from oak trees useful for crafting weapons";
                _amount = 1;
                _value = 1;
                _type = ItemType.Resource;
                _icon = "Resources/Wood1";
                _mesh = "Resources/Wood1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            case 602:
                _name = "Birch Wood";
                _description = "Wood from birch trees useful for crafting weapons";
                _amount = 1;
                _value = 1;
                _type = ItemType.Resource;
                _icon = "Resources/Wood2";
                _mesh = "Resources/Wood2";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            #endregion
            #region Equipment 700 - 799
            case 700:
                _name = "Wooden Flute";
                _description = "A flute for jamming out at a fire or on your journey";
                _amount = 1;
                _value = 1;
                _type = ItemType.Equipment;
                _icon = "Equipment/Flute1";
                _mesh = "Equipment/Flute1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            case 701:
                _name = "Wooden lute";
                _description = "A lute for jamming out at a fire or on your journey";
                _amount = 1;
                _value = 1;
                _type = ItemType.Equipment;
                _icon = "Equipment/Lute1";
                _mesh = "Equipment/Lut1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            case 702:
                _name = "Rope";
                _description = "Holes are no longer a problem if you have this bad boy";
                _amount = 1;
                _value = 1;
                _type = ItemType.Equipment;
                _icon = "Equipment/Rope1";
                _mesh = "Equipment/Rope1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            #endregion
            #region Armour 800 - 899
            case 800:
                _name = "Steel Helemt";
                _description = "Protects your head from lethal blows whilst you battle enemies up close";
                _amount = 1;
                _value = 1;
                _type = ItemType.Armour;
                _icon = "Armour/Helmet1";
                _mesh = "Armour/Helmet1";
                _damage = 0;
                _armour = 25;
                _heal = 0;
                _rarity = "common";
                break;
            #endregion
            #region QuestItem 900 - 999
            case 900:
                _name = "Power Stone";
                _description = "Infinity stone be cole brand compared to this";
                _amount = 1;
                _value = 999;
                _type = ItemType.QuestItem;
                _icon = "QuestItem/PowerStone1";
                _mesh = "QuestItem/PowerStone1";
                _damage = 100;
                _armour = 0;
                _heal = 0;
                _rarity = "quest legendary";
                break;
            #endregion
            #region Junk 1000 - 1099
            case 1000:
                _name = "Rat Tail";
                _description = "A tail from a rat";
                _amount = 1;
                _value = 1;
                _type = ItemType.Junk;
                _icon = "Junk/RatTail1";
                _mesh = "Junk/RatTail1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            #endregion
            #region  Miscellanious 1100 - 1199
            case 1100:
                _name = "Screws";
                _description = "useful for mechanical weapons";
                _amount = 1;
                _value = 1;
                _type = ItemType.Miscellanious;
                _icon = "Miscellaneous/Screws1";
                _mesh = "Miscellaneous/Screws1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;
            #endregion
            default:
                _name = "default";
                _description = "default item";
                _amount = 1;
                _value = 1;
                _type = ItemType.Miscellanious;
                _icon = "Ingredients/Mushroom1";
                _mesh = "Ingredients/Mushroom1";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                _rarity = "common";
                break;

        }

        Item temp = new Item
        {
            ID = itemID,
            Value = _value,
            Amount = _amount,
            Damage = _damage,
            Durability = _durability,
            Heal = _heal,
            Rarity = _rarity,
            Armour = _armour,
            Mana = _mana,
            Icon = Resources.Load("Icon/" + _icon) as Texture2D,
            ItemMesh = Resources.Load("Mesh/" + _mesh) as GameObject,
            Name = _name,
            Description = _description,
            Type = _type
        };
        return temp;
    }
}

