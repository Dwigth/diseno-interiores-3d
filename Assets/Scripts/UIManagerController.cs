using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerController : MonoBehaviour {
    public GameObject canvasMenu;
    public GameObject canvasConfig;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void test()
    {
        Debug.Log("Este es un ejmplo");
    }

    public void goToConfig(){
        canvasMenu.SetActive(false);
        canvasConfig.SetActive(true);
    }

    public void goAtConfig() {
        canvasMenu.SetActive(true);
        canvasConfig.SetActive(false);
    }
}
