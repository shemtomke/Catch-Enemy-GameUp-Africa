using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float increaseSpeed;
    public LayerMask obstacles;
    public float dist;

    float timeTaken;
    int randomPos;
    bool isJumpEnemy;

    Rigidbody rb;
    Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        InvokeRepeating("SideMove", timeTaken, 1.5f);
    }
    private void Update()
    {
        Movement();
        Jump();

        if(transform.position.x > 0)
        {
            transform.position = new Vector3(3, transform.position.y, transform.position.z);
        }
        else if(transform.position.x < 0)
        {
            transform.position = new Vector3(-3, transform.position.y, transform.position.z);
        }
    }
    void Movement()
    {
        //move in z axis
        transform.Translate(Vector3.forward * speed);
        speed += increaseSpeed;

        timeTaken = Random.Range(0, 5.0f);
        randomPos = Random.Range(0, 4);
    }
    //left and right to move the player sideways
    void SideMove()
    {
        switch (randomPos)
        {
            case 0:
                transform.position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
                break;
            case 1:
                transform.position = new Vector3(transform.position.x - 3, transform.position.y, transform.position.z);
                break;
        }
    }
    //enemy jumps when a raycast detects an obstacle
    void Jump()
    {
        RaycastHit hit;
        isJumpEnemy = Physics.Raycast(transform.position, transform.forward, out hit, dist, obstacles);

        if (isJumpEnemy)
        {
            anim.SetTrigger("isJump");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
