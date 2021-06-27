using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Animator animator;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Dead", true);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.6)
        {
            gameObject.SetActive(false);
        }
    }
}
