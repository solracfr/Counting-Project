//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] Vector2 spawnPosition;
    [SerializeField] Canvas canvas;
    float radius = ArrowHandler.screenScaler;

    // Start is called before the first frame update
    void Start()
    {
        canvas = transform.parent.GetComponent<Canvas>(); //TODO: NEEDS TO SPAWN WITH CANVAS AS PARENT OBJECT, OTHERWISE IT DOESN'T SHOW UP
        transform.position = RandomlySpawnTarget();
    }

    Vector2 RandomlySpawnTarget()
    {
        Vector2 canvasOffset = canvas.transform.position;
        float randRadians = Random.Range(0f, 2 * Mathf.PI);

        return spawnPosition = radius * new Vector2(Mathf.Cos(randRadians), Mathf.Sin(randRadians)) + canvasOffset;

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
