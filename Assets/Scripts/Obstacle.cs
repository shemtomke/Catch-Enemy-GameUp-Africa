using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //when a player hits the obstacle then gameover is set to true
        if (collision.gameObject.CompareTag("Player"))
        {
            //game over
            Debug.Log("Game Over");
            //GameManager.isGameOver = true;

            //reduce speed
            //playerController.speed -= 0.01f;
        }
    }
}
