using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform gunPosition;
    [SerializeField] GameObject projectile;
    Animator animator;
    AttackerSpawner myLaneSpawner;
    private void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }
    private void Update()
    {
        bool attack = IsAttackerInLane();
        animator.SetBool("IsAttacking", attack);
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spwaner in attackerSpawners)
        {
            bool isCloseEnough = (Mathf.Abs(spwaner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = spwaner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        return myLaneSpawner.transform.childCount > 0;
    }

    public void Fire()
    {
        Instantiate(projectile, gunPosition.position, transform.rotation);
    }
}
