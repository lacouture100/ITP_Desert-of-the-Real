using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileColorChange : MonoBehaviour
{

    public Material enterMaterial;

    public Material exitMaterial;

    public string colliderTag = "Player";
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(colliderTag))
        {
            transform.GetComponent<MeshRenderer>().material = enterMaterial;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(colliderTag))
        {
            transform.GetComponent<MeshRenderer>().material = exitMaterial;
        }

    }
}
