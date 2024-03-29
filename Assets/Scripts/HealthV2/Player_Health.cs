using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool isInvincible = false;
    public SpriteRenderer graphics;
    public float invincibilityFlashDelay = 0.2f;

    public BarreDeVie healthBar;
    [SerializeField] GameObject hitboxDMG;

    public GameObject player;
    public Transform respawnPoint;

    public FloatSO Health;



    // Start is called before the first frame update
    void Start()
    {
        // le joueur commence avec toute sa vie
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        Health.CurrentHealth = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // test pour voir si ca fonctionne
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }


    public void Heal(int healAmount)
    {
        if (currentHealth < maxHealth)
        {
            currentHealth = currentHealth + healAmount;
            healthBar.SetHealth(currentHealth);

            if (currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
                healthBar.SetHealth(currentHealth);
            }

        }

        
    }



    public void TakeDamage (int damage)
    {
        if(!isInvincible)
        {
            currentHealth -= damage;  // si on prends des degats ont retire de la vie a la vie actuelle
            healthBar.SetHealth(currentHealth); // pour mettre a jour le visuel de la barre de vie
            isInvincible = true;
            StartCoroutine(InvincibilityFlash());
            StartCoroutine(HandleInvincibilityDelay());
            Health.CurrentHealth = currentHealth;
            if (currentHealth <= 0)
            {
                //Scene currentScene = SceneManager.GetActiveScene();
                //SceneManager.LoadScene(currentScene.name);
                PlayerDied();


            }

        }
    }

    private void PlayerDied()
    {
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }


    public IEnumerator InvincibilityFlash()
    {
        while (isInvincible)
        {
            hitboxDMG.SetActive(false);
            graphics.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(invincibilityFlashDelay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(invincibilityFlashDelay);

            hitboxDMG.SetActive(true);
        }
        Debug.Log("Coroutine1");
    }

    public IEnumerator HandleInvincibilityDelay()
    {
        yield return new WaitForSeconds(1.5f);
        isInvincible = false;
        Debug.Log("Coroutine2");
    }

    
       





}
