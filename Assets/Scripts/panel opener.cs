using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelopener : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    public void openPanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
