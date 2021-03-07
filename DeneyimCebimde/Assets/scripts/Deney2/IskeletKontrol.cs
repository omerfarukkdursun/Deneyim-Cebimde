using UnityEngine;

public class IskeletKontrol : MonoBehaviour
{
    public GameObject manager;
     

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == this.gameObject.name)
            manager.GetComponent<Deney2Kontrol>().AlanGiris();

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == this.gameObject.name)
            manager.GetComponent<Deney2Kontrol>().AlanCıkıs();

    }
}
