using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�÷��̾� ��Ʈ�ѷ� ���ο����� ����ϹǷ� private ���� ������ ���
    private float fLeftWallXPos = -10.5f;   //���� �� X ��ǥ��
    private float fRightWallXPos = 10.5f;   //������ �� X ��ǥ��
    private float fGroundYPos = -3.6f;      //�ٴ� Y ��ǥ��

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * ArrowController ���� ȭ���� ȭ�� ������ ������ �ڱ� �ڽ��� �Ҹ��Ű�� �޼ҵ带 �����Ͽ�
         * �÷��̾��� X��ǥ���� ������ ���� ����� ���� X��ǥ������ �̵��Ѵ�.
         */
        if (transform.position.x < fLeftWallXPos) //����(�÷��̾��� X��ǥ�� < ���� �� X��ǥ��)
        {
            transform.position = new Vector2(fLeftWallXPos, fGroundYPos); //���� �� ��ġ�� �ʱ�ȭ
        }
        else if(transform.position.x > fRightWallXPos) //����(�÷��̾��� X��ǥ�� > ������ �� X��ǥ��)
        { 
            transform.position = new Vector2(fRightWallXPos, fGroundYPos); //������ �� ��ġ�� �ʱ�ȭ
        }
        else
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
