using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouch : MonoBehaviour
{
    private PlayerHealth health;

    private float valuechange = 1f;

    private void Start()
    {
        health = GetComponent<PlayerHealth>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) health.Damage(valuechange);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Eat"))
        {
            health.Eat(valuechange);
            Destroy(collider.gameObject);
        }
    }
}
