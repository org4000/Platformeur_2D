using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReforgeSpell : MonoBehaviour
{
    public KeyFrags KF;
    public PowerFragment PF;
    public bool unlockDoor = false;
   
    void Update()
    {

        if (KF.KeyFragCollected >= 3)
        {
            if (PF.ReforgeSpell == true)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    unlockDoor = true;
                    Debug.Log("Reforge Spell Casted");
                }

            }

        }

    }
}
