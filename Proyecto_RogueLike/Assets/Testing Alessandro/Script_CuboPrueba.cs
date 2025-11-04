using UnityEngine;

public class Script_CuboPrueba : MonoBehaviour, InterfaceHealth
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    HealthComponent healthComponent;
    void Start()
    {
        healthComponent = gameObject.AddComponent<HealthComponent>();
        healthComponent.MaxHealth = 100f;
        healthComponent.CurrentHealth = healthComponent.MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            healthComponent.TakeDamage(10);
        }
    }

    public void OnTakeDamage()
    {
        Debug.Log("Cubo ha recibido daño. "+ healthComponent.CurrentHealth + " / " + healthComponent.MaxHealth);
    }
    public void OnHeal()
    {
        Debug.Log("Cubo ha sido curado.");
    }
    public void OnDeath()
    {
        Debug.Log("Cubo ha muerto.");
    }

}
