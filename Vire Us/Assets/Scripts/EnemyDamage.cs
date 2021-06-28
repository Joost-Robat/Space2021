using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetTrigger("Attack");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        anim.SetTrigger("Walk");
    }
}
