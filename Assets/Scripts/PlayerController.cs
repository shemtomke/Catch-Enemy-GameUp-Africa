using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float increaseSpeed;
    private void Update()
    {
        Movement();
    }
    void Movement()
    {
        //move in z axis
        transform.Translate(Vector3.forward * speed);

        //if you hit an object then reduce the speed
        //increase speed of the player as you progress with the game
        speed += increaseSpeed;

        SideMove();
    }
    //left and right to move the player sideways
    void SideMove()
    {
        //move to the left only if your transform has reached max of 3
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //move right either when the player is left/centre
            if (transform.position.x == 0 || transform.position.x == -3)
            {
                transform.position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //move left if the player is right/centre
            if(transform.position.x == 0 || transform.position.x == 3)
            {
                transform.position = new Vector3(transform.position.x - 3, transform.position.y, transform.position.z);
            }
        }
    }
}
