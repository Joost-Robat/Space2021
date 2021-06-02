using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
    PlayerControls playerHealth;
    public float healthIncrease = 25f;
    void Awake()
    {
        playerHealth = FindObjectOfType<PlayerControls>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(playerHealth.Health < 100)
        {
            Destroy(gameObject);
            playerHealth.Health = playerHealth.Health + healthIncrease;   
        }
    }
}
