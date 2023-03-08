using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle_10_Cards : MonoBehaviour
{
    [SerializeField] List<Sprite> card_Img;
    [SerializeField] SpriteRenderer[] card_Slot;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        Invoke("PlayStartAnim", 1f);
    }

    public void Shuffle_Cards()
    {
        StartCoroutine(ResetAnim());
    }
    void PlayStartAnim()
    {
        anim.Play("Shuffle");
        ShuffleCards();
    }

    IEnumerator ResetAnim()
    {
        anim.Play("Reset");
        yield return new WaitForSeconds(2f);
        anim.Play("Shuffle");
        ShuffleCards();

    }

    void ShuffleCards()
    {
        
        for (int i = 0; i < card_Slot.Length; i++)
        {
            List<int> list = new List<int>();
            int Rand = 0;
            list = new List<int>(new int[card_Img.Count]);

            for (int j = 1; j < card_Img.Count; j++)
            {
                Rand = Random.Range(0, card_Img.Count);

                while (list.Contains(Rand))
                {
                    Rand = Random.Range(0, card_Img.Count);
                }
            }
            card_Slot[i].sprite = card_Img[Rand];
        }
    }
}
