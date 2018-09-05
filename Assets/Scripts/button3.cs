using UnityEngine;
using UnityEngine.SceneManagement;

public class button3 : MonoBehaviour {

    public GameObject PanelButton;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public GameObject Panel6;
    public GameObject Panel7;
    public GameObject Panel8;
    public GameObject Panel9;
    public GameObject Panel10;
    public GameObject Panel11;
    public GameObject Panel12;
    public GameObject Panel13;
    public GameObject Panel14;
    public GameObject Panel15;
    public GameObject Panel16;
    public GameObject Panel17;
    public GameObject Panel18;
    public GameObject Panel19;
    public GameObject Panel20;
    public GameObject Panel21;
    public GameObject Panel22;
    public GameObject Panel23;
    public GameObject Panel24;

    public void UpdatePanel () {
        PanelButton.SetActive(false);
            Panel1.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(false);
            Panel4.SetActive(false);
            Panel5.SetActive(false);
            Panel6.SetActive(false);
            Panel7.SetActive(false);
            Panel8.SetActive(false);
            Panel9.SetActive(false);
            Panel10.SetActive(false);
            Panel11.SetActive(false);
            Panel12.SetActive(false);
            Panel13.SetActive(false);
            Panel14.SetActive(false);
            Panel15.SetActive(false);
            Panel16.SetActive(false);
            Panel17.SetActive(false);
            Panel18.SetActive(false);
            Panel19.SetActive(false);
            Panel20.SetActive(false);
            Panel21.SetActive(false);
            Panel22.SetActive(false);
            Panel23.SetActive(false);
            Panel24.SetActive(false);
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

    public void But_8 () {
		UpdatePanel ();
        Panel8.SetActive(true);
	}	

    public void But_9 () {
		UpdatePanel ();
        Panel9.SetActive(true);
	}	

    public void But_10 () {
		UpdatePanel ();
        Panel10.SetActive(true);
	}	

    public void But_11 () {
		UpdatePanel ();
        Panel11.SetActive(true);
	}	

    public void But_12 () {
		UpdatePanel ();
        Panel12.SetActive(true);
	}	

    public void But_13 () {
		UpdatePanel ();
        Panel13.SetActive(true);
	}	

    public void But_14 () {
		UpdatePanel ();
        Panel14.SetActive(true);
	}	

    public void But_15 () {
		UpdatePanel ();
        Panel15.SetActive(true);
	}	

    public void But_16 () {
		UpdatePanel ();
        Panel16.SetActive(true);
	}	

    public void But_17 () {
		UpdatePanel ();
        Panel17.SetActive(true);
	}	

    public void But_18 () {
		UpdatePanel ();
        Panel18.SetActive(true);
	}	

    public void But_19 () {
		UpdatePanel ();
        Panel19.SetActive(true);
	}	

    public void But_20 () {
		UpdatePanel ();
        Panel20.SetActive(true);
	}	

    public void But_21 () {
		UpdatePanel ();
        Panel21.SetActive(true);
	}	

    public void But_22 () {
		UpdatePanel ();
        Panel22.SetActive(true);
	}	

    public void But_23 () {
		UpdatePanel ();
        Panel23.SetActive(true);
	}

    public void But_24 () {
		UpdatePanel ();
        Panel24.SetActive(true);
	}
}
