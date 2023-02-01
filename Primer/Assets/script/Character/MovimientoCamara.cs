using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            TurnOnCamera(camera2, camera1);
        }

    }

    private void TurnOnCamera(CinemachineVirtualCamera camToTurnOn, CinemachineVirtualCamera otherCamera)
    {
        Debug.Log("Turn on");
        {
            camToTurnOn.gameObject.SetActive(true); 
            otherCamera.gameObject.SetActive(false); 
        }
    }
}
