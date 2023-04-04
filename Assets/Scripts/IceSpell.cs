using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D.IK;

public class IceSpell : MonoBehaviour
{
    [SerializeField] private GameObject IcePlatform;
    [SerializeField] private GameObject IceWall;

    // Essai de limite de 2 platformes max en même temps 
    //Faire en sorte qu'il puisse y avoir que 2 platformes à la fois
    //Faire spawn une platforme augmente de 1 la variable, avoir une platforme qui se détruit réduit de 1 avec un max de 2
    
    int count = 0;
    

    [SerializeField] private float _fireRate = 1.0f;
    private float _canFire = -1f;


    // Start is called before the first frame update
    void Start()
    {
 

    }

    

    // Update is called once per frame
    void Update()
    {

       
       


        if (Input.GetKeyDown(KeyCode.Mouse1) && Time.time > _canFire) //Si le joueur appuie sur click droit et qu'il n'est pas en cooldown, alors crée une platforme de glace
        {
            _canFire = Time.time + _fireRate;
            Instantiate(IcePlatform, transform.position + new Vector3(0, 0 - 1, 0), Quaternion.identity); // Crée un gameObject Platforme sous les pieds du joueur
            count = count += +1;
            Debug.Log("Objet créer, il y a "+count+" objets sur la scène");
        }

        if (Input.GetKeyDown(KeyCode.A) && Time.time > _canFire) //Si le joueur appuie sur A et qu'il n'est pas en cooldown, alors crée une platforme de glace
        {
            _canFire = Time.time + _fireRate;
            Instantiate(IceWall, transform.position + new Vector3(-1, 0, 0), Quaternion.Euler(0, 0, 90)); // Crée un gameObject Platforme sous les pieds du joueur
            count = count += +1;
            Debug.Log("Objet créer, il y a " + count + " objets sur la scène");
        }

        if (Input.GetKeyDown(KeyCode.Z) && Time.time > _canFire) //Si le joueur appuie sur Z et qu'il n'est pas en cooldown, alors crée une platforme de glace
        {
            _canFire = Time.time + _fireRate;
            Instantiate(IceWall, transform.position + new Vector3(1, 0, 0), Quaternion.Euler(0, 0, 90)); // Crée un gameObject Platforme sous les pieds du joueur
            count = count += +1;
            Debug.Log("Objet créer, il y a " + count + " objets sur la scène");
        }


    }

   





}
