using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour
{
    // Declare a public variable to access in our other script
    public string name;


    public void Function1(string name)
    {
        Debug.Log(Function2(name));
        
    }


    private string Function2(string name)
    {
        //Debug.Log(name + "has executed th script A's custom function.");
        return name + "has executed my Function 1!. I'm " + this.name + "by the way.";
    }
}