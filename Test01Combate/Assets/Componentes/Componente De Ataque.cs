using UnityEngine;

public class ComponenteDeAtaque : MonoBehaviour
{
   [Header("Config Arma")]
    public GameObject projectileEntityPrefab; // Prefab de la ENTIDAD proyectil
    public Transform firePoint;               // Punto de salida del disparo
    public float fireRate = 0.5f;             // Segundos entre disparos

    private float nextFireTime = 0f;

    /// <summary>
    /// Ejecuta un disparo en la dirección indicada.
    /// </summary>
    /// <param name="direction">Dirección hacia donde disparar.</param>
    public void Attack(Vector2 direction)
    {
        if (Time.time < nextFireTime) return; // cooldown
        nextFireTime = Time.time + fireRate;

        if (projectileEntityPrefab == null || firePoint == null)
        {
            Debug.LogWarning("AttackComponent sin proyectil o firePoint asignado en el arma.");
            return;
        }

        // Crear la ENTIDAD proyectil
        GameObject projEntity = Instantiate(projectileEntityPrefab, firePoint.position, Quaternion.identity);

        // Darle la dirección inicial
        ComponentedeProyectil projectile = projEntity.GetComponent<ComponentedeProyectil>();
        if (projectile != null)
        {
            projectile.SetDirection(direction);
        }
    }
}