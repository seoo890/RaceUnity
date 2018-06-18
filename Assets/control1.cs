using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control1 : MonoBehaviour {

    public float speed = 0;
    public float hen = 0;
    public float Maxs = 0.4f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += 0.04f;
            //speed *= 1.1f;
            if (speed >= Maxs)
                speed = Maxs;
        }
        //if (Input.GetKeyDown(KeyCode.DownArrow))
            
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed -= 0.08f;
            //speed *= 1.1f;
            if (speed <=-2*Maxs)
                speed = -2*Maxs;
            //speed -= 0.1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hen = 10 * (0.1f / speed);
            if (speed >= -0.08f && speed <= 0.08f)
                hen = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            hen = -10 * (0.1f / speed);
            if (speed >= -0.08f&&speed<=0.08f)
                hen = 0;
        }
        if (hen < -5)
            hen = -5;
        if (hen > 5)
            hen = 5;
        this.transform.Translate(0, speed, 0);
        this.transform.Rotate(0, 0, hen);
        
        hen = 0;
        speed *= 0.98f;
	}
}
