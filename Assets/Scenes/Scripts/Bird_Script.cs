using UnityEngine;
using UnityEngine.InputSystem;


public class Bird_Script : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidBody;
    [SerializeField] private InputAction flap;

    private GameManager_Script gameManager;

    private bool birdIsAlive = true;
    private float flapStrength = 5;


    private void OnEnable() // Neccessary for new Input System
    {
        flap.Enable();
    }
    private void OnDisable() // Neccessary for new Input System
    {
        flap.Disable();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.gameOver();
        birdIsAlive = false;
    }


    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager") 
            .GetComponent<GameManager_Script>();
    }


    void Update()
    {
        // new Input System
        if (birdIsAlive && flap.triggered)
        {
            birdRigidBody.velocity = flap.ReadValue<Vector2>() * flapStrength;
        }

        // game over when bird leaves screen
        if (transform.position.y < -5 || transform.position.y > 5) 
        {
            gameManager.gameOver();
            birdIsAlive = false;
        } 
    }
}
