using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public float timer;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>();
        animator.SetBool("Dead", true);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 0.35)
        {
            gameObject.SetActive(false);
        }
    }
}
