using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Close the build after showcasing that things work.

public class close : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] float waitTime = 5;
    [SerializeField] float crashTime = 2;
    float timer;

    bool textActive;

    // every update, check timer things, then update timer.
    void Update()
    {
        if (timer > waitTime && !textActive) { text.SetActive(true); textActive = true; }
        if (timer > crashTime + waitTime) { Application.Quit(); }

        timer += Time.deltaTime;
    }
}
