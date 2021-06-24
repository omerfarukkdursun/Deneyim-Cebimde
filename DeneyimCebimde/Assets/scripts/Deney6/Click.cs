using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Sprite duz;

    [SerializeField] GameObject winPanel;
    [SerializeField] Text winText;
    [SerializeField] GameObject yemek;
    [SerializeField] GameObject spor;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null && hit.transform.gameObject.name == "Adam")
            {
                hit.transform.gameObject.GetComponent<SpriteRenderer>().sprite = duz;
            }
            else if (hit.collider != null && hit.transform.gameObject.name == "sebze")
            {
                winPanel.SetActive(true);
                float f = PlayerPrefs.GetFloat("puan") + 300;
                PlayerPrefs.SetFloat("puan", f);
                winText.text = "\nKAZANDIN!\n\n\nToplam Puan " + PlayerPrefs.GetFloat("puan");
                winPanel.GetComponent<Animator>().SetBool("isWin", true);
                if(yemek != null)
                {
                    yemek.SetActive(false);
                }
                if (spor != null)
                {
                    spor.SetActive(false);
                }
            }
        }
    }
}
