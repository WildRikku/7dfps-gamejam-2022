using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadMoveZ : MonoBehaviour
{
    private float startZ;
    public float move_speed = 1f;
    public float move_range_z = 5f;

    private bool moveFlag = false;

    void Start()
    {
        startZ = transform.position.z;
        Debug.Log(startZ);
    }

    // Update is called once per frame
    void Update()
    {
        //positive Bewegung in Z-Richtung
        if (transform.position.z <= startZ + move_range_z && moveFlag == false)
        {
            transform.Translate(0, 0, move_speed * Time.deltaTime);
            if (transform.position.z >= startZ + move_range_z)
            {
                moveFlag = true;
            }
        }

        //negative Bewegung in z-Richtung
        if (transform.position.z >= startZ && moveFlag == true)
        {
            transform.Translate(0, 0, move_speed * Time.deltaTime * (-1));
            if (transform.position.z <= startZ)
            {
                moveFlag = false;
            }
        }


    }
}
