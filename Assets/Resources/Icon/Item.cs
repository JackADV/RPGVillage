using UnityEngine;

public class Item
{
    #region Variables
    private int _id;
    private string _name;
    private string _description;
    private int _amount;
    private int _value;
    private ItemType _type;
    private Texture2D _icon;
    private GameObject _mesh;

    private int _damage;
    private int _armour;
    private int _heal;
    private int _durability;
    private string _rarity;
    private int _mana;
    #endregion
    #region Public Properties
    public int ID
    {
        get { return _id; }//read
        set { _id = value; }//write
    }
    public string Name
    {
        get { return _name; }//read
        set { _name = value; }//write
    }
    public string Description
    {
        get { return _description; }//read
        set { _description = value; }//write
    }
    public int Value
    {
        get { return _value; }//read
        set { _value = value; }//write
    }
    public int Amount
    {
        get { return _amount; }//read
        set { _amount = value; }//write
    }
    public int Damage
    {
        get { return _damage; }//read
        set { _damage = value; }//write
    }
    public int Armour
    {
        get { return _armour; }//read
        set { _armour = value; }//write
    }
    public int Heal
    {
        get { return _heal; }//read
        set { _heal = value; }//write
    }
    public GameObject ItemMesh
    {
        get { return _mesh; }
        set { _mesh = value; }

    }
    public int Durability
    {
        get { return _durability; }//read
        set { _durability = value; }//write
    }
    public string Rarity
    {
        get { return _rarity; }//read
        set { _rarity = value; }//write
    }
    public Texture2D Icon
    {
        get { return _icon; }
        set { _icon = value; }
    }
    public ItemType Type
    {
        get { return _type; }
        set { _type = value; }
        #endregion
    }
    public int Mana
    {
        get { return _mana; }//read
        set { _mana = value; }//write
    }
}
public enum ItemType
{
    Ingredient,
    Potion,
    Scroll,
    Food,
    Apparel,
    Weapon,
    Resource,
    Equipment,
    Armour,
    QuestItem,
    Money,
    Junk,
    Miscellanious,
    UNASSIGNED



        // public enum PerkFunction
        // {Health increase, damage increase }

}
