using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelector : MonoBehaviour {

    //Create a public Color Type that can be set from the inspector to be used in each menu Item

    public Color colorSelector;
    private void Start()
    {
        //Set our material color to the colorSelector color

        transform.GetComponent<MeshRenderer>().material.color = colorSelector;
    }

    //Hint Look at Color class in Unity SDK

    //Setup Collider Trigger to send the color of this object to the Brush Handler

    private void OnTriggerEnter(Collider other)
    {
        // Find the brush in scene
        BrushHandler brushHandler = (BrushHandler)FindObjectOfType(typeof(BrushHandler));

        // If there is a brush, set our brush's color with the setBrushColor Method
        if (brushHandler)
        {

                other.gameObject.GetComponent<BrushHandler>().setBrushColor(colorSelector);
        }
        
    }

}
