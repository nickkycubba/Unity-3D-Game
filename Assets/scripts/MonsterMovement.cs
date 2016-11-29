using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
    public Transform player;               // Find the player
    //PlayerHealth playerHealth;      // Player's remaining HP
   // EnemyHealth enemyHealth;        // Remaining Monster HP
    NavMeshAgent nav;               // Reference to the nav mesh agent.


    void Awake()
    {
       // playerHealth = player.GetComponent<PlayerHealth>();
       // enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>(); //References to the mesh component
    }


    void Update()
    {
        // If the enemy and the player have health left...
        //if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
       // {
            // Send the monster to the player
            nav.SetDestination(player.position);
       // }
        // Otherwise...
      //  else
       // {
            // ... disable the nav mesh agent.
           // nav.enabled = false;
       // }
    }
}