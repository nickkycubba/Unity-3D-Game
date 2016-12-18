using UnityEngine;
using System.Collections;

public class weaponSwitching : MonoBehaviour {

    public GameObject weapon1;
    public GameObject weapon2;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            SwapWeapon();
        }
	
	}

    void SwapWeapon()
    {
        if(weapon1.active = true)
        {
            weapon1.SetActiveRecursively(false);
            weapon2.SetActiveRecursively(true);
        }
        else
        {
            weapon1.SetActiveRecursively(true);
            weapon2.SetActiveRecursively(false);
        }
    }
}
