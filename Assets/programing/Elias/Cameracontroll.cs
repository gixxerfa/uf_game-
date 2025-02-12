using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroll : MonoBehaviour
{
    public GameObject[] Canvaslist = new GameObject[7];
    public GameObject[] Cameralist = new GameObject[7];
    // Start is called before the first frame update
    void Start()
    {
        cc(2);
    }
    public void cc(int Camera)
    {
        for (int i = 0; i < Cameralist.Length; i++)
        {
            Cameralist[i].gameObject.SetActive(false);
        }
        
        Cameralist[Camera].SetActive(true);
        Canvaslist[Camera].SetActive(true);
    }
        // Update is called once per frame
    void Update()
    {
        
    }
}
