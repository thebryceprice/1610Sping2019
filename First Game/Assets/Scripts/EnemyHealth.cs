using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    
    
    public void Start()
    {
        enemyHealth = 100;
    }
    
    public void Update()
    {

        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
