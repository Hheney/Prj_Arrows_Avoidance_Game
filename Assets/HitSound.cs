/*
 * ��Ʈ(ȭ��, ��, �� ��) ���� ��� Ŭ����
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSoundController : MonoBehaviour
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
    /// ��Ʈ(ȭ��, ��, �� �� �浹) ���� ��� �޼ҵ�
    /// </summary>
    public void f_PlayHitSound() //�ܺο��� �����ؾ� �ϹǷ� public ��������
    {
        GetComponent<AudioSource>().Play();
    }
}
