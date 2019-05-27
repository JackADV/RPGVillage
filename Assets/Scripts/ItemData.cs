using UnityEngine;

public static class ItemData 
{
    public static Item CreateItem(int itemID)
    {
        string name = "";
        int value = 0;
        string description = "";
        string icon = "";
        string mesh = "";
        ItemType type = ItemType.Food;
        int heal = 0;
        int damage = 0;
        int armour = 0;
        int amount = 0;
        switch (itemID)
        {

            #region Food 0-99
            case 0:              
                name = "Apple";
                value = 5;
                description = "Munchy and Crunchy";
                icon = "Food/Apple_Icon";
                mesh = "Food/Apple_Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
                break;
            case 1:
                name = "Bread";
                value = 5;
                description = "Crunchy on the outside moist and soft on the inside";
                icon = "Food/Bread_Icon";
                mesh = "Food/Bread_Mesh";
                type = ItemType.Food;
                heal = 10;
                amount = 1;
                break;
            case 2:
                name = "Cupcake";
                value = 10;
                description = "Sweet and a fun time food";
                icon = "Food/Cupcake_Icon";
                mesh = "Food/Cupcake_Mesh";
                type = ItemType.Food;
                heal = 12;
                amount = 1;
                break;

            #endregion
            #region Weapon 100-199
            case 100:
                name = "Mace";
                value = 50;
                description = "You gonna die";
                icon = "Weapon/Mace_Icon";
                mesh = "Weapong/Mace_Mesh";
                type = ItemType.Weapon;
                damage = 65;
                amount = 1;
                break;
            case 101:
                name = "Hammer";
                value = 48;
                description = "Your head is gonna get crushed";
                icon = "Weapon/Hammer_Icon";
                mesh = "Weapon/Hammer_Icon";
                type = ItemType.Weapon;
                damage = 80;
                amount = 1;
                break;
            case 102:
                name = "Sword";
                value = 60;
                description = "Slice and dice time";
                icon = "Weapon/Sword_Icon";
                mesh = "Weapon/Sword_Mesh";
                type = ItemType.Weapon;
                damage = 60;
                amount = 1;
                break;
            #endregion
            #region Apparel 200-299
            case 200:
                name = "Cloak";
                value = 20;
                description = "A smashing cloak for a smashing adventure";
                icon = "Apparel/Cloak_Icon";
                mesh = "Apparel/Cloak_Mesh";
                type = ItemType.Apparel;
                armour = 5;
                amount = 1;
                break;
            case 201:
                name = "Shield";
                value = 30;
                description = "Blocks attacks";
                icon = "Apparel/Shield_Icon";
                mesh = "Apparel/Shield_Mesh";
                type = ItemType.Apparel;
                armour = 15;
                amount = 1;
                break;
            case 202:
                name = "Pants";
                value = 20;
                description = "You can't be running around pantless";
                icon = "Apparel/Pants_Icon";
                mesh = "Apparel/Pants_Mesh";
                type = ItemType.Apparel;
                armour = 8;
                amount = 1;
                break;
            #endregion
            #region Crafting 300-399
            case 300:
                name = "Leather";
                value = 3;
                description = "Fresh straight form the finest cow";
                icon = "Crafting/Leather_Icon";
                mesh = "Crafting/leather_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            case 301:
                name = "Cloth";
                value = 3;
                description = "The best cloth ever ever";
                icon = "Crafting/Cloth_Icon";
                mesh = "Crafting/Cloth_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            case 302:
                name = "Stone";
                value = 5;
                description = "Its pretty hard";
                icon = "Crafting/Stone_Icon";
                mesh = "Crafting/Stone_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            #endregion
            #region Quest 400-499
            case 400:
                name = "Ultra rare red berries";
                value = 1000;
                description = "So rare we can't even tell you how rare they are";
                icon = "Quest/RedBerry_Icon";
                mesh = "Quest/RedBerry_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            case 401:
                name = "The dagger the end all daggers";
                value = 1500000;
                description = "It is better than all daggers before it";
                icon = "Quest/Dagger_Icon";
                mesh = "Quest/Dagger_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            case 402:
                name = "The book of a thousand truths";
                value = 19500000;
                description = "It holds many truths";
                icon = "Quest/Book_Icon";
                mesh = "Quest/Bok_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            #endregion
            #region Ingredients 500-599
            case 500:
                name = "Grapes";
                value = 2;
                description = "You could make wine";
                icon = "Ingredients/Grapes_Icon";
                mesh = "Ingredients/Grapes_Mesh";
                type = ItemType.Ingredient;
                amount = 1;
                break;
            case 501:
                name = "Fish";
                value = 8;
                description = "You could make a mean fish diner";
                icon = "Ingredients/Fish_Icon";
                mesh = "Ingredients/Fish_Mesh";
                type = ItemType.Ingredient;
                amount = 1;
                break;
            case 502:
                name = "Chocolate";
                value = 7;
                description = "Who doesn't love chocolate";
                icon = "Ingredients/Chocolate_Icon";
                mesh = "Ingredients/Chocolate_Mesh";
                type = ItemType.Ingredient;
                amount = 1;
                break;
            #endregion
            #region Potions 600-699
            case 600:
                name = "Health Potion";
                value = 25;
                description = "Restores health and tastes like cherry";
                icon = "Potion/HealthPotion_Icon";
                mesh = "Potion/HealthPotion_Mesh";
                type = ItemType.Potion;
                heal = 100;
                amount = 1;
                break;
            case 601:
                name = "Mana Potion";
                value = 25;
                description = "Restores mana and tastes like blueberry";
                icon = "Potion/ManaPotion_Icon";
                mesh = "Potion/ManaPotion_Mesh";
                type = ItemType.Potion;
                amount = 1;
                break;
            case 602:
                name = "Stamina Potion";
                value = 25;
                description = "restores stamina and tastes like grape";
                icon = "Potion/StaminaPotion_Icon";
                mesh = "Potion/StaminaPotion_Mesh";
                type = ItemType.Potion;
                amount = 1;
                break;

            #endregion
            #region Scrolls 700-799
            case 700:
                name = "Scroll Of Necromancy";
                value = 500;
                description = "Summons skeletons cool right";
                icon = "Scrolls/Scroll Of Necromancy_Icon";
                mesh = "Scrolls/Scrolls_Mesh";
                type = ItemType.Scroll;
                amount = 1;
                break;
            case 701:
                name = "The Scroll Of Batman";
                value = 10000;
                description = "Summons batman to your aid";
                icon = "Scrolls/The Scroll Of Batman_Icon";
                mesh = "Scrolls/The Scroll Of Batman__Mesh";
                type = ItemType.Scroll;
                amount = 1;
                break;
            case 702:
                name = "Scroll Of Basic Spells";
                value = 25;
                description = "Allows you to cast basic spells";
                icon = "Scrolls/Scroll Of Basic Spells_Icon";
                mesh = "Scrolls/Scroll Of Basic Spells__Mesh";
                type = ItemType.Scroll;
                amount = 1;
                break;
            #endregion
            default:
                itemID = 0;
                name = "Apple";
                value = 5;
                description = "Munchy and Crunchy";
                icon = "Food/Apple_Icon";
                mesh = "Food/Apple_Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
                break;
        }
        Item temp = new Item
        {
            Name = name,
            Description = description,
            ID = itemID,
            Value = value,
            Damage = damage,
            Armour = armour,
            Amount = amount,
            Heal = heal,
            Type = type,
            Mesh = Resources.Load("Prefabs/" + mesh) as GameObject,
            icon = Resources.Load("Icon/" + icon) as Texture2D
        };
        return temp;
    }
}
