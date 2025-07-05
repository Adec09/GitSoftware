using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public int damageAmount = 999; 

    void OnCollisionEnter2D(Collision2D collision)
    {
        CharacterController player = collision.gameObject.GetComponent<CharacterController>();
        if (player != null)
        {
            player.TakeDamage(damageAmount);
        }
    }
}
