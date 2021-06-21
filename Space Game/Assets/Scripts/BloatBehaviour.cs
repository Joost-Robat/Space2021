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
        if(transform.position.x < playerX)
        {
            flip(false);
            speedX += 5 * Time.deltaTime;
        }
        else
        {
            flip(true);
            speedX -= 5 * Time.deltaTime;
        }
        transform.position += new Vector3(speedX, 0, 0) * Time.deltaTime;
        if(transform.position.y > playerY)
        {
            speedY -= 5 * Time.deltaTime;
        }
        else
        {
            speedY += 5 * Time.deltaTime;
        }
        transform.position += new Vector3(0, speedY, 0) * Time.deltaTime;
    }
    void flip(bool Statement)
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.flipX = Statement;
    }
}
