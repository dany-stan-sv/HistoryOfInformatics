using UnityEngine;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour {

    public GameObject PanelButton;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;

	public void Back () {
		if (PanelButton.activeSelf) {
            SceneManager.LoadScene("Start_scene");
        }
        else { 
            PanelButton.SetActive(true);
            Panel1.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(false);
            Panel4.SetActive(false);
        }
	}	

    public void But_1 () {
		PanelButton.SetActive(false);
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
	}	

    public void But_2 () {
		PanelButton.SetActive(false);
        Panel1.SetActive(false);
        Panel2.SetActive(true);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
	}
	
    public void But_3 () {
		PanelButton.SetActive(false);
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(true);
        Panel4.SetActive(false);
	}	

    public void But_4 () {
		PanelButton.SetActive(false);
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(true);
	}	
}
