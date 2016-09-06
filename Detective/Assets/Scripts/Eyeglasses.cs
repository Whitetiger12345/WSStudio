using UnityEngine;
using System.Collections;

public class Eyeglasses : MonoBehaviour {
	public bool wear;
	public int maxbattery,curbattery,battery_size,start;
	public float charge_speed;
	public Texture glasses;
	private float time;
	// Use this for initialization
	void Start () {
		wear = false;
		battery_size = 10/*+battery_level*/;
		maxbattery = 4 * battery_size;
		curbattery = maxbattery;

	}
	
	// Update is called once per frame
	void Update () {
		charge_speed=2/*-charge_level*/;
		battery_size = 10/*+battery_level*/;
		maxbattery = 4 * battery_size;
		if(Input.GetKeyDown(KeyCode.G))
			wear=!wear;
		if (curbattery > 0 && wear) {
			Battery_discharge ();
		}
		if (curbattery < maxbattery && !wear)
			Battery_charge (charge_speed);
		
	}

	void Battery_discharge(){
		
		if (Time.time > time) {
			start += 50;
			time = Time.time + 1f;
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
	}
}
