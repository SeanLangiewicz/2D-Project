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
        currentHealth = maxHealth;  
        healthSlider.value = maxHealth;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
           
        DealDamage();
       

    }


    float DealDamage()
    {
        currentHealth -= damage;
        
        CalculateHealth();
        SliderCalculation();
        

        if (currentHealth <= 0)
        {
            Die();
        }
        return damage;
    }

    private void SliderCalculation()
    {
        healthSlider.value = CalculateHealth();
    }

    private void Die()
    {
        currentHealth = 0;
        Debug.Log("You are Dead");
    }

    float CalculateHealth()
    {
        calculatedHealth = (currentHealth / maxHealth)*100;
    
        return calculatedHealth;
        
    }
}
