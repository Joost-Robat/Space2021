using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpPad : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float launchForce;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("JumpPad"))
        {
            rigidBody.velocity = Vector2.up * launchForce;
        }
    }
}
