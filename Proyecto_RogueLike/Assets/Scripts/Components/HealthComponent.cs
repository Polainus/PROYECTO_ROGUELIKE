using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    float currentHealth;
    public float CurrentHealth
    {
        get => currentHealth;
        set
        {
            currentHealth = value; 
        }
    }
    float maxHealth;
    public float MaxHealth
    {
        get => maxHealth;
        set
        {
            maxHealth = value;
        }
    }
    void Awake() 
    {
        SetUpHealth();
    }
    void SetUpHealth()
    {
        currentHealth = maxHealth;
    }
}

