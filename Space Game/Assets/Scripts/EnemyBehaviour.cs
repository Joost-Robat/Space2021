using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    float playerX;
    float playerY;
    GameObject player;
    private bool facingRight = true;
    public bool isOnPlatform = false;
    private float rangePlayerY;
    private float rangePlayerX;
    private float xMinus;
    private float xPlus;
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
        xMinus = playerX - 10;
        xPlus = playerX + 10;
        if(transform.position.x >= playerX)
            // Plus if statement
        {
            if(xPlus <= transform.position.x)
            {

            }
        }
        if(transform.position.x <= playerX)
            // Minus if statement
        {
            if(xMinus <= transform.position.x)
            {

            }
        }
        if(gameObject.transform.position.y <= playerY)
        {
            if (gameObject.transform.position.x <= playerX || gameObject)
            {

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
        rangePlayerY = playerY;
    }
    void flip(bool Statement)
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.flipX = Statement;
    }
}
