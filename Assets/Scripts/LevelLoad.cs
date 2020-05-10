using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] int timeToWait = 6;
    int currentSceneIndex;
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Splash Screen Scene we need to wait for seconds
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    // A Courotine that wait for seconds and then return
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
