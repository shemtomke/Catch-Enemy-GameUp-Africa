using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool rotate; // do you want it to rotate?

    public float rotationSpeed;

    public AudioClip collectSound;

    public GameObject collectEffect;

    private void Update()
    {
        if (rotate)
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //when a player hits the collectable then add plus 1
        if (collision.gameObject.CompareTag("Player"))
        {
            Collect();
        }
    }

    void Collect()
    {
        if (collectSound)
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        if (collectEffect)
            Instantiate(collectEffect, transform.position, Quaternion.identity);

        //score collectable
        GameManager.collectableScore++;

        //game over
        Destroy(gameObject);
    }
}
