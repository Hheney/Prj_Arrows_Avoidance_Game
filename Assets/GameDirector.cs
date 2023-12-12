/*
 * 플레이어가 화살에 맞으면 화면 오른쪽 위에 표시되는 HP 게이지를 줄이는 기능
 * 플레이어와 화살 충돌을 감지하고 UI를 갱신하는 스크립트 작성
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               // UI를 사용하기에 추가
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    /*
     * 감독 스크립트를 사용해 HP 게이지를 갱신하려면 감독 스크립트가 HP 게이지의 실체를 조작할 수 있어야 함
     * 그러기 위해서 Object 변수를 선언해서 HP Guage Image Object를 저장할 변수
     */
    GameObject gHpGauge = null; // 게임오브젝트 타입으로 null로 초기화

    // Start is called before the first frame update
    void Start()
    {
        /*
         * 각 오브젝트 상자에 대응하는 오브젝트를 씬 안에서 찾아 넣어야 한다.
         * 씬 안에서 오브젝트를 찾는 메소드 : Find
         * Find 메소드는 오브젝트 이름을 인수로 전달하고,
         * Find 메소드를 사용해 씬 중에서 HP 게이지의 오브젝트를 찾아서 오브젝트 변수인 gHpGauge에 저장
         */
        gHpGauge = GameObject.Find("HpGauge");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void f_HpBarReduction() // 공격을 받으면 피가 깍이는 메소드, ArrowController에서 호출을 해야하기에 public선언
    {
        /*
         * 유니티 오브젝트는 GameObject라는 빈 상자에 설정 자료(컴퍼넌트)를 추가해서 기능을 확장함
         * 예) 오브젝트를 물리적으로 움직이게 하려면 Rigidbody 컴퍼넌트 추가
         * 예) 소리를 내게 하려면 AudioSource 컴퍼넌트 추가
         * 예) 자체 기능을 늘리고 싶다면 스크립트 컴퍼넌트를 추가함
         * 컴퍼넌트 접근 방법 : GetComponent<>()
         * GetComponent는 게임 오브젝트에 대해 "oo 컴퍼넌트를 주세요"라고 부탁하면,
         * 예) AudioSource 컴퍼넌트를 원하면 → GetComponent<AudioSource>()
         * 예) Text 컴퍼넌트를 원하면 → GetComponent<Text>()
         * 예) 직접 만든 스크립트도 컨퍼넌트의 일종이므로 GetComponent 메소드를 사용해서 구할 수 있음
         */
        gHpGauge.GetComponent<Image>().fillAmount -= 0.1f;


        if(gHpGauge.GetComponent<Image>().fillAmount == 0.0f)
        {
            //다음씬
            SceneManager.LoadScene("EndScene");
        }
        
    }
}
