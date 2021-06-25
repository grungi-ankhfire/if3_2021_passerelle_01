using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCounter : MonoBehaviour
{

    public ObjectMovement movementComponent;

    // Start is called before the first frame update
    void Start()
    {
        movementComponent = GetComponent<ObjectMovement>();
        Debug.Log($"Nbre mouvements : {movementComponent.movements.Count}");
    }

}
