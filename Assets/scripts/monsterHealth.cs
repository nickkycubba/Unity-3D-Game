using UnityEngine;
using System.Collections;

public class monsterHealth : MonoBehaviour {

    public int currentHealth = 5;

	public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
