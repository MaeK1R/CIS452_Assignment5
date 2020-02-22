/*
 * Matt Kirchoff
 * SimplePrefabFactory.cs
 * CIS452 Assignment 5
 * Prefab factory for ammo factory, contains prefabs of what to spawn
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePrefabFactory : MonoBehaviour
{
    public GameObject laser;
    public GameObject rocket;
    public GameObject gun;

    private GameObject ammo;

    public GameObject LoadGun(string type)
    {
        ammo = null;

        if (type.Equals("laser"))
        {
            ammo = laser;
        }
        else if (type.Equals("rocket"))
        {
            ammo = rocket;

        }
        else if (type.Equals("bullet"))
        {
            ammo = gun;

        }

        return ammo;
    }

}
