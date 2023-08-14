using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSMeter : MonoBehaviour
{

    public TextMeshProUGUI FpsCounterText;

    private float pollingTime = 1f;
    private float time;
    private int frameCount;
    void Update()
    {
        time += Time.deltaTime;
        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            FpsCounterText.text = frameRate.ToString() + " FPS";
        }
    }
}
