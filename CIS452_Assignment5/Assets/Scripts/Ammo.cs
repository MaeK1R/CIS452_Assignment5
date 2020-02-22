using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    protected string AmmoType { get; set; }
    protected float Speed { get; set; }

    public void Attack()
    {
        Debug.Log("The " + this.AmmoType);
    }

    public void Move()
    {
        Debug.Log("The " + this.AmmoType);

    }

    public override string ToString()
    {
        return "EnemyType: " + this.AmmoType;
       
    }

}

