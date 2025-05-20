using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recording : MonoBehaviour
{
    [SerializeField] private GameObject recordButton;
    [SerializeField] private GameObject stopRecordButton;
    public void Record()
    {
        recordButton.SetActive(false);
        stopRecordButton.SetActive(true);

    }

    public void StopRecord()
    {
        recordButton.SetActive(true);
        stopRecordButton.SetActive(false);
    }
}
