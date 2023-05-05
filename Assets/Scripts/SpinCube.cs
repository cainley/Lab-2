using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{
    private float spinningX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(spinningX, 1, 1), 50 * Time.deltaTime);
    }

    public void ToggleSpinX(bool spin)
    {
        if (spin == true)
        {
            spinningX = 5f;
        }
        else if (spin == false)
        {
            spinningX = 0f;
        }
    }
}
