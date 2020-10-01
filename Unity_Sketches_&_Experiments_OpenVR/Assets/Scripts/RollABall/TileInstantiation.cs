using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInstantiation : MonoBehaviour
{


    // The prefab we want to instance
    public GameObject objectToInstance;

    [Header("Instance instantiation area range")]
    [Header("X axis")]
    public float minRangeX = -50;
    public float maxRangeX = 50;
    public float spacingX = 2.0f;

    [Header("Z axis")]
    public float minRangeZ = -50;
    public float maxRangeZ = 50;
    public float spacingZ = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Create each instance
        for (float x = minRangeX; x < maxRangeX; x += (spacingX + objectToInstance.transform.localScale.z))
        {
            for (float z = minRangeZ; z < maxRangeZ; z += (spacingZ + objectToInstance.transform.localScale.z))
            {

                // Spawn each instance in a random position
                Vector3 startPosition = new Vector3(x, (0 + objectToInstance.transform.localScale.y), z);

                createInstanceFromObject(objectToInstance, startPosition);
            }
        }
    }

    public void createInstanceFromObject(GameObject objectToInstance, Vector3 position)
    {
        //Instantiate the Object
        GameObject instantiatedObject = GameObject.Instantiate<GameObject>(objectToInstance);
        //Set to the position in the second argument
        instantiatedObject.transform.position = position;
        //Set the gameOBject with the script as it's parent
        instantiatedObject.transform.parent = transform;
    }
}
