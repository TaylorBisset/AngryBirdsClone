using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SlingShot : MonoBehaviour
{
    private LineRenderer leftLineRenderer;
    private LineRenderer rightLineRenderer;

    private Transform leftStartPosition;
    private Transform rightStartPosition;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            DrawSlingShot();
        }
    }

    private void DrawSlingShot()
    {
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        SetLines(touchPosition);
    }

    private void SetLines(Vector2 position)
    {
        leftLineRenderer.SetPosition(0, position);
        leftLineRenderer.SetPosition(1, leftStartPosition.position);
        
        rightLineRenderer.SetPosition(0, position);
        rightLineRenderer.SetPosition(1, rightStartPosition.position);
    }
}
