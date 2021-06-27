using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public int damage = 10;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerControls player = hitInfo.GetComponent<PlayerControls>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
