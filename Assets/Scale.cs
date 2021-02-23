using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public GameObject model;
    public Slider slider;
    public float scaleMinValue;
    public float scaleMaxValue;
    

    // Start is called before the first frame update
    void Start()
    {
        //this.slider.onValueChanged.AddListener(this.OnSliderChanged);
        slider.minValue = scaleMinValue;
        slider.maxValue = scaleMaxValue;
        slider.onValueChanged.AddListener(OnSliderChanged);
    }

    // Update is called once per frame
    void Update()
    {
        //model.transform.localScale = new Vector3(x, y, z);
    }

    public void OnSliderChanged(float value)
    {
        model.transform.localScale = new Vector3(value, value, value);
    }
}
