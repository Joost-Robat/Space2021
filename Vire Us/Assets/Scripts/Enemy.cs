using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 50;

    public GameObject deathEffect;
    public void Start()
    {
        Spawner spawner = GetComponent<Spawner>();
        //health = 50 + Random.Range(spawner.multiplierMinimum, spawner.multiplierMaximum);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}