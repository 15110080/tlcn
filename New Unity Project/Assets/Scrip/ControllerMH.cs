using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerMH : MonoBehaviour {

    public void btnBack()
    {
        SceneManager.LoadScene("PhongCach");
    }
}
