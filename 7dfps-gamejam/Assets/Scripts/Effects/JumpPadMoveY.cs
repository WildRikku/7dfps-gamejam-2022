using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadMoveY : MonoBehaviour
{
    private float startY;
    public float move_speed = 1f;
    public float move_range_y = 5f;

    private bool moveFlag = false;

    void Start()
    {
        startY = transform.position.y;
        Debug.Log(startY);
    }

    // Update is called once per frame
    void Update()
    {
        //positive Bewegung in y-Richtung
        if (transform.position.y <= startY + move_range_y && moveFlag == false)
        {
            transform.Translate(0, move_speed * Time.deltaTime, 0);
            if (transform.position.y >= startY + move_range_y)
            {
                moveFlag = true;
            }
        }
      
        //negative Bewegung in y-Richtung
        if (transform.position.y >= startY  && moveFlag == true)
        {
            transform.Translate(0, move_speed * Time.deltaTime * (-1), 0);
            if (transform.position.y <= startY)
            {
                moveFlag = false;
            }
        }
  

    }
}
