using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Print supporting message
        print("Hi n00b!");

        //Integers

        int totalSecondsPlayed = 100; //Las variable empiezas con letra minuscula
        const int SecondsPerMinute = 60; //Las constantes empiezas con letra minuscula

        int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
        int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

        print("Minutes Played: " + minutesPlayed);
        print("Seconds Played: " + secondsPlayed);
    }
}
