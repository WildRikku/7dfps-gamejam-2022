using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadMoveX : MonoBehaviour
{
    private float startX;
    public float move_speed = 1f;
    public float move_range_x = 5f;

    private bool moveFlag = false;

    void Start()
    {
        startX = transform.position.x;
        Debug.Log(startX);
    }

    // Update is called once per frame
    void Update()
    {
        if (move_range_x > 0)
        {
            //positive Bewegung in x-Richtung---
            if (transform.position.x <= startX + move_range_x && moveFlag == false)
            {
                transform.Translate(move_speed * Time.deltaTime, 0, 0);
                if (transform.position.x >= startX + move_range_x)
                {
                    moveFlag = true;
                }
            }

            //negative Bewegung in x-Richtung
            if (transform.position.x >= startX && moveFlag == true)
            {
                transform.Translate(move_speed * Time.deltaTime * (-1), 0, 0);
                if (transform.position.x <= startX)
                {
                    moveFlag = false;
                }
            }
        }
        //----------------
        else
        {
            if (transform.position.x >= startX + move_range_x && moveFlag == false)
            {
                transform.Translate(move_speed * Time.deltaTime*(-1), 0, 0);
                if (transform.position.x <= startX + move_range_x)
                {
                    moveFlag = true;
                }
            }

            //negative Bewegung in x-Richtung
            if (transform.position.x <= startX && moveFlag == true)
            {
                transform.Translate(move_speed * Time.deltaTime, 0, 0);
                if (transform.position.x >= startX)
                {
                    moveFlag = false;
                }
            }
        }

    }
}
