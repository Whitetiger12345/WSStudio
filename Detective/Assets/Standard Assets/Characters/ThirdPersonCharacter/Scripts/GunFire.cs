using UnityEngine;
using System.Collections;

public class GunFire : MonoBehaviour {

	public Transform bullet; 
	public int BulletForce = 5000; 
	public int Magaz = 7; 
	public AudioClip Fire; 
	public AudioClip Reload; 
	void Update () { 
		if(Input.GetMouseButtonDown(0)&Magaz>0){ 
			Transform BulletInstance = (Transform) Instantiate (bullet, GameObject.Find ("Spawn").transform.position, Quaternion.identity); 
			BulletInstance.GetComponent<Rigidbody>().AddForce (transform.forward * BulletForce); 
			Magaz = Magaz - 1; 
			GetComponent<AudioSource>().PlayOneShot(Fire); 
			GetComponent<AudioSource>().PlayOneShot(Reload); 
		} 
		if(Input.GetKeyDown(KeyCode.R)){ 
			Magaz = 7; 
		}
	} 
}﻿
