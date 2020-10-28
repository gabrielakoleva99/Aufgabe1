using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script fuer die Prefabs
public class NewBehaviourScript : MonoBehaviour
{

    //Füge ein Attribut vom Typ Transform hinzu
    public Transform myPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        //mehrere Instanzen des myPrefab - Objekts auf der Spielplattform erzeugen
            for (int i = 1; i < 5; i++)
            {
                Instantiate(myPrefab, new Vector3(Random.Range(-10, 10), 11, Random.Range(-10, 10)), Quaternion.identity);
                myPrefab.transform.Rotate(new Vector3(0, 0, 1f), Space.World);
          }

        
    }

    // Update is called once per frame
    void Update()
    {
        //gibt dem Prefab eine Rotation
        myPrefab.transform.Rotate(new Vector3(0, 0, 1f), Space.World);

    }
}
