using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public GameController gameController;
    private void OnTriggerEnter(Collider other)     
{

if (other.gameObject.tag == "Collectables")
    {
        score.AddScore(1);
        Destroy(other.gameObject);
    }
}

private void OnCollisionEnter(Collision other)
{
    if (other.gameObject.tag == "Obstacles")
    {
        gameController.GameOver();
        playerScript.enabled = false;
    }
}

}
