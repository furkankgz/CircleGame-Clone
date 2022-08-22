using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Color[] colors;
    [SerializeField] private float lerpValue;
    [SerializeField] private float time;

    private int colorIndex;
    private float currentTime;

    void Start()
    {
        mainCamera = Camera.main;
    }


    void Update()
    {
        ChangeSmoothCameraColor();
        SetColorChangeTime();
    }

    private void ChangeSmoothCameraColor()
    {
        mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, colors[colorIndex], lerpValue * Time.deltaTime);
    }

    private void SetColorChangeTime()
    {
        if (currentTime <= 0)
        {
            IncreaseColorIndexValue();
            CheckColorIndexValue();
            currentTime = time; 
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
    
    private void IncreaseColorIndexValue()
    {
        colorIndex++;
    }

    private void CheckColorIndexValue()
    {
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void OnDestroy()
    {
        mainCamera.backgroundColor = colors[1];
    }
}
