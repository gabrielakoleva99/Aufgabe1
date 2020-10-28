using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    public float rotateSpeed = 1f;
    public Vector3 point;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Erzeugt ein Player-Objekt, das sich mit Hilfe der Tastatur Achsenparallen bewegen kann.

    void Update()
    {
       float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        //Beim Nach-vorne-Gehen geht der Player in die Richtung, in die er gerade schaut
        transform.rotation = Quaternion.LookRotation(direction);

        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        // macht das Objekt rotatable mit "O" und "P"
        if (Input.GetKey(KeyCode.O))
        {
            gameObject.transform.Rotate(Vector3.up, rotateSpeed* Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.P))
        {
            gameObject.transform.Rotate(-Vector3.up,rotateSpeed* Time.deltaTime);
        }

    }
}
