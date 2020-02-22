/*
 * Matt Kirchoff
 * SimpleAmmoFactory.cs
 * CIS452 Assignment 5
 * simple ammo factory, creates ammo object to be instantiated
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAmmoFactory : MonoBehaviour
{

    private GameObject ammo;

    public GameObject AddAmmoScript(GameObject prefab, string type)
    {
        ammo = prefab;

        if (type.Equals("laser"))
        {

            if (ammo.GetComponent<laser>() == null)
            {
                ammo.AddComponent<laser>();
            }
        }
        else if (type.Equals("rocket"))
        {

            if (ammo.GetComponent<magic>() == null)
            {
                ammo.AddComponent<magic>();
            }

        }
        else if (type.Equals("bullet"))
        {

            if (ammo.GetComponent<slime>() == null)
            {
                ammo.AddComponent<slime>();
            }

        }
        return ammo;
    }

}