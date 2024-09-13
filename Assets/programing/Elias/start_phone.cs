using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start_phone : MonoBehaviour
{
    public Button start,options, exit;
   
    // Update is called once per frame
    void Update()
    {
        
    }
    public void newlevelbutton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
