using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int healthLevel = 10;
    public int maxHealth;
    public int currentHealth;
    CapsuleCollider playerCapsuleCollider;
    Rigidbody playerRigidBody;

    private void Awake()
    {
        playerCapsuleCollider = GetComponent<CapsuleCollider>();
        playerRigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        maxHealth = SetMaxHealthFromHealthLevel();
        currentHealth = maxHealth;
    }

    public int SetMaxHealthFromHealthLevel()
    {
        maxHealth = healthLevel * 10;
        return maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
    }
}
