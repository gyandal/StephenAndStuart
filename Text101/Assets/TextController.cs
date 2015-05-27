using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;
    public enum States { cell, mirror, sheets0, lock0, cellMirror, sheets1, lock1, freedom };
    private States myState;
    // Use this for initialization
    void Start()
    {
        myState = States.cell;
        //text.text = "Hello World!";
    }

    // Update is called once per frame
    void Update()
    {
        print(myState);
        if(myState == States.cell)
        {
            StateCell();
        }
        else if (myState == States.sheets0)
        {
            StateSheets0();
        }
    }

    void StateCell()
    {
        text.text = @"You are in a prison cell, and you want to escape. There are some dirty sheets on the bed a mirror on the wall, and the door is locked from the outside.
Press S to view Sheets, M to view Mirror and L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets0;
        }
    }

    void StateSheets0()
    {
        text.text = @"Fucking filthy
Press R to return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
}
