using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloatFlyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject emitter = GameObject.FindGameObjectWithTag("emitter");
        emitter.gameObject.SetActive(true);
        GameObject bloatFly = GameObject.FindGameObjectWithTag("bloatFly");
        bloatFly.gameObject.SetActive(false);
    }
}
