using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergySystem : MonoBehaviour
{
    [SerializeField] float maxEnergyPoints = 100f;
    [SerializeField] float energyRegenPerSecond = 1.0f;
    

    public float SkillCost = 0f;
    

    public Slider energySlider;
    public float energy;

   private float currentEnergyPoints;


    

    void Start()
    {
        currentEnergyPoints = maxEnergyPoints;
        energySlider.value = maxEnergyPoints;

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            
            CalculateEnergy();
           
            

        }

        EnergyRegen();

    }

    private void EnergyRegen()
    {
        float pointsToAdd = energyRegenPerSecond * Time.deltaTime;
        currentEnergyPoints = Mathf.Clamp(currentEnergyPoints + pointsToAdd, 0, maxEnergyPoints);
        CalculateSlider();
    }

    private void CalculateEnergy()
    {
        currentEnergyPoints -= SkillCost;
        CalculateSlider();
    }

    private void CalculateSlider()
    {
        energySlider.value = currentEnergyPoints;
    }
}
