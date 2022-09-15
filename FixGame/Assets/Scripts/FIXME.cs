using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * =========================================================================
 *                              INSTRUCTIONS
 * 
 * Go through this script and the Square objects in Unity and find the 
 *      errors, there are 22 in total!
 * All script you should ignore are hidden away in marked regions.
 * Your code is working when all sqaures will be visible AND no errors 
 *      or warnings are present in your console
 * Every line you can edit will have a comment next to it explaining what 
 *      the line SHOULD do (rather than what it might be doing in the 
 *      case that it is broken, use that as a guide if something looks off
 * Double-check the inspector in Unity to make sure everything is hooked 
 *      up properly!
 * 
 * =========================================================================
*/



public class FIXME : MonoBehaviour
{
    //Inspector Variables
    //All of these variables are used to grab information from the square objects that are displayed in our scene
    public SpriteRenderer spriteRenderer; //here we attach the sprite renderer of our square in the inspector
    public Color clickColor; //the color the square changes to when clicked
    public int squareID; //the integer that is the same number as the corresponding square

    //Math Variables
    //These variables are used to run various tests before confirming our code is working
    private float _x = 2f; //number used to manipulate outcomes based on what number the square is
    private int _localID; //used to manipulate our squareID without changing that base number
    private Int _temp; //a temperary variable we'll use in math
    private bool _run; //a true or false variable that determines whether or not we should run the code

    
    Start()
    {
        if (_run == true) { //if _run is true, run all of the code!

            for (int i = 0, int i < sqareID, int i++) //count up to the squareID number and then assign it to _localID
            {
                _localID = int i; //addign i to _localID
            }

            _temp = Divider(_x, _localID); //divided the second number by the first one and assigns it to _temp

            if (_temp == 0) //if the _localID is 0 or 1
            {
                if (_localID == 0) //if _localID is 0
                {
                    ChangeColor() //call the ChangeColor() function
                }
                else if (_localID = 1) //if _localID is 1
                {
                    ChangeColor(); //call the ChangeColor() function
                }
            }
            else if (_temp == 1) //if the _localID is 2 or 3
            (
                if (_localID == 2) //if _localID is 0
                {
                    ChangeColor(); //call the ChangeColor() function
                }
                else if (_localID == 3) //if _localID is 1
                {
                    ChangeColor; //call the ChangeColor() function
                }
            )
            else if (_temp == 2) //if the _localID is 4 or 5

                if (_localID > 5) //if _localID is 4
                {
                    ChangeColor(); //call the ChangeColor() function
                }
                else if (_localID < 4) // if _localID is 5
                {
                    ChangeColor(); //call the ChangeColor() function
                }

            else if (_temp == 3) //if the _localID is 6 or 7
            {
                if (_localID <<= 6) //if _localID is 6
                {
                    ChangeColor(); //call the ChangeColor() function
                }
                else if (_localID >= 7) //if _localID is 7
                {
                    ChangeColor(); //call the ChangeColor() function
                }
            }
            else (_temp == 4) //if the _localID is 8 or 9
            {
                if (_localID == 8) //if _localID is 8
                {
                    ChangeColor(); //call the ChangeColor() function
                }
                else //if _localID is 9
                {
                    ChangeColor(); //call the ChangeColor() function
                }
            }
            else //if the _localID is 10 or 11
            {
                if (_localID < 10) //if _localID is 10
                {
                    ChangeColor(); //call the ChangeColor() function
                }
                else if (_localID > 10) //if _localID is 11
                {
                    ChangeColor(); //call the ChangeColor() function
                }

            }
        }
    }

    void ChangeColor()
    {
        SpriteRenderer.color = clickColor; //set the color of the sprite, on the sprite renderer to the color we have set with our clickColor variable
    }

    int Divider(int x, int y) //you can call on this function to divide the second number by the first one
    {
        int divided = y / x; //divides y by x

        return divided; //assigns y/x to the value you called this function to assign to
    




}
