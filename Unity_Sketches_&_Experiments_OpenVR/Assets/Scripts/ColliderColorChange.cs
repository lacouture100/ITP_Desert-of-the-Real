using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderColorChange : MonoBehaviour
{

    public Material enterMaterial;

    public Material exitMaterial;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        transform.GetComponent<MeshRenderer>().material = enterMaterial;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.GetComponent<MeshRenderer>().material = exitMaterial;
    }
}
