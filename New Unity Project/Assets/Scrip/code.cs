using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class code : MonoBehaviour {

    // Use this for initialization
    public code.ButtonType bt;
    public code() { }
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.48f, 0.48f);
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(0.48f, 0.48f);
        if (bt == code.ButtonType.btnNext)
        {
            SceneManager.LoadScene("MoHinh");
        }
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public enum ButtonType
    {
        btnNext
    }
}
