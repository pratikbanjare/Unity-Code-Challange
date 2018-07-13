using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;
public class DecreaseHealth : MonoBehaviour {

    public static int health = 1;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    void Start()
    {
        GameObject.FindGameObjectWithTag("HealthValue").GetComponent<Text>().text = health.ToString();
        initialPosition = this.transform.position;
        initialRotation = this.transform.rotation;
    }

    void FixedUpdate()
    {
        if (this.transform.position != initialPosition && health !=0)
        {
            StartCoroutine(ResetObstacle());
        }
        

    }

    IEnumerator ResetObstacle()
    {
        //this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        yield return new WaitForSeconds(8);

        this.transform.rotation = initialRotation;
        this.transform.position = initialPosition;
        //this.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "ColliderBody" || collision.collider.name == "ColliderBottom" || collision.collider.name == "ColliderFront")
        {
            if (health > 0)
            {
                health = health - 1;
                GameObject.FindGameObjectWithTag("HealthValue").GetComponent<Text>().text = health.ToString();
            }

            if (health == 0)
            {
                StopCar();
            }
        }     
    }

    public void StopCar()
    {
        CarUserControl.StopCar = true;
        //GameObject.FindGameObjectWithTag("Player").GetComponent<CarUserControl>().enabled = false;
        //GameObject.FindGameObjectWithTag("ReloadSceneButton").GetComponent<Image>().enabled = true;
        //GameObject.FindGameObjectWithTag("ReloadSceneText").GetComponent<Text>().enabled = true;
        //GameObject.FindGameObjectWithTag("EyePointer").GetComponent<GvrReticlePointer>().enabled = true;
        GameObject.FindGameObjectWithTag("ReloadTimer").GetComponent<StartCountDown>().StartBackCount();

    }

    
    
}
