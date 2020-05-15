using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    private void OnMouseDown()
    {
        ChangeColor();
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }

    private void ChangeColor()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
            button.GetComponent<SpriteRenderer>().color = Color.black;
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
