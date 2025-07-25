using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool isAnsweringQuestion = false;

    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (timerValue <= 0 && !isAnsweringQuestion)
        {
            timerValue = timeToCompleteQuestion;
            isAnsweringQuestion = true;
        }
        else if (timerValue <= 0 && isAnsweringQuestion)
        {
            timerValue = timeToShowCorrectAnswer;
            isAnsweringQuestion = false;
        }
    }
}
