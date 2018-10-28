using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerPK : MonoBehaviour {
    public void btnNext1()
    {
        SceneManager.LoadScene("MoHinh");
    }
    public void btnBack()
    {
        SceneManager.LoadScene("LoaiPhong");
    }
}
