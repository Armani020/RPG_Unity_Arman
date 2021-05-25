using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HouseDoor1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene("_scene/BakerHouseInside");
    }
}
