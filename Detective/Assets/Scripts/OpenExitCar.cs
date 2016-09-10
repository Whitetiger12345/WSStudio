using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{

public class OpenExitCar : MonoBehaviour {
	
	public bool Player;
	public GameObject Detective,lights;
	public bool inCar,on_lights;
	public GameObject CarCamera;
	public GameObject PlayerCamera;
	public GameObject Exit;
	public GameObject CamP, CamC;
	
	void Start (){
		gameObject.GetComponent<CarController>().enabled = false;
	   gameObject.GetComponent<CarUserControl>().enabled = false;
	   gameObject.GetComponent<CarAudio>().enabled = false;
	   CarCamera.SetActive (false);
	   PlayerCamera.SetActive (true);
	   
   }
	

void OnTriggerEnter(Collider other){
	if(other.tag=="Player")
	{
		Player=true;
			
		}
}
void OnTriggerExit(Collider other){
	if(other.tag=="Player")
	{
		Player=false;
	}
}
void Update (){
	if (Player==true){
   if (Input.GetKeyUp(KeyCode.E)){
	   Detective.SetActive (false);
	   gameObject.GetComponent<CarController>().enabled = true;
	   gameObject.GetComponent<CarUserControl>().enabled = true;
	   gameObject.GetComponent<CarAudio>().enabled = true;
	   CarCamera.SetActive (true);
	   PlayerCamera.SetActive (false);
	   inCar=true;
	   CamP.tag = "Untagged";CamC.tag = "MainCamera";
   }

}
			if (inCar == true) {
				if (Input.GetKeyDown (KeyCode.L)) {
					on_lights = !on_lights;
					lights.SetActive (on_lights);		
				}
				if (Input.GetKeyDown (KeyCode.E)) {
					
					Detective.SetActive (true);
					Detective.transform.position = Exit.transform.position;
					inCar = false;
					gameObject.GetComponent<CarController> ().enabled = false;
					gameObject.GetComponent<CarUserControl> ().enabled = false;
					gameObject.GetComponent<CarAudio> ().enabled = false;
					CarCamera.SetActive (false);
					PlayerCamera.SetActive (true);
					CamP.tag = "MainCamera";CamC.tag = "Untagged";
				}
	} else {
				on_lights = false;	
				lights.SetActive (on_lights);
		}
}
}

}
		

 
