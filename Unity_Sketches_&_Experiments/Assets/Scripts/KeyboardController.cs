using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class KeyboardController : MonoBehaviour
{
    [SerializeField]
    float _moveSpeed = 0.1f;

    [SerializeField]
    float rotateSpeed = 1.0f;
    [SerializeField]
    Transform upDownRotation;

    // Declare our input movement. This will control our ball using Unity's Input System.
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            return;

        var move = Vector3.zero;
        var rotate = 0f;
        var upDown = 0f;

        if (Input.GetKey(KeyCode.W))
            move += transform.forward;
        if (Input.GetKey(KeyCode.A))
            move += -transform.right;
        if (Input.GetKey(KeyCode.S))
            move += -transform.forward;
        if (Input.GetKey(KeyCode.D))
            move += transform.right;

        if (Input.GetKey(KeyCode.E))
            rotate += 1;
        if (Input.GetKey(KeyCode.Q))
            rotate -= 1;

        if (Input.GetKey(KeyCode.Z))
            upDown += 1;
        if (Input.GetKey(KeyCode.C))
            upDown -= 1;

        var moveSpeed = move * _moveSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
            moveSpeed *= 1;

        transform.Rotate(Vector3.up, rotateSpeed * rotate);
        if (upDownRotation != null)
        {
            upDownRotation.Rotate(Vector3.left, rotateSpeed * upDown);
        }
        transform.position += moveSpeed;
    }

    public void move(int dir)
    {
        var move = Vector3.zero;

        if (dir == 1)
            move += transform.forward;
        if (dir == 2)
            move += -transform.right;
        if (dir == -1)
            move += -transform.forward;
        if (dir == -2)
            move += transform.right;

        var moveSpeed = move * _moveSpeed;

        transform.position += moveSpeed;

    }

    private void OnMove(InputValue movementValue)
    {
        // movement value will store the input direction in the X and Y axis
        Vector2 movementVector = movementValue.Get<Vector2>();

        // deconstruct our 2D vector into X and Y. These values will later become our X and Z values in the ball's movement
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    public void rotate(int dir)
    {
        transform.Rotate(Vector3.up, rotateSpeed * dir);
    }

}
