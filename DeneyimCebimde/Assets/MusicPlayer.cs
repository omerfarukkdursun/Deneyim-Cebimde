using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public static MusicPlayer mp;
    private void Start()
    {
        Debug.Log("start");
        if (mp != null)
            Destroy(gameObject);
        else
            mp = this;

        DontDestroyOnLoad(gameObject);

        //if(GameObject.Find("MusicPlayButton") != null)
        //{
        //    yourButton = GameObject.Find("MusicPlayButton").GetComponent<Button>();
        //    Debug.Log("buldu");
        //    yourButton.onClick.RemoveListener(Sound);
        //    yourButton.onClick.AddListener(Sound);
        //}
        //else
        //{
        //    Debug.Log("bulamadı");
        //}
    
    }

    
    

}
