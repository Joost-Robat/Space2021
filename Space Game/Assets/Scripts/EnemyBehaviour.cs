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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rangePlayerY = playerY + 10;
        rangePlayerX = playerX + 10;
        GameObject player = GameObject.Find("Player");
        playerY = player.transform.position.y;
        playerX = player.transform.position.x;
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
