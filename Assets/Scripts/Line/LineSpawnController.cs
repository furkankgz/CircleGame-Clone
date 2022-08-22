using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSpawnController : MonoBehaviour
{
    [SerializeField] private GameObject lastLineObject;
    [SerializeField] private GameObject linePrefab;
    [SerializeField] private float spawnTime;

    private GameObject newLineObject;

    private void Start()
    {
        StartCoroutine(nameof(CreateNewLineObject));
    }

    IEnumerator CreateNewLineObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            newLineObject = Instantiate(linePrefab, lastLineObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Transform>().position, transform.rotation);
            lastLineObject = newLineObject;
        }
    }

}
