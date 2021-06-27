using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
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
    public float jumpAnimationTimer;
    public bool animationJump = false;
    public Animator animator;
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
                if(jumpTrue < 45)
                {
                    jumpTrue += 10 * Time.deltaTime;
                }
                else
                {
                    animationJump = true;
                }
            }
            else
            {
                jumpTrue = 0;
            }
        }
        if(inRange == true)
        {
            if (animationJump == true)
            {
                if (jumpAnimationTimer == 0)
                {
                    animator.SetTrigger("jump1");
                }
                jumpAnimationTimer += Time.deltaTime;
                if (jumpAnimationTimer >= 0.9f)
                {
                    rigidBody.AddForce(new Vector2(0, 80), ForceMode2D.Impulse);
                    jumpTrue -= 25;
                    animationJump = false;
                    jumpAnimationTimer = 0;
                }
            }
        }
        else
        {
            animationJump = false;
            jumpAnimationTimer = 0;
            jumpTrue -= 25;
        }
        if (transform.position.x < playerX)
        {
            if (speed < 0)
            {
                speedUp = 4;
                speed += 15 * speedUp * Time.deltaTime;
                if (speed > 35)
                {
                    speed = 35;
                }
            }
            else
            {
                speedUp = 1;
                speed += 15 * Time.deltaTime;
                if (speed > 35)
                {
                    speed = 35;
                }
            }
        }
        else
        {
            if (speed > 0)
            {
                speedUp = 4;
                speed -= 15 * speedUp * Time.deltaTime;
                if (speed < -35)
                {
                    speed = -35;
                }
            }                                   // Begin Tegenstribbel Rechts
            else
            {
                speedUp = 1;
                speed -= 15 * Time.deltaTime;
                if (speed < -35)
                {
                    speed = -35;
                }
            }
        }
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        //Debug.Log(jumpTrue);
        //Debug.Log("Right: " + speedRight);
        //Debug.Log("Left: " + speedLeft);
    }
}
