using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public GameObject ObjectToToggle;
    private Toggle toggle; 
    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleObject()
    {
        ObjectToToggle.SetActive(toggle.isOn);
    }
}
