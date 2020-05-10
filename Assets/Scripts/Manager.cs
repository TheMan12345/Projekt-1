using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    bool TheGameHasEnded = false;
    public float Delay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (TheGameHasEnded == false){



        TheGameHasEnded = true;
        Invoke("Restart", Delay);
        }
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}


