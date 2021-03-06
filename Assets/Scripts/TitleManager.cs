using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// title manager
public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // called when the screen size changes.
    public void OnScreenResolutionChange(int option)
    {
        switch (option)
        {
            case 0: // 1280 X 720
            case 1:
                Screen.fullScreenMode = FullScreenMode.Windowed;
                Screen.fullScreen = false;

                break;
            case 2: // Windowed (just does full screen again)
                Screen.fullScreenMode = FullScreenMode.MaximizedWindow;
                Screen.fullScreen = false;
                break;

            case 3: // Full Screen
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
                Screen.fullScreen = true;

                break;
        }
    }

    // plays the game
    public void PlayGame()
    {
        // loads the round scene.
        SceneManager.LoadScene("RoundScene");
    }

    // exits the game
    public void ExitApplication()
    {
        Application.Quit();
    }
}
