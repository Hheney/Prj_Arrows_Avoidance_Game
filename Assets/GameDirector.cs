using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               // UI�� ����ϱ⿡ �߰�

public class GameDirector : MonoBehaviour
{
    GameObject gHpGauge = null;             // ���ӿ�����Ʈ Ÿ������ null�� �ʱ�ȭ

    // Start is called before the first frame update
    void Start()
    {
        gHpGauge = GameObject.Find("HpGauge");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damege()            // ������ ������ �ǰ� ���̴� �޼ҵ�, ArrowController���� ȣ���� �ؾ��ϱ⿡ public����
    {
        gHpGauge.GetComponent<Image>().fillAmount -= 0.1f;     
    }
}
