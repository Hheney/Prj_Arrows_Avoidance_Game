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
        // Ű�� �������� �����ϱ� ���ؼ��� Input Ŭ������ GetKeyDown �޼��带 �����
        // �� �޼���� �Ű������� ������ Ű�� ������ ���� true�� �� �� ��ȯ
        // GetKeyDown �޼���� ���ݱ��� ����ϴ� GetMouseButtonDown �޼���� ����ϹǷ� ���� ������ �� ���� ��
        // Ű�� ���� ���� : GetKeyDown()
        // Ű�� �����ٰ� �� ���� : GetKeyUp()
        // ���� ȭ��ǥ Ű�� ������ �� -> GetKeyDown(KeyCode.LeftArrow)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Translate �޼��� : ������Ʈ�� ���� ��ǥ���� �μ� ����ŭ �̵���Ű�� �޼���
            // ���� -3 �̹Ƿ� �������� '3' ��ŭ �����δ�.
            transform.Translate(-0.18f, 0, 0);
        }

        // ������ ȭ��ǥ Ű�� ������ �� -> GetKeyDown(KeyCode.RightArrow)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Translate �޼��� : ������Ʈ�� ���� ��ǥ���� �μ� ����ŭ �̵���Ű�� �޼���
            // ���� 3 �̹Ƿ� ���������� '3' ��ŭ �����δ�.
            transform.Translate(0.18f, 0, 0);
        }

    }

    public void RButtonDown()         // ������ ��ư�� ������ �� �۵��Ǵ� �Լ�
    {
        transform.Translate(1, 0, 0);
    }

    public void LButtonDown()         // ���� ��ư�� ������ �� �۵��Ǵ� �Լ�
    {
        transform.Translate(-1, 0, 0);
    }
}
