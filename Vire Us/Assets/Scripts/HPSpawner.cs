using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSpawner : MonoBehaviour
{
    public float timer;
    public int multiplierMinimum = 30;
    public int multiplierMaximum = 30;
    public int multiplierRandom;
    public GameObject HPcell;
    void Start()
    {
        HPcell hpcell = GetComponent<HPcell>();
    }

    void Update()
    {
        HPcell hpcell = GetComponent<HPcell>();
        timer += Time.deltaTime;
        Debug.Log("timer:" + timer);
        if (timer >= 30)
        {
            Instantiate(HPcell, transform.position, transform.rotation);
            timer -= 30;

        }
    }
}
