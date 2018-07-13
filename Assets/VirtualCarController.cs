using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCarController : MonoBehaviour {

    Transform carPosition;

    void OnEnable()
    {
        carPosition = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        carPosition.position = carPosition.position + new Vector3(0, 0, Time.deltaTime);
    }
}
