using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class EnemyData : MonoBehaviour
{

    public static float enemyHealth;
    float healthHolder = 450;
    public static float enemyCurrentHealth;
    private float dataHealth;
    public Image healthbar;
    public Sprite full, eighty, sixty, forty, twenty, zero;
    public GameObject self;
    public static int tanksDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = healthHolder;
        enemyCurrentHealth = enemyHealth;
    }

    // Update is called once per frame
    void Update()
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
            Debug.Log("Enemy died.");
            healthbar.sprite = zero;
            tanksDestroyed++;
            Destroy(self);
        }
    }
    
    void CheckHealth()
    {
        dataHealth = ((enemyCurrentHealth * 100) / enemyHealth);
        Debug.Log(dataHealth);
    }
}