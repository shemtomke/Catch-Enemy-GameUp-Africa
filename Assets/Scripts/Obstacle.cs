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
            GameManager.isGameOver = true;
        }
    }
}
