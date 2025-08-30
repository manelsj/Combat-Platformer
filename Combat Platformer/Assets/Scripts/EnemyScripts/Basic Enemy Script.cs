using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyScript : MonoBehaviour
{
    public float health;

    public void DecreaseHealth(float damage)
    {
        health -= damage;
        if (health <= 0) Destroy(gameObject);
    }
}
