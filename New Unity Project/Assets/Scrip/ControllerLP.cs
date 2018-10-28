using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllerLP : MonoBehaviour
{

    public void btnNext1()
    {
        SceneManager.LoadScene("PhongCach");
    }
    public void btnBack()
    {
        SceneManager.LoadScene("LoaiNha");
    }
}

