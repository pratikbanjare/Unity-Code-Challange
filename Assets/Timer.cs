using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {

    public static bool StartTimer = false;
    public float dt = 0;
	void Start()
    {
        StartTimer = true;
    }
    void Update()
    {

        if (StartTimer)
        {
            dt = dt + Time.deltaTime;
            if (dt >= 60)
            {
                StartTimer = false;
                GameObject.FindGameObjectWithTag("ReloadTimer").GetComponent<StartCountDown>().StartBackCount();
            }
        }
        GetComponent<Text>().text = (Mathf.Ceil(60 - dt)).ToString();
    }



}
