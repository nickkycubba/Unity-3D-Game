using UnityEngine;
using System.Collections;

public class recoil : MonoBehaviour {
   // public Animation anim;


    void Start () {
	
	}
	
	
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            //anim = GetComponent<Animation>();
            GetComponent<Animation>().Play();
        }


    }
}
