using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public int randomizedInt;
    public int multiplierMinimum = 0;
    public int multiplierMaximum = 50;
    public GameObject Enemy;
    void Start()
    {
        randomizedInt = Random.Range(4, 10);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= randomizedInt)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
            timer = 0;
            multiplierMaximum += 1;
            randomizedInt = Random.Range(4, 10);
        }
    }
}
