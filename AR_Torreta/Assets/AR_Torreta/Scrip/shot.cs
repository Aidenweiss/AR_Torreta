using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour {
    public AudioClip shot_;
    public AudioSource adSrc;
    public GameObject laser;
    GameObject LaserClone;
    public float force;
	// Use this for initialization
	void Start () {
        force = 50f;
        adSrc = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shotsound();
            disparaLaser();
        }
    }

    public void disparaLaser()
    {
        LaserClone = Instantiate(laser, transform.position, transform.rotation);
        LaserClone.GetComponent<Rigidbody>().AddForce(LaserClone.transform.forward * force, ForceMode.Impulse);
        Destroy(LaserClone.gameObject, 3f);
    }
    public void Shotsound()
    {
        adSrc.PlayOneShot(shot_);
    }

}
