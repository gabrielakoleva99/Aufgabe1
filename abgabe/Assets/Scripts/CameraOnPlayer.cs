using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnPlayer : MonoBehaviour
    
{
   public Vector3 offset;
    public Transform target;
    public float smoothSpeed = 0.125f;
    public float currentX = 0f;
    public float rotateSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //die Kamera hängt an die Position des Spielers 
    // Kamera übernimmt die Rotation des Spielers 
    void LateUpdate()
    {
        Rotate();
        transform.position = target.position;
        Vector3 desiredPosition = target.position + offset;
        offset = Quaternion.AngleAxis(currentX / 100.0f, Vector3.up) * offset;
    }

    //macht Spieler rotatable
    void Rotate()
    {
        if (Input.GetKey(KeyCode.O))
        {
            gameObject.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.P))
        {
            gameObject.transform.Rotate(-Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
  
}
