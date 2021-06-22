using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 5;

    public GameObject deathEffect;
    public void Start()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Spawner"))
        {
            Spawner spawner = obj.GetComponent<Spawner>();
            health += Random.Range(spawner.multiplierMinimum, spawner.multiplierMaximum);
        }
        GameObject[] spawners = GameObject.FindGameObjectsWithTag("Spawner");
        foreach(GameObject spawner in spawners)
        {
            Spawner aSpawner = spawner.GetComponent<Spawner>();
            health += Random.Range(aSpawner.multiplierMinimum, aSpawner.multiplierMaximum);
        }
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