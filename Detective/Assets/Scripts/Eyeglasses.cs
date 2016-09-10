using UnityEngine;
using System.Collections;

public class Eyeglasses : MonoBehaviour {
	public bool wear;
	public int maxbattery,curbattery,start;
	public float charge_speed;
	public Texture glasses;
	public Texture[] Battery;
	private float time;
	// Use this for initialization
	void Start () {
		wear = false;
		maxbattery = 4;
		curbattery = maxbattery;

	}
	
	// Update is called once per frame
	void Update () {
		charge_speed=10/*-charge_level*/;
		maxbattery = 4;
		if(Input.GetKeyDown(KeyCode.G))
			wear=!wear;
		if (curbattery > 0 && wear) {
			Battery_discharge ();
		} else {
			wear = false;
		}
		if (curbattery < maxbattery && !wear)
			Battery_charge (charge_speed);
		
	}

	void Battery_discharge(){
		
		if (Time.time > time) {
			start += 50;
			time = Time.time + 10f;
		}
		if (start == 100) {
			curbattery--;
			start = 0;
		}
	}


	void Battery_charge(float speed){
		if (Time.time > time) {
			start += 50;
			time = Time.time + speed;
		}
		if (start == 100) {
			curbattery++;
			start = 0;
		}
	}
	void OnGUI(){
		
		if (wear) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), glasses);
			GUI.Label (new Rect(Screen.width/1.12f,20,100,100),"Detective Glasses v1.0");

		}
		GUI.DrawTexture (new Rect (10, 10, Screen.width/10, Screen.height/12), Battery[curbattery]);
	}
}
