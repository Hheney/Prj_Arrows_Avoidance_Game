using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               // UI를 사용하기에 추가

public class GameDirector : MonoBehaviour
{
    GameObject gHpGauge = null;             // 게임오브젝트 타입으로 null로 초기화

    // Start is called before the first frame update
    void Start()
    {
        gHpGauge = GameObject.Find("HpGauge");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damege()            // 공격을 받으면 피가 깍이는 메소드, ArrowController에서 호출을 해야하기에 public선언
    {
        gHpGauge.GetComponent<Image>().fillAmount -= 0.1f;     
    }
}
