/*
 * 보너스(하트 충돌) 사운드 출력 클래스
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
    /// 보너스(하트 충돌) 사운드 출력 메소드
    /// </summary>
    public void f_PlayBonusSound() //외부에서 참조해야 하므로 public 접근제한
    {
        GetComponent<AudioSource>().Play();
    }
}
