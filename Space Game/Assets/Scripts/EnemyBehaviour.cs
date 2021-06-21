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
        PlayerYTest = player.transform.position.y - 1;
        EnemyY = transform.position.y;
        xMinus = playerX - 40;
        xPlus = playerX + 40;
        if (xPlus <= transform.position.x)
        {
            if (xMinus <= transform.position.x)
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
                jumpTrue += 10 * Time.deltaTime;
                if (jumpTrue >= 50)
                {
                    rigidBody.AddForce(new Vector2(0, 80), ForceMode2D.Impulse);
                    jumpTrue -= 25;
                }
            }
            else
            {
                jumpTrue = 0;
            }
        }
        if(transform.position.x <= playerX)
        {
            flip(false);
            if(speed < 0)
            {
                speedUp = 4;
                speed += 15 * speedUp * Time.deltaTime;
                if (speed > 35)
                {
                    speed = 35;
                }
            }
            speedUp = 1;
            speed += 4 * Time.deltaTime;
            if(speed > 35)
            {
                speed = 35;
            }
        }
        else
        {
            flip(true);
            if(speed > 0)
            {
<<<<<<< HEAD
                speedUp = 4;
                speed -= 15 * speedUp * Time.deltaTime;
                if (speed < -35)
                {
                    speed = -35;
                }
=======
                speedLeft = 35;
            }                                   // Begin Tegenstribbel Rechts
            if (speedRight < 0)
            {
                speedRight -= 1f * Time.deltaTime;
>>>>>>> 00c6ac687e862c129d3d924da6bc0367e14ea34a
            }
            speedUp = 1;
            speed -= 10 * Time.deltaTime;
            if(speed < -35)
            {
                speed = -35;
            }
        }
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        //Debug.Log(jumpTrue);
        //Debug.Log("Right: " + speedRight);
        //Debug.Log("Left: " + speedLeft);
    }
    void flip(bool Statement)
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.flipX = Statement;
    }
}
