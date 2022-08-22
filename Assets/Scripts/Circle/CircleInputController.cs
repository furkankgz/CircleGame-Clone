using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInputController : MonoBehaviour
{
    [SerializeField] private CircleDataTransmitter circleDataTransmitter;

    public bool isTouch = false;

    void Update()
    {
        HandleCircleInput();
    }

    private void HandleCircleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isTouch = true;
            circleDataTransmitter.IncreaseScoreValue(); 
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isTouch= false;
        }
    }
}
