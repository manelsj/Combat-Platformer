using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemyScript : MonoBehaviour
{
    public int direction = 1;
    public float speed;
    public GameObject checkpoint01;
    public GameObject checkpoint02;
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(direction * speed, 0);
    }
    private void SwitchDirection()
    {
        direction *= -1;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Post"))
        {
            SwitchDirection();
            //if (((direction == 1) && (other.GetComponent<PatrolPostScript>().postNum == 1)) ||
            //    ((direction == -1) && (other.GetComponent<PatrolPostScript>().postNum == 2)))
            //{
            //    SwitchDirection();
            //}
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            other.gameObject.GetComponent<BasicPlayerScript>().health--;
        }
    }
}
