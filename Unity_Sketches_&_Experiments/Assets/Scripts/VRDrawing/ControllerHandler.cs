using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerHandler : MonoBehaviour {
    private BrushHandler brushHandler;

    //public GameObject brush;
    public void Pressed()
    {

       // Debug.Log(transform.position);
        Draw();
    }


    private void Start()
    {

    }
    public void Update()
    {
        Pressed();

        //Instantiate(brush, transform.position, transform.rotation);

    }
        public void Draw()
    {

        //find the brush controller using findobject of type

        brushHandler = (BrushHandler)FindObjectOfType(typeof(BrushHandler));

        //see which color is currently applied in the brush
        Color brushHandlerColor = brushHandler.returnCurrentBrushColor();

        //update the material of your brush to that color
        brushHandler.GetComponent<MeshRenderer>().material.color = brushHandlerColor;

        //draw our brush here using instantiating

        Instantiate(brushHandler, transform.position, transform.rotation);

    
    }
}
