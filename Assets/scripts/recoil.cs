using UnityEngine;
using System.Collections;

public class recoil : MonoBehaviour {
   // public Animation anim;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            //anim = GetComponent<Animation>();
            GetComponent<Animation>().Play();
        }


    }
}
