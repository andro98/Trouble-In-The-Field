using System;
using UnityEngine;

// This class For enemies attackers to move to left by each update
public class Attacker : MonoBehaviour
{
    float currentSpeed = 0.0f;
    GameObject currentTarget;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
            GetComponent<Animator>().SetBool("isAttacking", false);

    }

    // THIS FUNCION WILL BE FIRED FROM THE ANIMATION TIMELINE
    public void SetMovementSpeed(float speed)
    {
        this.currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget) return;

        Health health = currentTarget.GetComponent<Health>();
        if (health) { health.DealDamage(damage); }
    }
}
