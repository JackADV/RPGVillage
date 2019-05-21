using UnityEngine;
using System.Collections;
//this script can be found in the Component section under the option Character Set Up 
//Character Movement
//This script requires the component Character controller
[RequireComponent(typeof(CharacterController))]
//This command moves the script to its own menu on the Add Component Menu
[AddComponentMenu("IntroPRG/RPG/Player/Movement")]
public class Movement : MonoBehaviour
{
    #region Variables
    [Header("PLAYER MOVEMENT")]
    [Space(10)]
    //Header is only for the inspector but it must have members added to it (varibles)\\
    [Header("Characters Move Direction")]
    [Space(10)]
    //Vector3 is the type of varible\\
    //movedirection is the name of the varible can be called whatever you need it to be named\\
    //vector3 called moveDirection
    public Vector3 moveDirection;
    public static bool canMove;
    //we will use this to apply movement in worldspace
    //private CharacterController (https://docs.unity3d.com/ScriptReference/CharacterController.html) charC
    private CharacterController _charController;
    //[Header("Character Variables")]
    [Header("Character Variables")]
    [Space(10)]
    public float jumpSpeed;
    public float speed, gravity;
    //public float variables jumpSpeed, speed, gravity
    #endregion
    #region Start
    private void Start()
    //charc is on this game object we need to get the character controller that is attached to it
    {
        _charController = GetComponent<CharacterController>();
        canMove = true;

    }

    #endregion
    #region Update
    private void Update()
    {
       if (canMove)
        {
            //if our character is grounded
            if (_charController.isGrounded)  //we are able to move in game scene meaning
            {


                //moveDir has the value of Input.Get Axis.. Horizontal, 0, Vertical (horizontal is side to side movement vertical is front and back, the axis is always either 0,1 or -1)
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                //moveDir is transformed in the direction of our moveDir (moves to where the character is facing/the local direction)
                moveDirection = transform.TransformDirection(moveDirection);
                //our moveDir is then multiplied by our speed
                moveDirection *= speed;


                //we can also jump if we are grounded so
                //in the input button for jump is pressed then
                if (Input.GetButton("Jump"))

                    //our moveDir.y is equal to our jump speed
                    moveDirection.y = jumpSpeed;

            }


            //regardless of if we are grounded or not the players moveDir.y is always affected by gravity timesed my time.deltaTime to normalize it
            moveDirection.y -= gravity * Time.deltaTime;
            //we then tell the character Controller that it is moving in a direction timesed Time.deltaTime (this line is what makes the character move)
            _charController.Move(moveDirection * Time.deltaTime);
        }
    }
    #endregion
}
#region     hey hey its saturday
#endregion







//Input Manager(https://docs.unity3d.com/Manual/class-InputManager.html)
//Input(https://docs.unity3d.com/ScriptReference/Input.html)


