using UnityEngine;

public class InterfaceHealth : MonoBehaviour
{
   public interface IHealth
        {
            void OnTakeDamage();
            void OnHeal();
            void OnDeath();
        }
}
