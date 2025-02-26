using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttons_details_hover : MonoBehaviour
{
    public static buttons_details_hover _instance;
    public TextMeshProUGUI textComponent;
    public GameObject gg;
    // Start is called before the first frame update

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    void Start()
    {
        Cursor.visible = true;
        gg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
        
    }
    public void SetAndshowtooltip(string message)
    {
        gameObject.SetActive(true);
        textComponent.text = message;
    }
    public void hidetooltip()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }
}
