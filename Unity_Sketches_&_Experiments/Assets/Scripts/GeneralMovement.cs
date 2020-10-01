using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// A CLASS IS EQUAL TO A TYPE
public class GeneralMovement : MonoBehaviour
{

 
    public GameObject transformObject;
    public Transform transformObjectTransform;

    public Transform parentCube;
    public Transform childCube;
    

    public 
    // Start is called before the first frame update
    void Start()
    {
        
        // The two declarations below are identical
        Vector3 position_1 = transformObjectTransform.position;
        Vector3 position_2 = transformObject.transform.position;

        // The two declarations below are identical
        Vector3 eulerRotation_1 = transformObjectTransform.eulerAngles;
        Vector3 eulerRotation_2 = transformObject.transform.eulerAngles;

        // Using quaternions avoids the problem of a gimbal lock. This could work by using radians as well.
        Quaternion qRotation = transformObjectTransform.rotation;

        // The two declarations below are identical
        Vector3 scale_1 = transformObjectTransform.localScale;
        Vector3 scale_2 = transformObject.transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        /* POSITION */

        // Get the position of our gameObject
        Vector3 position = transformObjectTransform.position;

        //Move the gameObject in the x direction.
        position.x += 0.01f;

        //Assign our new value to the gameObject's position 
        transformObjectTransform.position = position;

        // Get the cube's local position.
        Vector3 childLocalPosition = childCube.localPosition;

        // Get the cube's world position
        Vector3 childWorldPosition = childCube.position;

        /* ROTATION */

        // Get the cube's local rotation.
        //Vector3 childLocalRotation = childCube.eulerAngles;

        // Rotate the cube on it's axis
        //childLocalRotation.x += 20.0f * Time.deltaTime;

        //Assign our new value to the gameObject's rotation 
        //childCube.rotation = Quaternion.Euler(childLocalRotation);
    }
}
