using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public int multiplierMinimum = 10;
    public int multiplierMaximum = 10;
    public int multiplierRandom;
    public GameObject Enemy;
    void Start()
    {
        Enemy enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy enemy = GetComponent<Enemy>();
        multiplierRandom = Random.Range(multiplierMinimum, multiplierMaximum);
        timer += Time.deltaTime;
        Debug.Log("timer:" + timer);
        if(timer >= 10)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
            timer -= 10;
            if(multiplierMaximum <= 50)
            {
                multiplierMaximum += 1;
            }
        }
        Debug.Log("multiplierRandom = " + multiplierRandom);
    }
}
