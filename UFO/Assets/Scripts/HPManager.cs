using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI������ ����

public class HPManager : MonoBehaviour
{
    public static int hp = 3; // hp �Լ� ���� 

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    void Start()
    {
        //���� �� �̹��� Ȱ��ȭ
        life1.GetComponent<Image>().enabled = true;
        life2.GetComponent<Image>().enabled = true;
        life3.GetComponent<Image>().enabled = true;
    }

    void Update()
    {
        switch (hp)
        {
            case 2: //���� �� �̹��� Ȱ��ȭ
                life3.GetComponent<Image>().enabled = false;
                break;
            case 1:
                life2.GetComponent<Image>().enabled = false;
                break;
            case 0:
                life1.GetComponent<Image>().enabled = false;
                //game over
                break;
        }
    }
}



