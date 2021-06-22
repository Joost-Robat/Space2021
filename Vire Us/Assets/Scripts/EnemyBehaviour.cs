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
    public float speedRight = 0;
    public float speedLeft = 0;
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
        // Begin movement right
        if (gameObject.transform.position.x <= playerX)
        {
            speedRight += 10f * Time.deltaTime;
            flip(false);
            if (speedRight > 25)
            {
                speedRight = 25;
            }
            // Start Tegenstribbel Links
            if (speedLeft < 0)
            {
                speedLeft -= 1f * Time.deltaTime;
            }
            else if (speedLeft > 0)
            {
                speedLeft = 0;
            }
        }                                   // End Tegenstribbel Links
                                            // End movement right
                                            // Begin movement left
        if (gameObject.transform.position.x >= playerX)
        {
            speedLeft += 10f * Time.deltaTime;
            flip(true);
            if (speedLeft > 25)
            {
                speedLeft = 25;
            }                                   // Begin Tegenstribbel Rechts
            if (speedRight < 0)
            {
                speedRight -= 1f * Time.deltaTime;
            }
            else if (speedRight > 0)
            {
                speedRight = 0;
            }
        }                                       // End Tegenstribbel Rechts
                                                // End movement left
                                                // Movement Actions
        transform.position += new Vector3(speedRight, 0, 0) * Time.deltaTime;
        transform.position -= new Vector3(speedLeft, 0, 0) * Time.deltaTime;
        Debug.Log(jumpTrue);
    }
    void flip(bool Statement)
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.flipX = Statement;
    }
}