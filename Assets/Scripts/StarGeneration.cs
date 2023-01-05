using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGeneration : MonoBehaviour
{
    float timer1 = 0;
    float timer2 = 0;
    float timer3 = 0;
    float timeDiff1 = 2.5f;
    float timeDiff2 = 2.5f;
    float timeDiff3 = 2.5f;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    GameObject starIns1;
    GameObject starIns2;
    GameObject starIns3;

    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        if (timer1 > timeDiff1)
        {
            timeDiff1 = Random.Range(0.5f, 1.0f);
            starIns1 = Instantiate(star1);
            starIns1.transform.position = new Vector3(Random.Range(-3.0f, 2.5f), 5, -1);
            timer1 = 0;
        }

        timer2 += Time.deltaTime;
        
        if (timer2 > timeDiff2)
        {
            timeDiff2 = Random.Range(2.0f, 3.0f);
            starIns2 = Instantiate(star2);
            starIns2.transform.position = new Vector3(Random.Range(-3.0f, 2.5f), 5, -1);
            timer2 = 0;
        }

        timer3 += Time.deltaTime;
        if (timer3 > timeDiff3)
        {
            timeDiff3 = Random.Range(4.0f, 5.0f);
            starIns3 = Instantiate(star3);
            starIns3.transform.position = new Vector3(Random.Range(-3.0f, 2.5f), 5, -1);
            timer3 = 0;
        }
    }
}
