/*
 * ���ʽ�(��Ʈ �浹) ���� ��� Ŭ����
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounsSoundController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ���ʽ�(��Ʈ �浹) ���� ��� �޼ҵ�
    /// </summary>
    public void f_PlayBonusSound() //�ܺο��� �����ؾ� �ϹǷ� public ��������
    {
        GetComponent<AudioSource>().Play();
    }
}
