using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //when a player hits the collectable then add plus 1
        if (collision.gameObject.CompareTag("Player"))
        {
            //score collectable
            GameManager.collectableScore++;

            //game over
            Destroy(gameObject);
        }
    }
}
