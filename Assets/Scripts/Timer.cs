using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float fulltime;
    public float timeLeft = 0f;

    public void Start1()
    {
        timeLeft = fulltime;
        StartCoroutine(StartTimer());
    }

    public IEnumerator StartTimer()
    {
        while (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            yield return null;
        }
        if (timeLeft < 0)
        {
            timeLeft = 1000f;
        }
    }
}
