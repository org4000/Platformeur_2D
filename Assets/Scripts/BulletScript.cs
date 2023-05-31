using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;


public class BulletScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;
    private GameObject bullet;
    [SerializeField] GameObject MAge;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);


    }


   

    //private void OnCollisionEnter2D(Collision2D other)
    //{
    //    if (other.gameObject != MAge)
    //    {
    //        Destroy(gameObject);

    //    }

        
    //}


    private void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(gameObject); Rajouter ça pour que les projectiles touches les murs mais que l'ennemi soit invincible
        if (other.gameObject.layer == 3)
        {
            Destroy(gameObject);

        }

        if (other.gameObject.CompareTag("ennemy"))
        { 
            Destroy(gameObject);
        }

    }





    // Update is called once per frame
    void Update()
    {




    }

    




}
