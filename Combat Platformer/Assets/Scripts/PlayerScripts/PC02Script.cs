using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC02Script : MonoBehaviour
{
    public GameObject hitboxGO;
    public GameObject hitboxLocation;
    public float hitboxTime;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) Attack();
    }

    void Attack()
    {
        GameObject hitboxClone = Instantiate(hitboxGO, hitboxLocation.transform.position, hitboxLocation.transform.rotation);
        Destroy(hitboxClone, hitboxTime);
    }
}
