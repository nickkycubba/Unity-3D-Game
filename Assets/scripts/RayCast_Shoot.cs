using UnityEngine;
using System.Collections;

public class RayCast_Shoot : MonoBehaviour {

    public int gunDamage = 1;
    public float firerate = .25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;

    private Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    private LineRenderer laserLine;
    private float nextFire;
    private AudioSource gunShot;
    
    	
	void Start ()
    {
        laserLine = GetComponent<LineRenderer>();
        gunShot = GetComponent<AudioSource>();
        fpsCam = GetComponentInParent<Camera>();

	}
	
	
	void Update ()
    {
	    if(Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + firerate;

            StartCoroutine(shotEffect());

            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));
            RaycastHit hit;

            laserLine.SetPosition(0, gunEnd.position);

            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange)) ;
            {
                laserLine.SetPosition(1, hit.point);

                monsterHealth health = hit.collider.GetComponent<monsterHealth>();

                if(health != null)
                {
                    health.Damage(gunDamage);
                }
                /*if(hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }*/
            }
            /*else
            {
                laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward * weaponRange));
            }*/
 

        }
	}

    private IEnumerator shotEffect()
    
    {
        gunShot.Play();

        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
    }
}
