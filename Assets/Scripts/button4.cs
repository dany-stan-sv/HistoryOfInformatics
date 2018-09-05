using UnityEngine;
using UnityEngine.SceneManagement;

public class button4 : MonoBehaviour {

    public GameObject PanelButton;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public GameObject Panel6;
    public GameObject Panel7;

    public void UpdatePanel () {
        PanelButton.SetActive(false);
            Panel1.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(false);
            Panel4.SetActive(false);
            Panel5.SetActive(false);
            Panel6.SetActive(false);
            Panel7.SetActive(false);
    }

	public void Back () {
		if (PanelButton.activeSelf) {
            SceneManager.LoadScene("Start_scene");
        }
        else { 
            UpdatePanel ();
            PanelButton.SetActive(true);
        }
	}	

    public void But_1 () {
		UpdatePanel ();
        Panel1.SetActive(true);
	}	

    public void But_2 () {
		UpdatePanel ();
        Panel2.SetActive(true);
	}
	
    public void But_3 () {
		UpdatePanel ();
        Panel3.SetActive(true);
	}	

    public void But_4 () {
		UpdatePanel ();
        Panel4.SetActive(true);
	}

    public void But_5 () {
		UpdatePanel ();
        Panel5.SetActive(true);
	}	
	
    public void But_6 () {
		UpdatePanel ();
        Panel6.SetActive(true);
	}	

    public void But_7 () {
		UpdatePanel ();
        Panel7.SetActive(true);
	}	
}
