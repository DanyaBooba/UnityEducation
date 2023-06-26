using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float maxHealth = 10f;
    private float health;

    private void Start()
    {
        health = maxHealth;
        Health();
    }

    private void Health()
    {
        if(health <= 0f) InvokeNullHealth();

        if(health > maxHealth) health = maxHealth;

        Debug.Log("Health: " + health);
    }

    public void Damage(float damage)
    {
        ChangeHealth(-damage);
    }

    public void Eat(float eat)
    {
        ChangeHealth(eat);
    }

    private void ChangeHealth(float change)
    {
        health += change;
        Health();
    }

    private void InvokeNullHealth()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
