using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Compass : MonoBehaviour {


    GameObject Player;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<RawImage>().uvRect = new Rect(Player.transform.localEulerAngles.y / 360, 0, 1, 1);
	}
}
