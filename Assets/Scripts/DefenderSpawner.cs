using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicker());
    }
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        this.defender = defenderToSelect;
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
        float newX = Mathf.RoundToInt(pos.x);
        float newY = Mathf.RoundToInt(pos.y);
        return new Vector2(newX, newY);
    }
    private void SpawnDefender(Vector2 pos)
    {
        Defender newDefender = Instantiate(defender, pos, Quaternion.identity) as Defender;
    }
}
