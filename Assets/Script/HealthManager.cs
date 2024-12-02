using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int IncreaseHealth(int currentHealth, int increaseAmount, int maxHealth)
    { 
     int newHealth = currentHealth + increaseAmount;
        return ClampHealth(currentHealth, newHealth);
    }// End IncreaseHealth method

    public int ClampHealth(int currentHealth, int maxHealth)
    {
        if (currentHealth > maxHealth)
        { 
          return maxHealth;
        }
        else
        {
            return currentHealth;
        }
    }// End ClampHealth method
}
