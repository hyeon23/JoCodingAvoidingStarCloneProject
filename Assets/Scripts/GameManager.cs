using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int Score;
    public static int bestScore;
    public AudioClip s1;
    public AudioClip s2;
    public AudioClip s3;
    AudioSource audioSource;

    private void Start()
    {
        Score = 0;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(string str)
    {
        switch(str){
            case "B1":
                audioSource.clip = s1;
                break;
            case "B2":
                audioSource.clip = s2;
                break;
            case "B3":
                audioSource.clip = s3;
                break;
        }
        audioSource.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Star")
        {
            PlaySound("B1");
        }
        else if(collision.gameObject.tag == "Star2")
        {
            PlaySound("B2");
        }
        else if(collision.gameObject.tag == "Star3")
        {
            PlaySound("B3");
        }
    }
}
