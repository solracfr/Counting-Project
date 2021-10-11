using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject targetPrefab;
    public GameObject canvas;
    public int spawnRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        StartCoroutine(SpawnTargets());
    }

    IEnumerator SpawnTargets()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(targetPrefab, canvas.transform);
        }
    }

    
}
