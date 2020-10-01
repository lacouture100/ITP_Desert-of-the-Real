using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{

    [Header("Current Rotation")]
    [SerializeField]
    Vector3 myLocalRotation;

    [Header ("Rotation Control")]

    [Range(0f, 500f)]
    public float speedX = 20.0f;

    [Range(0f, 500f)]
    public float speedY = 20.0f;

    [Range(0f, 500f)]
    public float speedZ = 20.0f;
    // Start is called before the first frame update
    void Start()
 {
         myLocalRotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {

        // Rotate the cube on each axis
        myLocalRotation.x += speedX* Time.deltaTime;
        myLocalRotation.y += speedY * Time.deltaTime;
        myLocalRotation.z += speedZ * Time.deltaTime;

        //Assign our new value to the gameObject's rotation 
        transform.rotation = Quaternion.Euler(myLocalRotation);
    }
}

