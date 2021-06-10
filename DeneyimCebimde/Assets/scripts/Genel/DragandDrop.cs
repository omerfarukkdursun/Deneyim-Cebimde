using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDrop : MonoBehaviour
{
    // Update is called once per frame
    bool IsDraging;
    private void OnMouseDown()
    {
        IsDraging = true;
    }
    private void OnMouseUp()
    {
        IsDraging = false;
    }


    void Update()
    {
        if (IsDraging) {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(pos);        
        }
    }
}
