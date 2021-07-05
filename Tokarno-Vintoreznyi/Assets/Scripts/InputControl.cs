using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    public GameObject cameraOrbit;
    public float rotateSpeed = 8f;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float height = rotateSpeed * Input.GetAxis("Mouse Y");
            float width = rotateSpeed * Input.GetAxis("Mouse X");

            if (cameraOrbit.transform.eulerAngles.z + height <= 0.1f || cameraOrbit.transform.eulerAngles.z + height >= 179.9f)
                height = 0;
            //if (cameraOrbit.transform.eulerAngles.y + width <= 0.1f || cameraOrbit.transform.eulerAngles.y + width >= 179.9f)
            //    width = 0;
            cameraOrbit.transform.eulerAngles = new Vector3(
                cameraOrbit.transform.eulerAngles.x,
                cameraOrbit.transform.eulerAngles.y + width,
                cameraOrbit.transform.eulerAngles.z + height);
        }
        float scrollFactor = Input.GetAxis("Mouse ScrollWheel");
        if (scrollFactor != 0)
        {
            cameraOrbit.transform.localScale = cameraOrbit.transform.localScale * (1f - scrollFactor);
        }
    }
}
