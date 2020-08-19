using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public float playerHealth;
    public float setShellDamage;
    public float fireRate;
    public float playerForwardSpeed;
    public float playerTurnSpeed;
    public float playerBackSpeed;
    
    public float enemyHealth;    
    public float setEnemyShellDamage;


    public float torpedoThrust;
    public float enemyTorpedoThrust;

    private int hitsTaken = 0;
    private int hitsGiven = 0;
    private int tanksDestroyed = 0;
    private int selfDestroyed = 0;

    public int HitPointValue;
    public int DestroyPointValue;
    private int TotalPoints;


    public float bulletTimeout;
    public float enemyBulletTimeout;

    // Start is called before the first frame update
    void Start()
    {
        TankData.playerHealth = playerHealth;
        EnemyData.enemyHealth = enemyHealth;
        TorpedoHit.shellDamage = setShellDamage;
        TorpedoHit.enemyShellDamage = setEnemyShellDamage;
        PlayerMovement.playerForwardSpeed = playerForwardSpeed;
        PlayerMovement.playerTurnSpeed = playerTurnSpeed;
        PlayerMovement.playerBackSpeed = playerBackSpeed;
        //5.0f
        TotalPoints = (HitPointValue * hitsGiven) + (DestroyPointValue * tanksDestroyed);

        TorpedoSpawn.thrust = torpedoThrust;
        EnemyFire.enemyThrust = enemyTorpedoThrust;
        TorpedoSpawn.bulletTimeout = bulletTimeout;
        EnemyFire.enemyBulletTimeout = enemyBulletTimeout;
        TorpedoSpawn.fireRate = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        hitsTaken = TorpedoHit.hitsTaken;
        hitsGiven = TorpedoHit.hitsGiven;
        tanksDestroyed = EnemyData.tanksDestroyed;
        selfDestroyed = TankData.selfDestroyed;
    }
}
