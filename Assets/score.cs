using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    float time = 0;
    GameObject Score;

	// Use this for initialization
	void Start () {
        this.Score = GameObject.Find("Time");
	}
	
	// Update is called once per frame
	void Update () {
        this.time += Time.deltaTime;
        Debug.Log(time);
        int hour = (int)time/60 ;
        int min = (int)time%60 ;
        float mini = time%1f*100;

        this.Score.GetComponent<Text>().text = "시간 : " + hour.ToString("D2") + " : " + min.ToString("D2") + " : " + mini.ToString("F0");
    }
}
