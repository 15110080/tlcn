using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllerLN : MonoBehaviour {

    public void btnNext()
    {
        SceneManager.LoadScene("LoaiPhong");
    }
    public void Logout()
    {
        SceneManager.LoadScene("DangNhap");
    }
}
