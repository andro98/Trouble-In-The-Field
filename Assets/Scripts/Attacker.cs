using UnityEngine;

// This class For enemies attackers to move to left by each update
public class Attacker : MonoBehaviour
{
    float currentSpeed = 0.0f;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }
    // THIS FUNCION WILL BE FIRED FROM THE ANIMATION TIMELINE
    public void SetMovementSpeed(float speed)
    {
        this.currentSpeed = speed;
    }
}
