using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public int levelNum;
    public List<GameObject> checkpoints = new List<GameObject>();
    public int currentCheck;
    private int lastCheck;
    private GameObject GameManager;
    public GameObject PlayerGO;

    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindWithTag("Game Manager");
        lastCheck = checkpoints.Count;
        currentCheck = 0;
        checkpoints[0].GetComponent<Checkpoint>().disabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextCheckpoint()
    {
        currentCheck++;

        if (currentCheck == checkpoints.Count - 1) {
            nextLevel();
        }

    }

    private void nextLevel()
    {
        GameManager.GetComponent<GameManager>().nextLevel();
    }

    public void resetLevel()
    {
        PlayerGO.transform.position = checkpoints[currentCheck].transform.position;
        PlayerGO.GetComponent<BasicPlayerScript>().health = PlayerGO.GetComponent<BasicPlayerScript>().maxHealth;
    }
}
