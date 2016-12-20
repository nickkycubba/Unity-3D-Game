﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pick_Up : MonoBehaviour {

    //public RayCast_Shoot RayCast_Shoot2;
    public GameObject getTotalAmmo;
    public int distance;
    public int item_count = 0;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Collect();
	
	}

    void Collect()
    {
      if(Input.GetMouseButtonUp(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, distance))
            {
                if(hit.collider.gameObject.name == "item")
                {
                    Debug.Log("item hit");
                    Destroy(hit.collider.gameObject);
                    item_count++;
                }
                if(hit.collider.gameObject.name == "Ammo_pack")
                {
                    Debug.Log("Ammo hit");
                    Destroy(hit.collider.gameObject);
                    getTotalAmmo.GetComponent<RayCast_Shoot>().totalAmmo = 30;
                }
            }

            if(item_count == 1)
            {
                SceneManager.LoadSceneAsync("gameWon");
            }
        }
    }
}
