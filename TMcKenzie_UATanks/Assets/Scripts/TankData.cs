using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class TankData : MonoBehaviour
{
    public  float playerHealth;
    public  float currentHealth;
    private float dataHealth;
    //public float enemyHealth;
    public GameObject self;
    public Image healthbar;
    public  int selfDestroyed;


    

    // Start is called before the first frame update
    void Start()
    {
        self = gameObject;
        healthbar = GetComponentInChildren<Image>();
        playerHealth = 450;
        currentHealth = playerHealth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckHealth();
        if (dataHealth > 81)
        {
            healthbar.sprite = GameManager.Instance.blueSprites[0];
        }

        if (dataHealth >= 61 && dataHealth <= 80)
        {
            healthbar.sprite = GameManager.Instance.blueSprites[1];
        }

        if (dataHealth >= 41 && dataHealth <= 60)
        {
            healthbar.sprite = GameManager.Instance.blueSprites[2];
        }

        if (dataHealth >= 21 && dataHealth <= 40)
        {
            healthbar.sprite = GameManager.Instance.blueSprites[3];
        }

        if (dataHealth >= 1 && dataHealth <= 20)
        {
            healthbar.sprite = GameManager.Instance.blueSprites[4];
        }

        if (dataHealth <= 0)
        {
            Debug.Log("Player died.");
            healthbar.sprite = GameManager.Instance.blueSprites[5];
            selfDestroyed++;
            GameManager.Instance.selfDestroyed += 1;
            Destroy(self);
        }
    }

    void CheckHealth()
    {
        dataHealth = ((currentHealth * 100) / playerHealth);
    }
}
