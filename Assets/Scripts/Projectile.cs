using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;
    [SerializeField] float damage = 100.0f;
    [SerializeField] Vector2 direction = new Vector2(1, 0);
    void Update()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
    //  IF PROJECTILE TRIGGER WITH AN ATTACKER THAT HAS A HEALTH SCRIPT
    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        var attacker = other.GetComponent<Attacker>();
        if (attacker && health)
        {
            health.DealDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
