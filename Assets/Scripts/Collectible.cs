using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameManager GM;
    private void OnTriggerEnter2D(Collider2D Collect)
    {
        if(Collect.name == "Player")
        {
            Debug.Log("Tu as r�cup�rer le joyau!");
            GM.CollectJoyau();
            Destroy(gameObject);
        }
    }


}
