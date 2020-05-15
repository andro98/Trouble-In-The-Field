using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject deathVFX;
    [SerializeField] float health = 100f;
    public void DealDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(this.gameObject);
        }
    }
    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 0.5f);
    }
}
