using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstComponent : MonoBehaviour
{

    public float rotationSpeed;
    public bool reverse;
    public Vector3 rotationAxis;

    void Start() {
        Debug.Log("Inside the start method !");
    }

    void Update() {
        float rotation = rotationSpeed * Time.deltaTime;
        if (reverse) {
            rotation *= -1;
        }

        transform.Rotate(rotationAxis * rotation, Space.World);

        // if(!reverse)
        // {
        //     transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime, Space.World);
        // }
        // else
        // {
        //     transform.Rotate(-rotationAxis * rotationSpeed * Time.deltaTime, Space.World);
        // }


    }   

}
