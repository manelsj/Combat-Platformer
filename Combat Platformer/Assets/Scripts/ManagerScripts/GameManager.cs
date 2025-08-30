using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> levelList = new List<GameObject>();
    public List<string> levelNameList = new List<string>();
    private int levelNum;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        levelNum = 0;
        loadLevel(levelNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void loadLevel(int sceneNum)
    {
        SceneManager.LoadScene(levelNameList[sceneNum]);
    }

    public void nextLevel()
    {
        levelNum++;
        loadLevel(levelNum);
    }
}
