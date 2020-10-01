using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //Declare the initial speed for the player ball
    public float speed = 0;

    // Declare the rigidBody variable
    private Rigidbody rb;

    // Declare our input movement. This will control our ball using Unity's Input System.
    private float movementX;
    private float movementY;

    // Declare our initial score.
    public int score;
    // Declare how many pickups you need to collide with to win.
    public int winScore = 10;

    // This will display our score on screen
    public TextMeshProUGUI scoreText;

    // This object will be displayed after we win the game/ reach a certain score
    public GameObject winTextObject;

    // This object will display the time passed since the game started
    public TextMeshProUGUI timerTextObject;

    // Declare our initial time
    private float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        // here is where we get a reference the rigidbody component in our gameobject.
        rb = GetComponent<Rigidbody>();

        // Inititalize our score
        score = 0;

        // Initialize the score text on our GUI
        SetScoreText();

        //Since it has a starting state of ) = score, we have to add it to the void Start() function.
        winTextObject.SetActive(false);

    }

    private void Update()
    {
        // Set our timer value as the time which has passed since we started the game.
        time += Time.deltaTime;
        //Update our time value every frame
        SetTime();
    }


    private void OnMove(InputValue movementValue)
    {
        // movement value will store the input direction in the X and Y axis
        Vector2 movementVector = movementValue.Get<Vector2>();
        
        // deconstruct our 2D vector into X and Y. These values will later become our X and Z values in the ball's movement
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // Set the text of our declared scoreText GameObject to the current time.
    void SetScoreText()
    {
        scoreText.text = "score: " + score.ToString();
        if(score >= winScore)
        {
            // Display our win message
            winTextObject.SetActive(true);
            speed = 0;
        }
    }

    // Set the text of our declared timerText GameObject to the current time.
    void SetTime()
    {
        timerTextObject.text = "time: " + time.ToString();
    }

    // Fixed Update takes care of the physics updates that happen between fram and frame. It happens before Update()
    private void FixedUpdate()
    {
        // Create the new vector with our input values.The Y axis will stay fixed, on the floor
        Vector3 ballMovement = new Vector3(movementX, 0.0f, movementY);
        // addForce to the rigidbody component
        rb.AddForce(ballMovement * speed);
    }

    // Define what happens when this GameObject collides with a trigger object
    private void OnTriggerEnter(Collider other)
    {
        //Check the colliding GameObject to check if it is a pickup item
        if (other.gameObject.CompareTag("Pickup"))
        {
            // When the object touches a trigger collider set the colliding object inactive. Make it dissapear
            other.gameObject.SetActive(false);
            // Increase the score
            score++;

            //Update the score texton GUI
            SetScoreText();
        }
       
    }

}

