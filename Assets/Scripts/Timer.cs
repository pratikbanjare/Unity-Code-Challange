using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private Text timerValue;
    private Slider slider;
    public float setTimeValue = 61.0F;
    int x;
    int y;

	// Use this for initialization
	void Start ()
    {
        timerValue = GetComponentInChildren<Text>();
        slider = GetComponentInChildren<Slider>();
        Debug.Log(timerValue.text);
        timerValue.text = setTimeValue.ToString();
        x = (int)setTimeValue;
        slider.maxValue = x - 1;

    }
	
	// Update is called once per frame
	void Update ()
    {
        setTimeValue -= 1*Time.deltaTime;
        y = (int)setTimeValue; 
        timerValue.text = y.ToString();
        slider.value = x-setTimeValue;
        if(y == 0)
        {
            Application.Quit();
        }
            
	}
}
