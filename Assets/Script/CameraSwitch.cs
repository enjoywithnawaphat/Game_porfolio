using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] private GameObject thirdPersonCamera;
    [SerializeField] private GameObject firstPersonCamera;
    public bool isFristPerson;

    public void SwitchCamera()
    {
        isFristPerson = !isFristPerson;

        thirdPersonCamera.SetActive(!isFristPerson);
        firstPersonCamera.SetActive(isFristPerson);
    }

}
