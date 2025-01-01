using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Test");
        if (other.collider.tag == "Enemy")
        {
            other.gameObject.GetComponent<BasicEnemyScript>().DecreaseHealth(10);
            Debug.Log("Test");
        }

        Destroy(gameObject);
    }
}
