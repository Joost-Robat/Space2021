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

    void OnTriggerStay2D(Collider2D attack)
    {
        PlayerControls player = attack.GetComponent<PlayerControls>();
        if (player != null)
        {
            anim.SetTrigger("Attack");
        }
    }

    void OnTriggerExit2D(Collider2D stopattack)
    {
        PlayerControls player = stopattack.GetComponent<PlayerControls>();
        if (player != null)
        {
            anim.SetTrigger("StopAttack");
        }
    }
}
