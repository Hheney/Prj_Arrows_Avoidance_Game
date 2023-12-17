using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void f_RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void f_ExitGame()
    {
        Application.Quit();
        Debug.Log("End");
    }
}

