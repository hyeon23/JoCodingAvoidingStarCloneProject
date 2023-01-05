using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anime;
    SpriteRenderer render;
    public float speed;
    bool leftDown = false;
    bool rightDown = false;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (leftDown)
        {
            rigid.AddForce(Vector2.left * speed * Time.deltaTime * 8, ForceMode2D.Impulse);
            render.flipX = true;
            anime.SetBool("isRunning", true);
        }
        else if (rightDown)
        {
            rigid.AddForce(Vector2.right * speed * Time.deltaTime * 8, ForceMode2D.Impulse);
            render.flipX = false;
            anime.SetBool("isRunning", true);
        }
        else
        {
            anime.SetBool("isRunning", false);
        }
    }
    public void LeftButtonDown()
    {
        leftDown = true;
    }
    public void LeftButtonUp()
    {
        leftDown = false;
    }
    public void RightButtonDown()
    {
        rightDown = true;
    }
    public void RightButtonUp()
    {
        rightDown = false;
    }
}
