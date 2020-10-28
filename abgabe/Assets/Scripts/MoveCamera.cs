using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Kamera folgt dem Player-Objekt in einem bestimmten Abstand (Offset).
    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        offset = target.transform.rotation * offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition; 
        transform.LookAt(target);
    }
}
