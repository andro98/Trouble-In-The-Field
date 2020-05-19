using UnityEngine;
//THIS CLASS IS JUST LIKE A TYPE TO CHECK FOR DEFENDERS AT SPAWNING TIME
public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 100;

    public void AddStars(int amount)
    {
        FindObjectOfType<StartDisplay>().AddStars(amount);
    }
}
