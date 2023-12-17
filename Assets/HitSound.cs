/*
 * 히트(화살, 물, 불 등) 사운드 출력 클래스
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
    /// 히트(화살, 물, 불 등 충돌) 사운드 출력 메소드
    /// </summary>
    public void f_PlayHitSound() //외부에서 참조해야 하므로 public 접근제한
    {
        GetComponent<AudioSource>().Play();
    }
}
