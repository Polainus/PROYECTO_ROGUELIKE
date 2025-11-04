using UnityEngine;


public class HealthComponent : MonoBehaviour 
{
    private float currentHealth;
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
    public void TakeDamage(float damage)
    {
        InterfaceHealth healthInterface = GetComponent<InterfaceHealth>();
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            
            healthInterface?.OnDeath();
        }
        else
        {
            
            healthInterface?.OnTakeDamage();
        }
    }

}

