using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHealth;
    public int currentHealth;
    public BarreDeVie healthBar;
    private SpriteRenderer graphics;
    [SerializeField] GameObject HEALTHBAR;

    public GameObject Drop;


    // Start is called before the first frame update
    void Start()
    {
        HEALTHBAR.SetActive(false);
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            if(Drop != null)
            {
                Instantiate(Drop, transform.position, Quaternion.identity);
                Object.Destroy(gameObject);
            }
            else
            {
                Object.Destroy(gameObject);

            }

        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; 
        healthBar.SetHealth(currentHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fireball")
        {
            TakeDamage(20);
            StartCoroutine(ShowBar());
        }
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fireball")
        {
            TakeDamage(20);
            StartCoroutine(ShowBar());
        }
    }



    private IEnumerator ShowBar()
    {
        HEALTHBAR.SetActive(true);
        yield return new WaitForSeconds(5f);
        HEALTHBAR.SetActive(false);
    }
}
