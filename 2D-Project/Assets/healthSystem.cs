using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthSystem : MonoBehaviour
{
    public float maxHealth = 100;
   public float currentHealth;
  // public float maxHealth { get; set; }
   //public float currentHealth { get; set; }
    public Slider healthSlider;

    private float calculatedHealth;

    public float damage;



    void Start()
    {
        //maxHealth = 20f;
        currentHealth = maxHealth;
        Debug.Log(currentHealth + "is the current health");
       // healthSlider.value = CalculateHealth();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            DealDamage(5);
       

    }


    void DealDamage(float damage)
    {
        currentHealth -= damage;
        healthSlider.value = CalculateHealth();
        Debug.Log(damage + "Damage Done");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        currentHealth = 0;
        Debug.Log("You are Dead");
    }

    float CalculateHealth()
    {
       
      
        calculatedHealth = (float)currentHealth / maxHealth;

        Debug.Log("Current Health" + currentHealth);
        Debug.Log("Max health" + maxHealth);
        Debug.Log("Calc health" + calculatedHealth);

        return calculatedHealth;
        
    }
}
