using UnityEngine;
using UnityEngine.UI;

public class StartDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;

    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }
    public bool HaveEnoughStars(int amout)
    {
        return stars >= amout;
    }
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
}
