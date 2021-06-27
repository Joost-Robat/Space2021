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
    public bool jumped = false;
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
        xMinus = playerX - 35;
        xPlus = playerX + 35;
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
                    if (jumpTrue < 35)
                    {
                        jumpTrue += 10 * Time.deltaTime;
                    }
                    if (jumpTrue > 35)
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
            if(jumped == false)
            {
                animator.SetTrigger("jump");
                jumped = true;
            }
            jumpTimer += Time.deltaTime;
            if(jumpTimer > 2.1)
            {
                if (jumpTimer > 2.2)
                {
                    jumpTrue -= 25;
                    jumpTimer = 0;
                    rigidBody.AddForce(new Vector2(0, 80), ForceMode2D.Impulse);
                    jumped = false;
                    movement = true;
                }
                else
                {
                    transform.position -= new Vector3(0, 0.01f, 0);
                }
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
            if(transform.position.x > playerX)
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
