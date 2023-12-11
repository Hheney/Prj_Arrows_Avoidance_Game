using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject gPlayer = null;
    GameObject gDir = null;                 // ������ũ��Ʈ�� ã�ƿ��� ���� �ʱ�ȭ

    Vector2 vArrowPosition = Vector2.zero;
    Vector2 vPlayerPosition = Vector2.zero;
    Vector2 vDir = Vector2.zero;

    float fDistance = 0.0f;
    float r1 = 0.5f;
    float r2 = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        gPlayer = GameObject.Find("player");
        //gDir = GameObject.Find("GameDirector"); //���ӵ��� ã�ƿ���
    }

    // Update is called once per frame
    void Update()
    {
        // Translate �޼��� : ������Ʈ�� ���� ��ǥ���� �μ� ����ŭ �̵���Ű�� �޼���
        //    Y ��ǥ�� -0.1f�� �����ϸ� ������Ʈ�� ���ݾ� ������ �Ʒ��� �����δ�
        //    �����Ӹ��� ������� ���Ͻ�Ų��.
        transform.Translate(0, -0.1f, 0);

        // ȭ�� ������ ���� ȭ�� �Ҹ��Ű��
        //   ȭ���� ������ �θ� ȭ�� ������ ������ �ǰ�, ���� �������� ������ ��� ������
        //   ȭ���� ������ �ʴ� ������ ��� �������� ��ǻ�� ���� ����� �ؾ��ϹǷ� �޸� ����
        //   �޸𸮰� ������� �ʵ��� ȭ���� ȭ�� ������ ������ ������Ʈ�� �Ҹ���Ѿ� ��
        // Destroy �޼��� : �Ű������� ������ ������Ʈ�� ����
        //   �Ű������� �ڽ�(ȭ�� ������Ʈ)�� ����Ű�� gameObject ������ �����ϹǷ� ȭ����
        //   ȭ�� ������ ������ �� �ڱ� �ڽ��� �Ҹ��Ŵ
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        vArrowPosition = transform.position;
        vPlayerPosition = gPlayer.transform.position;

        vDir = vArrowPosition - vPlayerPosition;

        fDistance = vDir.magnitude;

        if (fDistance < r1 + r2)
        {
            GameObject gDir = GameObject.Find("GameDirector");

            gDir.GetComponent<GameDirector>().f_HpBarReduction();   // ã�ƿ� gDir�� ���� f_HpBarReduction �޼ҵ� ��������

            Destroy(gameObject);
        }
    }
}