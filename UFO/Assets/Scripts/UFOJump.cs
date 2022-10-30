using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UFOJump : MonoBehaviour
{ 
    Rigidbody2D rb;
    public float jumpPower;

    void Start()
    {
        HPManager.hp = 3; //'HPManager'Script�� hp ���� �ҷ���
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other) //�÷��̾� UFO�� �ε����� ��
    {
        //hp���� 0���� ũ�� hp -1 �ƴϸ� ���� ����
        if (HPManager.hp > 0)
        {
            HPManager.hp -= 1;
        }
        if (HPManager.hp == 0)
        {
           if (Score.score > Score.bestScore)
            {
                Score.bestScore = Score.score;
            }
            SceneManager.LoadScene("02_GameoverScene");
        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower;
        }
    }
}
