using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    Renderer m_Renderer;

    void Start()
    {
        rb.velocity = transform.right * speed;
        m_Renderer = GetComponent<Renderer>();
    }
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);

        PlayerControls player = hitInfo.GetComponent<PlayerControls>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    void Update()
    {
        if (!m_Renderer.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
