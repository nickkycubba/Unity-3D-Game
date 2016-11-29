using UnityEngine;
using System.Collections;

public class ShootGun : MonoBehaviour {
    public Rigidbody projectile;
    public float speed = 20;
    public AudioClip impact;
    public Animation anim;
    AudioSource sound;



    // Use this for initialization
    void Start () {
        sound = GetComponent<AudioSource>();	
	}
    
	// Update is called once per frame
	void Update () {
        //jeyboard input
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            //make object move
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

            //gun sound
            sound.PlayOneShot(impact, .75f);

            //gun animation
            
        }
	
	}
}
