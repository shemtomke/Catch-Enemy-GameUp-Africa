using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchEnemy : MonoBehaviour
{
    public bool isHitEnemy;
    public Transform enemyTarget;
    public float dist;
    public LayerMask enemyLayer;

    public Animator enemyAnim;
    Animator playerAnim;

    private void Start()
    {
        playerAnim = GetComponent<Animator>();
    }
    
    private void Update()
    {
        RayCastEnemy();
    }
    //Do not pass the enemy


    //raycast from the player
    void RayCastEnemy()
    {
        RaycastHit hit;
        isHitEnemy = Physics.Raycast(transform.position, transform.forward, out hit, dist, enemyLayer);

        if (isHitEnemy)
        {
            //when the raycast detects the enemy then catch the player
            Catch();
        }
    }
    //button on click
    void Catch()
    {
        //set the iscatchenemy To true
        GameManager.isCatchEnemy = true;

        //play animation
        playerAnim.SetTrigger("isFight");
        enemyAnim.SetTrigger("isCaught");
        //change camera

    }
}
