using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public string sceneEasy;
    public string sceneMedium;
    public string sceneHard;
    public string sceneCredits;

    Dropdown dropDown;
    
    public void StarGame()
    {
        dropDown = GetComponent<Dropdown>();
        int val = dropDown.value(index);
     

        if (val == 0)
        {
            SceneManager.LoadScene(sceneEasy);    
        }
         if (val == 1)
        {
            SceneManager.LoadScene(sceneMedium);    
        }
         if (val == 2)
        {
            SceneManager.LoadScene(sceneHard);    
        }
    }

    public void Credits()
    {
        SceneManager.LoadScene(sceneCredits);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
