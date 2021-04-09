using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFinishTrigger : MonoBehaviour
{
    [SerializeField] GameObject gameController;

    public void FinishAnim()
    {
        gameController.GetComponent<Deney5Kontrol>().counter++;  
    }
    
}
