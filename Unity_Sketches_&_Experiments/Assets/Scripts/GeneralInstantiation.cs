using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralInstantiation : MonoBehaviour
{

    // The prefab we want to instance
    public GameObject objectToInstance;

    // Amount of prefabs to instantiate
    [SerializeField]
    int amountOfInstances = 500;


    // Start is called before the first frame update
    void Start()
    {
        // Create each instance
        for(int i=0; i< amountOfInstances; i++)
        {
            // Spawn each instance in a random position
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));

            // Spawn each instance with a random forward direction
            int direction = Random.Range(0, 5);

            // Initialize the instanceDirection variable.
            Vector3 instanceDirection = Vector3.forward;

            switch (direction)
            {
                case 0:
                    instanceDirection = Vector3.forward;
                    break;
                case 1:
                    instanceDirection = Vector3.back;
                    break;
                case 2:
                    instanceDirection = Vector3.up;
                    break;
                case 3:
                    instanceDirection = Vector3.down;
                    break;
                case 4:
                    instanceDirection = Vector3.left;
                    break;
                case 5:
                    instanceDirection = Vector3.right;
                    break;
            }

            createInstanceFromObject(objectToInstance, randomPosition, instanceDirection);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createInstanceFromObject(GameObject objectToInstance, Vector3 position, Vector3 direction)
    {
        GameObject instantiatedObject = GameObject.Instantiate<GameObject>(objectToInstance);
        instantiatedObject.transform.position = position;
    }
}
