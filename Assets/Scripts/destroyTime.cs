using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class destroyTime : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
    
        Destroy(gameObject, 3.0f);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "walls")
        {
            Debug.Log("Hit the wall");
            Destroy(gameObject);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
      

    }
}
