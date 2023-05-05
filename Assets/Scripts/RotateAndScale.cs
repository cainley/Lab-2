using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAndScale : MonoBehaviour
{
    public Slider rotationSlider;
    public Slider scaleSlider;

    private float angleSliderNumber;
    private float scaleSliderNumber;

    // Update is called once per frame
    void Update()
    {
        angleSliderNumber = rotationSlider.value * 360f;
        this.transform.rotation = Quaternion.Euler(0, angleSliderNumber, 0);

        scaleSliderNumber = scaleSlider.value * 10f;
        Vector3 scale = new Vector3(scaleSliderNumber, scaleSliderNumber, scaleSliderNumber);
        this.transform.localScale = scale;

    }
}
