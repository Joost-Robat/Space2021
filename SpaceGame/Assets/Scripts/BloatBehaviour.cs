using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloatBehaviour : MonoBehaviour
{
    public float PlayerPosition;
    public float playerY;
    public float playerX;
    public float speedX;
    public float speedY;
    public float speedUp = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject emitter = GameObject.FindGameObjectWithTag("emitter");
        emitter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        playerY = player.transform.position.y;
        playerX = player.transform.position.x;
        if(transform.position.x < playerX)                  //X Position
        {
            flip(false);
            if(speedX > 0)
            {
                speedUp = 10;
                speedX += 15 * speedUp * Time.deltaTime;
                if(speedX > 20)
                {
                    speedX = 20;
                }
            }
            else
            {
                speedUp = 1;
                speedX += 15 * Time.deltaTime;
                if(speedX > 20)
                {
                    speedX = 20;
                }
            }
        }
        else
        {
            flip(true);
            if (speedX < 0)
            {
                speedUp = 10;
                speedX -= 15 * speedUp * Time.deltaTime;
                if(speedX < -20)
                {
                    speedX = -20;
                }
            }
            else
            {
                speedUp = 1;
                speedX -= 15 * Time.deltaTime;
                if(speedX < -20)
                {
                    speedX = -20;
                }
            }
        }                                               //X Position
        transform.position += new Vector3(speedX, 0, 0) * Time.deltaTime;
                                                        //Y Position
        if(transform.position.y > playerY)
        {
            if(speedY < 0)
            {
                speedUp = 10;
                speedY -= 15 * speedUp * Time.deltaTime;
                if(speedY < -20)
                {
                    speedY = -20;
                }
            }
            else
            {
                speedUp = 1;
                speedY -= 15 * Time.deltaTime;
                if(speedY < -20)
                {
                    speedY = -20;
                }
            }
        }
        else
        {
            if(speedY > 0)
            {
                speedUp = 10;
                speedY += 15 * speedUp * Time.deltaTime;
                if(speedY > 20)
                {
                    speedY = 20;
                }
            }
            else
            {
                speedUp = 1;
                speedY += 15 * Time.deltaTime;
                if(speedY > 20)
                {
                    speedY = 20;
                }
            }
        }
                                                        //Y Position
        transform.position += new Vector3(0, speedY, 0) * Time.deltaTime;
    }
    void flip(bool Statement)
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.flipX = Statement;
    }
}
