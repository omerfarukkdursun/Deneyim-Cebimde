using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaletControl : MonoBehaviour
{
    public GameObject[] kagit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && kagit != null)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                foreach (GameObject k in kagit) {
                    k.GetComponent<KagitKontrol>().ChangeSprite(hit.collider.gameObject.name);
                }
            }
        }
    }
}
