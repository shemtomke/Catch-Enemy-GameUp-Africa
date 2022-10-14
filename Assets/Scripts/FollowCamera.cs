using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    private Vector3 offset, gameWinOffset;
    public float smoothSpeed = 0.04f;

    CatchEnemy catchEnemy;

    void Start()
    {
        offset = transform.position - target.position;
        //gameWinOffset = new Vector3(0, );
        catchEnemy = FindObjectOfType<CatchEnemy>();
    }

    private void LateUpdate()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, target.position + offset, smoothSpeed);
        transform.position = newPosition;

        if(GameManager.isCatchEnemy)
        {
            //change the camera pos and rot
            
            //pos (0, 3, 6)
            //rot (12, 180, 0)
        }
    }
}
