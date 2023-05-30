using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    private Vector2 moveDirection;
    private float moveSpeed;

    private float timer;


    //private void OnEnable()
    //{
    //    Invoke("Destroy", 3f);
    //}



    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer > 10)
        {
            Destroy(gameObject);

        }
    }



  

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void OnDestroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(gameObject); Rajouter ça pour que les projectiles touches les murs mais que l'ennemi soit invincible
        if (other.gameObject.layer == 3)
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player_Health>().TakeDamage(20);
            Destroy(gameObject);
        }
    }



}
