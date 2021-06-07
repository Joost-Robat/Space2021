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
    public float countdown = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Enemy enemy = GetComponent<Enemy>();
        Spawner multiplier = GetComponent<Spawner>();
        enemy.health = enemy.health * multiplier.multiplierRandom;
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
        if (gameObject.transform.position.x <= playerX)
        {
            transform.position += new Vector3(10f, 0f, 0f) * Time.deltaTime;
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            flip(false);
        }
        if (gameObject.transform.position.x >= playerX)
        {
            transform.position -= new Vector3(10f, 0f, 0f) * Time.deltaTime;
            flip(true);
        }
        Debug.Log(jumpTrue);
    }
    void flip(bool Statement)
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.flipX = Statement;
    }
}
