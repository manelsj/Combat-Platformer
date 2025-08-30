using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject levelManager;
    private bool disabled = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Test");

        if ((other.gameObject.tag == "Player") && (!disabled))
        {
            levelManager.GetComponent<LevelManager>().nextCheckpoint();
            disabled = true;
        }
        
        
    }
}
