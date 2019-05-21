//in this script  you will only need using UnityEngine as we just need the script to connect to unity
using UnityEngine;
//this public class doent inherit from MonoBehaviour
//this script is also referenced by other scripts but never attached to anything
public class Item
{
    //basic variables for items that we need are 
    #region Private Variables
    //Identification Number
    private int _id;
    //Object Name
    private string _name;
    //Value of the Object
    private int _value;
    //Description of what the Object is
    private string _description;
    //Icon that displays when that Object is in an Inventory
    private Texture2D _icon;
    //Mesh of that object when it is equipt or in the world
    private GameObject _mesh;
    //Enum ItemType which is the Type of object so we can classify them
    private ItemType _type;
    private int _heal;
    private int _damage;
    private int _armour;
    private int _amount;


    #endregion
    #region Constructors
    //A constructor is a bit of code that allows you to create objects from a class. You call the constructor by using the keyword new 
    //followed by the name of the class, followed by any necessary parameters.
    //the Item needs Identification Number, Object Name, Icon and Type
    //here we connect the parameters with the item variables
    #endregion
    #region Public Variables
    //here we are creating the public versions or our private variables that we can reference and connect to when interacting with items
    //public Identification Number 
    public int ID
    {
        //get the private Identification Number
        get { return _id; }
        //and set it to the value of our public Identification Number
        set { _id = _value; }

    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public Texture2D icon
    {
        get { return _icon; }
        set { icon = value; }
    }
    public GameObject Mesh
    {
        get { return _mesh; }
        set { _mesh = value; }
    }
    public ItemType Type
    {
        get { return _type; }
        set { _type = value; }
    }
    public int Heal
    {
        get { return _heal; }
        set { _heal = value; }
    }
    public int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }
    public int Armour
    {
        get { return _armour; }
        set { _armour = value; }
    }
    public int Amount
    {
        get { return _amount; }
        set { _amount = value; }
    }
    //public Name 
    //get the private Name
    //and set it to the value of our public Name

    //public Value 
    //get the private Value
    //and set it to the value of our public Value
    //public Description 
    //get the private Description
    //and set it to the value of our public Description
    //public Icon 
    //get the private Icon
    //and set it to the value of our public Icon
    //public Mesh 
    //get the private Mesh
    //and set it to the value of our public Mesh
    //public Type 
    //get the private Type
    //and set it to the value of our public Type
    #endregion
}
#region Enums
//The Global Enum ItemType that we have created categories in
public enum ItemType
{
    Food,
    Weapon,
    Apparel,
    Crafting,
    Quest,
    Money,
    Ingredient,
    Potion,
    Scroll

}
#endregion
