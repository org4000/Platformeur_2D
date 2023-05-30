using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public ReforgeSpell RS;

    void Update()
    {
        
        if (RS.unlockDoor == true)
        {
            Destroy(gameObject);
        }



    }
}
