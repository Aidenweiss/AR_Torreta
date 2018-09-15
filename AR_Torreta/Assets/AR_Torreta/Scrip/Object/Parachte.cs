using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parachte : MonoBehaviour {
    float a;
	// Use this for initialization
	void Start () {
        a = 10;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.eulerAngles = new Vector3(0, 0, a * Time.deltaTime);
       // transform.Rotate(0, 0, -a * Time.deltaTime);
        
        
        if (transform.rotation.z >-20 && transform.rotation.z <= 0)
        {
            transform.Rotate(0, 0, -a * Time.deltaTime);
            //transform.eulerAngles = new Vector3(0, 0, a * Time.deltaTime);
        }
        if(transform.rotation.z <20 && transform.rotation.z > 0)
        {
            transform.Rotate(0, 0,a * Time.deltaTime);
            //transform.eulerAngles = new Vector3(0,0,-a * Time.deltaTime);
            //transform.rotation.z = (a * Time.deltaTime);
            //transform.Rotate(0, 0,-a * Time.deltaTime);
        }
		
	}

}
