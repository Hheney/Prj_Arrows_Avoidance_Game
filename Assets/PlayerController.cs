using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 키가 눌렀는지 검출하기 위해서는 Input 클래스의 GetKeyDown 메서드를 사용함
        // 이 메서드는 매개변수로 전달한 키가 눌리는 순간 true를 한 번 반환
        // GetKeyDown 메서드는 지금까지 사용하던 GetMouseButtonDown 메서드와 비슷하므로 쉽게 이해할 수 있을 것
        // 키를 누른 순간 : GetKeyDown()
        // 키를 누르다가 뗀 순간 : GetKeyUp()
        // 왼쪽 화살표 키가 눌렀을 때 -> GetKeyDown(KeyCode.LeftArrow)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Translate 메서드 : 오브젝트를 현재 좌표에서 인수 값만큼 이동시키는 메서드
            // 값이 -3 이므로 왼쪽으로 '3' 만큼 움직인다.
            transform.Translate(-0.18f, 0, 0);
        }

        // 오른쪽 화살표 키가 눌렀을 때 -> GetKeyDown(KeyCode.RightArrow)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Translate 메서드 : 오브젝트를 현재 좌표에서 인수 값만큼 이동시키는 메서드
            // 값이 3 이므로 오른쪽으로 '3' 만큼 움직인다.
            transform.Translate(0.18f, 0, 0);
        }

    }

    public void RButtonDown()         // 오른쪽 버튼을 눌렀을 시 작동되는 함수
    {
        transform.Translate(1, 0, 0);
    }

    public void LButtonDown()         // 왼쪽 버튼을 눌렀을 시 작동되는 함수
    {
        transform.Translate(-1, 0, 0);
    }
}
