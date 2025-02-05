using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject playerGO;

    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = playerGO.transform.position + offset;
    }
}
