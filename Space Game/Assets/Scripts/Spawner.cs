using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public float multiplierMinimum = 50;
    public float multiplierMaximum = 51;
    public GameObject Enemy;
    void Start()
    {
        Enemy enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        multiplierMaximum += Time.deltaTime;
        Debug.Log("timer:" + timer);
        if(timer >= 10)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
            timer -= 10;
            if(multiplierMaximum <= 1000)
            {
                multiplierMaximum += 1;
            }
        }
    }
}
