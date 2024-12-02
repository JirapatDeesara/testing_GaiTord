using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int IncreaseHealth(int currentHealth, int increaseAmount, int maxHealth)
    { 
     int newHealth = currentHealth + increaseAmount;
       return Mathf.Clamp(currentHealth, 0, maxHealth);
    }// End IncreaseHealth method
}
