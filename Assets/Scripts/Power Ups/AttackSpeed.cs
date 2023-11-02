using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpeed : MonoBehaviour
{
    public float speed = 0.25f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        randomDirection.Normalize();

        rb.velocity = randomDirection * speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out StatsManager playerLife))
        {
            playerLife.AddAttackSpeed(0.25f);
            Destroy(gameObject);
        }
    }
}