using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerFrag1 : MonoBehaviour
{
    public PowerFragment PF;

    private void OnTriggerEnter2D (Collider2D Collect)
    {
        if (Collect.name == "Player")
        {
            Debug.Log("Waw");
            PF.IceSpell = true;
            
            Destroy(gameObject);

        }
    }



}
