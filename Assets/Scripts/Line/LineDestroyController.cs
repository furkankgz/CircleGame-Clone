using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroyController : MonoBehaviour
{
    [SerializeField] private float endXValue;

    void Update()
    {
        CheckLinePositionX();
    }

    private void CheckLinePositionX()
    {
        if (transform.position.x <= endXValue)
        {
            Destroy(gameObject);
        }
    }
}
