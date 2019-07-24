using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int damage = 10;
    public float fireDelay = 1;
    public float range = 10;
    public int cost = 100;
    public int level = 1;

    float fireTimer;


    /*
    protected List<Transform> DetectTargets()
    {

    }
    */

    public Transform GetClosestTarget(List<Transform> targets)
    {
        float min = float.MaxValue;
        Transform closest = null;
        foreach (var target in targets)
        {

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        




    }

    public virtual void Aim()
    {

    }

    public virtual void Fire()
    {

    }
}
