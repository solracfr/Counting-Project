using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class ArrowHandler : MonoBehaviour
{
    [SerializeField] InputAction setArrowPosition;
    [SerializeField] Canvas canvas;
    public static float screenScaler = 140f;
    public RectTransform arrowSpriteTransform;



    void OnEnable()
    {
        setArrowPosition.Enable();
    }

    void OnDisable()
    {
        setArrowPosition.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        arrowSpriteTransform = GetComponent<RectTransform>();
        canvas = transform.parent.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        SetArrowPosition();
    }

    void SetArrowPosition()
    {
        Vector2 canvasOffset = canvas.transform.position; // Canvas is placed somewhere else in 3D space when the game starts
        Vector2 setPosition = setArrowPosition.ReadValue<Vector2>().normalized;
        float xPosition = setPosition.x;
        float yPosition = setPosition.y;

        arrowSpriteTransform.position = (setPosition * screenScaler) + canvasOffset;

        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Target")) Debug.Log("Target hit");
    }
}
