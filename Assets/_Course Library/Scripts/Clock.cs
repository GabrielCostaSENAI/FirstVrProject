using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    [SerializeField] GameObject secondsHand;
    [SerializeField] GameObject minutesHand;
    [SerializeField] GameObject hoursHand;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        DateTime currentTime = DateTime.Now;
        
        //Seconds rotation 
        float secondDegree = (currentTime.Second / 60f) * 360f;
        secondsHand.transform.localRotation = Quaternion.Euler( new Vector3(secondDegree, 0, 0));

        //Minutos rotation 
        float minutesDegree = (currentTime.Minute / 60f) * 360f;
        minutesHand.transform.localRotation = Quaternion.Euler(new Vector3(minutesDegree, 0, 0));

        //Minutos rotation 
        float hoursDegree = (currentTime.Hour / 12f) * 360f;
        hoursHand.transform.localRotation = Quaternion.Euler(new Vector3(hoursDegree, 0, 0));

    }
}
