using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    private void OnMouseDown()
    {
        AttemptToPlaceDefenderAt(GetSquareClicker());
    }
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        this.defender = defenderToSelect;
    }
    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        StartDisplay starDisplay = FindObjectOfType<StartDisplay>();
        int defenderCost = defender.GetStarCost();
        // If We have enough stars
        if (starDisplay.HaveEnoughStars(defenderCost))
        {
            SpawnDefender(gridPos);
            starDisplay.SpendStars(defenderCost);
        }
    }
    private Vector2 GetSquareClicker()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);     // To Convert the position to the grid system we have
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }
    private Vector2 SnapToGrid(Vector2 pos)
    {
        Vector2 newPos;
        float newX = Mathf.RoundToInt(pos.x);
        newPos.x = (newX <= 0) ? 1 : newX;
        float newY = Mathf.RoundToInt(pos.y);
        newPos.y = (newY <= 0) ? 1 : newY;
        newPos.y = (newY >= 5) ? 5 : newY;
        return newPos;
    }
    private void SpawnDefender(Vector2 pos)
    {
        Defender newDefender = Instantiate(defender, pos, defender.transform.rotation) as Defender;
    }
}
