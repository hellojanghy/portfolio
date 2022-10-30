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
        HPManager.hp = 3; //'HPManager'Script의 hp 값을 불러옴
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other) //플레이어 UFO가 부딪혔을 때
    {
        //hp값이 0보다 크면 hp -1 아니면 게임 종료
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
