using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform gunPosition;
    [SerializeField] GameObject projectile;
    public void Fire()
    {
        Instantiate(projectile, gunPosition.position, transform.rotation);
    }
}
