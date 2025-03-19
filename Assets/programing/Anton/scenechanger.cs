using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{

    void scene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

   public void quit()
    {
        Application.Quit();
        print("quited");
    }
}
