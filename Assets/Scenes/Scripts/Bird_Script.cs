using UnityEngine;

public class Bird_Script : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D birdRigidBody;

    private GameManager_Script gameManager;


    private bool birdIsAlive = true;
    private float flapStrength = 5;

    


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
        if (Input.GetKeyDown("space") && birdIsAlive) // old input manager
        {
            birdRigidBody.velocity = Vector2.up * flapStrength; // Vector2.up is a shortcut for Vector(0,1)
        }

        if (transform.position.y < -5 || transform.position.y > 5) // game over when bird leaves screen
        {
            gameManager.gameOver();
            birdIsAlive = false;
        } 
    }
}
