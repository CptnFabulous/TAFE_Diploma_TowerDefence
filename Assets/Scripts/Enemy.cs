using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int damage = 10;
    public float speed = 10f;
    

    protected List<Transform> DetectObstacles()
    {

        return new List<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {

    }
}
