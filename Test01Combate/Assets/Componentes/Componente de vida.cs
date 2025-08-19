using UnityEngine;

public class ComponenteDeVida : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public System.Action OnDeath;
    void Start()
    {
        currentHealth = maxHealth;
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            OnDeath?.Invoke();
        }
    }
        public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
    }

    public int GetHealth() => currentHealth;
}
