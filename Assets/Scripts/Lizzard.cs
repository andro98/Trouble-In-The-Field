using UnityEngine;

public class Lizzard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;
        if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
