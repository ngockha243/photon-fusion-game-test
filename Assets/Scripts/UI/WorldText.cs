using System;
using TMPro;
using UnityEngine;

public class WorldText : MonoBehaviour
{
    [SerializeField] private Transform textTransform;
    [SerializeField] private TextMeshPro nameText;
    
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
        
        if (textTransform == null)
        {
            textTransform = transform;
        }
    }

    private void LateUpdate()
    {
        if (mainCamera == null) return;

        textTransform.LookAt(mainCamera.transform);
        textTransform.Rotate(0, 180, 0);
    }

    public void ChangeName(string name)
    {
        nameText.text = name;
    }
}
