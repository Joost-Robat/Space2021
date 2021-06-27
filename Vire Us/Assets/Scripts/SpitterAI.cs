using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterAI : MonoBehaviour
{
    float playerX;
    float playerY;
    float EnemyY;
    bool inRange = false;
    GameObject player;
    private float PlayerYTest;
    private float xMinus;
    private float xPlus;
    public float jumpTrue;
    private Rigidbody2D rigidBody;
    public float speed = 0;
    public float speedUp = 1;
    public float countdown = 0;
    public Animator animator;
    public bool movement = true;
    public float jumpTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        playerY = player.transform.position.y;
        playerX = player.transform.position.x;
        PlayerYTest = player.transform.position.y - 10;
        EnemyY = transform.position.y;
        xMinus = playerX - 45;
        xPlus = playerX + 45;
        if (xPlus > transform.position.x)
        {
            if (xMinus < transform.position.x)
            {
                inRange = true;
            }
            else
            {
                inRange = false;
            }
        }
        if (inRange == true)
        {
            if (EnemyY < PlayerYTest)
            {
                if(movement == true)
                {
                    if (jumpTrue < 45)
                    {
                        jumpTrue += 10 * Time.deltaTime;
                    }
                    if (jumpTrue > 45)
                    {
                        movement = false;
                    }
                }
            }
            else
            {
                jumpTrue = 0;
            }
        }
        if(movement == false)
        {
            if(jumpTimer == 0)
            {
                animator.SetTrigger("jump");
            }
            jumpTimer += Time.deltaTime;
            if(jumpTimer > 1.6)
            {
                jumpTrue -= 25;
                jumpTimer = 0;
                rigidBody.AddForce(new Vector2(0, 80), ForceMode2D.Impulse);
                movement = true;
            }
        }
                                                            //Movement via if statement
        if(movement == true)
        {
            if (transform.position.x < playerX)
            {
                if (speed < 0)
                {
                    speedUp = 4;
                    speed += 10 * speedUp * Time.deltaTime;
                    if (speed > 20)
                    {
                        speed = 20;
                    }
                }
                else
                {
                    speedUp = 1;
                    speed += 10 * Time.deltaTime;
                    if (speed > 20)
                    {
                        speed = 20;
                    }
                }
            }
            else
            {
                if (speed > 0)
                {
                    speedUp = 4;
                    speed -= 10 * speedUp * Time.deltaTime;
                    if (speed < -20)
                    {
                        speed = -20;
                    }
                }                                   // Begin Tegenstribbel Rechts
                else
                {
                    speedUp = 1;
                    speed -= 10 * Time.deltaTime;
                    if (speed < -20)
                    {
                        speed = -20;
                    }
                }
            }
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
                                                        //Movement via if statement
        //Debug.Log(jumpTrue);
        //Debug.Log("Right: " + speedRight);
        //Debug.Log("Left: " + speedLeft);
    }
}
