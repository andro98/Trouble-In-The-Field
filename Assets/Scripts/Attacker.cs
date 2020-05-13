using UnityEngine;

// This class For enemies attackers to move to left by each update
public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    [SerializeField] float moveSpeed = 1.0f;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
    }
}
