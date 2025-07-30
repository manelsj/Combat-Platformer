using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int levelNum;
    public List<GameObject> checkpoints = new List<GameObject>();
    private int currentCheck;
    private int lastCheck;
    private GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindWithTag("Game Manager");
        lastCheck = checkpoints.Count;
        currentCheck = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextCheckpoint()
    {
        currentCheck++;

        if (currentCheck == checkpoints.Count) {
            nextLevel();
        }

    }

    private void nextLevel()
    {
        GameManager.GetComponent<GameManager>().nextLevel();
    }
}
