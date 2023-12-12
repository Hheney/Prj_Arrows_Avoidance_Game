/*
 * �÷��̾ ȭ�쿡 ������ ȭ�� ������ ���� ǥ�õǴ� HP �������� ���̴� ���
 * �÷��̾�� ȭ�� �浹�� �����ϰ� UI�� �����ϴ� ��ũ��Ʈ �ۼ�
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               // UI�� ����ϱ⿡ �߰�
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    /*
     * ���� ��ũ��Ʈ�� ����� HP �������� �����Ϸ��� ���� ��ũ��Ʈ�� HP �������� ��ü�� ������ �� �־�� ��
     * �׷��� ���ؼ� Object ������ �����ؼ� HP Guage Image Object�� ������ ����
     */
    GameObject gHpGauge = null; // ���ӿ�����Ʈ Ÿ������ null�� �ʱ�ȭ

    // Start is called before the first frame update
    void Start()
    {
        /*
         * �� ������Ʈ ���ڿ� �����ϴ� ������Ʈ�� �� �ȿ��� ã�� �־�� �Ѵ�.
         * �� �ȿ��� ������Ʈ�� ã�� �޼ҵ� : Find
         * Find �޼ҵ�� ������Ʈ �̸��� �μ��� �����ϰ�,
         * Find �޼ҵ带 ����� �� �߿��� HP �������� ������Ʈ�� ã�Ƽ� ������Ʈ ������ gHpGauge�� ����
         */
        gHpGauge = GameObject.Find("HpGauge");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void f_HpBarReduction() // ������ ������ �ǰ� ���̴� �޼ҵ�, ArrowController���� ȣ���� �ؾ��ϱ⿡ public����
    {
        /*
         * ����Ƽ ������Ʈ�� GameObject��� �� ���ڿ� ���� �ڷ�(���۳�Ʈ)�� �߰��ؼ� ����� Ȯ����
         * ��) ������Ʈ�� ���������� �����̰� �Ϸ��� Rigidbody ���۳�Ʈ �߰�
         * ��) �Ҹ��� ���� �Ϸ��� AudioSource ���۳�Ʈ �߰�
         * ��) ��ü ����� �ø��� �ʹٸ� ��ũ��Ʈ ���۳�Ʈ�� �߰���
         * ���۳�Ʈ ���� ��� : GetComponent<>()
         * GetComponent�� ���� ������Ʈ�� ���� "oo ���۳�Ʈ�� �ּ���"��� ��Ź�ϸ�,
         * ��) AudioSource ���۳�Ʈ�� ���ϸ� �� GetComponent<AudioSource>()
         * ��) Text ���۳�Ʈ�� ���ϸ� �� GetComponent<Text>()
         * ��) ���� ���� ��ũ��Ʈ�� ���۳�Ʈ�� �����̹Ƿ� GetComponent �޼ҵ带 ����ؼ� ���� �� ����
         */
        gHpGauge.GetComponent<Image>().fillAmount -= 0.1f;


        if(gHpGauge.GetComponent<Image>().fillAmount == 0.0f)
        {
            //������
            SceneManager.LoadScene("EndScene");
        }
        
    }
}
