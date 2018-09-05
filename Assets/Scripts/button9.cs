using UnityEngine;
using UnityEngine.SceneManagement;

public class button9 : MonoBehaviour {

    public GameObject PanelButton;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;

    public void UpdatePanel () {
        PanelButton.SetActive(false);
            Panel1.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(false);
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
}
