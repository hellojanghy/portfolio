using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI설정을 위함

public class HPManager : MonoBehaviour
{
    public static int hp = 3; // hp 함수 생성 

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    void Start()
    {
        //시작 시 이미지 활성화
        life1.GetComponent<Image>().enabled = true;
        life2.GetComponent<Image>().enabled = true;
        life3.GetComponent<Image>().enabled = true;
    }

    void Update()
    {
        switch (hp)
        {
            case 2: //시작 시 이미지 활성화
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



