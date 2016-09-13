using UnityEngine;
using System.Collections;

public class Debugray : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay (gameObject.transform.position, gameObject.transform.forward*10f);
	}
}
