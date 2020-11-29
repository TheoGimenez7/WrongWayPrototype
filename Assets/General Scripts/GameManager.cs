using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string LevelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
