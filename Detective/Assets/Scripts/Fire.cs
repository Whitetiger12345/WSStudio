using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
	public Transform Cam;
	public GameObject Decal;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){
			Ray ray = new Ray (Cam.position, Cam.forward*10f);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit,1000f)){
				GameObject dec = Instantiate<GameObject>(Decal); 
				dec.transform.position = hit.point + hit.normal * 0.01f;
				dec.transform.rotation = Quaternion.LookRotation (-hit.normal);
			}
		}
	}
}
