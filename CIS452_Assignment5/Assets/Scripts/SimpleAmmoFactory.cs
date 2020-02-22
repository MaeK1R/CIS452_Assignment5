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

            if (ammo.GetComponent<rocket>() == null)
            {
                ammo.AddComponent<rocket>();
            }

        }
        else if (type.Equals("bullet"))
        {

            if (ammo.GetComponent<bullet>() == null)
            {
                ammo.AddComponent<bullet>();
            }

        }
        return ammo;
    }

}