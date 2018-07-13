using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Vehicles.Car;

public class StartCar : MonoBehaviour {

    void Start()
    {
        //GameObject.FindGameObjectWithTag("EyePointer").GetComponent<GvrReticlePointer>().enabled = true;
    }

	public void StartingCar()
    {
        //GameObject.FindGameObjectWithTag("EyePointer").GetComponent<GvrReticlePointer>().enabled = false;
        CarUserControl.StopCar = false;
        this.gameObject.SetActive(false);

    }
}
