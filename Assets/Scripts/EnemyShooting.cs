using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public int numberOfProjectiles;

    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    private GameObject player;

    float radius, moveSpeed;
    Vector2 startPoint;


    // Start is called before the first frame update
    void Start()
    {
        radius = 5f;
        moveSpeed = 5f;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        float distance = Vector2.Distance(transform.position, player.transform.position);
        //Debug.Log(distance);

        if(distance < 10)
        {
            timer += Time.deltaTime;

            if (timer > 4)
            {
                timer = 0;
                
                shoot(numberOfProjectiles);
            }
        }

       

    }

    void shoot(int numberOfProjectiles)
    {
        //Instantiate(bullet, bulletPos.position, Quaternion.identity);
        float angleStep = 360f / numberOfProjectiles;
        float angle = 0f;

        for (int i = 0; i <= numberOfProjectiles - 1; i++)
        {
            float projectilesDirXposition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float projectilesDirYposition = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

            Vector2 projectileVector = new Vector2(projectilesDirXposition, projectilesDirYposition);
            Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

            var proj = Instantiate(bullet, bulletPos.position, Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileMoveDirection.x, projectileMoveDirection.y);

            angle += angleStep;


        }








    }





}
