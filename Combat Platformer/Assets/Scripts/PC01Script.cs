using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC01Script : MonoBehaviour
{
    public GameObject projectileGO;
    public GameObject projectileSpawnLocation;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) Fire();
    }

    void Fire()
    {
        GameObject projectileClone = Instantiate(projectileGO, projectileSpawnLocation.transform.position, projectileSpawnLocation.transform.rotation);
    }
}
