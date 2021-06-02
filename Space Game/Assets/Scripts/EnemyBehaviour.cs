using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    float playerX;
    float playerY;
    GameObject player;
    public bool isOnPlatform = false;
    private float PlayerYTest;
    private float rangePlayerX;
    private float xMinus;
    private float xPlus;
    private float JumpForce = 1;
    public float jumpTrue;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        playerY = player.transform.position.y;
        playerX = player.transform.position.x;
        PlayerYTest = player.transform.position.y - 1;
        xMinus = playerX - 30;
        xPlus = playerX + 30;
        if(transform.position.x >= playerX)
            // Plus if statement
        {
            if(xPlus <= transform.position.x)
            {
                if (transform.position.y <= PlayerYTest)
                {
                    transform.position += new Vector3(0, 1000, 0) * Time.deltaTime;
                    jumpTrue += 10 * Time.deltaTime;
                    Debug.Log(jumpTrue);
                    if (jumpTrue >= 50)
                    {
                        transform.position += new Vector3(0, 50, 0) * Time.deltaTime;
                        jumpTrue -= 50;
                    }
                    else
                    {
                        jumpTrue = 0;
                    }
                }
            }
        }
        if(transform.position.x <= playerX)
            // Minus if statement
        {
            if (xMinus <= transform.position.x)
            {
                if (transform.position.y <= PlayerYTest)
                {
                    jumpTrue += 10 * Time.deltaTime;
                    Debug.Log(jumpTrue);
                    if (jumpTrue >= 50)
                    {
                        transform.position += new Vector3(0, 1000, 0) * Time.deltaTime;
                        jumpTrue -= 10;
                    }
                    else
                    {
                        jumpTrue = 0;
                    }
                }
            }
        }
        if (gameObject.transform.position.x <= playerX)
        {
            transform.position += new Vector3(2f, 0f, 0f) * Time.deltaTime;
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            flip(false);
        }
        if(gameObject.transform.position.x >= playerX)
        {
            transform.position -= new Vector3(2f, 0f, 0f) * Time.deltaTime;
            flip(true);
        }
    }
    void flip(bool Statement)
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.flipX = Statement;
    }
}
