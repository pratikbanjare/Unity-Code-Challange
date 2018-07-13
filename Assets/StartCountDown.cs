using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
public class StartCountDown : MonoBehaviour {

    private bool countStarted = false;
	public  void StartBackCount()
    {
        if (countStarted == true)
        {
            return;
        }
        countStarted = true;
        StartCoroutine(waitForend());
    }

    IEnumerator waitForend()
    {
        GameObject.FindGameObjectWithTag("ReloadTimer").GetComponent<Text>().text = "Reloading in 5";
        yield return new WaitForSeconds(1);
        GameObject.FindGameObjectWithTag("ReloadTimer").GetComponent<Text>().text = "Reloading in 4";
        yield return new WaitForSeconds(1);
        GameObject.FindGameObjectWithTag("ReloadTimer").GetComponent<Text>().text = "Reloading in 3";
        yield return new WaitForSeconds(1);
        GameObject.FindGameObjectWithTag("ReloadTimer").GetComponent<Text>().text = "Reloading in 2";
        yield return new WaitForSeconds(1);
        GameObject.FindGameObjectWithTag("ReloadTimer").GetComponent<Text>().text = "Reloading in 1";
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        DecreaseHealth.health = 1;
        CarUserControl.StopCar = false;
        Timer.StartTimer = true;
    }
}
