using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float playerX;
    public bool rotated = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        playerX = player.transform.position.x;
        if(transform.position.x > playerX)
        {
            if(rotated != true)
            {
                transform.Rotate(0, 180, 0);
                rotated = true;
            }
        }
        if(transform.position.x < playerX)
        {
            if(rotated != false)
            {
                transform.Rotate(0, 180, 0);
                rotated = false;
            }
        }
    }
}
