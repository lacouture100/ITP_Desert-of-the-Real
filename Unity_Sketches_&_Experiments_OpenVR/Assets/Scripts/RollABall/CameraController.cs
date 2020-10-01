using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Declare the player and the offset to the camer
    public GameObject player;
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        // Define the distance between the CURRENT camera transform position  and our player transform postiion
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame, LateUpdate runs after every update has been handled. The camera position will only move until the payer has moved for that frame.
    void LateUpdate()
    {
        // update the camera position at every frame
        transform.position = player.transform.position + offset;
    }
}
