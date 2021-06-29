using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBloatfly : MonoBehaviour
{
    public float playerY;
    public float timer;
    public GameObject BloatFly;
    public int randomInt;
    // Start is called before the first frame update
    void Start()
    {
        randomInt = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        playerY = player.transform.position.y;
        if(transform.position.y < player.transform.position.y)
        {
            timer += Time.deltaTime;
            if(timer >= 10)
            {
                Instantiate(BloatFly, gameObject.transform.position, gameObject.transform.rotation);
                timer -= randomInt;
                randomInt = Random.Range(0, 4);

            }
        }
    }
}
