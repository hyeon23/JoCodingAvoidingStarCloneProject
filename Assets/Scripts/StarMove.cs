using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public float starSpeed;
    StarGeneration star;
    Animator anime;
    bool landTrigger;

 

    private void Awake()
    {
        landTrigger = false;
        rigid = GetComponent<Rigidbody2D>();
        starSpeed = Random.Range(40.0f, 50.0f);
        anime = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        rigid.velocity = Vector2.down * starSpeed * Time.deltaTime * 8;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            anime.SetBool("isDestroy", true);
            Invoke("SetUnactive", 1.0f);
            landTrigger = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            if(landTrigger == true) // Goal
            {
                GameManager.Score += 1;
                CancelInvoke();
                SetUnactive();
            }
            else //Game Over
            {
                if(GameManager.bestScore < GameManager.Score)
                {
                    GameManager.bestScore = GameManager.Score;
                }
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }

    public void SetUnactive()
    {
        gameObject.SetActive(false);
        Destroy(gameObject, 3.0f);
    }
}
