using UnityEngine;

public class ScoreTrigger_Script : MonoBehaviour
{

    private GameManager_Script gameManager;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            gameManager.addScore(1);
        }
        
    }


    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager")
            .GetComponent<GameManager_Script>();
    }
}
