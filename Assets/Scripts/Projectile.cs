using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;
    [SerializeField] float damage = 100.0f;
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
    //  IF PROJECTILE TRIGGER WITH AN ATTACKER THAT HAS A HEALTH SCRIPT
    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        health.DealDamage(damage);
    }
}
