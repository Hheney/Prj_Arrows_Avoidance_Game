/*
 * ���� �����, ���� ��ư�� ���� Ŭ����
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

    public void f_ReStartGame() //���� �����(onclick ��ư)
    {
        SceneManager.LoadScene("GameScene");
    }

    public void f_EndGame() //���� ����(onclick ��ư)
    {
        Application.Quit();
        Debug.Log("END"); //Unity ȯ�濡�� ���ᰡ ���� �ʾ� ����׷α׿� END ����ϵ��� ��
    }
}

