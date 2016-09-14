using UnityEngine;
using System.Collections;
namespace UnityStandardAssets.Characters.ThirdPerson
{
public class CoverWall : MonoBehaviour {
	public Animator anim;
	public bool cover;
	void Start () {
		anim=gameObject.GetComponent<Animator> ();
	}

	
	// Update is called once per frame
	void Update () {
		if (cover) {
			anim.SetFloat ("Turn", Input.GetAxis ("Horizontal"));
			gameObject.GetComponent<ThirdPersonUserControl> ().enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			anim.SetBool ("Cover", true);
			cover = !cover;
		}
			if (!cover) {
				anim.SetBool ("Cover", false);

			}
	}
  }
}