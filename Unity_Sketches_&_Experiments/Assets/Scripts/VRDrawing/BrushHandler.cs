using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushHandler : MonoBehaviour {


    //create a private variable that stores the currentColor

    private Color currentColor;

    //create a public variable that returns the prefab for drawing (hint, prefabs are gameobjects)

    public GameObject brushShape;

    //create a public function that sets up the color of the currentColor (hint, function must have a Color variable)
    public void setBrushColor(Color setColor)
    {
        //Set our material's color whatever color the Color selector is. We invoke this function from the colorSelector.
        transform.GetComponent<MeshRenderer>().material.color = setColor;
    }

    //create a public function that returns the Color of the currentColor
    public Color returnCurrentBrushColor()
    {
        // Returns the applied color when invoked
        return brushShape.transform.GetComponent<MeshRenderer>().material.color;
    }

}
