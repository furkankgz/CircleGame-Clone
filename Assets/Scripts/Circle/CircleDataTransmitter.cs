using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDataTransmitter : MonoBehaviour
{
    [SerializeField] private CircleInputController circleInputController;
    [SerializeField] private CircleScoreController circleScoreController;


    public bool GetIsTouch()
    {
        return circleInputController.isTouch;
    }

    public void IncreaseScoreValue()
    {
        circleScoreController.IncreaseScoreValue();
    }
}
