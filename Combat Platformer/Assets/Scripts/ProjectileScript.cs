using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;
    public float destroyTime;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody.velocity = transform.up * speed;
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Enemy")
        {
            other.gameObject.GetComponent<BasicEnemyScript>().DecreaseHealth(10);
        }
            
        Destroy(gameObject);
    }
}
