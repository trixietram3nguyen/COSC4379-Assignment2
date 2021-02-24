using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public List<GameObject> models;
    public Slider slider;
    public float scaleMinValue;
    public float scaleMaxValue;
    private List<Vector3> originalScale = new List<Vector3>(3);

    // Start is called before the first frame update
    void Start()
    {
        models.ForEach(model => originalScale.Add(new Vector3(model.transform.localScale.x, model.transform.localScale.y, model.transform.localScale.z)));
        //this.slider.onValueChanged.AddListener(this.OnSliderChanged);
        slider.minValue = scaleMinValue;
        slider.maxValue = scaleMaxValue;
        slider.onValueChanged.AddListener(OnSliderChanged);
        
        //for (int i = 0; i < models.Count - 1; i++)
        //{
        //    originalScale[i] = new Vector3(models[i].transform.localScale.x, models[i].transform.localScale.y, models[i].transform.localScale.z);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //model.transform.localScale = new Vector3(x, y, z);
    }

    public void OnSliderChanged(float value)
    {
        for (int i = 0; i < models.Count; i++)
        {
            if (models[i].name == "Penny")
            {
                models[i].transform.localScale = new Vector3(originalScale[i].x * value, originalScale[i].y, originalScale[i].z * value);
            }
            else
            {
                models[i].transform.localScale = new Vector3(originalScale[i].x * value, originalScale[i].y * value, originalScale[i].z * value);
            }
        }
        //Vector3 scale = new Vector3(value, value, value);
        //models.ForEach(delegate (GameObject model)
        //{
        //    if (model.name == "Penny")
        //    {
        //        Vector3 scale = new Vector3(value, model.transform.localScale.y, value);
        //        model.transform.localScale = scale;
        //    }
        //    else
        //    {
        //        model.transform.localScale = scale;
        //    }
        //});

    }


}
