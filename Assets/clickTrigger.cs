using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using  TMPro;
public class clickTrigger : MonoBehaviour
{
    public TextMeshProUGUI fakemail;
    public TextMeshProUGUI instagram; 
    public TMP_InputField username; 
    public TMP_InputField password; 
    public GameObject deleteEmail; // Reference to the deleteEmail button
    public GameObject clickme; // Reference to the clickme button
    public GameObject enter; // Reference to the clickme button
    public GameObject hacked; 
    public GameObject winwin; 
    public GameObject looseloose; 
     void Start()
    {
        // Hide the input fields initially
        username.gameObject.SetActive(false);
        password.gameObject.SetActive(false);
        enter.gameObject.SetActive(false);
        hacked.gameObject.SetActive(false);
        winwin.gameObject.SetActive(false);
        looseloose.gameObject.SetActive(false);
    }
    public void ButtonDemo(){
        fakemail.text =""; 
        instagram.text="Instagram Reset Password";
        username.gameObject.SetActive(true);
        password.gameObject.SetActive(true);
        enter.gameObject.SetActive(true);
         // Hide the buttons
        deleteEmail.SetActive(false);
        clickme.SetActive(false);
    }
    public void winner(){
        fakemail.text = "Email deleted"; 
        instagram.text="";
        winwin.gameObject.SetActive(true);
        deleteEmail.SetActive(false);
        clickme.SetActive(false);
    }
    public void reset(){
       // fakemail.text = "Account hacked"; 
        instagram.text="";
        deleteEmail.SetActive(false);
        clickme.SetActive(false);
        username.gameObject.SetActive(false);
        password.gameObject.SetActive(false);
        enter.gameObject.SetActive(false);
        hacked.gameObject.SetActive(true);
        looseloose.gameObject.SetActive(true);
    }
    public void exitMessage(){
        SceneManager.LoadSceneAsync(3);
    }
    public void retry(){
        SceneManager.LoadSceneAsync(0);
    }
}
