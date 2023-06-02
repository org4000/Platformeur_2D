using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class EnemyDrop : MonoBehaviour
{
    public GameObject Drop;
    public EnemyHealth EH;

    private void Update()
    {
        if (EH.currentHealth <= 0)
        {
            Debug.Log("aaaaaaaaaaaaaaaaaa");
            Instantiate(Drop, transform.position, Quaternion.identity); 
            //Object.Destroy(gameObject);
        }
    }



    
}
