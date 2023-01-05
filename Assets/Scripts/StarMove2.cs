using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarMove2 : MonoBehaviour
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
        anime = GetComponent<Animator>();
        starSpeed = Random.Range(25.0f, 40.0f);
    }

    private void FixedUpdate()
    {
        rigid.velocity = Vector2.down * starSpeed * Time.deltaTime * 8;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            anime.SetBool("isDestroy", true);
            Invoke("SetUnactive", 1.0f);
            landTrigger = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            if (landTrigger == true) // Goal
            {
                GameManager.Score += 2;
                CancelInvoke();
                SetUnactive();
            }
            else //Game Over
            {
                if (GameManager.bestScore < GameManager.Score)
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
