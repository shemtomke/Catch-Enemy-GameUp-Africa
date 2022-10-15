using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce;

    bool isGrounded = true;
    Rigidbody rb;
    Animator anim;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        if (GameManager.isCatchEnemy || GameManager.isGameOver)
            return;

        Jump();
    }
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
    void Jump()
    {
        Vector3 jump = new Vector3(transform.position.x, 2f, transform.position.z);
        //when the player swipes up
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.SetTrigger("isJump"); //use trigger
            isGrounded = false;
        }
    }
}
