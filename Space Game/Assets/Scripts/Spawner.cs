using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public int multiplierMinimum = 0;
    public int multiplierMaximum = 50;
    public GameObject Enemy;
    void Start()
    {
        Enemy enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        Debug.Log("timer:" + timer);
        if (timer >= 5)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
            timer -= 10;
            multiplierMaximum += 1;
        }
    }
}
