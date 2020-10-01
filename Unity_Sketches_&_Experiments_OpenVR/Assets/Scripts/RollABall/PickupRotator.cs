using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotator : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime is a float value that represents the change from the last frma e to the current one. It smoothens our movemment.Dynamically changes its value based on the length of a frame.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
