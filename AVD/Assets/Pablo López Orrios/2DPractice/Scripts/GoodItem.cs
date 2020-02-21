using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodItem : MonoBehaviour
{
    public enum Item { Cherry=0,Gem=1 }
    public Item item;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetInteger("Type", (int)item);
    }

    public void PickItem()
    {
        GetComponent<Animator>().SetBool("Pick", true);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        if (collision.CompareTag("Player")) { PickItem(); }
    }
    public void Killme() 
    {

        Destroy(gameObject); 
    }
}
