using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{

   public void scene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

   public void quit()
    {
        Application.Quit();
        print("quited");
    }

    public void start_game()
    {
        SceneManager.LoadScene("Game1");
    }
}
