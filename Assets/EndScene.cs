/*
 * 게임 재시작, 종료 버튼을 위한 클래스
 */

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

    public void f_ReStartGame() //게임 재시작(onclick 버튼)
    {
        SceneManager.LoadScene("GameScene");
    }

    public void f_EndGame() //게임 종료(onclick 버튼)
    {
        Application.Quit();
        Debug.Log("END"); //Unity 환경에서 종료가 되지 않아 디버그로그에 END 출력하도록 함
    }
}

