using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject playerGO;

    public float zOffset;

    public float horizontalOffset;

    private Vector3 position;

    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerGO.transform.position.x > position.x + horizontalOffset)
        {
            position.x = playerGO.transform.position.x - horizontalOffset;
        }
        else if (playerGO.transform.position.x < position.x - horizontalOffset)
        {
            position.x = playerGO.transform.position.x + horizontalOffset;
        }


        position = new Vector3(position.x, playerGO.transform.position.y, playerGO.transform.position.z + zOffset);
        transform.position = position;
    }
}
