using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="odacýk")
        {
            print("sfdghjkýlþlkjhgfhjkl");
            Odacýk odacýk = other.gameObject.GetComponent<Odacýk>();
            odacýk.enabled= true;
        }
    }
}
