using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public GameObject model;
    public Slider slider;
    private float previousValue;
    // Start is called before the first frame update
    void Start()
    {
        this.slider.onValueChanged.AddListener(this.OnSliderChanged);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSliderChanged(float value)
    {
        float delta = value - previousValue;
        if(delta != previousValue)
        {
            model.transform.Rotate(Vector3.right * delta * 360);
        }
        previousValue = value;
    }
}
