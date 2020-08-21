using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class TankData : MonoBehaviour
{
    public static float playerHealth;
    public static float currentHealth;
    private float dataHealth;
    public float enemyHealth;
    public GameObject self;
    public Image healthbar;
    public static int selfDestroyed;

    public Sprite full, eighty, sixty, forty, twenty, zero;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 450;
        currentHealth = playerHealth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckHealth();
        if (dataHealth > 81)
        {
            healthbar.sprite = full;
        }

        if (dataHealth >= 61 && dataHealth <= 80)
        {
            healthbar.sprite = eighty;
        }

        if (dataHealth >= 41 && dataHealth <= 60)
        {
            healthbar.sprite = sixty;
        }

        if (dataHealth >= 21 && dataHealth <= 40)
        {
            healthbar.sprite = forty;
        }

        if (dataHealth >= 1 && dataHealth <= 20)
        {
            healthbar.sprite = twenty;
        }

        if (dataHealth <= 0)
        {
            Debug.Log("Player died.");
            healthbar.sprite = zero;
            selfDestroyed++;
            Destroy(self);
        }
    }

    void CheckHealth()
    {
        dataHealth = ((currentHealth * 100) / playerHealth);
    }
}
